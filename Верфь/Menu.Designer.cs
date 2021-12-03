namespace Верфь
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.priceButton = new System.Windows.Forms.Button();
            this.manufactureButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(125, 140);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 32);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(125, 104);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(123, 30);
            this.priceButton.TabIndex = 13;
            this.priceButton.Text = "Цены";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // manufactureButton
            // 
            this.manufactureButton.Location = new System.Drawing.Point(125, 66);
            this.manufactureButton.Name = "manufactureButton";
            this.manufactureButton.Size = new System.Drawing.Size(123, 32);
            this.manufactureButton.TabIndex = 12;
            this.manufactureButton.Text = "Производство";
            this.manufactureButton.UseVisualStyleBackColor = true;
            this.manufactureButton.Click += new System.EventHandler(this.manufactureButton_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(125, 27);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(123, 33);
            this.userButton.TabIndex = 11;
            this.userButton.Text = "Пользователи";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Меню администратора";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 215);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.manufactureButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Меню администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Button manufactureButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Label label2;
    }
}