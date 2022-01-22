using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Geres4U.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed class CategoryValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null || value.GetType() != typeof(string)) return false;
            String cat = (String) value;
            Category c = new Category(cat);
            if (c.Id != -1) return true;
            else return false;
        }
    }
}
