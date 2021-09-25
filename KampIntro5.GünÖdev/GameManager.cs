using System;
using System.Collections.Generic;
using System.Text;

namespace KampIntro5.GünÖdev
{
    public class GameManager : IGameService
    {
        public void Oyunsatinalindi(GameManager game)
        {
            Console.WriteLine("Oyun satın alındı");
        }

        public void Sepeteekle(GameManager game)
        {
            Console.WriteLine("Sepete eklendi");
        }
    }
}
