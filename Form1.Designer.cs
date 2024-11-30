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
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Card
            // 
            this.rtb_Card.Location = new System.Drawing.Point(97, 363);
            this.rtb_Card.Name = "rtb_Card";
            this.rtb_Card.Size = new System.Drawing.Size(152, 125);
            this.rtb_Card.TabIndex = 0;
            this.rtb_Card.Text = "";
            // 
            // pb_PlayerImage
            // 
            this.pb_PlayerImage.Location = new System.Drawing.Point(29, 22);
            this.pb_PlayerImage.Name = "pb_PlayerImage";
            this.pb_PlayerImage.Size = new System.Drawing.Size(296, 335);
            this.pb_PlayerImage.TabIndex = 1;
            this.pb_PlayerImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_PlayerImage);
            this.panel1.Controls.Add(this.rtb_Card);
            this.panel1.Location = new System.Drawing.Point(518, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 506);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayerImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Card;
        private System.Windows.Forms.PictureBox pb_PlayerImage;
        private System.Windows.Forms.Panel panel1;
    }
}

