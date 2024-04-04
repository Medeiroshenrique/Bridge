using System;

namespace Bridge
{
    public class Filme : ICanal
    {
        const String canal = "HBO";
        const String filme = "Aquaman e o reino perdido";
        public string Canal()
        {
            return string.Format($"Canal: {canal}");
        }

        public string Status()
        {
            return string.Format($"Assistindo agora: {filme}");
        }
    }
}
