namespace DivisasNative
{
    public class Converter
    {
        public static Exchange Convert(decimal pesos)
        {
            return new Exchange
            {
                Dollars = pesos / 2975M,
                Euros = pesos / 3456M,
                Pounds = pesos / 4302M,
            };
        }
    }
}