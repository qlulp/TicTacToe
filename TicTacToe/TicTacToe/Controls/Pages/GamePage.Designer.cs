
namespace TicTacToe.Controls.Pages
{
    partial class GamePage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.DragForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.BackgroundPanel = new Guna.UI.WinForms.GunaGradientPanel();
            this.ExitButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ScoreLabel = new Guna.UI.WinForms.GunaLabel();
            this.Board = new TicTacToe.Controls.GameBoard();
            this.RobotPlayerCard = new TicTacToe.Controls.PlayerCard();
            this.UserPlayerCard = new TicTacToe.Controls.PlayerCard();
            this.Cell7 = new TicTacToe.Controls.CellControl();
            this.Cell8 = new TicTacToe.Controls.CellControl();
            this.Cell9 = new TicTacToe.Controls.CellControl();
            this.Cell4 = new TicTacToe.Controls.CellControl();
            this.Cell3 = new TicTacToe.Controls.CellControl();
            this.Cell2 = new TicTacToe.Controls.CellControl();
            this.Cell6 = new TicTacToe.Controls.CellControl();
            this.Cell5 = new TicTacToe.Controls.CellControl();
            this.Cell1 = new TicTacToe.Controls.CellControl();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragForm
            // 
            this.DragForm.TargetControl = this.BackgroundPanel;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackgroundPanel.BackgroundImage")));
            this.BackgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundPanel.Controls.Add(this.Board);
            this.BackgroundPanel.Controls.Add(this.RobotPlayerCard);
            this.BackgroundPanel.Controls.Add(this.UserPlayerCard);
            this.BackgroundPanel.Controls.Add(this.ExitButton);
            this.BackgroundPanel.Controls.Add(this.ScoreLabel);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(44)))), ((int)(((byte)(173)))));
            this.BackgroundPanel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(6)))), ((int)(((byte)(76)))));
            this.BackgroundPanel.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(13)))), ((int)(((byte)(90)))));
            this.BackgroundPanel.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(6)))), ((int)(((byte)(79)))));
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(290, 500);
            this.BackgroundPanel.TabIndex = 1;
            this.BackgroundPanel.Text = "gunaGradientPanel1";
            // 
            // ExitButton
            // 
            this.ExitButton.AnimationHoverSpeed = 0.07F;
            this.ExitButton.AnimationSpeed = 0.03F;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(60)))), ((int)(((byte)(186)))));
            this.ExitButton.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ExitButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ExitButton.CheckedForeColor = System.Drawing.Color.White;
            this.ExitButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.CheckedImage")));
            this.ExitButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.FocusedColor = System.Drawing.Color.Empty;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = global::TicTacToe.Properties.Resources.Cross;
            this.ExitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ExitButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ExitButton.Location = new System.Drawing.Point(242, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitButton.OnHoverImage = null;
            this.ExitButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ExitButton.OnPressedColor = System.Drawing.Color.Black;
            this.ExitButton.Radius = 16;
            this.ExitButton.Size = new System.Drawing.Size(36, 34);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreLabel.Location = new System.Drawing.Point(21, 23);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(141, 23);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Очки:";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScoreLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(60)))), ((int)(((byte)(186)))));
            this.Board.Location = new System.Drawing.Point(12, 221);
            this.Board.Name = "Board";
            this.Board.Padding = new System.Windows.Forms.Padding(10);
            this.Board.Size = new System.Drawing.Size(266, 266);
            this.Board.TabIndex = 9;
            // 
            // RobotPlayerCard
            // 
            this.RobotPlayerCard.Avatar = ((System.Drawing.Image)(resources.GetObject("RobotPlayerCard.Avatar")));
            this.RobotPlayerCard.BackColor = System.Drawing.Color.Yellow;
            this.RobotPlayerCard.IsActive = true;
            this.RobotPlayerCard.Location = new System.Drawing.Point(157, 64);
            this.RobotPlayerCard.Mark = global::TicTacToe.Properties.Resources.Cross;
            this.RobotPlayerCard.Name = "RobotPlayerCard";
            this.RobotPlayerCard.Padding = new System.Windows.Forms.Padding(4);
            this.RobotPlayerCard.PlayerName = "Робот";
            this.RobotPlayerCard.Size = new System.Drawing.Size(108, 142);
            this.RobotPlayerCard.State = TicTacToe.Controls.CellState.Cross;
            this.RobotPlayerCard.TabIndex = 8;
            // 
            // UserPlayerCard
            // 
            this.UserPlayerCard.Avatar = ((System.Drawing.Image)(resources.GetObject("UserPlayerCard.Avatar")));
            this.UserPlayerCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(60)))), ((int)(((byte)(186)))));
            this.UserPlayerCard.IsActive = false;
            this.UserPlayerCard.Location = new System.Drawing.Point(25, 64);
            this.UserPlayerCard.Mark = ((System.Drawing.Image)(resources.GetObject("UserPlayerCard.Mark")));
            this.UserPlayerCard.Name = "UserPlayerCard";
            this.UserPlayerCard.Padding = new System.Windows.Forms.Padding(4);
            this.UserPlayerCard.PlayerName = "Вы";
            this.UserPlayerCard.Size = new System.Drawing.Size(108, 142);
            this.UserPlayerCard.State = TicTacToe.Controls.CellState.Zero;
            this.UserPlayerCard.TabIndex = 7;
            // 
            // Cell7
            // 
            this.Cell7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Cell7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell7.Location = new System.Drawing.Point(13, 179);
            this.Cell7.Name = "Cell7";
            this.Cell7.Padding = new System.Windows.Forms.Padding(10);
            this.Cell7.Size = new System.Drawing.Size(74, 74);
            this.Cell7.State = TicTacToe.Controls.CellState.Empty;
            this.Cell7.TabIndex = 8;
            // 
            // Cell8
            // 
            this.Cell8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Cell8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell8.Location = new System.Drawing.Point(96, 179);
            this.Cell8.Name = "Cell8";
            this.Cell8.Padding = new System.Windows.Forms.Padding(10);
            this.Cell8.Size = new System.Drawing.Size(74, 74);
            this.Cell8.State = TicTacToe.Controls.CellState.Empty;
            this.Cell8.TabIndex = 7;
            // 
            // Cell9
            // 
            this.Cell9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Cell9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell9.Location = new System.Drawing.Point(179, 179);
            this.Cell9.Name = "Cell9";
            this.Cell9.Padding = new System.Windows.Forms.Padding(10);
            this.Cell9.Size = new System.Drawing.Size(74, 74);
            this.Cell9.State = TicTacToe.Controls.CellState.Empty;
            this.Cell9.TabIndex = 6;
            // 
            // Cell4
            // 
            this.Cell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Cell4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell4.Location = new System.Drawing.Point(13, 96);
            this.Cell4.Name = "Cell4";
            this.Cell4.Padding = new System.Windows.Forms.Padding(10);
            this.Cell4.Size = new System.Drawing.Size(74, 74);
            this.Cell4.State = TicTacToe.Controls.CellState.Empty;
            this.Cell4.TabIndex = 5;
            // 
            // Cell3
            // 
            this.Cell3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Cell3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell3.Location = new System.Drawing.Point(179, 13);
            this.Cell3.Name = "Cell3";
            this.Cell3.Padding = new System.Windows.Forms.Padding(10);
            this.Cell3.Size = new System.Drawing.Size(74, 74);
            this.Cell3.State = TicTacToe.Controls.CellState.Empty;
            this.Cell3.TabIndex = 4;
            // 
            // Cell2
            // 
            this.Cell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Cell2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell2.Location = new System.Drawing.Point(96, 13);
            this.Cell2.Name = "Cell2";
            this.Cell2.Padding = new System.Windows.Forms.Padding(10);
            this.Cell2.Size = new System.Drawing.Size(74, 74);
            this.Cell2.State = TicTacToe.Controls.CellState.Empty;
            this.Cell2.TabIndex = 3;
            // 
            // Cell6
            // 
            this.Cell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Cell6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell6.Location = new System.Drawing.Point(179, 96);
            this.Cell6.Name = "Cell6";
            this.Cell6.Padding = new System.Windows.Forms.Padding(10);
            this.Cell6.Size = new System.Drawing.Size(74, 74);
            this.Cell6.State = TicTacToe.Controls.CellState.Empty;
            this.Cell6.TabIndex = 2;
            // 
            // Cell5
            // 
            this.Cell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Cell5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell5.Location = new System.Drawing.Point(96, 96);
            this.Cell5.Name = "Cell5";
            this.Cell5.Padding = new System.Windows.Forms.Padding(10);
            this.Cell5.Size = new System.Drawing.Size(74, 74);
            this.Cell5.State = TicTacToe.Controls.CellState.Empty;
            this.Cell5.TabIndex = 1;
            // 
            // Cell1
            // 
            this.Cell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Cell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cell1.Location = new System.Drawing.Point(13, 13);
            this.Cell1.Name = "Cell1";
            this.Cell1.Padding = new System.Windows.Forms.Padding(10);
            this.Cell1.Size = new System.Drawing.Size(74, 74);
            this.Cell1.State = TicTacToe.Controls.CellState.Empty;
            this.Cell1.TabIndex = 0;
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackgroundPanel);
            this.Name = "GamePage";
            this.Size = new System.Drawing.Size(290, 500);
            this.BackgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl DragForm;
        private Guna.UI.WinForms.GunaGradientPanel BackgroundPanel;
        private Guna.UI.WinForms.GunaAdvenceButton ExitButton;
        private Guna.UI.WinForms.GunaLabel ScoreLabel;
        private CellControl Cell7;
        private CellControl Cell8;
        private CellControl Cell9;
        private CellControl Cell4;
        private CellControl Cell3;
        private CellControl Cell2;
        private CellControl Cell6;
        private CellControl Cell5;
        private CellControl Cell1;
        private PlayerCard RobotPlayerCard;
        private PlayerCard UserPlayerCard;
        private GameBoard Board;
    }
}
