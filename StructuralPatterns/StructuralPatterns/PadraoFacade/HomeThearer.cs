using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoFacade
{
    public class HomeTheaterFacade
    {
        private DvdPlayer _dvdPlayer;
        private Projector _projector;
        private Lights _lights;
        private SoundSystem _soundSystem;

        public HomeTheaterFacade(DvdPlayer dvd, Projector proj, Lights lights, SoundSystem sound)
        {
            _dvdPlayer = dvd;
            _projector = proj;
            _lights = lights;
            _soundSystem = sound;
        }

        public void PlayMovie(string movie)
        {
            Console.WriteLine("Iniciando o Home Theater...");
            _lights.Dim();
            _projector.On();
            _soundSystem.On();
            _soundSystem.SetVolume(10);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Encerrando o Home Theater...");
            _lights.On();
            _projector.Off();
            _soundSystem.Off();
            _dvdPlayer.Off();
        }
    }
}
