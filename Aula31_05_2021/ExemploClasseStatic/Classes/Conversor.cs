namespace ExemploClasseStatic.Classes
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.24f;
        public static float RealToDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }
        public static float DolarToReal(float valorUS){
            return CotacaoDolar * valorUS;
        }
    }
}