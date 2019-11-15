using System;
using System.Collections.Generic;

namespace core_mssql.Models
{
    public partial class Categoria
    {
        public int Idcategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Observacion { get; set; }
    }
}
