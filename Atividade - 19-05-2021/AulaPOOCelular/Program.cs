using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = DateTime.Now;
            Celular celularNovo = new Celular();
            celularNovo.modelo = "ObaBox";
            celularNovo.color = "Black";
            celularNovo.tamanho = 6.7f;
            celularNovo.ligado = true;

            Console.WriteLine($@"
            =================================
                    Modelo do Celular:
            =================================
            Modelo:     {celularNovo.modelo}
            Cor:        {celularNovo.color}
            Tamanho:    {celularNovo.tamanho} px
            =================================
            ");

            Console.WriteLine("Para ligar o celular, digite 2.");
            int ligCelular = int.Parse(Console.ReadLine());
            if (ligCelular == 2)
            {
                celularNovo.Ligar();
            }
            if (celularNovo.ligado == true)
            {
                do
                {
                    Console.WriteLine($@"
                             =============================================
                             |                     °O                    |
                                                      {dateTime}         
                             |                                           |
                                         Bem vindo ao seu {celularNovo.modelo}    
                             |                                           |
                             |                                           |
                             |                                           |
                             |    |                                 |    |
                             |    |    Escolha o que deseja fazer:  |    |
                             |    |                                 |    |
                             |    |    1 - Fazer uma ligação.       |    |
                             |    |                                 |    |
                             |    |    2 - Enviar uma mensagem.     |    |
                             |    |                                 |    |
                             |    |    0 - Desligar.                |    |
                             |    |                                 |    |
                             ==============================================
                ");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine($@"
                             ==============================================
                             |                     °O                     |
                                                      {dateTime}           
                             |                                            |
                             |          Para quem deseja ligar?           |
                             |                                            |
                             |           Seus contatos:                   |
                             |                                            |
                             |           Odirlei:                         |
                             |                                            |
                             |           Thiago:                          |
                             |                                            |
                             |           Polícia:                         |
                             |                                            |
                             |           Bombeiro:                        |
                             |                                            |
                             |           Ambulância:                      |
                             |                                            |
                             ==============================================
                            ");
                            string cnt = Console.ReadLine() .ToLower();
                            Console.WriteLine($@"
                             ==============================================
                             |                     °O                     |
                                                    {dateTime}
                             |                                            |
                                        {cnt}                         
                             |                                            |
                                        {celularNovo.FazerLgo()}          
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             ==============================================
                            ");
                            break;
                        case "2":
                            Console.WriteLine($@"

                             ==============================================
                             |                     °O                     |
                                                     {dateTime}
                             |                                            |
                             |      Para quem deseja mandar mensagem?     |
                             |                                            |
                             |           Seus contatos:                   |
                             |                                            |
                             |           Odirlei:                         |
                             |                                            |
                             |           Thiago:                          |
                             |                                            |
                             |           Polícia:                         |
                             |                                            |
                             |           Bombeiro:                        |
                             |                                            |
                             |           Ambulância:                      |
                             |                                            |
                             ==============================================
                            ");
                            cnt = Console.ReadLine() .ToLower();
                            Console.WriteLine("Digite sua mensagem: ");
                            string msg = Console.ReadLine();
                            Console.WriteLine($@"
                             ==============================================
                             |                     °O                     |
                                                     {dateTime}
                             |                                            |
                                  {cnt}                         
                             |                                            |
                                  Mensagem: {msg}                             
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                             |                                            |
                                          {celularNovo.EnviarMsg()}         
                             |                                            |
                             |                                            |
                             |                                            |
                             ==============================================
                            ");
                            break;
                        case "0":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Tem certeza? S/N");
                            Console.ResetColor();
                            string crtz = Console.ReadLine() .ToUpper() .Substring(0, 1);
                            if (crtz == "S")
                            {
                            celularNovo.Desligar();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Desligando...");
                            Console.ResetColor();
                            }
                            break;
                        default:
                            break;
                    }

                } while (celularNovo.ligado);
            }
        }
    }
}
