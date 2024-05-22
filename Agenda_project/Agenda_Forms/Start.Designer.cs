namespace Agenda_Forms
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.bnvlbl = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.VeziAGbutton = new System.Windows.Forms.Button();
            this.Optiunibtn = new System.Windows.Forms.Button();
            this.Intructiunibtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnvlbl
            // 
            this.bnvlbl.AutoSize = true;
            this.bnvlbl.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnvlbl.Location = new System.Drawing.Point(284, 22);
            this.bnvlbl.Name = "bnvlbl";
            this.bnvlbl.Size = new System.Drawing.Size(202, 38);
            this.bnvlbl.TabIndex = 0;
            this.bnvlbl.Text = "BUN VENIT";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(387, 260);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(157, 59);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Ieşire aplicaţie";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(387, 132);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(157, 59);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Adaugă activitate";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // VeziAGbutton
            // 
            this.VeziAGbutton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeziAGbutton.Location = new System.Drawing.Point(387, 197);
            this.VeziAGbutton.Name = "VeziAGbutton";
            this.VeziAGbutton.Size = new System.Drawing.Size(157, 57);
            this.VeziAGbutton.TabIndex = 14;
            this.VeziAGbutton.Text = "Vizualizează agenda";
            this.VeziAGbutton.UseVisualStyleBackColor = true;
            this.VeziAGbutton.Click += new System.EventHandler(this.VeziAGbutton_Click);
            // 
            // Optiunibtn
            // 
            this.Optiunibtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Optiunibtn.Location = new System.Drawing.Point(224, 199);
            this.Optiunibtn.Name = "Optiunibtn";
            this.Optiunibtn.Size = new System.Drawing.Size(157, 57);
            this.Optiunibtn.TabIndex = 21;
            this.Optiunibtn.Text = "Opţiuni";
            this.Optiunibtn.UseVisualStyleBackColor = true;
            this.Optiunibtn.Click += new System.EventHandler(this.Optiunibtn_Click);
            // 
            // Intructiunibtn
            // 
            this.Intructiunibtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intructiunibtn.Location = new System.Drawing.Point(224, 262);
            this.Intructiunibtn.Name = "Intructiunibtn";
            this.Intructiunibtn.Size = new System.Drawing.Size(157, 57);
            this.Intructiunibtn.TabIndex = 23;
            this.Intructiunibtn.Text = "Instrucţiuni";
            this.Intructiunibtn.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Intructiunibtn);
            this.Controls.Add(this.Optiunibtn);
            this.Controls.Add(this.VeziAGbutton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.bnvlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Agenda de Activităţi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bnvlbl;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button VeziAGbutton;
        private System.Windows.Forms.Button Optiunibtn;
        private System.Windows.Forms.Button Intructiunibtn;
    }
}