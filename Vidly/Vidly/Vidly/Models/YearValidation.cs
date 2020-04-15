using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
    public class YearValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Movies movies = (Movies)validationContext.ObjectInstance;

            if (movies.ReleaseDate > 1700)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Bad news from validation class");
            }

        }
    }
}