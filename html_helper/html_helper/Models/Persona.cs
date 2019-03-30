using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace html_helper.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Este campo debe ser completado obligatoriamente")]
        public int Cedula { get; set; }

        [Required(ErrorMessage = "Este campo debe ser completado obligatoriamente")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo debe ser completado obligatoriamente")]
        public string Apellido { get; set; }

        [Range(15,99, ErrorMessage = "La edad debe ser mayor o igual a 15 y menor de 99")]
        public int Edad { get; set; }

        public int Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Por favor introduceir un correo válido")]
        public string Correo { get; set; }

        public string Genero { get; set; }

        public string EstadoCivil { get; set; }

        public string Hobbys { get; set; }

       
    }
}