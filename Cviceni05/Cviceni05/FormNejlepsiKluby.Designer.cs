namespace Cviceni05
{
    partial class FormNejlepsiKluby
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
            this.labelNejlepsiKluby = new System.Windows.Forms.Label();
            this.labelGoly = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 84);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 119);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // labelNejlepsiKluby
            // 
            this.labelNejlepsiKluby.AutoSize = true;
            this.labelNejlepsiKluby.Location = new System.Drawing.Point(17, 16);
            this.labelNejlepsiKluby.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNejlepsiKluby.Name = "labelNejlepsiKluby";
            this.labelNejlepsiKluby.Size = new System.Drawing.Size(99, 17);
            this.labelNejlepsiKluby.TabIndex = 1;
            this.labelNejlepsiKluby.Text = "Nejlepší kluby:";
            // 
            // labelGoly
            // 
            this.labelGoly.AutoSize = true;
            this.labelGoly.Location = new System.Drawing.Point(17, 49);
            this.labelGoly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoly.Name = "labelGoly";
            this.labelGoly.Size = new System.Drawing.Size(53, 17);
            this.labelGoly.TabIndex = 2;
            this.labelGoly.Text = "Góly: 0";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(333, 211);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormNejlepsiKluby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 245);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelGoly);
            this.Controls.Add(this.labelNejlepsiKluby);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormNejlepsiKluby";
            this.Text = "Nejlepší kluby";
            this.Load += new System.EventHandler(this.FormNejlepsiKluby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelNejlepsiKluby;
        private System.Windows.Forms.Label labelGoly;
        private System.Windows.Forms.Button buttonOK;
    }
}