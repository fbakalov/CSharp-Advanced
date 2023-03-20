
namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int _min;
        private readonly int _max;

        public MyRangeAttribute(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public override bool IsValid(object obj)
        {
            return (int)obj > _min && (int)obj < _max; ;
        }
    }
}
