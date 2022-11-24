using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KusokTekstovogoEditora
{
    internal class ImposibleJson
    {

        private int Y_Position = 2;
        private int X_Position = 2;
        public void Json_Edit(string Jpath)
        {
            List<JsonSmth> Pieces =JsonConvert.DeserializeObject< List < JsonSmth >> (Jpath);
            menu(Pieces);
            
            
      
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Y_Position--;

                }

                else if (key.Key == ConsoleKey.DownArrow)
                {
                    Y_Position++;

                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    X_Position--;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    X_Position++;
                }
                else if (key.Key == ConsoleKey.Escape) { break; }
                Console.Clear();
                
                menu(Pieces);
                Console.SetCursorPosition(X_Position, Y_Position);
                if (key.Key == ConsoleKey.Enter)
                {
                    if (Y_Position == 0) { Pieces[0].Name =Pieces[0].Name + Console.ReadLine(); }
                   else if (Y_Position == 1) { Pieces[0].Spot = Pieces[0].Spot + Console.ReadLine(); }
                    else if (Y_Position == 2) { Pieces[0].Type = Pieces[0].Type + Console.ReadLine(); }

                    else if (Y_Position == 3) { Pieces[1].Name = Pieces[1].Name + Console.ReadLine(); }
                    else if (Y_Position == 4) { Pieces[1].Spot = Pieces[1].Spot + Console.ReadLine(); }
                    else if (Y_Position == 5) { Pieces[1].Type = Pieces[1].Type + Console.ReadLine(); }
                }
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (Y_Position == 0) { Pieces[0].Name =  Console.ReadLine(); }
                    else if (Y_Position == 1) { Pieces[0].Spot =  Console.ReadLine(); }
                    else if (Y_Position == 2) { Pieces[0].Type =  Console.ReadLine(); }

                    else if (Y_Position == 3) { Pieces[1].Name =  Console.ReadLine(); }
                    else if (Y_Position == 4) { Pieces[1].Spot =  Console.ReadLine(); }
                    else if (Y_Position == 5) { Pieces[1].Type =  Console.ReadLine(); }
                }
                if (key.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    Console.WriteLine("Введите путь (вместе с названием)");
                    string path2 = Console.ReadLine();
                    string path = JsonConvert.SerializeObject(Pieces);
                    File.WriteAllText(path2, path);
                }
                else if (key.Key == ConsoleKey.Escape) { break; }

                Console.SetCursorPosition(X_Position, Y_Position);

            }
            
        }
        private void menu(List<JsonSmth> Balbes)
        {
            Console.WriteLine(Balbes[0].Name);
            Console.WriteLine(Balbes[0].Spot);
            Console.WriteLine(Balbes[0].Type);
            
            Console.WriteLine(Balbes[1].Name);
            Console.WriteLine(Balbes[1].Spot);
            Console.WriteLine(Balbes[1].Type);
            
        }
    }
}

