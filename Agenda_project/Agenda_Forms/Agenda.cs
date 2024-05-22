using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Forms
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
            AfiseazaContinutulFisierului("D:\\Projects\\PIU-main\\Agenda_project\\Agenda_project\\numeFisier.txt");
        }

        private void AfiseazaContinutulFisierului(string filePath)
        {
            try
            {
                
                //citesc tot fisierul
                string[] lines = File.ReadAllLines(filePath);

                int initialY = 100;

                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');

                    // Afisez id-ul pe o linie
                    Label idLabel = new Label();
                    idLabel.Text = fields[0].Trim();
                    idLabel.Font = new Font("Lucida Fax", 16, FontStyle.Bold);
                    idLabel.AutoSize = true;
                    idLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top; // Aliniere stanga sus
                    idLabel.Location = new Point(20, initialY);
                    this.Controls.Add(idLabel);

                    // Afisez numele pe aceeași linie, dupa id
                    Label nameLabel = new Label();
                    nameLabel.Text = fields[1].Trim();
                    nameLabel.Font = new Font("Lucida Fax", 16, FontStyle.Bold);
                    nameLabel.AutoSize = true;
                    nameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top; // Aliniere stanga sus
                    nameLabel.Location = new Point(60, initialY);
                    this.Controls.Add(nameLabel);

                    // Afisez data si ora pe aceeași linie, dupa nume
                    Label dateTimeLabel = new Label();
                    dateTimeLabel.Text = $"{fields[2].Trim()}    {fields[3].Trim()}";
                    dateTimeLabel.Font = new Font("Lucida Fax", 16, FontStyle.Bold);
                    dateTimeLabel.AutoSize = true;
                    dateTimeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top; // Aliniere la stânga sus
                    dateTimeLabel.Location = new Point(200, initialY);
                    this.Controls.Add(dateTimeLabel);

                    initialY += idLabel.Height + 10; // Spatiu vertical intre activitati
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare în timpul citirii fișierului: " + ex.Message);
            }
        }

        // butoane de comanda    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start Start = new Start();
            Start.Show();
        }

        

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Optiunibtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form Modifica_Date = new Modifica_date();
            Modifica_Date.Show();
        }
    }
}