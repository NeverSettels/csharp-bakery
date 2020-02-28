using System;
using System.Drawing;
using Console = Colorful.Console;
using Bakery.Models;



namespace Bakery
{
    class Program
    {
    private static string _bakeryName = @"
  _____    _____   ________   ________    _____   _____        _____      ______      ____      __   ___    _____   ______    __      __ 
 / ____\  / ___/  (___  ___) (___  ___)  / ___/  (_   _)      / ____\    (_   _ \    (    )    () ) / __)  / ___/  (   __ \   ) \    / ( 
( (___   ( (__        ) )        ) )    ( (__      | |       ( (___        ) (_) )   / /\ \    ( (_/ /    ( (__     ) (__) )   \ \  / /  
 \___ \   ) __)      ( (        ( (      ) __)     | |        \___ \       \   _/   ( (__) )   ()   (      ) __)   (    __/     \ \/ /   
     ) ) ( (          ) )        ) )    ( (        | |   __       ) )      /  _ \    )    (    () /\ \    ( (       ) \ \  _     \  /    
 ___/ /   \ \___     ( (        ( (      \ \___  __| |___) )  ___/ /      _) (_) )  /  /\  \   ( (  \ \    \ \___  ( ( \ \_))     )(     
/____/     \____\    /__\       /__\      \____\ \________/  /____/      (______/  /__(  )__\  ()_)  \_\    \____\  )_) \__/     /__\ ";
        static void Main()
        {
       
        TypeLineTitle(_bakeryName);
        }
        static void TypeLineTitle(string str)
        {
          string welcome = "Welcome to:";
          Console.SetCursorPosition((Console.WindowWidth - welcome.Length) / 2, Console.CursorTop);
          for (int i = 0; i < welcome.Length; i++)
            {
                Console.Write(welcome[i], Color.Yellow);
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - 100) / 2, Console.CursorTop);
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i], Color.Turquoise);
                System.Threading.Thread.Sleep(5);
            }
            Console.WriteLine();
        }
    }
}
