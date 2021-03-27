using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Controls
{
    public partial class PlayerCard : UserControl
    {
        private readonly Color ActiveColor = Color.Yellow;
        private readonly Color BaseColor = Color.FromArgb(98, 60, 186);
        public CellState State { get; set; }
        /// <summary>
        /// Аватар игрока
        /// </summary>
        public Image Avatar
        {
            get => PlayerAvatar.Image;
            set => PlayerAvatar.Image = value;
        }

        /// <summary>
        /// Имя игрока
        /// </summary>
        public string PlayerName
        {
            get => PlayerNameLabel.Text;
            set => PlayerNameLabel.Text = value;
        }

        /// <summary>
        /// Метка игрока. Крестил/нолик
        /// </summary>
        public Image Mark
        {
            get => PlayerMark.Image;
            set => PlayerMark.Image = value;
        }

        private bool _IsActive = false;
        public bool IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                _IsActive = value;
                this.BackColor = value ? ActiveColor : BaseColor;
            }
        }

        public PlayerCard()
        {
            InitializeComponent();
        }
    }
}
