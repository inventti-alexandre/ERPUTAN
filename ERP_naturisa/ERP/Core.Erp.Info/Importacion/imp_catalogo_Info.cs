﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
    public  class imp_catalogo_Info
    {

        public string IdCatalogoImport { get; set; }
        public int IdCatalogoImport_tipo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Abrebiatura { get; set; }
        public string NombreIngles { get; set; }
        public int? Orden { get; set; }

        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public imp_catalogo_Info() { }
    }
}
