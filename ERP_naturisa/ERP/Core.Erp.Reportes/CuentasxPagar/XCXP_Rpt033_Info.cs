﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt033_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_movcaja { get; set; }
        public decimal IdCbteCble_movcaja { get; set; }
        public int IdTipocbte_movcaja { get; set; }
        public string IdCtaCble { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string cm_beneficiario { get; set; }
        public string cm_observacion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public Nullable<decimal> IdPersona { get; set; }
        public string nom_persona { get; set; }
        public int IdTipoMovi { get; set; }
        public string nom_TipoMovi { get; set; }
        public double cm_valor { get; set; }

        //campos adicionales
        public string em_Nombre { get; set; }
    }
}
