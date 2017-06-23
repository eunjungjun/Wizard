using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int bank = 500;
        int bet = 10;
        int round = 0;
        int affection = 0;

        bool blackRawrbool = true;
        bool whiteRawrbool = false;

        public Form1()
        {
            InitializeComponent();
            betTextbox.Text = bet.ToString();
            bankTextbox.Text = bank.ToString();

            nameLabel.BackColor = Color.Transparent;
            bankLabel.BackColor = Color.Transparent;
            betLabel.BackColor = Color.Transparent;
            roundLabel.BackColor = Color.Transparent;
            playerRollLabel.BackColor = Color.Transparent;
            houseRollLabel.BackColor = Color.Transparent;
            resultLabel.BackColor = Color.Transparent;
            hpLabel.BackColor = Color.Transparent;

            kittyPicture.BackColor = System.Drawing.Color.Transparent;
            rawrPicture.BackColor = System.Drawing.Color.Transparent;
            whiteRawr.BackColor = System.Drawing.Color.Transparent;

            this.kittyPicture.MouseEnter += new System.EventHandler(this.kittyPicture_MouseEnter);
            this.kittyPicture.MouseLeave += new System.EventHandler(this.kittyPicture_MouseLeave);

            healthBar.Maximum = 1000;
            healthBar.Value += 1000;

        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            try
            {
                bet = Convert.ToInt32(betTextbox.Text);
            }
            catch
            {
                MessageBox.Show("That is not a valid bet!");
                return;
            }

            if (bet > bank)
            {
                MessageBox.Show("You can't bet that much!");
                return;
            }

            round = round + 1;
            roundTextbox.Text = round.ToString();

            Random randomGen = new Random();
            int computerDie = randomGen.Next(1, 7);
            int computerDie2 = randomGen.Next(1, 7);
            int computerRoll = computerDie + computerDie2;
            houseRollTextbox.Text = computerRoll.ToString();

            int playerDie = randomGen.Next(1, 7);
            int playerDie2 = randomGen.Next(1, 7);
            int playerRoll = playerDie + playerDie2;
            playerRollTextbox.Text = playerRoll.ToString();

            String result = "lose";
            if (playerRoll > computerRoll)
            {
                result = "win";
                bank = bank + bet;
            }
            else
            {
                bank = bank - bet;
            }

            bankTextbox.Text = bank.ToString();

            resultTextbox.Text = "You " + result + "!";

            if (bank <= 0)
            {
                playAgain.Visible = true;
                rollButton.Enabled = false;
                MessageBox.Show("You have no money left in the bank.");
            }

        }

        private void kittyButton_Click(object sender, EventArgs e)
        {
            if (bank < 1000)
            {
                MessageBox.Show("You don't have that much!");
                return;
            }

            kittyPicture.Visible = true;
            bank = bank - 1000;
            bankTextbox.Text = bank.ToString();
            kittyButton.Enabled = false;
            glassesButton.Visible = true;
        }

        private void kittyPicture_MouseEnter(object sender, EventArgs e)
        {
            if (blackRawrbool == true)
            {
                kittyPicture.Controls.Add(rawrPicture);
                rawrPicture.Image = WindowsFormsApplication1.Properties.Resources.Rawr;
                rawrPicture.Visible = true;
                rawrPicture.Location = new Point(25, 0);
                if (affection == 100)
                {
                    rawrPicture.Image = WindowsFormsApplication1.Properties.Resources.Mrowr;
                }
            }

            if (whiteRawrbool == true)
            {
                kittyPicture.Controls.Add(whiteRawr);
                whiteRawr.Image = WindowsFormsApplication1.Properties.Resources.RawrWhite;
                whiteRawr.Visible = true;
                whiteRawr.Location = new Point(25, 0);
                if (affection == 100)
                {
                    whiteRawr.Image = WindowsFormsApplication1.Properties.Resources.WhiteMrowr;
                }
            }

        }
        private void kittyPicture_MouseLeave(object sender, EventArgs e)
        {

            rawrPicture.Visible = false;
            whiteRawr.Visible = false;

        }

        private void glassesButton_Click(object sender, EventArgs e)
        {
            if (bank < 500)
            {
                MessageBox.Show("You don't have that much!");
                return;
            }
            kittyPicture.Image = WindowsFormsApplication1.Properties.Resources.kittyGlassesFinal;
            bank = bank - 500;
            bankTextbox.Text = bank.ToString();
            hatButton.Visible = true;
            glassesButton.Enabled = false;
            affection += 25;
        }

        private void hatButton_Click(object sender, EventArgs e)
        {
            if (bank < 500)
            {
                MessageBox.Show("You don't have that much!");
                return;
            }
            kittyPicture.Image = WindowsFormsApplication1.Properties.Resources.kittyglasseshat;
            bank = bank - 500;
            bankTextbox.Text = bank.ToString();
            kittyRobesButton.Visible = true;
            hatButton.Enabled = false;
            affection += 25;
        }

        private void kittyRobesButton_Click(object sender, EventArgs e)
        {
            if (bank < 500)
            {
                MessageBox.Show("You don't have that much!");
                return;
            }
            kittyPicture.Image = WindowsFormsApplication1.Properties.Resources.kittyComplete;
            bank = bank - 500;
            bankTextbox.Text = bank.ToString();
            robesButton.Visible = true;
            kittyRobesButton.Enabled = false;
            affection += 25;
        }

        private void robesButton_Click(object sender, EventArgs e)
        {
            if (bank < 500)
            {
                MessageBox.Show("You don't have that much!");
                return;
            }
            bank = bank - 500;
            bankTextbox.Text = bank.ToString();
            endButton.Visible = true;
            robesButton.Enabled = false;
            affection += 25;
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Ending;
            nameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            bankLabel.ForeColor = System.Drawing.Color.DarkBlue;
            betLabel.ForeColor = System.Drawing.Color.DarkBlue;
            roundLabel.ForeColor = System.Drawing.Color.DarkBlue;
            playerRollLabel.ForeColor = System.Drawing.Color.DarkBlue;
            houseRollLabel.ForeColor = System.Drawing.Color.DarkBlue;
            resultLabel.ForeColor = System.Drawing.Color.DarkBlue;
            hpLabel.ForeColor = System.Drawing.Color.DarkBlue;

            blackRawrbool = true;
            whiteRawrbool = false;

            kittyButton.Visible = false;
            glassesButton.Visible = false;
            hatButton.Visible = false;
            kittyRobesButton.Visible = false;
            robesButton.Visible = false;
            endButton.Visible = false;
            playAgain.Visible = true;
            backgroundChange.Enabled = false;
            togetherToolStripMenuItem.Visible = true;

        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            playAgain.Visible = false;
            rollButton.Enabled = true;
            bank = 500;
            bankTextbox.Text = bank.ToString();
            round = 0;
            affection = 0;
            blackRawrbool = true;
            whiteRawrbool = false;

            kittyPicture.Visible = false;
            kittyPicture.Image = WindowsFormsApplication1.Properties.Resources.kittyFinal;
            kittyButton.Visible = true;
            kittyButton.Enabled = true;
            glassesButton.Enabled = true;
            glassesButton.Visible = false;
            hatButton.Enabled = true;
            hatButton.Visible = false;
            kittyRobesButton.Enabled = true;
            kittyRobesButton.Visible = false;
            robesButton.Enabled = true;
            robesButton.Visible = false;
            endButton.Visible = false;
            backgroundChange.Enabled = true;
            healthBar.Value = 1000;
        }

        private void defaultBackground_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Bubbles;

            nameLabel.ForeColor = Color.FromArgb(69, 69, 69);
            bankLabel.ForeColor = Color.FromArgb(69, 69, 69);
            betLabel.ForeColor = Color.FromArgb(69, 69, 69);
            roundLabel.ForeColor = Color.FromArgb(69, 69, 69);
            playerRollLabel.ForeColor = Color.FromArgb(69, 69, 69);
            houseRollLabel.ForeColor = Color.FromArgb(69, 69, 69);
            resultLabel.ForeColor = Color.FromArgb(69, 69, 69);
            hpLabel.ForeColor = Color.FromArgb(69, 69, 69);

            blackRawrbool = true;
            whiteRawrbool = false;
        }

        private void spaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Space1;

            nameLabel.ForeColor = System.Drawing.Color.Pink;
            bankLabel.ForeColor = System.Drawing.Color.Pink;
            betLabel.ForeColor = System.Drawing.Color.Pink;
            roundLabel.ForeColor = System.Drawing.Color.Pink;
            playerRollLabel.ForeColor = System.Drawing.Color.Pink;
            houseRollLabel.ForeColor = System.Drawing.Color.Pink;
            resultLabel.ForeColor = System.Drawing.Color.Pink;
            hpLabel.ForeColor = System.Drawing.Color.Pink;

            blackRawrbool = false;
            whiteRawrbool = true;
        }

        private void pusheenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Pusheen;

            nameLabel.ForeColor = System.Drawing.Color.Black;
            bankLabel.ForeColor = System.Drawing.Color.Black;
            betLabel.ForeColor = System.Drawing.Color.Black;
            roundLabel.ForeColor = System.Drawing.Color.Black;
            playerRollLabel.ForeColor = System.Drawing.Color.Black;
            houseRollLabel.ForeColor = System.Drawing.Color.Black;
            resultLabel.ForeColor = System.Drawing.Color.Black;
            hpLabel.ForeColor = System.Drawing.Color.Black;

            blackRawrbool = true;
            whiteRawrbool = false;
        }

        private void underwaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Underwater;

            nameLabel.ForeColor = Color.FromArgb(255, 136, 0);
            bankLabel.ForeColor = Color.FromArgb(255, 136, 0);
            betLabel.ForeColor = Color.FromArgb(255, 136, 0);
            roundLabel.ForeColor = Color.FromArgb(255, 136, 0);
            playerRollLabel.ForeColor = Color.FromArgb(255, 136, 0);
            houseRollLabel.ForeColor = Color.FromArgb(255, 136, 0);
            resultLabel.ForeColor = Color.FromArgb(255, 136, 0);
            hpLabel.ForeColor = Color.FromArgb(255, 136, 0);

            blackRawrbool = false;
            whiteRawrbool = true;
        }

        private void woodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Woods;

            nameLabel.ForeColor = System.Drawing.Color.White;
            bankLabel.ForeColor = System.Drawing.Color.White;
            betLabel.ForeColor = System.Drawing.Color.White;
            roundLabel.ForeColor = System.Drawing.Color.White;
            playerRollLabel.ForeColor = System.Drawing.Color.White;
            houseRollLabel.ForeColor = System.Drawing.Color.White;
            resultLabel.ForeColor = System.Drawing.Color.White;
            hpLabel.ForeColor = System.Drawing.Color.White;

            blackRawrbool = false;
            whiteRawrbool = true;
        }
        private void togetherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Ending;
            nameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            bankLabel.ForeColor = System.Drawing.Color.DarkBlue;
            betLabel.ForeColor = System.Drawing.Color.DarkBlue;
            roundLabel.ForeColor = System.Drawing.Color.DarkBlue;
            playerRollLabel.ForeColor = System.Drawing.Color.DarkBlue;
            houseRollLabel.ForeColor = System.Drawing.Color.DarkBlue;
            resultLabel.ForeColor = System.Drawing.Color.DarkBlue;
            hpLabel.ForeColor = System.Drawing.Color.DarkBlue;

            blackRawrbool = true;
            whiteRawrbool = false;
        }

        private void kittyPicture_Click(object sender, EventArgs e)
        {
            if (affection == 0)
            {
                MessageBox.Show("Fierce Kitty scratched you!");
                healthBar.Value = healthBar.Value - 500;
            }

            if (affection == 25)
            {
                MessageBox.Show("Fierce Kitty batted at you!");
                healthBar.Value = healthBar.Value - 250;
            }

            if (affection == 50)
            {
                MessageBox.Show("Fierce Kitty ignored you!");
                healthBar.Value = healthBar.Value - 50;
            }

            if (affection == 75)
            {
                MessageBox.Show("Fierce Kitty stared at you!");
                healthBar.Value = healthBar.Value - 25;
            }

            if (affection == 100)
            {
                MessageBox.Show("Fierce Kitty nuzzled you!");
                healthBar.Value = 1000;
            }

            if (healthBar.Value == 0)
            {
                MessageBox.Show("You died of blood loss...and Fierce Kitty left.");

                kittyPicture.Visible = false;
                playAgain.Visible = true;
            }
        }
    }
}
