using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pian
{
    internal class Piano 
    {
             private int currentOctave = 1;
        private List<int[]> octaves = new List<int[]>
    {
        new int[] {261, 293, 329, 349, 392, 440, 493, 523}, // 1 октава
        new int[] {523, 587, 659, 698, 784, 880, 987, 1046},// 2 октава
        new int[] {1046,1174,1318,1396,1568,1720,1975,2093},//3 октава
        new int[] {2093,2349,2637,2793,3136,3440,3951,4186},//4 октава
        new int[] {4186, 4698,5274}//5 октава
    };

        static void Main(string[] args)
        {
            Piano piano = new Piano();
            piano.Start();
        }

        public void Start()
        {
            Console.WriteLine("Используйте клавиши A-K для игры. Нажмите F1, F2, F3 и т.д. для изменения октавы.");
            Console.WriteLine("Нажмите Enter для выхода.");

            while (true)
            {           
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                if (key.Key == ConsoleKey.Enter)
                {
                    Environment.Exit(0);
                    
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    ChangeOctave(1);
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    ChangeOctave(2);
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    ChangeOctave(3);
                }
                else if (key.Key == ConsoleKey.F4)
                {
                    ChangeOctave(4);
                }
                else if (key.Key == ConsoleKey.F5)
                {
                    ChangeOctave(5);
                }

                else if (key.Key == ConsoleKey.A)
                {
                   
                    Console.Beep(GetOctave()[0], 300);
                    
                    
                }
                else if (key.Key == ConsoleKey.S)
                {
                    
                    Console.Beep(GetOctave()[1], 300);
                }
                else if (key.Key == ConsoleKey.D)
                {
                    
                    Console.Beep(GetOctave()[2], 300);
                }
                else if (key.Key == ConsoleKey.F)
                {
                   
                    Console.Beep(GetOctave()[3], 300);
                }
                else if (key.Key == ConsoleKey.G)
                {
                    
                    Console.Beep(GetOctave()[4], 300);
                }
                else if (key.Key == ConsoleKey.H)
                {
                    
                    Console.Beep(GetOctave()[5], 300);
                }
                else if (key.Key == ConsoleKey.J)
                {
                    
                    Console.Beep(GetOctave()[6], 300);
                }
                else if (key.Key == ConsoleKey.K)
                {
                    Console.Beep (GetOctave()[7], 300);
              
                }
            }
        }

        
        public int[] GetOctave()
        {
            return octaves[currentOctave - 1];
        }
        public void ChangeOctave(int octave)
        {
            if (octave >= 1 && octave <= octaves.Count)
            {
                currentOctave = octave;
                Console.WriteLine("Октава " + currentOctave);
            }
            else
            {
                Console.WriteLine("Недопустимая октава");
            }
        }
    }

}
    

