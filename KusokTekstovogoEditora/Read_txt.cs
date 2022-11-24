using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KusokTekstovogoEditora
{
    public class Read_txt
    {
        private int Y_Position = 2;// это опять кринжатина полная...
        private int X_Position = 2;
        public void Text_Edit(string path)
        {
           
          
            Console.WriteLine(path);
           
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
                else if(key.Key == ConsoleKey.RightArrow)
                {
                    X_Position++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
               
                Console.Clear();
                Console.WriteLine(path);
                Console.SetCursorPosition(X_Position, Y_Position);
                if (key.Key == ConsoleKey.Enter)
                {
                    path = path.Insert(X_Position, Console.ReadLine());
                   
                }
                    if (key.Key == ConsoleKey.F1)
                    {
                        Console.Clear();
                        Console.WriteLine("Введите путь (вместе с названием)");
                        string path2 = Console.ReadLine();
                    File.WriteAllText(path2, path);
                    }
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                
                
                Console.SetCursorPosition(X_Position, Y_Position);
                
            }
        }
     
    }
}
