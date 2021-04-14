namespace Cviceni05
{
    partial class FormLigaMistru
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonPridej = new System.Windows.Forms.Button();
            this.buttonVymaz = new System.Windows.Forms.Button();
            this.buttonUpravit = new System.Windows.Forms.Button();
            this.buttonNejlepsiKlub = new System.Windows.Forms.Button();
            this.buttonRegistrovat = new System.Windows.Forms.Button();
            this.buttonZrusit = new System.Windows.Forms.Button();
            this.buttonKonec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footballClubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonUloz = new System.Windows.Forms.Button();
            this.buttonNacti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 422);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(861, 116);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonPridej
            // 
            this.buttonPridej.Location = new System.Drawing.Point(721, 15);
            this.buttonPridej.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPridej.Name = "buttonPridej";
            this.buttonPridej.Size = new System.Drawing.Size(157, 28);
            this.buttonPridej.TabIndex = 2;
            this.buttonPridej.Text = "Přidej...";
            this.buttonPridej.UseVisualStyleBackColor = true;
            this.buttonPridej.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonVymaz
            // 
            this.buttonVymaz.Location = new System.Drawing.Point(721, 52);
            this.buttonVymaz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVymaz.Name = "buttonVymaz";
            this.buttonVymaz.Size = new System.Drawing.Size(156, 28);
            this.buttonVymaz.TabIndex = 3;
            this.buttonVymaz.Text = "Vymaž";
            this.buttonVymaz.UseVisualStyleBackColor = true;
            this.buttonVymaz.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpravit
            // 
            this.buttonUpravit.Location = new System.Drawing.Point(721, 89);
            this.buttonUpravit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpravit.Name = "buttonUpravit";
            this.buttonUpravit.Size = new System.Drawing.Size(156, 28);
            this.buttonUpravit.TabIndex = 4;
            this.buttonUpravit.Text = "Upravit";
            this.buttonUpravit.UseVisualStyleBackColor = true;
            this.buttonUpravit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNejlepsiKlub
            // 
            this.buttonNejlepsiKlub.Location = new System.Drawing.Point(721, 126);
            this.buttonNejlepsiKlub.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNejlepsiKlub.Name = "buttonNejlepsiKlub";
            this.buttonNejlepsiKlub.Size = new System.Drawing.Size(157, 28);
            this.buttonNejlepsiKlub.TabIndex = 5;
            this.buttonNejlepsiKlub.Text = "Nejlepší klub";
            this.buttonNejlepsiKlub.UseVisualStyleBackColor = true;
            this.buttonNejlepsiKlub.Click += new System.EventHandler(this.buttonBest_Click);
            // 
            // buttonRegistrovat
            // 
            this.buttonRegistrovat.Location = new System.Drawing.Point(721, 163);
            this.buttonRegistrovat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrovat.Name = "buttonRegistrovat";
            this.buttonRegistrovat.Size = new System.Drawing.Size(157, 28);
            this.buttonRegistrovat.TabIndex = 6;
            this.buttonRegistrovat.Text = "Registrovat";
            this.buttonRegistrovat.UseVisualStyleBackColor = true;
            this.buttonRegistrovat.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonZrusit
            // 
            this.buttonZrusit.Location = new System.Drawing.Point(721, 200);
            this.buttonZrusit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZrusit.Name = "buttonZrusit";
            this.buttonZrusit.Size = new System.Drawing.Size(157, 28);
            this.buttonZrusit.TabIndex = 7;
            this.buttonZrusit.Text = "Zrušit";
            this.buttonZrusit.UseVisualStyleBackColor = true;
            this.buttonZrusit.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonKonec
            // 
            this.buttonKonec.Location = new System.Drawing.Point(721, 237);
            this.buttonKonec.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKonec.Name = "buttonKonec";
            this.buttonKonec.Size = new System.Drawing.Size(157, 28);
            this.buttonKonec.TabIndex = 8;
            this.buttonKonec.Text = "Konec";
            this.buttonKonec.UseVisualStyleBackColor = true;
            this.buttonKonec.Click += new System.EventHandler(this.buttonKonec_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.footballClubDataGridViewTextBoxColumn,
            this.goalsDataGridViewTextBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(655, 390);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "jmeno";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Jméno";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // footballClubDataGridViewTextBoxColumn
            // 
            this.footballClubDataGridViewTextBoxColumn.DataPropertyName = "FotbalovyKlub";
            this.footballClubDataGridViewTextBoxColumn.HeaderText = "Fotbalový klub";
            this.footballClubDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.footballClubDataGridViewTextBoxColumn.Name = "footballClubDataGridViewTextBoxColumn";
            this.footballClubDataGridViewTextBoxColumn.Width = 150;
            // 
            // goalsDataGridViewTextBoxColumn
            // 
            this.goalsDataGridViewTextBoxColumn.DataPropertyName = "Goly";
            this.goalsDataGridViewTextBoxColumn.HeaderText = "Góly";
            this.goalsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goalsDataGridViewTextBoxColumn.Name = "goalsDataGridViewTextBoxColumn";
            this.goalsDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FootballClub";
            this.dataGridViewTextBoxColumn1.HeaderText = "Club";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FootballClub";
            this.dataGridViewTextBoxColumn2.HeaderText = "Club";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FootballClub";
            this.dataGridViewTextBoxColumn3.HeaderText = "Club";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(721, 273);
            this.buttonUloz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(157, 28);
            this.buttonUloz.TabIndex = 8;
            this.buttonUloz.Text = "Ulož";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.buttonUloz_Click);
            // 
            // buttonNacti
            // 
            this.buttonNacti.Location = new System.Drawing.Point(721, 309);
            this.buttonNacti.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNacti.Name = "buttonNacti";
            this.buttonNacti.Size = new System.Drawing.Size(157, 28);
            this.buttonNacti.TabIndex = 8;
            this.buttonNacti.Text = "Načti";
            this.buttonNacti.UseVisualStyleBackColor = true;
            this.buttonNacti.Click += new System.EventHandler(this.buttonNacti_Click);
            // 
            // FormLigaMistru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonNacti);
            this.Controls.Add(this.buttonUloz);
            this.Controls.Add(this.buttonKonec);
            this.Controls.Add(this.buttonZrusit);
            this.Controls.Add(this.buttonRegistrovat);
            this.Controls.Add(this.buttonNejlepsiKlub);
            this.Controls.Add(this.buttonUpravit);
            this.Controls.Add(this.buttonVymaz);
            this.Controls.Add(this.buttonPridej);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLigaMistru";
            this.Text = "Liga Mistrů";
            this.Load += new System.EventHandler(this.FormLigaMistru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonPridej;
        private System.Windows.Forms.Button buttonVymaz;
        private System.Windows.Forms.Button buttonUpravit;
        private System.Windows.Forms.Button buttonNejlepsiKlub;
        private System.Windows.Forms.Button buttonRegistrovat;
        private System.Windows.Forms.Button buttonZrusit;
        private System.Windows.Forms.Button buttonKonec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn footballClubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUloz;
        private System.Windows.Forms.Button buttonNacti;
    }
}

