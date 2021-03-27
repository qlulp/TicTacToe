
namespace TicTacToe.Controls
{
    partial class PlayerCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerCard));
            this.ElipseControl = new Guna.UI.WinForms.GunaElipse(this.components);
            this.CardBackgroundPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.PlayerMark = new System.Windows.Forms.PictureBox();
            this.PlayerNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.PlayerAvatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.CardBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseControl
            // 
            this.ElipseControl.Radius = 10;
            this.ElipseControl.TargetControl = this;
            // 
            // CardBackgroundPanel
            // 
            this.CardBackgroundPanel.BackColor = System.Drawing.Color.Transparent;
            this.CardBackgroundPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.CardBackgroundPanel.Controls.Add(this.PlayerMark);
            this.CardBackgroundPanel.Controls.Add(this.PlayerNameLabel);
            this.CardBackgroundPanel.Controls.Add(this.PlayerAvatar);
            this.CardBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardBackgroundPanel.Location = new System.Drawing.Point(4, 4);
            this.CardBackgroundPanel.Name = "CardBackgroundPanel";
            this.CardBackgroundPanel.Radius = 10;
            this.CardBackgroundPanel.Size = new System.Drawing.Size(100, 134);
            this.CardBackgroundPanel.TabIndex = 1;
            // 
            // PlayerMark
            // 
            this.PlayerMark.Location = new System.Drawing.Point(32, 89);
            this.PlayerMark.Name = "PlayerMark";
            this.PlayerMark.Size = new System.Drawing.Size(36, 36);
            this.PlayerMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerMark.TabIndex = 2;
            this.PlayerMark.TabStop = false;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerNameLabel.Location = new System.Drawing.Point(0, 63);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(100, 23);
            this.PlayerNameLabel.TabIndex = 1;
            this.PlayerNameLabel.Text = "Вы";
            this.PlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerNameLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // PlayerAvatar
            // 
            this.PlayerAvatar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(60)))), ((int)(((byte)(186)))));
            this.PlayerAvatar.Image = ((System.Drawing.Image)(resources.GetObject("PlayerAvatar.Image")));
            this.PlayerAvatar.Location = new System.Drawing.Point(26, 14);
            this.PlayerAvatar.Name = "PlayerAvatar";
            this.PlayerAvatar.Size = new System.Drawing.Size(46, 46);
            this.PlayerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerAvatar.TabIndex = 0;
            this.PlayerAvatar.TabStop = false;
            this.PlayerAvatar.UseTransfarantBackground = false;
            // 
            // PlayerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(60)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.CardBackgroundPanel);
            this.Name = "PlayerCard";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(108, 142);
            this.CardBackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse ElipseControl;
        private Guna.UI.WinForms.GunaElipsePanel CardBackgroundPanel;
        private System.Windows.Forms.PictureBox PlayerMark;
        private Guna.UI.WinForms.GunaLabel PlayerNameLabel;
        private Guna.UI.WinForms.GunaCirclePictureBox PlayerAvatar;
    }
}
