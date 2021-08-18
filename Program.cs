using System;
using System.Diagnostics;


namespace Timer
{
    class Program
    {        
        static void Main()
        {
            string time = DateTime.Now.ToString("hh:mm");
            Console.WriteLine("Defina o Horario que irá desligar (hh:mm): ");
            string timer = Console.ReadLine();
            while (true)
            {
                
                time = DateTime.Now.ToString("hh:mm");
                Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                if(timer == time)
                {
                    break;
                }
            }
            
            Process.Start("shutdown.exe","-s -t 180 -c'Falta 30 mins para desligar, salve tudo!!'");
            Console.WriteLine("acabou!");
            Console.ReadLine();
        }
    }
}
