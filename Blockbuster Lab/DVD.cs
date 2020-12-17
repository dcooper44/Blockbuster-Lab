using System;

namespace Blockbuster_Lab
{
    class DVD : Movie
    {
        public override void Play()
        {
            bool keepLooping;

            do
            {
                Console.WriteLine("Please select a scene to watch? (0-2)");

                PrintScenes();

                string userSelection = Console.ReadLine();              
                

                if (int.TryParse(userSelection, out int intScene) && intScene >= 0 && intScene < Scenes.Count)
                {
                    Console.WriteLine(Scenes[intScene]);

                    keepLooping = false;
                }
                else
                {
                    Console.WriteLine("Please Try Again");
                    keepLooping = true;
                }

            } while (keepLooping);

        }
        
    }
}





