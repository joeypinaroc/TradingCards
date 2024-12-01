namespace TradingCards
{
    partial class Add_Player
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Team = new System.Windows.Forms.Label();
            this.lbl_PPG = new System.Windows.Forms.Label();
            this.lbl_RPG = new System.Windows.Forms.Label();
            this.lbl_APG = new System.Windows.Forms.Label();
            this.lbl_FG = new System.Windows.Forms.Label();
            this.lbl_3P = new System.Windows.Forms.Label();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Team = new System.Windows.Forms.TextBox();
            this.num_PPG = new System.Windows.Forms.NumericUpDown();
            this.num_RPG = new System.Windows.Forms.NumericUpDown();
            this.num_APG = new System.Windows.Forms.NumericUpDown();
            this.num_FG = new System.Windows.Forms.NumericUpDown();
            this.num_3P = new System.Windows.Forms.NumericUpDown();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_PPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_APG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_FG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_3P)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(246, 36);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(109, 41);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Name:";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Team
            // 
            this.lbl_Team.AutoSize = true;
            this.lbl_Team.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team.Location = new System.Drawing.Point(255, 86);
            this.lbl_Team.Name = "lbl_Team";
            this.lbl_Team.Size = new System.Drawing.Size(100, 41);
            this.lbl_Team.TabIndex = 8;
            this.lbl_Team.Text = "Team:";
            this.lbl_Team.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PPG
            // 
            this.lbl_PPG.AutoSize = true;
            this.lbl_PPG.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PPG.Location = new System.Drawing.Point(155, 139);
            this.lbl_PPG.Name = "lbl_PPG";
            this.lbl_PPG.Size = new System.Drawing.Size(200, 41);
            this.lbl_PPG.TabIndex = 9;
            this.lbl_PPG.Text = "Points (PPG):";
            this.lbl_PPG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_RPG
            // 
            this.lbl_RPG.AutoSize = true;
            this.lbl_RPG.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RPG.Location = new System.Drawing.Point(100, 189);
            this.lbl_RPG.Name = "lbl_RPG";
            this.lbl_RPG.Size = new System.Drawing.Size(255, 41);
            this.lbl_RPG.TabIndex = 10;
            this.lbl_RPG.Text = "Rebounds (RPG):";
            this.lbl_RPG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_APG
            // 
            this.lbl_APG.AutoSize = true;
            this.lbl_APG.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_APG.Location = new System.Drawing.Point(158, 239);
            this.lbl_APG.Name = "lbl_APG";
            this.lbl_APG.Size = new System.Drawing.Size(197, 41);
            this.lbl_APG.TabIndex = 11;
            this.lbl_APG.Text = "Assist (APG):";
            // 
            // lbl_FG
            // 
            this.lbl_FG.AutoSize = true;
            this.lbl_FG.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FG.Location = new System.Drawing.Point(95, 289);
            this.lbl_FG.Name = "lbl_FG";
            this.lbl_FG.Size = new System.Drawing.Size(260, 41);
            this.lbl_FG.TabIndex = 12;
            this.lbl_FG.Text = "Field Goal (FG%):";
            this.lbl_FG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_3P
            // 
            this.lbl_3P.AutoSize = true;
            this.lbl_3P.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3P.Location = new System.Drawing.Point(122, 339);
            this.lbl_3P.Name = "lbl_3P";
            this.lbl_3P.Size = new System.Drawing.Size(233, 41);
            this.lbl_3P.TabIndex = 13;
            this.lbl_3P.Text = "3-Points (3P%):";
            this.lbl_3P.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_Name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Name.Location = new System.Drawing.Point(375, 38);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(329, 38);
            this.txtbox_Name.TabIndex = 15;
            // 
            // txtBox_Team
            // 
            this.txtBox_Team.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Team.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Team.Location = new System.Drawing.Point(375, 88);
            this.txtBox_Team.Name = "txtBox_Team";
            this.txtBox_Team.Size = new System.Drawing.Size(329, 38);
            this.txtBox_Team.TabIndex = 16;
            // 
            // num_PPG
            // 
            this.num_PPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_PPG.Location = new System.Drawing.Point(375, 141);
            this.num_PPG.Name = "num_PPG";
            this.num_PPG.Size = new System.Drawing.Size(100, 38);
            this.num_PPG.TabIndex = 17;
            // 
            // num_RPG
            // 
            this.num_RPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_RPG.Location = new System.Drawing.Point(375, 191);
            this.num_RPG.Name = "num_RPG";
            this.num_RPG.Size = new System.Drawing.Size(100, 38);
            this.num_RPG.TabIndex = 18;
            // 
            // num_APG
            // 
            this.num_APG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_APG.Location = new System.Drawing.Point(375, 241);
            this.num_APG.Name = "num_APG";
            this.num_APG.Size = new System.Drawing.Size(100, 38);
            this.num_APG.TabIndex = 19;
            // 
            // num_FG
            // 
            this.num_FG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_FG.Location = new System.Drawing.Point(375, 291);
            this.num_FG.Name = "num_FG";
            this.num_FG.Size = new System.Drawing.Size(100, 38);
            this.num_FG.TabIndex = 20;
            // 
            // num_3P
            // 
            this.num_3P.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_3P.Location = new System.Drawing.Point(375, 341);
            this.num_3P.Name = "num_3P";
            this.num_3P.Size = new System.Drawing.Size(100, 38);
            this.num_3P.TabIndex = 21;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(165, 411);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(193, 60);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Add Player";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(367, 411);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(193, 60);
            this.btn_Cancel.TabIndex = 23;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click_1);
            // 
            // Add_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TradingCards.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 509);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.num_3P);
            this.Controls.Add(this.num_FG);
            this.Controls.Add(this.num_APG);
            this.Controls.Add(this.num_RPG);
            this.Controls.Add(this.num_PPG);
            this.Controls.Add(this.txtBox_Team);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.lbl_3P);
            this.Controls.Add(this.lbl_FG);
            this.Controls.Add(this.lbl_APG);
            this.Controls.Add(this.lbl_RPG);
            this.Controls.Add(this.lbl_PPG);
            this.Controls.Add(this.lbl_Team);
            this.Controls.Add(this.lbl_Name);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Player";
            ((System.ComponentModel.ISupportInitialize)(this.num_PPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_APG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_FG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_3P)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Team;
        private System.Windows.Forms.Label lbl_PPG;
        private System.Windows.Forms.Label lbl_RPG;
        private System.Windows.Forms.Label lbl_APG;
        private System.Windows.Forms.Label lbl_FG;
        private System.Windows.Forms.Label lbl_3P;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtBox_Team;
        private System.Windows.Forms.NumericUpDown num_PPG;
        private System.Windows.Forms.NumericUpDown num_RPG;
        private System.Windows.Forms.NumericUpDown num_APG;
        private System.Windows.Forms.NumericUpDown num_FG;
        private System.Windows.Forms.NumericUpDown num_3P;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
    }
}