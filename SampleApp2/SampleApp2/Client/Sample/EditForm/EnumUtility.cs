using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SampleApp2.Client.Sample.EditForm
{
    public static class EnumUtility
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();                            
        }
    }
}
