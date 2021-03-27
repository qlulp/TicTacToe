
namespace TicTacToe.Controls
{
    partial class CellControl
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
            this.EllipseRadius = new Guna.UI.WinForms.GunaElipse(this.components);
            this.CellImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CellImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EllipseRadius
            // 
            this.EllipseRadius.Radius = 10;
            this.EllipseRadius.TargetControl = this;
            // 
            // CellImage
            // 
            this.CellImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellImage.Location = new System.Drawing.Point(10, 10);
            this.CellImage.Name = "CellImage";
            this.CellImage.Size = new System.Drawing.Size(54, 54);
            this.CellImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CellImage.TabIndex = 0;
            this.CellImage.TabStop = false;
            this.CellImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CellControl_MouseDown);
            this.CellImage.MouseEnter += new System.EventHandler(this.CellControl_MouseEnter);
            this.CellImage.MouseLeave += new System.EventHandler(this.CellControl_MouseLeave);
            // 
            // CellControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.CellImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CellControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(74, 74);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CellControl_MouseDown);
            this.MouseEnter += new System.EventHandler(this.CellControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CellControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.CellImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaElipse EllipseRadius;
        private System.Windows.Forms.PictureBox CellImage;
    }
}
