﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.MobileSCI
{
    public class tbl_usuario_x_subcentro_Info
    {
        public string IdUsuarioSCI { get; set; }
        public decimal IdSCI { get; set; }
        public int IdEmpresa { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        //Campos que no existen en la tabla
        public bool seleccionado { get; set; }
        public string nom_centro { get; set; }
        public string nom_subcentro { get; set; }
    }
}
