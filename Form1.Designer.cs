namespace TradingCards
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
            this.playerList = new System.Windows.Forms.ListBox();
            this.lbl_playerList = new System.Windows.Forms.Label();
            this.cb_Team = new System.Windows.Forms.ComboBox();
            this.lbl_Team = new System.Windows.Forms.Label();
            this.cardFrame = new System.Windows.Forms.Panel();
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            this.lbl_PlayerTeam = new System.Windows.Forms.Label();
            this.rtb_Card = new System.Windows.Forms.RichTextBox();
            this.pb_PlayerImage = new System.Windows.Forms.PictureBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cardFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // playerList
            // 
            this.playerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.FormattingEnabled = true;
            this.playerList.ItemHeight = 41;
            this.playerList.Location = new System.Drawing.Point(47, 137);
            this.playerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(462, 453);
            this.playerList.TabIndex = 3;
            this.playerList.SelectedIndexChanged += new System.EventHandler(this.playerList_SelectedIndexChanged);
            // 
            // lbl_playerList
            // 
            this.lbl_playerList.AutoSize = true;
            this.lbl_playerList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerList.Location = new System.Drawing.Point(48, 95);
            this.lbl_playerList.Name = "lbl_playerList";
            this.lbl_playerList.Size = new System.Drawing.Size(170, 41);
            this.lbl_playerList.TabIndex = 4;
            this.lbl_playerList.Text = "Player List:";
            // 
            // cb_Team
            // 
            this.cb_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Team.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Team.FormattingEnabled = true;
            this.cb_Team.Items.AddRange(new object[] {
            "All"});
            this.cb_Team.Location = new System.Drawing.Point(260, 30);
            this.cb_Team.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Team.Name = "cb_Team";
            this.cb_Team.Size = new System.Drawing.Size(211, 40);
            this.cb_Team.TabIndex = 5;
            this.cb_Team.SelectedIndexChanged += new System.EventHandler(this.cb_Team_SelectedIndexChanged);
            // 
            // lbl_Team
            // 
            this.lbl_Team.AutoSize = true;
            this.lbl_Team.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team.Location = new System.Drawing.Point(48, 30);
            this.lbl_Team.Name = "lbl_Team";
            this.lbl_Team.Size = new System.Drawing.Size(192, 41);
            this.lbl_Team.TabIndex = 6;
            this.lbl_Team.Text = "Select Team:";
            // 
            // cardFrame
            // 
            this.cardFrame.BackgroundImage = global::TradingCards.Properties.Resources.cardBorder;
            this.cardFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardFrame.Controls.Add(this.lbl_PlayerName);
            this.cardFrame.Controls.Add(this.lbl_PlayerTeam);
            this.cardFrame.Controls.Add(this.rtb_Card);
            this.cardFrame.Controls.Add(this.pb_PlayerImage);
            this.cardFrame.Location = new System.Drawing.Point(583, 27);
            this.cardFrame.Margin = new System.Windows.Forms.Padding(4);
            this.cardFrame.Name = "cardFrame";
            this.cardFrame.Size = new System.Drawing.Size(501, 665);
            this.cardFrame.TabIndex = 2;
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerName.Location = new System.Drawing.Point(103, 62);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(214, 32);
            this.lbl_PlayerName.TabIndex = 2;
            this.lbl_PlayerName.Text = "<Player Name>";
            // 
            // lbl_PlayerTeam
            // 
            this.lbl_PlayerTeam.AutoSize = true;
            this.lbl_PlayerTeam.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerTeam.Location = new System.Drawing.Point(103, 12);
            this.lbl_PlayerTeam.Name = "lbl_PlayerTeam";
            this.lbl_PlayerTeam.Size = new System.Drawing.Size(293, 44);
            this.lbl_PlayerTeam.TabIndex = 4;
            this.lbl_PlayerTeam.Text = "<Player Team>";
            // 
            // rtb_Card
            // 
            this.rtb_Card.BackColor = System.Drawing.Color.White;
            this.rtb_Card.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Card.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Card.Location = new System.Drawing.Point(44, 469);
            this.rtb_Card.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_Card.Name = "rtb_Card";
            this.rtb_Card.ReadOnly = true;
            this.rtb_Card.Size = new System.Drawing.Size(403, 160);
            this.rtb_Card.TabIndex = 0;
            this.rtb_Card.TabStop = false;
            this.rtb_Card.Text = "";
            // 
            // pb_PlayerImage
            // 
            this.pb_PlayerImage.BackColor = System.Drawing.Color.White;
            this.pb_PlayerImage.Location = new System.Drawing.Point(44, 124);
            this.pb_PlayerImage.Margin = new System.Windows.Forms.Padding(4);
            this.pb_PlayerImage.Name = "pb_PlayerImage";
            this.pb_PlayerImage.Padding = new System.Windows.Forms.Padding(15);
            this.pb_PlayerImage.Size = new System.Drawing.Size(403, 346);
            this.pb_PlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PlayerImage.TabIndex = 1;
            this.pb_PlayerImage.TabStop = false;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(317, 633);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(192, 60);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(47, 633);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(215, 60);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TradingCards.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1589, 737);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.lbl_Team);
            this.Controls.Add(this.cb_Team);
            this.Controls.Add(this.lbl_playerList);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.cardFrame);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Trading Cards";
            this.cardFrame.ResumeLayout(false);
            this.cardFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Card;
        private System.Windows.Forms.PictureBox pb_PlayerImage;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.Label lbl_PlayerName;
        private System.Windows.Forms.Label lbl_PlayerTeam;
        private System.Windows.Forms.Panel cardFrame;
        private System.Windows.Forms.Label lbl_playerList;
        private System.Windows.Forms.ComboBox cb_Team;
        private System.Windows.Forms.Label lbl_Team;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
    }
}

