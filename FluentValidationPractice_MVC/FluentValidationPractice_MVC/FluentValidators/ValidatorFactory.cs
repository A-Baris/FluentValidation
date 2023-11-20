using FluentValidation;

namespace FluentValidationPractice_MVC.FluentValidators
{
    public class ValidatorFactory:ValidatorFactoryBase
    {
        public override IValidator CreateInstance(Type validatorType)
        {
            return validatorType == null ? null : (IValidator)Activator.CreateInstance(validatorType);
        }
    }
}
