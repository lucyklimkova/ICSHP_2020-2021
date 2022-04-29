namespace StarWars_Mario_Klimkova
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.menu = new System.Windows.Forms.Panel();
            this.exitBttn = new System.Windows.Forms.PictureBox();
            this.optionBttn = new System.Windows.Forms.PictureBox();
            this.startBttn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.BackgroundImage = global::StarWars_Mario_Klimkova.Properties.Resources.menu;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.exitBttn);
            this.menu.Controls.Add(this.optionBttn);
            this.menu.Controls.Add(this.startBttn);
            this.menu.Location = new System.Drawing.Point(36, 163);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(297, 286);
            this.menu.TabIndex = 0;
            // 
            // exitBttn
            // 
            this.exitBttn.Image = ((System.Drawing.Image)(resources.GetObject("exitBttn.Image")));
            this.exitBttn.Location = new System.Drawing.Point(96, 183);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(137, 50);
            this.exitBttn.TabIndex = 0;
            this.exitBttn.TabStop = false;
            this.exitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            this.exitBttn.MouseLeave += new System.EventHandler(this.ExitBttn_MouseLeave);
            this.exitBttn.MouseHover += new System.EventHandler(this.ExitBttn_MouseHover);
            // 
            // optionBttn
            // 
            this.optionBttn.Image = ((System.Drawing.Image)(resources.GetObject("optionBttn.Image")));
            this.optionBttn.Location = new System.Drawing.Point(96, 115);
            this.optionBttn.Name = "optionBttn";
            this.optionBttn.Size = new System.Drawing.Size(137, 50);
            this.optionBttn.TabIndex = 0;
            this.optionBttn.TabStop = false;
            this.optionBttn.Click += new System.EventHandler(this.OptionBttn_Click);
            this.optionBttn.MouseLeave += new System.EventHandler(this.OptionBttn_MouseLeave);
            this.optionBttn.MouseHover += new System.EventHandler(this.OptionBttn_MouseHover);
            // 
            // startBttn
            // 
            this.startBttn.Image = ((System.Drawing.Image)(resources.GetObject("startBttn.Image")));
            this.startBttn.Location = new System.Drawing.Point(96, 48);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(137, 50);
            this.startBttn.TabIndex = 0;
            this.startBttn.TabStop = false;
            this.startBttn.Click += new System.EventHandler(this.StartBttn_Click);
            this.startBttn.MouseLeave += new System.EventHandler(this.StartBttn_MouseLeave);
            this.startBttn.MouseHover += new System.EventHandler(this.StartBttn_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 461);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Start_Page_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox exitBttn;
        private System.Windows.Forms.PictureBox optionBttn;
        private System.Windows.Forms.PictureBox startBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}