namespace H_M_20
{
    internal class ConverterMethods
    {
        public static string AnyValuesToUs(double sum, double currentValue)
        {
            var result = sum / currentValue;
            return $"Sizning xaridingiz :{result}";
        }
        
        public static string UsToAnyValues(double us, double currentValue)
        {
            var result = us * currentValue;
            return $"Sizning xaridingiz :{result}";
        }
    }
}
