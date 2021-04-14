namespace Cviceni05
{
    partial class FormHrac
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
            this.labelJmeno = new System.Windows.Forms.Label();
            this.labelKlub = new System.Windows.Forms.Label();
            this.labelGoly = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.comboBoxKlub = new System.Windows.Forms.ComboBox();
            this.numericUpDownGoly = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoly)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Location = new System.Drawing.Point(21, 16);
            this.labelJmeno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(54, 17);
            this.labelJmeno.TabIndex = 0;
            this.labelJmeno.Text = "Jméno:";
            this.labelJmeno.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelKlub
            // 
            this.labelKlub.AutoSize = true;
            this.labelKlub.Location = new System.Drawing.Point(21, 65);
            this.labelKlub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKlub.Name = "labelKlub";
            this.labelKlub.Size = new System.Drawing.Size(40, 17);
            this.labelKlub.TabIndex = 1;
            this.labelKlub.Text = "Klub:";
            // 
            // labelGoly
            // 
            this.labelGoly.AutoSize = true;
            this.labelGoly.Location = new System.Drawing.Point(21, 110);
            this.labelGoly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoly.Name = "labelGoly";
            this.labelGoly.Size = new System.Drawing.Size(41, 17);
            this.labelGoly.TabIndex = 2;
            this.labelGoly.Text = "Góly:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(17, 165);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(141, 165);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(83, 16);
            this.textBoxJmeno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(160, 22);
            this.textBoxJmeno.TabIndex = 6;
            // 
            // comboBoxKlub
            // 
            this.comboBoxKlub.FormattingEnabled = true;
            this.comboBoxKlub.Location = new System.Drawing.Point(83, 62);
            this.comboBoxKlub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxKlub.Name = "comboBoxKlub";
            this.comboBoxKlub.Size = new System.Drawing.Size(160, 24);
            this.comboBoxKlub.TabIndex = 7;
            // 
            // numericUpDownGoly
            // 
            this.numericUpDownGoly.Location = new System.Drawing.Point(83, 108);
            this.numericUpDownGoly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownGoly.Name = "numericUpDownGoly";
            this.numericUpDownGoly.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownGoly.TabIndex = 8;
            // 
            // FormHrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 204);
            this.Controls.Add(this.numericUpDownGoly);
            this.Controls.Add(this.comboBoxKlub);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelGoly);
            this.Controls.Add(this.labelKlub);
            this.Controls.Add(this.labelJmeno);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHrac";
            this.Text = "Hráč";
            this.Load += new System.EventHandler(this.FormHrac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJmeno;
        private System.Windows.Forms.Label labelKlub;
        private System.Windows.Forms.Label labelGoly;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.ComboBox comboBoxKlub;
        private System.Windows.Forms.NumericUpDown numericUpDownGoly;
    }
}