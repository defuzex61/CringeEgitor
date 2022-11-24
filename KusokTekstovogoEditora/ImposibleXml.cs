using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KusokTekstovogoEditora
{
    public class ImposibleXml
    {
        private int Y_Position = 2;
        private int X_Position = 2;
        public void Xml_Edit(string Xpath)
        {
            List<JsonSmth> Pieces= new List<JsonSmth>();
            XmlSerializer xml = new XmlSerializer(typeof(List<JsonSmth>));
            using (FileStream potok = new FileStream(Xpath, FileMode.Open))
            {
                 Pieces= (List<JsonSmth>)xml.Deserialize(potok);
            }
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
                    if (Y_Position == 0) { Pieces[0].Name = Pieces[0].Name + Console.ReadLine(); }
                    else if (Y_Position == 1) { Pieces[0].Spot = Pieces[0].Spot + Console.ReadLine(); }
                    else if (Y_Position == 2) { Pieces[0].Type = Pieces[0].Type + Console.ReadLine(); }

                    else if (Y_Position == 3) { Pieces[1].Name = Pieces[1].Name + Console.ReadLine(); }
                    else if (Y_Position == 4) { Pieces[1].Spot = Pieces[1].Spot + Console.ReadLine(); }
                    else if (Y_Position == 5) { Pieces[1].Type = Pieces[1].Type + Console.ReadLine(); }
                }
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (Y_Position == 0) { Pieces[0].Name = Console.ReadLine(); }
                    else if (Y_Position == 1) { Pieces[0].Spot = Console.ReadLine(); }
                    else if (Y_Position == 2) { Pieces[0].Type = Console.ReadLine(); }

                    else if (Y_Position == 3) { Pieces[1].Name = Console.ReadLine(); }
                    else if (Y_Position == 4) { Pieces[1].Spot = Console.ReadLine(); }
                    else if (Y_Position == 5) { Pieces[1].Type = Console.ReadLine(); }
                }
                if (key.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    Console.WriteLine("Введите путь (вместе с названием)");
                    string path2 = Console.ReadLine();
                    using (FileStream potok = new FileStream(path2, FileMode.OpenOrCreate))
                    {
                        xml.Serialize(potok, Pieces);
                    }
                    
                    
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

