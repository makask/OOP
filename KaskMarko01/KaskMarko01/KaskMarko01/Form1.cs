using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaskMarko01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        tervitus lause = new tervitus();
   
        private void Form1_Load(object sender, EventArgs e)
        {
            lause.nimi = txtNimi.Text;
            lblTulemus.Text = lause.tere();
            txtNimi.Focus();
        }

        private void btnTere_Click(object sender, EventArgs e)
        {
            lause.nimi = txtNimi.Text;
            lblTulemus.Text = lause.tere();
            txtNimi.Text = "";
            txtNimi.Focus();
        }

        private void btnV2lja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kas soovite väljuda?", "Lõpp",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
                this.Close();
        }

        private void btnArv_Click(object sender, EventArgs e)
        {
            summa arvu = new summa();
            try {
                arvu.number1 = Convert.ToSingle(txtArv1.Text);
                arvu.number2 = Convert.ToSingle(txtArv2.Text);
                if (chkTehing.Checked)
                {
                    arvu.tehing = "+";
                    chkTehing.Text = "Liida";
                }
                else {
                    arvu.tehing = "-";
                    chkTehing.Text = "Lahuta";
                }
                Single tulemused = arvu.arvutus();
                lblSumma.Text = Convert.ToString(arvu.number1) + arvu.tehing
                    + Convert.ToString(arvu.number2) + "=" + Convert.ToString(tulemused);
            }
            catch
            {
                lblSumma.Text = "";
                MessageBox.Show("Sisesta arv", "Viga",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnV2rv_Click(object sender, EventArgs e)
        {
            if (btnRed.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else if (btnBlue.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            else {
                MessageBox.Show("Vali värv", "Vormi värvimine", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnTyhi_Click(object sender, EventArgs e)
        {
            btnBlue.Checked = false;
            btnRed.Checked = false;
            this.BackColor = SystemColors.Control;
        }
    }
}
