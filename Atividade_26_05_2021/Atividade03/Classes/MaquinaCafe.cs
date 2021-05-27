using System;

namespace Atividade03.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel
        {get; set;}

        public void FazerCafe(string qntdAcucar){
            acucarDisponivel = acucarDisponivel - 10;
        }
        public void FazerCafe(){

        }
    }
}