namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.betTextbox = new System.Windows.Forms.TextBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.bankLabel = new System.Windows.Forms.Label();
            this.bankTextbox = new System.Windows.Forms.TextBox();
            this.playerRollLabel = new System.Windows.Forms.Label();
            this.playerRollTextbox = new System.Windows.Forms.TextBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundTextbox = new System.Windows.Forms.TextBox();
            this.houseRollLabel = new System.Windows.Forms.Label();
            this.houseRollTextbox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backgroundChange = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pusheenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underwaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.woodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.togetherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kittyButton = new System.Windows.Forms.Button();
            this.kittyPicture = new System.Windows.Forms.PictureBox();
            this.rawrPicture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.whiteRawr = new System.Windows.Forms.PictureBox();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.hpLabel = new System.Windows.Forms.Label();
            this.glassesButton = new System.Windows.Forms.Button();
            this.kittyRobesButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.robesButton = new System.Windows.Forms.Button();
            this.hatButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kittyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawrPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteRawr)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.nameLabel.Location = new System.Drawing.Point(36, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.betLabel.Location = new System.Drawing.Point(48, 93);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(26, 13);
            this.betLabel.TabIndex = 1;
            this.betLabel.Text = "Bet:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(80, 14);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 2;
            // 
            // betTextbox
            // 
            this.betTextbox.Location = new System.Drawing.Point(80, 90);
            this.betTextbox.Name = "betTextbox";
            this.betTextbox.Size = new System.Drawing.Size(100, 20);
            this.betTextbox.TabIndex = 3;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(94, 133);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(74, 23);
            this.rollButton.TabIndex = 5;
            this.rollButton.Text = "Roll!";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // playAgain
            // 
            this.playAgain.Location = new System.Drawing.Point(598, 12);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(74, 23);
            this.playAgain.TabIndex = 6;
            this.playAgain.Text = "Play Again?";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bankLabel.Location = new System.Drawing.Point(39, 55);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(35, 13);
            this.bankLabel.TabIndex = 7;
            this.bankLabel.Text = "Bank:";
            // 
            // bankTextbox
            // 
            this.bankTextbox.Location = new System.Drawing.Point(80, 52);
            this.bankTextbox.Name = "bankTextbox";
            this.bankTextbox.ReadOnly = true;
            this.bankTextbox.Size = new System.Drawing.Size(100, 20);
            this.bankTextbox.TabIndex = 8;
            // 
            // playerRollLabel
            // 
            this.playerRollLabel.AutoSize = true;
            this.playerRollLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.playerRollLabel.Location = new System.Drawing.Point(21, 222);
            this.playerRollLabel.Name = "playerRollLabel";
            this.playerRollLabel.Size = new System.Drawing.Size(53, 13);
            this.playerRollLabel.TabIndex = 10;
            this.playerRollLabel.Text = "Your Roll:";
            // 
            // playerRollTextbox
            // 
            this.playerRollTextbox.Location = new System.Drawing.Point(80, 219);
            this.playerRollTextbox.Name = "playerRollTextbox";
            this.playerRollTextbox.ReadOnly = true;
            this.playerRollTextbox.Size = new System.Drawing.Size(100, 20);
            this.playerRollTextbox.TabIndex = 11;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.roundLabel.Location = new System.Drawing.Point(32, 182);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(42, 13);
            this.roundLabel.TabIndex = 12;
            this.roundLabel.Text = "Round:";
            // 
            // roundTextbox
            // 
            this.roundTextbox.Location = new System.Drawing.Point(80, 179);
            this.roundTextbox.Name = "roundTextbox";
            this.roundTextbox.ReadOnly = true;
            this.roundTextbox.Size = new System.Drawing.Size(100, 20);
            this.roundTextbox.TabIndex = 13;
            // 
            // houseRollLabel
            // 
            this.houseRollLabel.AutoSize = true;
            this.houseRollLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.houseRollLabel.Location = new System.Drawing.Point(12, 260);
            this.houseRollLabel.Name = "houseRollLabel";
            this.houseRollLabel.Size = new System.Drawing.Size(62, 13);
            this.houseRollLabel.TabIndex = 14;
            this.houseRollLabel.Text = "House Roll:";
            // 
            // houseRollTextbox
            // 
            this.houseRollTextbox.Location = new System.Drawing.Point(80, 257);
            this.houseRollTextbox.Name = "houseRollTextbox";
            this.houseRollTextbox.ReadOnly = true;
            this.houseRollTextbox.Size = new System.Drawing.Size(100, 20);
            this.houseRollTextbox.TabIndex = 15;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.resultLabel.Location = new System.Drawing.Point(34, 298);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 16;
            this.resultLabel.Text = "Result:";
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(80, 295);
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.ReadOnly = true;
            this.resultTextbox.Size = new System.Drawing.Size(100, 20);
            this.resultTextbox.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundChange});
            this.menuStrip1.Location = new System.Drawing.Point(9, 361);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(135, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backgroundChange
            // 
            this.backgroundChange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultBackground,
            this.spaceToolStripMenuItem,
            this.pusheenToolStripMenuItem,
            this.underwaterToolStripMenuItem,
            this.woodsToolStripMenuItem,
            this.togetherToolStripMenuItem});
            this.backgroundChange.Name = "backgroundChange";
            this.backgroundChange.Size = new System.Drawing.Size(127, 20);
            this.backgroundChange.Text = "Change Background";
            // 
            // defaultBackground
            // 
            this.defaultBackground.Name = "defaultBackground";
            this.defaultBackground.Size = new System.Drawing.Size(135, 22);
            this.defaultBackground.Text = "Default";
            this.defaultBackground.Click += new System.EventHandler(this.defaultBackground_Click);
            // 
            // spaceToolStripMenuItem
            // 
            this.spaceToolStripMenuItem.Name = "spaceToolStripMenuItem";
            this.spaceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.spaceToolStripMenuItem.Text = "Space";
            this.spaceToolStripMenuItem.Click += new System.EventHandler(this.spaceToolStripMenuItem_Click);
            // 
            // pusheenToolStripMenuItem
            // 
            this.pusheenToolStripMenuItem.Name = "pusheenToolStripMenuItem";
            this.pusheenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pusheenToolStripMenuItem.Text = "Pusheen";
            this.pusheenToolStripMenuItem.Click += new System.EventHandler(this.pusheenToolStripMenuItem_Click);
            // 
            // underwaterToolStripMenuItem
            // 
            this.underwaterToolStripMenuItem.Name = "underwaterToolStripMenuItem";
            this.underwaterToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.underwaterToolStripMenuItem.Text = "Underwater";
            this.underwaterToolStripMenuItem.Click += new System.EventHandler(this.underwaterToolStripMenuItem_Click);
            // 
            // woodsToolStripMenuItem
            // 
            this.woodsToolStripMenuItem.Name = "woodsToolStripMenuItem";
            this.woodsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.woodsToolStripMenuItem.Text = "Woods";
            this.woodsToolStripMenuItem.Click += new System.EventHandler(this.woodsToolStripMenuItem_Click);
            // 
            // togetherToolStripMenuItem
            // 
            this.togetherToolStripMenuItem.Name = "togetherToolStripMenuItem";
            this.togetherToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.togetherToolStripMenuItem.Text = "Together";
            this.togetherToolStripMenuItem.Visible = false;
            this.togetherToolStripMenuItem.Click += new System.EventHandler(this.togetherToolStripMenuItem_Click);
            // 
            // kittyButton
            // 
            this.kittyButton.Location = new System.Drawing.Point(239, 73);
            this.kittyButton.Name = "kittyButton";
            this.kittyButton.Size = new System.Drawing.Size(140, 23);
            this.kittyButton.TabIndex = 19;
            this.kittyButton.Text = "Buy Fierce Kitty for $1000";
            this.kittyButton.UseVisualStyleBackColor = true;
            this.kittyButton.Click += new System.EventHandler(this.kittyButton_Click);
            // 
            // kittyPicture
            // 
            this.kittyPicture.Image = global::WindowsFormsApplication1.Properties.Resources.kittyFinal;
            this.kittyPicture.Location = new System.Drawing.Point(436, 218);
            this.kittyPicture.Name = "kittyPicture";
            this.kittyPicture.Size = new System.Drawing.Size(268, 207);
            this.kittyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.kittyPicture.TabIndex = 20;
            this.kittyPicture.TabStop = false;
            this.kittyPicture.Visible = false;
            this.kittyPicture.Click += new System.EventHandler(this.kittyPicture_Click);
            // 
            // rawrPicture
            // 
            this.rawrPicture.Image = global::WindowsFormsApplication1.Properties.Resources.Rawr;
            this.rawrPicture.Location = new System.Drawing.Point(495, 222);
            this.rawrPicture.Name = "rawrPicture";
            this.rawrPicture.Size = new System.Drawing.Size(100, 70);
            this.rawrPicture.TabIndex = 21;
            this.rawrPicture.TabStop = false;
            this.rawrPicture.Visible = false;
            // 
            // whiteRawr
            // 
            this.whiteRawr.Image = global::WindowsFormsApplication1.Properties.Resources.RawrWhite;
            this.whiteRawr.Location = new System.Drawing.Point(473, 218);
            this.whiteRawr.Name = "whiteRawr";
            this.whiteRawr.Size = new System.Drawing.Size(100, 74);
            this.whiteRawr.TabIndex = 23;
            this.whiteRawr.TabStop = false;
            this.whiteRawr.Visible = false;
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(267, 14);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(100, 23);
            this.healthBar.TabIndex = 24;
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.hpLabel.Location = new System.Drawing.Point(236, 17);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(25, 13);
            this.hpLabel.TabIndex = 25;
            this.hpLabel.Text = "HP:";
            // 
            // glassesButton
            // 
            this.glassesButton.Location = new System.Drawing.Point(239, 111);
            this.glassesButton.Name = "glassesButton";
            this.glassesButton.Size = new System.Drawing.Size(140, 23);
            this.glassesButton.TabIndex = 27;
            this.glassesButton.Text = "Buy Kitty Glasses for $500";
            this.glassesButton.UseVisualStyleBackColor = true;
            this.glassesButton.Visible = false;
            this.glassesButton.Click += new System.EventHandler(this.glassesButton_Click);
            // 
            // kittyRobesButton
            // 
            this.kittyRobesButton.Location = new System.Drawing.Point(239, 187);
            this.kittyRobesButton.Name = "kittyRobesButton";
            this.kittyRobesButton.Size = new System.Drawing.Size(140, 23);
            this.kittyRobesButton.TabIndex = 28;
            this.kittyRobesButton.Text = "Buy Kitty Robes for $500";
            this.kittyRobesButton.UseVisualStyleBackColor = true;
            this.kittyRobesButton.Visible = false;
            this.kittyRobesButton.Click += new System.EventHandler(this.kittyRobesButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(220, 263);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(178, 48);
            this.endButton.TabIndex = 29;
            this.endButton.Text = "End your gambling addiction,\r\nand start a new life with your Fierce Kitty";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Visible = false;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // robesButton
            // 
            this.robesButton.Location = new System.Drawing.Point(239, 225);
            this.robesButton.Name = "robesButton";
            this.robesButton.Size = new System.Drawing.Size(140, 23);
            this.robesButton.TabIndex = 30;
            this.robesButton.Text = "Buy your Robes for $500";
            this.robesButton.UseVisualStyleBackColor = true;
            this.robesButton.Visible = false;
            this.robesButton.Click += new System.EventHandler(this.robesButton_Click);
            // 
            // hatButton
            // 
            this.hatButton.Location = new System.Drawing.Point(239, 149);
            this.hatButton.Name = "hatButton";
            this.hatButton.Size = new System.Drawing.Size(140, 23);
            this.hatButton.TabIndex = 31;
            this.hatButton.Text = "Buy Kitty Hat for $500";
            this.hatButton.UseVisualStyleBackColor = true;
            this.hatButton.Visible = false;
            this.hatButton.Click += new System.EventHandler(this.hatButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Bubbles;
            this.ClientSize = new System.Drawing.Size(684, 394);
            this.Controls.Add(this.hatButton);
            this.Controls.Add(this.robesButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.kittyRobesButton);
            this.Controls.Add(this.glassesButton);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.whiteRawr);
            this.Controls.Add(this.rawrPicture);
            this.Controls.Add(this.kittyPicture);
            this.Controls.Add(this.kittyButton);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.houseRollTextbox);
            this.Controls.Add(this.houseRollLabel);
            this.Controls.Add(this.roundTextbox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.playerRollTextbox);
            this.Controls.Add(this.playerRollLabel);
            this.Controls.Add(this.bankTextbox);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.betTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kitty";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kittyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawrPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteRawr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox betTextbox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.TextBox bankTextbox;
        private System.Windows.Forms.Label playerRollLabel;
        private System.Windows.Forms.TextBox playerRollTextbox;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.TextBox roundTextbox;
        private System.Windows.Forms.Label houseRollLabel;
        private System.Windows.Forms.TextBox houseRollTextbox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backgroundChange;
        private System.Windows.Forms.ToolStripMenuItem defaultBackground;
        private System.Windows.Forms.ToolStripMenuItem spaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pusheenToolStripMenuItem;
        private System.Windows.Forms.Button kittyButton;
        private System.Windows.Forms.PictureBox kittyPicture;
        private System.Windows.Forms.ToolStripMenuItem underwaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem woodsToolStripMenuItem;
        private System.Windows.Forms.PictureBox rawrPicture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox whiteRawr;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Button glassesButton;
        private System.Windows.Forms.Button kittyRobesButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button robesButton;
        private System.Windows.Forms.Button hatButton;
        private System.Windows.Forms.ToolStripMenuItem togetherToolStripMenuItem;
    }
}

