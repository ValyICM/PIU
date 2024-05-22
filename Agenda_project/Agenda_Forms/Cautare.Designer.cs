namespace Agenda_Forms
{
    partial class Cautare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cautare));
            this.Numetxt = new System.Windows.Forms.TextBox();
            this.Numelbl = new System.Windows.Forms.Label();
            this.Titlulbl = new System.Windows.Forms.Label();
            this.Datalbl = new System.Windows.Forms.Label();
            this.Datatxt = new System.Windows.Forms.TextBox();
            this.Oratxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cautabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numetxt
            // 
            this.Numetxt.Location = new System.Drawing.Point(215, 97);
            this.Numetxt.Name = "Numetxt";
            this.Numetxt.Size = new System.Drawing.Size(156, 20);
            this.Numetxt.TabIndex = 5;
            // 
            // Numelbl
            // 
            this.Numelbl.AutoSize = true;
            this.Numelbl.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numelbl.Location = new System.Drawing.Point(21, 97);
            this.Numelbl.Name = "Numelbl";
            this.Numelbl.Size = new System.Drawing.Size(188, 24);
            this.Numelbl.TabIndex = 4;
            this.Numelbl.Text = "Nume Activitate";
            // 
            // Titlulbl
            // 
            this.Titlulbl.AutoSize = true;
            this.Titlulbl.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlulbl.Location = new System.Drawing.Point(101, 27);
            this.Titlulbl.Name = "Titlulbl";
            this.Titlulbl.Size = new System.Drawing.Size(199, 24);
            this.Titlulbl.TabIndex = 6;
            this.Titlulbl.Text = "Caută activitatea ";
            // 
            // Datalbl
            // 
            this.Datalbl.AutoSize = true;
            this.Datalbl.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datalbl.Location = new System.Drawing.Point(21, 132);
            this.Datalbl.Name = "Datalbl";
            this.Datalbl.Size = new System.Drawing.Size(60, 24);
            this.Datalbl.TabIndex = 7;
            this.Datalbl.Text = "Data";
            // 
            // Datatxt
            // 
            this.Datatxt.Location = new System.Drawing.Point(215, 132);
            this.Datatxt.Name = "Datatxt";
            this.Datatxt.Size = new System.Drawing.Size(156, 20);
            this.Datatxt.TabIndex = 8;
            // 
            // Oratxt
            // 
            this.Oratxt.AutoSize = true;
            this.Oratxt.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oratxt.Location = new System.Drawing.Point(21, 169);
            this.Oratxt.Name = "Oratxt";
            this.Oratxt.Size = new System.Drawing.Size(152, 24);
            this.Oratxt.TabIndex = 9;
            this.Oratxt.Text = "Interval Orar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Cautabtn
            // 
            this.Cautabtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautabtn.Location = new System.Drawing.Point(121, 348);
            this.Cautabtn.Name = "Cautabtn";
            this.Cautabtn.Size = new System.Drawing.Size(157, 57);
            this.Cautabtn.TabIndex = 30;
            this.Cautabtn.Text = "Caută ";
            this.Cautabtn.UseVisualStyleBackColor = true;
            this.Cautabtn.Click += new System.EventHandler(this.Cautabtn_Click);
            // 
            // Cautare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.Cautabtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Oratxt);
            this.Controls.Add(this.Datatxt);
            this.Controls.Add(this.Datalbl);
            this.Controls.Add(this.Titlulbl);
            this.Controls.Add(this.Numetxt);
            this.Controls.Add(this.Numelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cautare";
            this.Text = "Cautare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numetxt;
        private System.Windows.Forms.Label Numelbl;
        private System.Windows.Forms.Label Titlulbl;
        private System.Windows.Forms.Label Datalbl;
        private System.Windows.Forms.TextBox Datatxt;
        private System.Windows.Forms.Label Oratxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cautabtn;
    }
}