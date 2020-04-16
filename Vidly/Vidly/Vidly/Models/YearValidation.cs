using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.ViewModel;

namespace Vidly.Models
{
    public class YearValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            MoviesTemplateViewModel movies = (MoviesTemplateViewModel)validationContext.ObjectInstance;

            //if(movies.Id==0)
            //{
            //    return ValidationResult.Success;
            //}
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