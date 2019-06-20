using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Formulario.MVC.Validators
{
    public class MutualAttribute : ValidationAttribute, IClientValidatable
    {
        private string _otherField;

        public MutualAttribute(string otherField, string errorMessage) 
            : base(errorMessage)
        {
            _otherField = otherField;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult resut = ValidationResult.Success;

            try
            {
                // REFLECTION 
                PropertyInfo fieldInfo = validationContext.ObjectType.GetProperty(_otherField);

                object resultValue = fieldInfo.GetValue(validationContext.ObjectInstance, null );
                string referenceProperty = resultValue != null ? resultValue.ToString() : string.Empty;

                if (value == null && !string.IsNullOrEmpty(referenceProperty) )
                {
                    resut = new ValidationResult(ErrorMessage);
                }
            }
            catch 
            {
                
                throw;
            }

            return resut;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            //Validação Jquery, lado do Cliente
            ModelClientValidationRule dddTelefoneRule = new ModelClientValidationRule();
            dddTelefoneRule.ErrorMessage = ErrorMessageString;
            dddTelefoneRule.ValidationType = "dddtelefone";

            dddTelefoneRule.ValidationParameters.Add("otherfield", _otherField);

            yield return dddTelefoneRule;


        }
    }
}