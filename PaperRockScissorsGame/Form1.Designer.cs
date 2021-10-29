namespace PaperRockScissorsGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ComPaperButton = new System.Windows.Forms.Button();
            this.ComRockButton = new System.Windows.Forms.Button();
            this.ComScissorsButton = new System.Windows.Forms.Button();
            this.HintLabel = new System.Windows.Forms.Label();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.BackgroundImage = global::PaperRockScissorsGame.Properties.Resources.scissors_01;
            this.ScissorsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScissorsButton.Location = new System.Drawing.Point(24, 22);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(80, 80);
            this.ScissorsButton.TabIndex = 0;
            this.ScissorsButton.Tag = "1";
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // RockButton
            // 
            this.RockButton.BackgroundImage = global::PaperRockScissorsGame.Properties.Resources.rock_01;
            this.RockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RockButton.Location = new System.Drawing.Point(24, 119);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(80, 80);
            this.RockButton.TabIndex = 1;
            this.RockButton.Tag = "2";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.BackgroundImage = global::PaperRockScissorsGame.Properties.Resources.paper_01;
            this.PaperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PaperButton.Location = new System.Drawing.Point(24, 217);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(80, 80);
            this.PaperButton.TabIndex = 2;
            this.PaperButton.Tag = "3";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ComPaperButton
            // 
            this.ComPaperButton.BackgroundImage = global::PaperRockScissorsGame.Properties.Resources.paper_02;
            this.ComPaperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComPaperButton.Location = new System.Drawing.Point(268, 217);
            this.ComPaperButton.Name = "ComPaperButton";
            this.ComPaperButton.Size = new System.Drawing.Size(80, 80);
            this.ComPaperButton.TabIndex = 5;
            this.ComPaperButton.Tag = "3";
            this.ComPaperButton.UseVisualStyleBackColor = true;
            // 
            // ComRockButton
            // 
            this.ComRockButton.BackgroundImage = global::PaperRockScissorsGame.Properties.Resources.rock_02;
            this.ComRockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComRockButton.Location = new System.Drawing.Point(268, 119);
            this.ComRockButton.Name = "ComRockButton";
            this.ComRockButton.Size = new System.Drawing.Size(80, 80);
            this.ComRockButton.TabIndex = 4;
            this.ComRockButton.Tag = "2";
            this.ComRockButton.UseVisualStyleBackColor = true;
            // 
            // ComScissorsButton
            // 
            this.ComScissorsButton.BackgroundImage = global::PaperRockScissorsGame.Properties.Resources.scissors_02;
            this.ComScissorsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComScissorsButton.Location = new System.Drawing.Point(268, 22);
            this.ComScissorsButton.Name = "ComScissorsButton";
            this.ComScissorsButton.Size = new System.Drawing.Size(80, 80);
            this.ComScissorsButton.TabIndex = 3;
            this.ComScissorsButton.Tag = "1";
            this.ComScissorsButton.UseVisualStyleBackColor = true;
            // 
            // HintLabel
            // 
            this.HintLabel.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HintLabel.ForeColor = System.Drawing.Color.Red;
            this.HintLabel.Location = new System.Drawing.Point(134, 139);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(109, 34);
            this.HintLabel.TabIndex = 6;
            this.HintLabel.Text = "猜拳結果";
            this.HintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HintLabel.Visible = false;
            // 
            // ReplayButton
            // 
            this.ReplayButton.Location = new System.Drawing.Point(150, 176);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(75, 23);
            this.ReplayButton.TabIndex = 7;
            this.ReplayButton.Text = "再玩一次";
            this.ReplayButton.UseVisualStyleBackColor = true;
            this.ReplayButton.Visible = false;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // EasyRadioButton
            // 
            this.EasyRadioButton.AutoSize = true;
            this.EasyRadioButton.Location = new System.Drawing.Point(19, 328);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(47, 16);
            this.EasyRadioButton.TabIndex = 8;
            this.EasyRadioButton.Text = "簡單";
            this.EasyRadioButton.UseVisualStyleBackColor = true;
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.Checked = true;
            this.NormalRadioButton.Location = new System.Drawing.Point(150, 328);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(47, 16);
            this.NormalRadioButton.TabIndex = 9;
            this.NormalRadioButton.TabStop = true;
            this.NormalRadioButton.Text = "一般";
            this.NormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // HardRadioButton
            // 
            this.HardRadioButton.AutoSize = true;
            this.HardRadioButton.Location = new System.Drawing.Point(263, 328);
            this.HardRadioButton.Name = "HardRadioButton";
            this.HardRadioButton.Size = new System.Drawing.Size(47, 16);
            this.HardRadioButton.TabIndex = 10;
            this.HardRadioButton.Text = "困難";
            this.HardRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 377);
            this.Controls.Add(this.HardRadioButton);
            this.Controls.Add(this.NormalRadioButton);
            this.Controls.Add(this.EasyRadioButton);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.ComPaperButton);
            this.Controls.Add(this.ComRockButton);
            this.Controls.Add(this.ComScissorsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.ScissorsButton);
            this.Name = "Form1";
            this.Text = "剪刀石頭布範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ComPaperButton;
        private System.Windows.Forms.Button ComRockButton;
        private System.Windows.Forms.Button ComScissorsButton;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.RadioButton NormalRadioButton;
        private System.Windows.Forms.RadioButton HardRadioButton;
    }
}

