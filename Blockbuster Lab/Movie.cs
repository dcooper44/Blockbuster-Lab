using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    public abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }

        public List<string> Scenes { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}, Category: {Category}, RunTime: {RunTime}");            
        }

        public void PrintScenes()
        {
            int index = 0;

            foreach (string scene in Scenes)
            {
                Console.WriteLine($"{index}: {scene}");
                index += 1;
            }
        }

        public abstract void Play();
    }
}





