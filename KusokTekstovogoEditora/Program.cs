using Newtonsoft.Json;
using System;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace KusokTekstovogoEditora
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расположение файла (Esc - выход, Backspace - полностью изменить строку, Enter - добавить):");
            string Text_Read = Console.ReadLine();
            string Text ;
            
            Text = File.ReadAllText(Text_Read);
            if (Text_Read.EndsWith("n"))
            {
               ImposibleJson jbrony = new ImposibleJson();
                jbrony.Json_Edit(Text);

            }
            else if (Text_Read.EndsWith("t"))
            {
                Read_txt read_txt = new Read_txt();
                read_txt.Text_Edit(Text);
                
            }
            else if (Text_Read.EndsWith("l"))
            {
               ImposibleXml imposibleXml = new ImposibleXml();
                imposibleXml.Xml_Edit(Text_Read);
            }
            

        }
    }
}