using System;


namespace Bridge
{
    public class SmartTelevision
    {
        public ICanal canalAtual { get; set; }
        public void MostrarCanalAtual()
        {
            if (canalAtual != null)
            {
                Console.WriteLine(canalAtual.Canal());
            }
            else {
                Console.WriteLine("Sintonize a algum canal, por favor!");
            }
        }

        public void MostrarProgramacaoAtual() {
            if (canalAtual != null)
            {
                Console.WriteLine(canalAtual.Status());
            }
            else {
                Console.WriteLine("Sintonize a algum canal, por favor!");
            }
        }
    }
}
