using System;

namespace Bridge
{
    public class Documentario : ICanal
    {
        const String canal = "Discovery Channel";
        const String documentario = "Caçadores de Mitos";
        public string Canal()
        {
            return string.Format($"Canal: {canal}");
        }

        public string Status()
        {
            return string.Format($"Assistindo agora: {documentario}");
        }
    }
}
