using System;

namespace Bridge {
    class Program {
        static void Main(string[] args)
        {
            SmartTelevision samsungSmartTV = new SmartTelevision();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Escolha o canal deseja assistir ");
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("1)Documentarios");
            Console.WriteLine("2)Series");
            Console.WriteLine("3)Filmes");
            Console.ResetColor();

            ConsoleKeyInfo canalSelecionado = Console.ReadKey();

            
                switch (canalSelecionado.KeyChar)
                {
                    case '1':
                        samsungSmartTV.canalAtual = new Documentario();
                        break;
                    case '2':
                        samsungSmartTV.canalAtual = new Series();
                        break;
                    case '3':
                        samsungSmartTV.canalAtual = new Filme();
                        break;
                }

            
            Console.WriteLine("-------------------------");
            samsungSmartTV.MostrarCanalAtual();
            samsungSmartTV.MostrarProgramacaoAtual();
        }
    }
}