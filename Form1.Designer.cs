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
            this.rtb_Card = new System.Windows.Forms.RichTextBox();
            this.pb_PlayerImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerList = new System.Windows.Forms.ListBox();
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            this.lbl_PlayerTeam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Card
            // 
            this.rtb_Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtb_Card.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Card.Location = new System.Drawing.Point(33, 424);
            this.rtb_Card.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_Card.Name = "rtb_Card";
            this.rtb_Card.ReadOnly = true;
            this.rtb_Card.Size = new System.Drawing.Size(385, 153);
            this.rtb_Card.TabIndex = 0;
            this.rtb_Card.TabStop = false;
            this.rtb_Card.Text = "";
            // 
            // pb_PlayerImage
            // 
            this.pb_PlayerImage.BackColor = System.Drawing.Color.DimGray;
            this.pb_PlayerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_PlayerImage.Location = new System.Drawing.Point(23, 4);
            this.pb_PlayerImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_PlayerImage.Name = "pb_PlayerImage";
            this.pb_PlayerImage.Size = new System.Drawing.Size(395, 415);
            this.pb_PlayerImage.TabIndex = 1;
            this.pb_PlayerImage.TabStop = false;
            this.pb_PlayerImage.Click += new System.EventHandler(this.pb_PlayerImage_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pb_PlayerImage);
            this.panel1.Controls.Add(this.rtb_Card);
            this.panel1.Location = new System.Drawing.Point(575, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 609);
            this.panel1.TabIndex = 2;
            // 
            // playerList
            // 
            this.playerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.FormattingEnabled = true;
            this.playerList.ItemHeight = 36;
            this.playerList.Location = new System.Drawing.Point(35, 148);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(462, 398);
            this.playerList.TabIndex = 3;
            this.playerList.SelectedIndexChanged += new System.EventHandler(this.playerList_SelectedIndexChanged);
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerName.Location = new System.Drawing.Point(579, 112);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(296, 46);
            this.lbl_PlayerName.TabIndex = 2;
            this.lbl_PlayerName.Text = "<Player Name>";
            // 
            // lbl_PlayerTeam
            // 
            this.lbl_PlayerTeam.AutoSize = true;
            this.lbl_PlayerTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerTeam.Location = new System.Drawing.Point(579, 55);
            this.lbl_PlayerTeam.Name = "lbl_PlayerTeam";
            this.lbl_PlayerTeam.Size = new System.Drawing.Size(291, 46);
            this.lbl_PlayerTeam.TabIndex = 4;
            this.lbl_PlayerTeam.Text = "<Player Team>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 838);
            this.Controls.Add(this.lbl_PlayerTeam);
            this.Controls.Add(this.lbl_PlayerName);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "NBA Trading Cards";
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Card;
        private System.Windows.Forms.PictureBox pb_PlayerImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.Label lbl_PlayerName;
        private System.Windows.Forms.Label lbl_PlayerTeam;
    }
}

