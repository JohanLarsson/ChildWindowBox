using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace ChildWindowBox
{
    public class MinValidationRule : ValidationRule
    {
        public static readonly DependencyProperty AssertMinProperty = DependencyProperty.RegisterAttached(
            "AssertMin",
            typeof(int),
            typeof(MinValidationRule),
            new PropertyMetadata(default(int)));

        public MinValidationRule()
            : base(ValidationStep.ConvertedProposedValue, true)
        {
        }

        public string ErrorMessage { get; set; }

        public int Min { get; set; }

        public static void SetAssertMin(DependencyObject element, int value)
        {
            element.SetValue(AssertMinProperty, value);
        }

        public static int GetAssertMin(DependencyObject element)
        {
            return (int)element.GetValue(AssertMinProperty);
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return ((int)value) >= Min
                ? ValidationResult.ValidResult
                : new ValidationResult(false, ErrorMessage);
        }
    }
}