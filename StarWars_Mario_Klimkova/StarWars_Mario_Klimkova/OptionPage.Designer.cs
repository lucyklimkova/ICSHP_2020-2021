namespace StarWars_Mario_Klimkova
{
    partial class OptionPage
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
            this.optionMenu = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Button();
            this.changeSkin = new System.Windows.Forms.Button();
            this.changeBacground = new System.Windows.Forms.Button();
            this.optionMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionMenu
            // 
            this.optionMenu.BackColor = System.Drawing.Color.Transparent;
            this.optionMenu.BackgroundImage = global::StarWars_Mario_Klimkova.Properties.Resources.option_menu;
            this.optionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionMenu.Controls.Add(this.close);
            this.optionMenu.Controls.Add(this.information);
            this.optionMenu.Controls.Add(this.changeSkin);
            this.optionMenu.Controls.Add(this.changeBacground);
            this.optionMenu.Location = new System.Drawing.Point(35, 40);
            this.optionMenu.Name = "optionMenu";
            this.optionMenu.Size = new System.Drawing.Size(314, 326);
            this.optionMenu.TabIndex = 0;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(70, 248);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(166, 33);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // information
            // 
            this.information.Location = new System.Drawing.Point(70, 193);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(166, 33);
            this.information.TabIndex = 0;
            this.information.Text = "Information";
            this.information.UseVisualStyleBackColor = true;
            this.information.Click += new System.EventHandler(this.Information_Click);
            // 
            // changeSkin
            // 
            this.changeSkin.Location = new System.Drawing.Point(70, 138);
            this.changeSkin.Name = "changeSkin";
            this.changeSkin.Size = new System.Drawing.Size(166, 33);
            this.changeSkin.TabIndex = 0;
            this.changeSkin.Text = "Change player skin";
            this.changeSkin.UseVisualStyleBackColor = true;
            this.changeSkin.Click += new System.EventHandler(this.ChangeSkin_Click);
            // 
            // changeBacground
            // 
            this.changeBacground.Location = new System.Drawing.Point(70, 84);
            this.changeBacground.Name = "changeBacground";
            this.changeBacground.Size = new System.Drawing.Size(166, 33);
            this.changeBacground.TabIndex = 0;
            this.changeBacground.Text = "Change Background";
            this.changeBacground.UseVisualStyleBackColor = true;
            this.changeBacground.Click += new System.EventHandler(this.ChangeBacground_Click);
            // 
            // OptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.optionMenu);
            this.Name = "OptionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.optionMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionMenu;
        private System.Windows.Forms.Button information;
        private System.Windows.Forms.Button changeSkin;
        private System.Windows.Forms.Button changeBacground;
        private System.Windows.Forms.Button close;
    }
}