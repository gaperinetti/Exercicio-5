using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = new StreamReader("produtos_estoque.txt");
            //TextReader tr = new StreamReader(@"C:\Users\...\Desktop\Test.txt"); 
            String linha = reader.ReadLine();
            while (linha != null)
            {

                int pos = linha.ToString().IndexOf('|');
                // int end = linha.ToString().Length;
            Console.WriteLine(linha.ToString().Remove(0,pos+1));
              
  

                linha = reader.ReadLine();

            }

            Console.ReadKey();
        }
    }
}
