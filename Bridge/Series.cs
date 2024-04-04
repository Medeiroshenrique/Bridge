using System;

namespace Bridge
{
    public class Series : ICanal
    {
        const String canal = "CW Television Network";
        const String serie = "The Flash";
        public string Canal()
        {
            return string.Format($"Canal: {canal}");
        }

        public string Status()
        {
            return string.Format($"Assistindo agora: {serie}");
        }
    }
}
