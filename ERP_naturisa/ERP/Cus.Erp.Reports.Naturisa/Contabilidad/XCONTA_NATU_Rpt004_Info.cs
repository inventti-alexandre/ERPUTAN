﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Contabilidad
{
    public class XCONTA_NATU_Rpt004_Info
    {

        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_cuenta { get; set; }
        public string nom_cuenta2 { get; set; }
        public int IdNivelCta { get; set; }
        public string GrupoCble { get; set; }
        public int OrderGrupoCble { get; set; }
        public string gc_estado_financiero { get; set; }
        public string IdCtaCblePadre { get; set; }


        public double? Saldo_Inicial { get; set; }
        public double? Debito_Mes { get; set; }
        public double? Credito_Mes { get; set; }
        public double? Saldo { get; set; }


        public double? Saldo_inicial_x_Movi { get; set; }
        public double? Debito_Mes_x_Movi { get; set; }
        public double? Credito_Mes_x_Movi { get; set; }
        public double? Saldo_x_Movi { get; set; }

        public string gc_GrupoCble { get; set; }
        public string pc_EsMovimiento { get; set; }
        public Nullable<int> gc_signo_operacion { get; set; }

        public int? IdPuntoCargo { get; set; }
        public int? IdPuntoCargo_Grupo { get; set; }
        public string IdCentroCosto { get; set; }

        public string nom_PuntoCargo { get; set; }
        public string nom_PuntoCargo_Grupo { get; set; }
        public string nom_CentroCosto { get; set; }
        public string nom_empresa { get; set; }
        public string nom_periodo { get; set; }
        public int IdPeriodo { get; set; }

        public string IdGrupo_Mayor { get; set; }
        public string nom_grupo_mayor { get; set; }
        public Nullable<int> order_grupo_mayor { get; set; }
        public int orden_fila { get; set; }
        public Nullable<bool> Reg_x_CC { get; set; }


        public string IdCtaCble_nivel2 { get; set; }
        public string pc_cuenta_nivel2 { get; set; }

        public string IdCtaCble_nivel3 { get; set; }
        public string pc_cuenta_nivel3 { get; set; }

        public string IdCtaCble_nivel4 { get; set; }
        public string pc_cuenta_nivel4 { get; set; }

        public string IdCtaCble_nivel5 { get; set; }
        public string pc_cuenta_nivel5 { get; set; }

        public string IdCtaCble_nivel6 { get; set; }
        public string pc_cuenta_nivel6 { get; set; }

    }
}

