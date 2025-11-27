using Microsoft.Ajax.Utilities;
using System.ComponentModel;

namespace VillaAgency.Models.Properties.Tools
{
    public static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
            if(value == null) {
                return string.Empty;
            }

            var field = value.GetType().GetField(value.ToString());

            if(field == null) { return value.ToString();}

            var attribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
           
            
            return attribute?.Description ?? value.ToString();
            
        }
    }
}
