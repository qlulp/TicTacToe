using System;
using System.Windows.Forms;
using TicTacToe.Controls;

namespace TicTacToe.Classes
{
    class GameManager
    {
        CellState[,] BoardArray;

        public void DetermineWinnder(CellState[,] arr)
        {
            BoardArray = arr;
            if (IsDiagonalLineFullOf(CellState.Cross) || IsDiagonalLineFullOf(CellState.Zero))
                MessageBox.Show("Есть контакт!");
            if (IsHorizontalLineFullOf(CellState.Cross) || IsHorizontalLineFullOf(CellState.Zero))
                MessageBox.Show("Есть контакт! горизонталь");
            if (IsVerticalLineFullOf(CellState.Cross) || IsVerticalLineFullOf(CellState.Zero))
                MessageBox.Show("Есть контакт! вертикаль");
        }

        /// <summary>
        /// Проверка по диагоналям
        /// </summary>
        /// <param name="cellState">ожидаемое состояние всех ячеек строки</param>
        /// <returns></returns>
        private bool IsDiagonalLineFullOf(CellState cellState)
        {
            if (cellState.Equals(CellState.Empty))
                throw new ArgumentException("Недопустимое значение cellState!");

            int countOfCells;

            // Проверка с [0,0] до [2:2]
            countOfCells = 0;
            for (int i = 0; i < 3; i++)
            {
                if (BoardArray[i, i] == cellState)
                    countOfCells++;
            }
            if (countOfCells == 3)
                return true;

            // Проверка с [0,2] до [2:0]
            countOfCells = 0;
            int j = 2;
            for (int i = 0; i < 3; i++)
            {
                if (BoardArray[i, j] == cellState)
                    countOfCells++;
                j--;
            }
            if (countOfCells == 3)
                return true;

            return false;
        }

        /// <summary>
        /// Проверка по горизонтали
        /// </summary>
        /// <param name="cellState">ожидаемое состояние всех ячеек строки</param>
        /// <returns></returns>
        private bool IsHorizontalLineFullOf(CellState cellState)
        {
            if (cellState.Equals(CellState.Empty))
                throw new ArgumentException("Недопустимое значение cellState!");

            for (int i = 0; i < 3; i++)
            {
                int countOfCells = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (BoardArray[i, j] == cellState)
                        countOfCells++;
                }
                if (countOfCells == 3)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Проверка по вертикали
        /// </summary>
        /// <param name="cellState">ожидаемое состояние всех ячеек строки</param>
        /// <returns></returns>
        private bool IsVerticalLineFullOf(CellState cellState)
        {
            if (cellState.Equals(CellState.Empty))
                throw new ArgumentException("Недопустимое значение cellState!");

            for (int i = 0; i < 3; i++)
            {
                int countOfCells = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (BoardArray[j, i] == cellState)
                        countOfCells++;
                }
                if (countOfCells == 3)
                    return true;
            }
            return false;
        }

    }
}
