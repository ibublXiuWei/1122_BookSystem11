using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.BookSystem.Extensions
{
	public class ValidationHelper
	{
		public static bool Validate<T>(T model, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			ValidationContext context = new ValidationContext(model, null, null);
			List<ValidationResult> errors = new List<ValidationResult>();
			errorProvider.Clear();
			bool ValidateAllProperties = true;
			bool IsValid = Validator.TryValidateObject(model, context, errors, ValidateAllProperties);
			if (!IsValid)
			{
				DisplayErrorsByErrorProvider(errors, map, errorProvider);
			}
			return IsValid;

		}

		private static void DisplayErrorsByErrorProvider(List<ValidationResult> errors, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{

			//this.errorProvider1.Clear();
			foreach (ValidationResult error in errors)
			{
				string propname = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propname, out Control ctrl))
				{
					errorProvider.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
	}
}
