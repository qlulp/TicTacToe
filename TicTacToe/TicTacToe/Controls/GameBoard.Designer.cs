
namespace TicTacToe.Controls
{
    partial class GameBoard
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
            this.ElipseControl = new Guna.UI.WinForms.GunaElipse(this.components);
            this.cellControl1 = new TicTacToe.Controls.CellControl();
            this.cellControl2 = new TicTacToe.Controls.CellControl();
            this.cellControl3 = new TicTacToe.Controls.CellControl();
            this.cellControl4 = new TicTacToe.Controls.CellControl();
            this.cellControl5 = new TicTacToe.Controls.CellControl();
            this.cellControl6 = new TicTacToe.Controls.CellControl();
            this.cellControl7 = new TicTacToe.Controls.CellControl();
            this.cellControl8 = new TicTacToe.Controls.CellControl();
            this.cellControl9 = new TicTacToe.Controls.CellControl();
            this.SuspendLayout();
            // 
            // ElipseControl
            // 
            this.ElipseControl.Radius = 14;
            this.ElipseControl.TargetControl = this;
            // 
            // cellControl1
            // 
            this.cellControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.cellControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl1.Location = new System.Drawing.Point(13, 13);
            this.cellControl1.Name = "cellControl1";
            this.cellControl1.Padding = new System.Windows.Forms.Padding(10);
            this.cellControl1.Size = new System.Drawing.Size(74, 74);
            this.cellControl1.State = TicTacToe.Controls.CellState.Empty;
            this.cellControl1.TabIndex = 0;
            // 
            // cellControl2
            // 
            this.cellControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.cellControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl2.Location = new System.Drawing.Point(96, 13);
            this.cellControl2.Name = "cellControl2";
            this.cellControl2.Padding = new System.Windows.Forms.Padding(10);
            this.cellControl2.Size = new System.Drawing.Size(74, 74);
            this.cellControl2.State = TicTacToe.Controls.CellState.Empty;
            this.cellControl2.TabIndex = 1;
            // 
            // cellControl3
            // 
            this.cellControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.cellControl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl3.Location = new System.Drawing.Point(179, 13);
            this.cellControl3.Name = "cellControl3";
            this.cellControl3.Padding = new System.Windows.Forms.Padding(10);
            this.cellControl3.Size = new System.Drawing.Size(74, 74);
            this.cellControl3.State = TicTacToe.Controls.CellState.Empty;
            this.cellControl3.TabIndex = 2;
            // 
            // cellControl4
            // 
            this.cellControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.cellControl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl4.Location = new System.Drawing.Point(13, 96);
            this.cellControl4.Name = "cellControl4";
            this.cellControl4.Padding = new System.Windows.Forms.Padding(10);
            this.cellControl4.Size = new System.Drawing.Size(74, 74);
            this.cellControl4.State = TicTacToe.Controls.CellState.Empty;
            this.cellControl4.TabIndex = 3;
            // 
            // cellControl5
            // 
            this.cellControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.cellControl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl5.Location = new System.Drawing.Point(96, 96);
            this.cellControl5.Name = "cellControl5";
            this.cellControl5.Padding = new System.Windows.Forms.Padding(10);
            this.cellControl5.Size = new System.Drawing.Size(74, 74);
            this.cellControl5.State = TicTacToe.Controls.CellState.Empty;
            this.cellControl5.TabIndex = 4;
            // 
            // cellControl6
            // 
            this.cellControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.cellControl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl6.Location = new System.Drawing.Point(179, 96);
            this.cellControl6.Name = "cellControl6";
            this.cellControl6.Padding = new System.Windows.Forms.Padding(10);
            this.cellControl6.Size = new System.Drawing.Size(74, 74);
            this.cellControl6.State = TicTacToe.Controls.CellState.Empty;
            this.cellControl6.TabIndex = 5;
            // 
            // cellControl7
            // 
            this.cellControl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.cellControl7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl7.Location = new System.Drawing.Point(13, 179);
            this.cellControl7.Name = "cellControl7";
            this.cellControl7.Padding = new System.Windows.Forms.Padding(10);
            this.cellControl7.Size = new System.Drawing.Size(74, 74);
            this.cellControl7.State = TicTacToe.Controls.CellState.Empty;
            this.cellControl7.TabIndex = 6;
            // 
            // cellControl8
            // 
            this.cellControl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.cellControl8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl8.Location = new System.Drawing.Point(96, 179);
            this.cellControl8.Name = "cellControl8";
            this.cellControl8.Padding = new System.Windows.Forms.Padding(10);
            this.cellControl8.Size = new System.Drawing.Size(74, 74);
            this.cellControl8.State = TicTacToe.Controls.CellState.Empty;
            this.cellControl8.TabIndex = 7;
            // 
            // cellControl9
            // 
            this.cellControl9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.cellControl9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl9.Location = new System.Drawing.Point(179, 179);
            this.cellControl9.Name = "cellControl9";
            this.cellControl9.Padding = new System.Windows.Forms.Padding(10);
            this.cellControl9.Size = new System.Drawing.Size(74, 74);
            this.cellControl9.State = TicTacToe.Controls.CellState.Empty;
            this.cellControl9.TabIndex = 8;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(60)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.cellControl9);
            this.Controls.Add(this.cellControl8);
            this.Controls.Add(this.cellControl7);
            this.Controls.Add(this.cellControl6);
            this.Controls.Add(this.cellControl5);
            this.Controls.Add(this.cellControl4);
            this.Controls.Add(this.cellControl3);
            this.Controls.Add(this.cellControl2);
            this.Controls.Add(this.cellControl1);
            this.Name = "GameBoard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(266, 266);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse ElipseControl;
        private CellControl cellControl9;
        private CellControl cellControl8;
        private CellControl cellControl7;
        private CellControl cellControl6;
        private CellControl cellControl5;
        private CellControl cellControl4;
        private CellControl cellControl3;
        private CellControl cellControl2;
        private CellControl cellControl1;
    }
}
