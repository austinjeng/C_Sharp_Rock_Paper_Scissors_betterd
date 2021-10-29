using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperRockScissorsGame

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            shoot(sender);
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            shoot(sender);
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            shoot(sender);
        }


        void shoot(object sender)
        {
            string name = ((Button)sender).Text;

            int playerHand = Convert.ToInt32(((Button)sender).Tag);
            int result = getGameResult();
            int computerHand = getComputerHand(playerHand, result);

            string playerHandName = getNameById(playerHand);
            string computerHandName = getNameById(computerHand);
            string resultString = getResultById(result);

            updateAllButtonToResultStyle(playerHand, computerHand);


            //MessageBox.Show("電腦出" + computerHandName + "，玩家出" + playerHandName, resultString);

            this.HintLabel.Text = resultString;
            this.HintLabel.Visible = true;


            this.ReplayButton.Visible = true;
        }

        int getComputerHand(int playerHand, int result)
        {

            int computerHand = -1;

            switch(result)
            {
                case -1:
                    computerHand = playerHand - 1;
                    break;

                case 0:
                    computerHand = playerHand;
                    break;

                case 1:
                    computerHand = playerHand + 1;
                    break;
            }

            if (computerHand < 1)
            {
                computerHand = 3;
            }

            if (computerHand > 3)
            {
                computerHand = 1;
            }

            return computerHand;

        }

        int getGameResult()
        {
            Random random = new Random();
            int randomNumber = random.Next(100);

            if (this.EasyRadioButton.Checked)
            {
                if (randomNumber < 13)
                {
                    return 1;
                }
                else if (randomNumber < 97)
                {
                    return -1;
                }
            }
            else if (this.NormalRadioButton.Checked)
            {
                if (randomNumber < 33)
                {
                    return 1;
                }
                else if (randomNumber < 66)
                {
                    return -1;
                }
            }
            else
            {
                if (randomNumber < 87)
                {
                    return 1;
                }
                else if (randomNumber < 97)
                {
                    return -1;
                }
            }

            return 0;
        }

        

        string getNameById(int id)
        {
            switch(id)
            {
                case 1:
                    return "剪刀";

                case 2:
                    return "石頭";

                case 3:
                    return "布";

                default:
                    return "作弊啦";
            }
        }

        string getResultById(int result)
        {
            switch (result)
            {
                case -1:
                    return "你贏了^_<";

                case 0:
                    return "平手";

                case 1:
                    return "你輸了Q_Q";

                default:
                    return "作弊啦";
            }
        }

        void updateAllButtonToResultStyle(int playerHand, int computerHand)
        {
            setResultButtonStyle(this.ScissorsButton, playerHand);
            setResultButtonStyle(this.RockButton, playerHand);
            setResultButtonStyle(this.PaperButton, playerHand);

            setResultButtonStyle(this.ComScissorsButton, computerHand);
            setResultButtonStyle(this.ComRockButton, computerHand);
            setResultButtonStyle(this.ComPaperButton, computerHand);
        }

        void setResultButtonStyle(Button button, int hand)
        {
            int tag = Convert.ToInt32(button.Tag);
            button.Visible = (tag == hand);
            button.Enabled = false;
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            restoreButtonStyle(this.ScissorsButton);
            restoreButtonStyle(this.RockButton);
            restoreButtonStyle(this.PaperButton);
            restoreButtonStyle(this.ComScissorsButton);
            restoreButtonStyle(this.ComRockButton);
            restoreButtonStyle(this.ComPaperButton);

            this.ReplayButton.Visible = false;
            this.HintLabel.Visible = false;
        }

        void restoreButtonStyle(Button button)
        {
            button.Visible = true;
            button.Enabled = true;
        }
    }
}
