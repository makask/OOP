using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kask03
{
    public partial class Form1 : Form
    {
        public int player1Score;
        public int player2Score;
        public Form1()
        {
            InitializeComponent();
            cleanTextFields();
            btn_Player1.Enabled = false;
            btn_Player2.Enabled = false;
        }

     

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            cleanTextFields();
            btn_Player1.Enabled = true;
        }

        private void cleanTextFields() {
            lbl_Points1.Text = "";
            lbl_Points2.Text = "";
            txtBox1.Text = "";
            txtBox2.Text = "";
            txtBox3.Text = "";
            txtBox4.Text = "";
            lbl_Result.Text = "";
        }

        private void btn_Player1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int dice1 = random.Next(1,7);
            int dice2 = random.Next(1,7);
            player1Score = dice1 + dice2;
            
            txtBox1.Text = Convert.ToString(dice1);
            txtBox2.Text = Convert.ToString(dice2);
            lbl_Points1.Text = Convert.ToString(player1Score);

            btn_Player1.Enabled = false;
            btn_Player2.Enabled = true;
        }

        private void btn_Player2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int dice3 = random.Next(1,7);
            int dice4 = random.Next(1,7);
            player2Score = dice3 + dice4;

            txtBox3.Text = Convert.ToString(dice3);
            txtBox4.Text = Convert.ToString(dice4);
            lbl_Points2.Text = Convert.ToString(player2Score);

            btn_Player2.Enabled = false;

            declareResult();
        }

        private void declareResult() {
            if (player1Score > player2Score)
            {
                lbl_Result.Text = "Võitis Juku";
            }
            else if (player2Score > player1Score)
            {
                lbl_Result.Text = "Võitis Peeter";
            }
            else {
                lbl_Result.Text = "Viik";
            }
        }
    }
}
