using System;

namespace SuperSmashSENAI
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Personagem personagem1 = new Personagem();
            personagem1.nome = "Homem-Aranha (Peter Parker)";
            personagem1.armadura = "Carisma";
            personagem1.barraEnergia = 85;
            personagem1.forca = 8;
            personagem1.resistencia = 5;

            Personagem personagem2 = new Personagem();
            personagem2.nome = "Homem-Aranha (Miles Morales)";
            personagem2.armadura = "Alta tecnologia";
            personagem2.barraEnergia = 75;
            personagem2.forca = 6;
            personagem2.resistencia = 2;

            // Personagem personagem3 = new Personagem();
            // personagem3.nome = "Gwen Stacy";
            // personagem3.armadura = "Banda de garagem";
            // personagem3.barraEnergia = 75;
            // personagem3.forca = 4;
            // personagem3.resistencia = 4;

            Console.WriteLine($@"
            =============================================
                        Aranhas disponíveis:

                    1 - Homem-Aranha(Peter Parker)
                    Nome: {personagem1.nome}
                    Idade: {personagem1.idade}
                    Armadura: {personagem1.armadura}
                    Barra de energia: {personagem1.barraEnergia} pontos

                    2 - Homem-Aranha Ultimate(Miles Morales)
                    Nome: {personagem2.nome}
                    Idade: {personagem2.idade}
                    Armadura: {personagem2.armadura}
                    Barra de energia: {personagem2.barraEnergia} pontos

            =============================================
            ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n QUE O MELHOR ARANHA VENÇA!!!" + "\n");
                Console.ResetColor();

            do
            {

                Console.WriteLine($@"
            ================================================================
                    Escolha o que {personagem1.nome} deve fazer:
            ================================================================
                                    1 - Atacar
                                    2 - Defender
            ================================================================
            ");
                int acao1 = int.Parse(Console.ReadLine());

                Console.WriteLine($@"
            ================================================================
                    Escolha o que {personagem2.nome} deve fazer:
            ================================================================
                                    1 - Atacar
                                    2 - Defender
            ================================================================
            ");
                int acao2 = int.Parse(Console.ReadLine());

                if (acao1 == 1 && acao2 == 1)
                {
                    personagem1.barraEnergia = personagem1.barraEnergia - personagem2.Atacar();

                    personagem2.barraEnergia = personagem2.barraEnergia - personagem1.Atacar();

                }
                else if (acao1 == 1 && acao2 == 2)
                {
                    personagem2.barraEnergia = personagem2.barraEnergia - (personagem1.Atacar() - personagem2.Defesa());
                }
                else if (acao1 == 2 && acao2 == 1)
                {
                    personagem1.barraEnergia = personagem1.barraEnergia - (personagem2.Atacar() - personagem1.Defesa());
                }
                else if (acao1 == 2 && acao2 == 2)
                {
                    Console.WriteLine("\n Ambos defenderam! Sem dano." + "\n");
                }
                if (c > 2)
                {
                    Console.WriteLine("Você agora tem acesso ao ataque especial! Digite 3 se deseja utilizá-lo");
                    if (acao1 == 3 && acao2 == 2)
                    {
                        personagem2.barraEnergia = personagem2.barraEnergia - (personagem1.AtaqueEspecial() - personagem2.Defesa());
                    }
                    else if (acao1 == 3 && acao2 == 1)
                    {
                        personagem2.barraEnergia = personagem2.barraEnergia - personagem1.AtaqueEspecial();
                        personagem1.barraEnergia = personagem1.barraEnergia - personagem2.Atacar();
                    }
                    else if (acao1 == 2 && acao2 == 3)
                    {
                        personagem1.barraEnergia = personagem1.barraEnergia - personagem2.AtaqueEspecial();
                    }
                    else if (acao1 == 1 && acao2 == 3)
                    {
                        personagem1.barraEnergia = personagem1.barraEnergia - personagem2.AtaqueEspecial();
                        personagem2.barraEnergia = personagem2.barraEnergia - personagem1.Atacar();
                    }
                    else if (acao1 == 3 && acao2 == 3)
                    {
                        personagem1.barraEnergia = personagem1.barraEnergia - personagem2.AtaqueEspecial();
                        personagem2.barraEnergia = personagem2.barraEnergia - personagem1.AtaqueEspecial();
                    }
                }
                c++;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Barra de energia {personagem1.nome}: {personagem1.barraEnergia}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Barra de energia {personagem2.nome}: {personagem2.barraEnergia}");
                Console.ResetColor();


            } while (personagem1.barraEnergia > 0 && personagem2.barraEnergia > 0);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n GAME OVER!!!" + "\n");
            Console.ResetColor();

        }
    }
}
