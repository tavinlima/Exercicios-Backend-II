namespace AulaPOOCelular
{
    public class Celular
    {
        public string color;
        public string modelo;
        public float tamanho;
        public bool ligado;

        public void Ligar(){
            
        }
        public void Desligar(){
            ligado = false;
        }
        public string FazerLgo(){
            return "Chamando...";    
        }
        public string EnviarMsg(){
            return "Mensagem Enviada!";
        }
    }
}