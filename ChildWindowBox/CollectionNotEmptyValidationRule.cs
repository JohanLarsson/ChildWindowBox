namespace ChildWindowBox
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Controls;

    public class CollectionNotEmptyValidationRule : ValidationRule
    {
        public CollectionNotEmptyValidationRule()
            : base(ValidationStep.RawProposedValue, true)
        {
        }

        public string ErrorMessage { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return (value as IEnumerable<object>)?.Any() == true
                ? ValidationResult.ValidResult
                : new ValidationResult(false, ErrorMessage);
        }
    }
}