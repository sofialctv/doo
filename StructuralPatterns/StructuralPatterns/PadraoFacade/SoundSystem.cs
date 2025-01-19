using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoFacade
{
    public class SoundSystem
    {
        public void On() => Console.WriteLine("Sistema de som ligado.");
        public void SetVolume(int volume) => Console.WriteLine($"Volume ajustado para {volume}.");
        public void Off() => Console.WriteLine("Sistema de som desligado.");
    }
}
