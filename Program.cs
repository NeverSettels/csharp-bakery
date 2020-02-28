using System;
using System.Drawing;
using System.Collections.Generic;
using Console = Colorful.Console;
using Bakery.Models;
using StyleSheet = Colorful.StyleSheet;



namespace Bakery
{
    class Program
    {
    private static string _bakeryName = @"
______ _                    _      ______       _                   
| ___ (_)                  ( )     | ___ \     | |                  
| |_/ /_  ___ _ __ _ __ ___|/ ___  | |_/ / __ _| | _____ _ __ _   _ 
|  __/| |/ _ \ '__| '__/ _ \ / __| | ___ \/ _` | |/ / _ \ '__| | | |
| |   | |  __/ |  | | |  __/ \__ \ | |_/ / (_| |   <  __/ |  | |_| |
\_|   |_|\___|_|  |_|  \___| |___/ \____/ \__,_|_|\_\___|_|   \__, |
                                                               __/ |
                                                              |___/ ";
  private static string _bakerypicture = @"
                ..::::...
              .::      `''''::::.,,
        '...::'                .----.
                              /_.--._\
                            ,  |=   |
                          ,/ \,|  =-|
                        ,/ /`\ \,   |
                      ,/ /`___`\ \,-|
                    ,/ /'.-:;-.`\ \ |
                  ,/ /` //_|_|_\\ `\ \, ,/\,
                ,/ /`   ||_|_|_||   `\;/ /\ \,
              ,/ /`     ||_|_|_||   ,/ /`/\`\ \,
          _,/ /`     ==_`-------',_/ /` ~\/~ `\ \,_
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
  private static string _goodBye = @"
 _____ _____  ___________  ________   _______   _ 
|  __ \  _  ||  _  |  _  \ | ___ \ \ / /  ___| | |
| |  \/ | | || | | | | | | | |_/ /\ V /| |__   | |
| | __| | | || | | | | | | | ___ \ \ / |  __|  | |
| |_\ \ \_/ /\ \_/ / |/ /  | |_/ / | | | |___  |_|
 \____/\___/  \___/|___/   \____/  \_/ \____/  (_)";
  private static string _enter = @"Do you wish to enter the Bakery? [Y] yes [N] no";
  private static int _cost = 0;
  private static Bread baguette = new Bread("Classic","Baguette", 6);
  private static Bread sourDoughRoll = new Bread("Sour","Roll", 4);
  private static Bread normalRoll = new Bread("Default","Roll", 2);
  private static Pastry chocolateDonut = new Pastry( "Choco" ,"Donut", "Chocolate", 3);
  private static Pastry glazedDonut = new Pastry("Glaze ","Donut", "Glazed", 3);
  private static Pastry jellyDonut = new Pastry("Jellied", "Donut", "Jelly", 4);
  private static Pastry muffin = new Pastry("BM","Muffin", "Blueberry", 6);
  private static List<Bread> _breads = new List<Bread>{baguette, sourDoughRoll, normalRoll};
  private static List<Pastry> _pastrys = new List<Pastry>{chocolateDonut, glazedDonut, jellyDonut, muffin};

          

        static void Main()
        {
       
        Console.Clear();
        TypeLineFast(_bakerypicture);
        string result = YesOrNo(_enter);
        if(result=="y")
        {
          Shoping();
        }else
        {
          GoodBye();
        }
       
        }
        static string YesOrNo(string _yesOrNo)
        {
        StyleSheet styleSheet = new StyleSheet(Color.White);
        styleSheet.AddStyle("Y*", Color.Green);
        styleSheet.AddStyle("N*", Color.Red);
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
                Console.Write(str[i], Color.Blue);
                System.Threading.Thread.Sleep(5);
            }
            Console.WriteLine();
        }
         static void TypeLineSlow(string str)
        {
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
          string purchase = YesOrNo("Hi! Welcome to the Bakery! Would you Like to Make a purchase? [Y] or [N]");
          if(purchase == "y")
          {
            ShowMenu();
            Choosing();
          }
          else{
            GoodBye();
          }
        }
        static void GoodBye()
        {
          TypeLineSlow($"You spent ${_cost} at Pierre's Bakery Today!");
          TypeLineFast(_goodBye);
        }
        static void ShowMenu()
        {
          TypeLineFast("Remeber Breads are buy 2 get 1 free! and Pastries are 3 for S5! (NO mixing and matching)\n");
          TypeLineSlow("BREADS:");
          foreach(Bread bread in _breads )
          {
            TypeLineSlow($" Name: {bread.NameBread}, Type: {bread.TypeBread}, Price: ${bread.PriceBread} ");
          }
          Console.WriteLine();
           TypeLineSlow("PASTRIES:");
          foreach(Pastry pastry in _pastrys )
          {
            TypeLineSlow($" Name: {pastry.NamePastry}, Pastry: {pastry.TypePastry}, Flavor: {pastry.FlavorPastry}, Price: ${pastry.PricePastry} ");
          }
        }
        static void AddCost(string selection, int amount )
        {
          int price = 0;
          switch(selection)
         {
           case "classic":
            price = calcBread(baguette.PriceBread, amount);
            _cost += price;
            break;
           case "sour":
            price = calcBread(sourDoughRoll.PriceBread, amount);
            _cost += price;
            break;
           case "default":
            price = calcBread(normalRoll.PriceBread, amount);
            _cost += price;
            break;
           case "choco":
            price = calcPastry(chocolateDonut.PricePastry, amount);
            _cost += price;
            break;
           case "glaze":
            price = calcPastry(glazedDonut.PricePastry, amount);
            _cost += price;
            break;
           case "jellied":
            price = calcPastry(jellyDonut.PricePastry, amount);
            _cost += price;
            break;
           case "bm":
            price = calcPastry(muffin.PricePastry, amount);
            _cost += price;
            break;
            default:
              TypeLineSlow("Sorry! We Dont Sell that! Please enter your choice again.");
              Choosing();
              break;
         }
        }
        static void Choosing()
        {
          TypeLineSlow("Enter the name of what you would like:");
          Console.Write("Your Choice: ");
          string choise = Console.ReadLine().ToLower();
          TypeLineSlow($"Enter the amount of {choise} you would like:");
          Console.Write("How many: ");
          string amountStr = Console.ReadLine();
          int amount = int.Parse(amountStr);
          AddCost(choise,amount);
          TypeLineSlow($"Your Total Cost is ${_cost}");
          string buyMore = YesOrNo("Would you like to get something else? [Y] or [N]");
          if(buyMore=="y"){
            Choosing();
          }
          else
          {
            GoodBye();
          }
        }
        static int calcBread(int price, int amount)
        {
          int freePieces = amount/3;
          return price*amount-(freePieces*price);
        }
        static int calcPastry(int price, int amount)
        {
          int fiveDollarPieces = amount/3;
          int fullPricePice = amount%3;
          return (5*fiveDollarPieces)+(fullPricePice*price);
        }
    }
}
