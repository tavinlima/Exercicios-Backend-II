using System;

namespace Atividade03.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel;

        public void FazerCafe(int qntdAcucar)
        {
            if (qntdAcucar <= acucarDisponivel)
            {
                Console.WriteLine($"Aqui está seu café! Com {qntdAcucar}g de açúcar.");
                acucarDisponivel = acucarDisponivel - qntdAcucar;
                Console.WriteLine($"Quantidade de açúcar disponível: {acucarDisponivel}g.");
            }
            else if (qntdAcucar > acucarDisponivel)
            {
                acucarDisponivel = acucarDisponivel - qntdAcucar;
                Console.WriteLine($"A quantidade exigida não é suportada. Aqui está seu café com {(acucarDisponivel + qntdAcucar)}g de açúcar restante dentro da máquina :)");
                Console.WriteLine("Quantidade de açúcar disponível: 0g.");
            }
        }
        public string FazerCafe()
        {
            return "Aqui está seu café! Sem açúcar ;)";
        }
    }
}