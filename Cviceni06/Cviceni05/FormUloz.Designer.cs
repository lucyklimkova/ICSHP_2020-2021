namespace Cviceni05
{
    partial class FormUloz
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(428, 189);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zvol jaké kluby chceš uložit:";
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(359, 235);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(91, 26);
            this.buttonUloz.TabIndex = 2;
            this.buttonUloz.Text = "Ulož";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUloz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 273);
            this.Controls.Add(this.buttonUloz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "FormUloz";
            this.Text = "FormUloz";
            this.Load += new System.EventHandler(this.FormUloz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUloz;
    }
}