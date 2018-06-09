﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Catalogo_Info
    {
        public string IdCatalogo { get; set; }
        public string IdTipoCatalogo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public int Orden { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }

        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }


        public Af_Catalogo_Info()
        { }
    }
}
