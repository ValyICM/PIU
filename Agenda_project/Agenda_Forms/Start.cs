using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Forms
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        //butoane de comanda

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AgendaAdd  = new AgendaAdd();
            AgendaAdd.Show();
        }

        private void VeziAGbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Agenda = new Agenda();
            Agenda.Show();
        }

        private void Optiunibtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Modifica_Date = new Modifica_date();
            Modifica_Date.Show();
        }
    }
}
