

using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objectType = obj.GetType();

            PropertyInfo[] properties = objectType
                .GetProperties()
                .Where(p => p.CustomAttributes
                    .Any(ca => typeof(MyValidationAttribute)
                        .IsAssignableFrom(ca.AttributeType)))
                .ToArray();

            foreach (var propertyInfo in properties)
            {
                IEnumerable<MyValidationAttribute> attributes = propertyInfo
                    .GetCustomAttributes(true)
                    .Where(ca => typeof(MyValidationAttribute)
                        .IsAssignableFrom(ca.GetType()))
                    .Cast<MyValidationAttribute>();

                foreach (MyValidationAttribute attribute in attributes)
                {
                    if (!attribute.IsValid(propertyInfo.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
