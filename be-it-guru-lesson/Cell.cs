using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_it_guru_lesson
{
    
    class Cell
    {
        private char cell;
        public void Cells()
        {
            cell = ' ';
        }
        public void Draw()
        {
            Console.Write(cell);
        }

        public void SetCell()
        {
            cell = '*';
        }

        public void ClearCell()
        {
            cell = ' ';
        }
        public bool IsEmpty()
        {
            if (cell == ' ')
            {
                return false;
            }
            else
                return true;
        }


    }
}
