using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Controls;

namespace TicTacToe.Classes
{
    // Не доделал
    class GameManager
    {
        public static void CheckBoard(in CellState[,] arr)
        {
            DiagonalCheck(in arr);
        }

        private void HorizontalCheck(in CellState[,] arr)
        {
          

        }

        private void VerticalCheck()
        {

        }

        private static void DiagonalCheck(in CellState[,] arr)
        {
            bool isFullLine = true;
            if (!arr[0, 0].Equals(CellState.Empty))
            {
                // От 0:0 до 3:3
                CellState expectedState = arr[0, 0];
                for (int i = 1; i < 3; i++)
                    if (arr[i, i] != expectedState)
                        isFullLine = false;
                if (isFullLine)
                    MessageBox.Show("Есть контакт");
            }
        }

    }
}
