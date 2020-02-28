using System;
using System.Drawing;
using Console = Colorful.Console;
using Bakery.Models;
using StyleSheet = Colorful.StyleSheet;



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
  private static string _bakerypicture = @"
                ..::::...
              .::      `'''':::..
        '...::'               .----.
                             /_.--._\
                            ,  |=   |
                          ,/ \,|  =-|
                        ,/ /`\ \,   |
                      ,/ /`___`\ \,-|
                    ,/ /'.-:;-.`\ \|
                  ,/ /` //_|_|_\\ `\ \, ,/\,
                ,/ /`   ||_|_|_||   `\;/ /\ \,
              ,/ /`     ||_|_|_||   ,/ /`/\`\ \,
            ,/ /`    ==_`-------' ,/ /` ~\/~ `\ \,
        ,/ /`==_     __|___-  ,/ /` ==-=|__|     `\ \,
      ,/ /`        --=      ,/ /`            __|-- `\ \,
    ,/ /`  |__ ..----.. = ,/ /`    ()    .--.     ()`\ \,
   / /`|     .'_.-;;-._'./ /;     {__} .'.--.'.  {__} ;\ \
  |/`  |_| =/.; | || | ; |/` | |::|/.'  _____  '.\ |::| | `\|
       |   |/_|_|_||_|_|_\| |= \::/||  /|_|_|\  || \::/ |
       | , ||-|-|-||-|-|-||=|   JL || |_|_|_|_| ||  JL  |
       |/_\||_|_|_||_|_|_||-|'     ||   .:::.   ||=_   _|
       /_ (|| | | || | | || |   ==_|| /:::::::\ || __P__|
       /_\ \|-|-|-||-|-|-|| |      || |::(`)::| ||/\ |  `\
      `>/ _\\_|_|_||_|_|_||-|-'| __|| \/`\+/`\/ ||||_____|
      /_/   <-------------' |      ||()\_/Y\_/  ||/  || |
     /  ` \_ ( ==_  __|-    |_|_   ||   / / \   || =_|| |
    `/_) | _ <`   __        |   =  ||  /_/ \_\  ||   || |
     >  /     \ == _  ==_   | -    ||           ||=  || |
   /_/   ( \  `\ _| =__   =|-__|_|  |-----------||_| || |
   )-._/ _\ _,-('    __.;-'-;__      `''''''    ||`      -._
  '-,._   \__.-`-;''`          ``--'`'''''''``-- `--'--. '
  ";
  private static string _enter = @"Do you wish to enter the Bakery? [Y] yes [N] no";
        static void Main()
        {
       
        Console.Clear();
        Console.WriteLine(_bakerypicture);
        string result = YesOrNo(_enter);
        if(result=="y")
        {
          Shoping();
        }else
        {

        }
       
        }
        static string YesOrNo(string _yesOrNo)
        {
        StyleSheet styleSheet = new StyleSheet(Color.White);
        styleSheet.AddStyle("Y[a-z]*", Color.Green);
        styleSheet.AddStyle("N[a-z]*", Color.Red);
         Console.WriteLineStyled(_yesOrNo, styleSheet);
         Console.Write("Enter: ");
        string input = Console.ReadLine().ToLower();
        if(input == "y")
        {
          return "y";
        }
        else
        {
          return "n";
        }
        }
        static void TypeLineFast(string str)
        {
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i], Color.Turquoise);
                System.Threading.Thread.Sleep(5);
            }
            Console.WriteLine();
        }
         static void TypeLineSlow(string str)
        {
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i], Color.Turquoise);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine();
        }

        static void Shoping()
        {
          TypeLineFast(_bakeryName);
          YesOrNo("Hi! Welcome to the Bakery! would you Like to Make a purchase? [Y] or [N]");
        }
        static void GoodBye()
        {
          
        }
    }
}
