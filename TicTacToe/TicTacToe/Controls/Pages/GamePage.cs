using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Classes;

namespace TicTacToe.Controls.Pages
{
    public partial class GamePage : UserControl
    {
        GameManager Manager;
        private PlayerCard _ActivePlayer;
        public PlayerCard ActivePlayer
        {
            get => _ActivePlayer;
            set
            {
                if (_ActivePlayer != null)
                {
                    _ActivePlayer.IsActive = false;
                }
                _ActivePlayer = value;
                _ActivePlayer.IsActive = true;
            }
        }

        public void SwitchActivePlayer()
        {
            if (ActivePlayer.Equals(UserPlayerCard))
                ActivePlayer = RobotPlayerCard;
            else
                ActivePlayer = UserPlayerCard;

            Manager.DetermineWinnder(Board.GetArray());
        }

        public GamePage()
        {
            InitializeComponent();

            Manager = new GameManager();
            ActivePlayer = UserPlayerCard;
            Board.SetGamePageControl(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
