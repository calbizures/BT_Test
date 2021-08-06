

namespace ApiCrud.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public int id { get; set; }
        public string codigo_usuario { get; set; }
        public string nombre_completo { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
