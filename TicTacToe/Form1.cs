using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            BunifuFlatButton btn = sender as BunifuFlatButton;
            

            btn.ButtonText = lblPlayer.Text;

            if (CheckForWinner() == "")
            {
                if (lblPlayer.Text.ToLower() == "x") lblPlayer.Text = "O";
                else lblPlayer.Text = "X";
            }
            else
            {
                lblWin.Text = "THE WINNER IS: " + CheckForWinner();
                disableAll();
                label1.Text = "ER IS EEN WINNAAR!!";
            }
            btn.Enabled = false;

        }


        private string CheckForWinner()
        {

            // 1 2 3
            // 4 5 6
            // 7 8 9
            if (Btn1.ButtonText == Btn2.ButtonText && Btn2.ButtonText == Btn3.ButtonText && Btn1.ButtonText != "")
            {
                return Btn1.ButtonText;
            }else if (Btn4.ButtonText == Btn5.ButtonText && Btn5.ButtonText == Btn6.ButtonText && Btn4.ButtonText != "")
            {
                return Btn4.ButtonText;
            }
            else if (Btn7.ButtonText == Btn8.ButtonText && Btn8.ButtonText == Btn9.ButtonText && Btn7.ButtonText != "")
            {
                return Btn7.ButtonText;
            }
            // 1 5 9
            // 7 5 3
            else if (Btn1.ButtonText == Btn5.ButtonText && Btn5.ButtonText == Btn9.ButtonText && Btn1.ButtonText != "")
            {
                return Btn1.ButtonText;
            }else if (Btn7.ButtonText == Btn5.ButtonText && Btn5.ButtonText == Btn3.ButtonText && Btn7.ButtonText != "")
            {
                return Btn7.ButtonText;
            }
            // 1 4 7
            // 2 5 8
            // 3 6 9
            else if (Btn1.ButtonText == Btn4.ButtonText && Btn4.ButtonText == Btn7.ButtonText && Btn1.ButtonText != "")
            {
                return Btn1.ButtonText;
            }
            else if (Btn2.ButtonText == Btn5.ButtonText && Btn5.ButtonText == Btn8.ButtonText && Btn2.ButtonText != "")
            {
                return Btn2.ButtonText;
            }
            else if (Btn3.ButtonText == Btn6.ButtonText && Btn6.ButtonText == Btn9.ButtonText && Btn3.ButtonText != "")
            {
                return Btn3.ButtonText;
            }
            else
            {
                return "";
            }
        }


        private void ResetScore(object sender, EventArgs e)
        {
            int teller = 1;

            while (teller < 10)
            {
                string BtnName = "Btn" + teller.ToString();
                BunifuFlatButton btn = this.Controls.Find(BtnName, true)[0] as BunifuFlatButton;

                btn.ButtonText = "";
                label1.Text = "Start the game!!!";
                btn.Enabled = true;
                lblWin.Text = "-";

                teller++;
            }
        }

        private void disableAll()
        {
            int teller = 1;

            while (teller < 10)
            {
                string BtnName = "Btn" + teller.ToString();
                BunifuFlatButton btn = this.Controls.Find(BtnName, true)[0] as BunifuFlatButton;

                btn.Enabled = false;

                teller++;
            }
        }


    }
}
