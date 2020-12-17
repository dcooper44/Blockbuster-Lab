using System;

namespace Blockbuster_Lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public override void Play()
        {
            Console.WriteLine($"{Scenes[CurrentTime]}");

            CurrentTime += 1;
        }

      

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}





