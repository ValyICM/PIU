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
                
                string[] lines = File.ReadAllLines(filePath);

                

                int initialY = 100;

                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');

                    // Afișează id-ul pe o linie
                    Label idLabel = new Label();
                    idLabel.Text = fields[0].Trim();
                    idLabel.Font = new Font("Lucida Fax", 16, FontStyle.Bold);
                    idLabel.AutoSize = true;
                    idLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top; // Aliniere la stânga sus
                    idLabel.Location = new Point(20, initialY);
                    this.Controls.Add(idLabel);

                    // Afișează numele pe aceeași linie, după id
                    Label nameLabel = new Label();
                    nameLabel.Text = fields[1].Trim();
                    nameLabel.Font = new Font("Lucida Fax", 16, FontStyle.Bold);
                    nameLabel.AutoSize = true;
                    nameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top; // Aliniere la stânga sus
                    nameLabel.Location = new Point(60, initialY);
                    this.Controls.Add(nameLabel);

                    // Afișează data și ora pe aceeași linie, după nume
                    Label dateTimeLabel = new Label();
                    dateTimeLabel.Text = $"{fields[2].Trim()}    {fields[3].Trim()}";
                    dateTimeLabel.Font = new Font("Lucida Fax", 16, FontStyle.Bold);
                    dateTimeLabel.AutoSize = true;
                    dateTimeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top; // Aliniere la stânga sus
                    dateTimeLabel.Location = new Point(200, initialY);
                    this.Controls.Add(dateTimeLabel);

                    initialY += idLabel.Height + 10; // Spațiu vertical între activități
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare în timpul citirii fișierului: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendaAdd AgendaAdd = new AgendaAdd();
            AgendaAdd.Show();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start Start = new Start();
            Start.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}