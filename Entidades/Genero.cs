using PeliculasAPI.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Entidades
{
    public class Genero: IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:10,ErrorMessage = "El campo {0} debe tener una longitud maxima de {1}")]
        //[PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        [Range(18,120)]
        public int Edad { get; set; }

        [CreditCard]
        public string TarjetaDeCredito { get; set; }

        [Url]
        public string URL { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Nombre.ToString()))
            {
                var primeraLetra = Nombre[0].ToString();

                if(primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe ser mayuscula", new string[] { nameof(Nombre)});
                }
            }
        }
    }
}
