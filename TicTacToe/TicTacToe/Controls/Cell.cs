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
using TicTacToe.Properties;

namespace TicTacToe.Controls
{
    public partial class Cell : UserControl
    {
        private CellState _State = CellState.Empty;
        /// <summary>
        /// Состояние ячейки. 
        /// </summary>
        public CellState State 
        {
            get => _State;
            set
            {
                if (_State != value && _State == CellState.Empty)
                {
                    _State = value;
                    UpdateImageState();
                    Page.SwitchActivePlayer();
                }
            } 
        }
        private GamePage Page { get; set; }

        public Cell()
        {
            InitializeComponent();
        }

        public void SetGamePageControl(in GamePage page)
        {
            Page = page;
        }

        private void UpdateImageState()
        {
            switch (State)
            {
                case CellState.Cross:
                {
                    CellImage.Image = Resources.Cross;
                    break;
                }
                case CellState.Zero:
                {
                    CellImage.Image = Resources.Zero;
                    break;
                }
            }
        }

        private void CellControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(85, 49, 159);
        }

        private void CellControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(53, 28, 106);
        }

        private void CellControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.State = Page.ActivePlayer.State;
        }
    }
}
