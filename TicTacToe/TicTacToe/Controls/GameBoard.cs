using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Controls.Pages;

namespace TicTacToe.Controls
{
    /// <summary>
    /// Empty - пустая ячейка
    /// Zero - поставлен нолик
    /// Cross - поставлен крестик
    /// </summary>
    public enum CellState
    {
        Empty,
        Cross,
        Zero
    };

    public partial class GameBoard : UserControl
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        public void SetGamePageControl(in GamePage page)
        {
            foreach (Cell cell in Controls.OfType<Cell>())
            {
                cell.SetGamePageControl(page);
            }
        }

        public CellState[,] GetArray()
        {
            /* Альтернативный вариант (не проверенный)
            CellState[,] result = new CellState[3, 3];
            int i = 0, j = 0;
            foreach (CellControl cell in this.Controls.OfType<CellControl>())
            {
                if (i == 2)
                {
                    i = 0;
                    j++;
                }
                result[i, j] = cell.State;
                i++;
            }
            return result;
            */

            return new CellState[3, 3]
            {
                { cellControl1.State,  cellControl2.State, cellControl3.State},
                { cellControl4.State,  cellControl5.State, cellControl6.State},
                { cellControl7.State,  cellControl8.State, cellControl9.State}
            };
        }
    }
}
