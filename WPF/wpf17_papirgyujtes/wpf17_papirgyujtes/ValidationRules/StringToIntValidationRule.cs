using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using System.Windows.Controls;


namespace wpf17_papirgyujtes.ValidationRules
{
    public class StringToIntValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int i;

            if (value.ToString() == null) { return new ValidationResult(false, "Csak szám lehet!"); }

            if (int.TryParse(value.ToString(), out i))
            {
                return new ValidationResult(true, null); // nincs hiba
            }

            return new ValidationResult(false, "Csak szám lehet!"); // van hiba
        }
    }
}
