namespace SuperSmashSENAI
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public int barraEnergia;
        public int forca;
        public int resistencia;


        public int Atacar(){
            int dano = 5 * forca;
            return dano;
        }
        public int Defesa(){
            int defesa = 3 * resistencia;
            return defesa;
        }
        public int AtaqueEspecial(){
            int dano = 5 * forca;
            int aSpecial = dano * 10;
            return aSpecial;
        }
    }
}