using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_it_guru_lesson
{
   
    class Field
    {
        private Cell[,] gameField = new Cell [20,10];
        public void buldField()
        {
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                for (int column = 0; column < gameField.GetLength(1); column++)
                {
                    gameField[row, column] = new Cell();
                }
            }
        }
        public void Draw()
        {

            Console.Clear();
            Console.WriteLine("============");
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                Console.Write("|");
                for (int column = 0; column < gameField.GetLength(1); column++)
                {
                    gameField[row, column].Draw();
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("============");

            
            
        }


        public void SetCell(int x, int y)
        {
            gameField[x, y].SetCell();

        }
        public void ClearRow()
        {
            bool emptyFlag;
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                emptyFlag = true;
                for (int column = 0; column < gameField.GetLength(1); column++)
                {
                    emptyFlag = emptyFlag && gameField[row, column].IsEmpty();
                }

                if (emptyFlag)
                {
                    DeleteRow(row);
                    ShiftRow(row);
                    this.Draw();
                }

            }
        }

        public void DeleteRow(int row)
        {
            for (int column = 0; column < gameField.GetLength(1); column++)
            {
                gameField[row, column].ClearCell();
            }
            
            
        }
        public void ShiftRow(int row)
        {
            //Cell buf;
            for (int i = row; i > 0; i--)
            {
                for (int column = 0; column < gameField.GetLength(1); column++)
                {
                    //buf = gameField[i, column];
                    gameField[i, column] = gameField[i - 1, column];
                    //gameField[i - 1, column] = buf;
                }
            }
        }
    }
}
