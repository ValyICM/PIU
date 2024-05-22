namespace Agenda_Forms
{
    partial class Modifica_date
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifica_date));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adaugabtn = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Modifbtn = new System.Windows.Forms.Button();
            this.Salveazabtn = new System.Windows.Forms.Button();
            this.Stergebtn = new System.Windows.Forms.Button();
            this.VeziAGbutton = new System.Windows.Forms.Button();
            this.Cautabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nume,
            this.Data,
            this.Ora});
            this.dataGridView1.Location = new System.Drawing.Point(344, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "#Id";
            this.Id.Name = "Id";
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume Activitate";
            this.Nume.Name = "Nume";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Ora
            // 
            this.Ora.HeaderText = "Interval orar";
            this.Ora.Name = "Ora";
            // 
            // Adaugabtn
            // 
            this.Adaugabtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adaugabtn.Location = new System.Drawing.Point(12, 12);
            this.Adaugabtn.Name = "Adaugabtn";
            this.Adaugabtn.Size = new System.Drawing.Size(157, 61);
            this.Adaugabtn.TabIndex = 21;
            this.Adaugabtn.Text = "Adaugă datele";
            this.Adaugabtn.UseVisualStyleBackColor = true;
            this.Adaugabtn.Click += new System.EventHandler(this.Adaugabtn_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(662, 377);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 61);
            this.ExitButton.TabIndex = 24;
            this.ExitButton.Text = "Ieşire aplicaţie";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 377);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(126, 61);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Înapoi";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Modifbtn
            // 
            this.Modifbtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifbtn.Location = new System.Drawing.Point(12, 95);
            this.Modifbtn.Name = "Modifbtn";
            this.Modifbtn.Size = new System.Drawing.Size(157, 61);
            this.Modifbtn.TabIndex = 25;
            this.Modifbtn.Text = "Modifică datele";
            this.Modifbtn.UseVisualStyleBackColor = true;
            // 
            // Salveazabtn
            // 
            this.Salveazabtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salveazabtn.Location = new System.Drawing.Point(175, 12);
            this.Salveazabtn.Name = "Salveazabtn";
            this.Salveazabtn.Size = new System.Drawing.Size(154, 61);
            this.Salveazabtn.TabIndex = 26;
            this.Salveazabtn.Text = "Salvează modificarile";
            this.Salveazabtn.UseVisualStyleBackColor = true;
            this.Salveazabtn.Click += new System.EventHandler(this.Salveazabtn_Click);
            // 
            // Stergebtn
            // 
            this.Stergebtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stergebtn.Location = new System.Drawing.Point(12, 180);
            this.Stergebtn.Name = "Stergebtn";
            this.Stergebtn.Size = new System.Drawing.Size(157, 61);
            this.Stergebtn.TabIndex = 27;
            this.Stergebtn.Text = "Şterge o activitate";
            this.Stergebtn.UseVisualStyleBackColor = true;
            this.Stergebtn.Click += new System.EventHandler(this.Stergebtn_Click);
            // 
            // VeziAGbutton
            // 
            this.VeziAGbutton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeziAGbutton.Location = new System.Drawing.Point(175, 95);
            this.VeziAGbutton.Name = "VeziAGbutton";
            this.VeziAGbutton.Size = new System.Drawing.Size(154, 61);
            this.VeziAGbutton.TabIndex = 28;
            this.VeziAGbutton.Text = "Vizualizează agenda";
            this.VeziAGbutton.UseVisualStyleBackColor = true;
            this.VeziAGbutton.Click += new System.EventHandler(this.VeziAGbutton_Click);
            // 
            // Cautabtn
            // 
            this.Cautabtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautabtn.Location = new System.Drawing.Point(175, 180);
            this.Cautabtn.Name = "Cautabtn";
            this.Cautabtn.Size = new System.Drawing.Size(157, 57);
            this.Cautabtn.TabIndex = 29;
            this.Cautabtn.Text = "Caută activitate";
            this.Cautabtn.UseVisualStyleBackColor = true;
            this.Cautabtn.Click += new System.EventHandler(this.Cautabtn_Click);
            // 
            // Modifica_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cautabtn);
            this.Controls.Add(this.VeziAGbutton);
            this.Controls.Add(this.Stergebtn);
            this.Controls.Add(this.Salveazabtn);
            this.Controls.Add(this.Modifbtn);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Adaugabtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modifica_date";
            this.Text = "Modifica_date";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ora;
        private System.Windows.Forms.Button Adaugabtn;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Modifbtn;
        private System.Windows.Forms.Button Salveazabtn;
        private System.Windows.Forms.Button Stergebtn;
        private System.Windows.Forms.Button VeziAGbutton;
        private System.Windows.Forms.Button Cautabtn;
    }
}