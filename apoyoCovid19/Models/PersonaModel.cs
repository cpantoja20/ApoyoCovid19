using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace apoyoCovid19.Models
{
    public class PersonaModel
    {

        [Required]
        public int Identificacion { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string CiudadP { get; set; }
        [Required]
        public string DepartamentoP { get; set; }
    }
    public class PersonaViewModel : PersonaModel
    {
        public PersonaViewModel()
        {
        }
        public PersonaViewModel(Persona persona)
        {
            Identificacion = persona.Identificacion;
            Nombre = persona.Nombre;
            Edad = persona.Edad;
            Sexo = persona.Sexo;
            CiudadP = persona.Ciudad;
            DepartamentoP = persona.Departamento;
        }
    }

    public class SexValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToString(value) == "M" || Convert.ToString(value) == "F")
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }
}


