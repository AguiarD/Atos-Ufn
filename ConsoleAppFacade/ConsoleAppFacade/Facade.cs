using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFacade
{
    public class Facade
    {
        Audio a1;
        Video v1;
        Input i1;
        public Facade()
        {
            a1 = new Audio();
            v1 = new Video();
            i1 = new Input();
        }

        public void InicializaAudioVideo()
        {
            Console.WriteLine("Innicializando componentes de audio e video!");
            a1.metodo();
            v1.metodo();
            i1.metodo();
        }

        public void ApresentaAudio()
        {
            Console.WriteLine("Inicializando Audio!");
            a1.metodo();
        }

        public void ApresentaVideo()
        {
            Console.WriteLine("Apresentando video!");
            v1.metodo();
        }
    }
}
