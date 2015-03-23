using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_it_guru_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Field f = new Field();
            f.buldField();
            f.Draw();
            while (true)
            {
                for (int j = 0; j < 10; j++)
                {
                    f.SetCell(19, j);
                    f.Draw();

                    Console.ReadLine();
                }
                f.ClearRow();
            }
          
           
            Console.ReadLine();
        }
    }
}
