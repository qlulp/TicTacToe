using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Controls;
using TicTacToe.Controls.Pages;


namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private readonly GamePage Game;
        public MainForm()
        {
            InitializeComponent();

            Game = new GamePage();
            this.Controls.Add(Game);
        }
    }
}
