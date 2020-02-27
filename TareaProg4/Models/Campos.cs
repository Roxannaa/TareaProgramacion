using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TareaProg4.Models
{
    public class Campos
    {
        [Required(ErrorMessage = "Campo Cedula no puede estar VACIO")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Campo Nombre no puede estar VACIO")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Apellido no puede estar VACIO")]
        public string Apellido { get; set; }

        [Range(15, 200, ErrorMessage = "Campo Edad debe ser mayor de 15 años")]
        public int Edad { get; set; }
        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Correo invalido")]
        public string Correo { get; set; }

        public Gender Genero { get; set; }

        public string Puesto { get; set; }

    }
    public enum Gender
    {
        Masculino,
        Femenino
    }
}