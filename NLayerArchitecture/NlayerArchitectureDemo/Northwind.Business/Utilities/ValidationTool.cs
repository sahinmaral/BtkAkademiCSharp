using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Northwind.Business.Utilities
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator , object entity)
        {
            var context = new ValidationContext<object>(entity);
            var validationResult = validator.Validate(context);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
    }
}
