

using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, string[] fields)
        {
            Type classType = Type.GetType("Stealer." + className);
            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder sb = new();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            sb.AppendLine($"Class under investigation: {className}");

            foreach (FieldInfo field in classFields.Where(x => fields.Contains(x.Name)))
            {S
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");

            }

            return sb.ToString().Trim();
        }
    }
}
