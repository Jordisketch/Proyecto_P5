﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
        public class TipoProveedor
    {
        public int ProveedorTipo { get; set; }  
        public string ProveedorTipoDescripcion{ get; set; }

        public DataTable listar()
        {
            DataTable R = new DataTable();

            return R;
        }






    }
}
