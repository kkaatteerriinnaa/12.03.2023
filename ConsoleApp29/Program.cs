using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApp29
{
    class Poetry
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string FIO { set; get; }
        public string Text { set; get; }
        public string Subject { set; get; }

        public Poetry(string Name, int Age, string fio, string text, string subject)
        {
            this.Name = Name;
            this.Age = Age;
            this.FIO = fio;
            this.Text = text;
            this.Subject = subject;
        }
    }
    class Add
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string FIO { set; get; }
        public string Text { set; get; }
        public string Subject { set; get; }

        public Add(string Name, int Age, string fio, string text, string subject)
        {
            this.Name = Name;
            this.Age = Age;
            this.FIO = fio;
            this.Text = text;
            this.Subject = subject;
        }
    }
    class Change
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string FIO { set; get; }
        public string Text { set; get; }
        public string Subject { set; get; }

        public Change(string Name, int Age, string fio, string text, string subject)
        {
            this.Name = Name;
            this.Age = Age;
            this.FIO = fio;
            this.Text = text;
            this.Subject = subject;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream file = new FileStream("poetry.txt", FileMode.Open);
                StreamReader sr = new StreamReader(file, Encoding.UTF8);
                String line;

                while((line=sr.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }

                StreamWriter sw = new StreamWriter("poetry.txt", true);
                do
                {
                   
                    line = Console.ReadLine();
                    
                    sw.WriteLine(line);
                } while (line != "");

                sw.Close();
                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
