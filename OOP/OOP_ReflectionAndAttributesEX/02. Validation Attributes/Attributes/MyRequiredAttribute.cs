

using ValidationAttributes;

namespace _02._Validation_Attributes.Attributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        => obj is not null;
    }
}
