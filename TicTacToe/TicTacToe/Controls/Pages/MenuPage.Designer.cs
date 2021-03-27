
namespace TicTacToe.Controls.Pages
{
    partial class MenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            this.BackgroundPanel = new Guna.UI.WinForms.GunaGradientPanel();
            this.StartButton = new Guna.UI.WinForms.GunaGradientButton();
            this.SettingsButton = new Guna.UI.WinForms.GunaGradientButton();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackgroundPanel.BackgroundImage")));
            this.BackgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundPanel.Controls.Add(this.SettingsButton);
            this.BackgroundPanel.Controls.Add(this.StartButton);
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
            // StartButton
            // 
            this.StartButton.AnimationHoverSpeed = 0.07F;
            this.StartButton.AnimationSpeed = 0.03F;
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BaseColor1 = System.Drawing.Color.Fuchsia;
            this.StartButton.BaseColor2 = System.Drawing.Color.SlateBlue;
            this.StartButton.BorderColor = System.Drawing.Color.Black;
            this.StartButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StartButton.FocusedColor = System.Drawing.Color.Empty;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Image = null;
            this.StartButton.ImageSize = new System.Drawing.Size(20, 20);
            this.StartButton.Location = new System.Drawing.Point(58, 239);
            this.StartButton.Name = "StartButton";
            this.StartButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.StartButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.StartButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.StartButton.OnHoverForeColor = System.Drawing.Color.White;
            this.StartButton.OnHoverImage = null;
            this.StartButton.OnPressedColor = System.Drawing.Color.Black;
            this.StartButton.Radius = 20;
            this.StartButton.Size = new System.Drawing.Size(160, 42);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Игра";
            this.StartButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.AnimationHoverSpeed = 0.07F;
            this.SettingsButton.AnimationSpeed = 0.03F;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(219)))), ((int)(((byte)(120)))));
            this.SettingsButton.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(231)))));
            this.SettingsButton.BorderColor = System.Drawing.Color.Black;
            this.SettingsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsButton.FocusedColor = System.Drawing.Color.Empty;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = null;
            this.SettingsButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SettingsButton.Location = new System.Drawing.Point(58, 302);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.SettingsButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.SettingsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SettingsButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SettingsButton.OnHoverImage = null;
            this.SettingsButton.OnPressedColor = System.Drawing.Color.Black;
            this.SettingsButton.Radius = 20;
            this.SettingsButton.Size = new System.Drawing.Size(160, 42);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackgroundPanel);
            this.Name = "MenuPage";
            this.Size = new System.Drawing.Size(290, 500);
            this.BackgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel BackgroundPanel;
        private Guna.UI.WinForms.GunaGradientButton StartButton;
        private Guna.UI.WinForms.GunaGradientButton SettingsButton;
    }
}
