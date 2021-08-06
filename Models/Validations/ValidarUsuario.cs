using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCrud.Models
{
    [MetadataType(typeof(usuario.MetaData))]
    public partial class usuario
    {
        sealed class MetaData
        {
            [Required]
            public string codigo_usuario;
            [Required]
            public string nombre_completo;
            [Required]
            public string email;
            [Required]
            public string password;

        }
            
    }
}