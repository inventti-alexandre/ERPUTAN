﻿ 
CREATE PROCEDURE [dbo].[spCXP_Rpt012]
  @idempresa int ,
  @fecha datetime ,
  @idProveedorIni decimal  ,
  @idProveedorFIn decimal  

AS
BEGIN
	 
	 
Select 
	A.IdEmpresa, A.IdCbteCble_Ogiro, A.IdTipoCbte_Ogiro, A.IdOrden_giro_Tipo, A.Documento, A.nom_tipo_doc, A.cod_tipo_doc,
	A.IdProveedor, A.nom_proveedor, A.Valor_a_pagar
	
	, ISNULL(b.MontoAplicado, 0) AS MontoAplicado, (A.Valor_a_pagar - ISNULL(b.MontoAplicado, 0))  as Saldo
	, A.Observacion,
	 A.Ruc_Proveedor, A.representante_legal, A.Tipo_cbte, A.Plazo_fact, 
	A.co_fechaOg,  co_FechaFactura_vct, A.Dias_Vcto,@fecha as Fecha_corte,
	(Case when datediff(day,co_FechaFactura_vct,@fecha) <=0 then (A.Valor_a_pagar - ISNULL(b.MontoAplicado, 0)) else 0 end) x_Vencer
	,(Case when datediff(day,co_FechaFactura_vct,@fecha) >=1  and datediff(day,co_FechaFactura_vct,@fecha) <=30 then (A.Valor_a_pagar - ISNULL(b.MontoAplicado, 0)) else 0 end) Vencido_1_30,
	(Case when datediff(day,co_FechaFactura_vct,@fecha) >=31  and datediff(day,co_FechaFactura_vct,@fecha) <=60 then (A.Valor_a_pagar - ISNULL(b.MontoAplicado, 0)) else 0 end) Vencido_31_60,
	(Case when datediff(day,co_FechaFactura_vct,@fecha) >=61  and datediff(day,co_FechaFactura_vct,@fecha) <=180 then (A.Valor_a_pagar - ISNULL(b.MontoAplicado, 0)) else 0 end) Vencido_61_180,
	(Case when datediff(day,co_FechaFactura_vct,@fecha) >=181   then (A.Valor_a_pagar - ISNULL(b.MontoAplicado, 0)) else 0 end) Vencido_Mayor_181
 from
 (
 
							Select * from 
							(
									SELECT                  a.IdEmpresa, a.IdCbteCble_Ogiro, a.IdTipoCbte_Ogiro, a.IdOrden_giro_Tipo, b.Codigo + '#:' + CAST(a.IdCbteCble_Ogiro AS VARCHAR(20)) 
									+ '/' + a.co_serie + '-' + a.co_factura AS Documento, b.Descripcion AS nom_tipo_doc, b.Codigo AS cod_tipo_doc, a.co_fechaOg, c.IdProveedor, 
									c.pr_nombre AS nom_proveedor, a.co_valorpagar AS Valor_a_pagar
									,a.co_observacion AS Observacion, d.pe_cedulaRuc AS Ruc_Proveedor, c.representante_legal, 'CBTE_CXP' AS Tipo_cbte,   
									DATEDIFF(day, co_FechaFactura, co_FechaFactura_vct) as Plazo_fact, datediff(day,co_FechaFactura_vct,@fecha) as Dias_Vcto, co_FechaFactura_vct
									FROM            dbo.vwcp_orden_giro_total_saldo AS a INNER JOIN
									dbo.cp_TipoDocumento AS b ON a.IdOrden_giro_Tipo = b.CodTipoDocumento INNER JOIN
									dbo.cp_proveedor AS c ON a.IdEmpresa = c.IdEmpresa AND a.IdProveedor = c.IdProveedor INNER JOIN
									dbo.tb_persona AS d ON c.IdPersona = d.IdPersona
							) as a
							where IdEmpresa = @idempresa and IdProveedor between @idProveedorIni and @idProveedorFIn
) as A
 left join (
 Select IdEmpresa,IdEmpresa_cxp,IdTipoCbte_cxp ,IdCbteCble_cxp,sum(MontoAplicado)MontoAplicado
 from 
 (
 
			 SELECT a.IdEmpresa,IdEmpresa_cxp,IdTipoCbte_cxp ,b.IdCbteCble_cxp,b.MontoAplicado,b.IdEmpresa_pago,IdTipoCbte_pago,b.IdCbteCble_pago, A.cb_Fecha 
			 FROM ct_cbtecble A 
			 INNER JOIN (
							 SELECT IdEmpresa, IdEmpresa_cxp,IdTipoCbte_cxp,IdCbteCble_cxp,Sum(MontoAplicado)MontoAplicado
							 ,IdEmpresa_pago,IdTipoCbte_pago,IdCbteCble_pago 
							 from cp_orden_pago_cancelaciones  
							 group by IdEmpresa, IdEmpresa_cxp,IdTipoCbte_cxp,IdCbteCble_cxp
							  ,IdEmpresa_pago,IdTipoCbte_pago,IdCbteCble_pago 
							  having IdEmpresa =@idempresa
						)
			   AS B ON A.IdEmpresa = B.IdEmpresa 
			   AND A.IdTipoCbte = B.IdTipoCbte_pago 
			  AND A.IdCbteCble = B.IdCbteCble_pago 
			  where   A.cb_Estado = 'A'
				and cb_Fecha<= @fecha
 
) as VISTA 
group by IdEmpresa,IdEmpresa_cxp,IdTipoCbte_cxp ,IdCbteCble_cxp ) as 
b on
 a.IdEmpresa = b.IdEmpresa_cxp and a.IdCbteCble_Ogiro = b.IdCbteCble_cxp and a.IdTipoCbte_Ogiro = b.IdTipoCbte_cxp and  a.IdEmpresa = b.IdEmpresa
 


 
END