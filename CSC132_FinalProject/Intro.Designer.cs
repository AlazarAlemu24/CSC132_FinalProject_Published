
namespace CSC132_FinalProject
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.picbxCUlogo = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblinfoIntro = new System.Windows.Forms.Label();
            this.btncontinue = new System.Windows.Forms.Button();
            this.btnexitIntro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxCUlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxCUlogo
            // 
            this.picbxCUlogo.Image = ((System.Drawing.Image)(resources.GetObject("picbxCUlogo.Image")));
            this.picbxCUlogo.Location = new System.Drawing.Point(316, 12);
            this.picbxCUlogo.Name = "picbxCUlogo";
            this.picbxCUlogo.Size = new System.Drawing.Size(621, 285);
            this.picbxCUlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxCUlogo.TabIndex = 0;
            this.picbxCUlogo.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblWelcome.Location = new System.Drawing.Point(389, 316);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(255, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to CU plan app!";
            // 
            // lblinfoIntro
            // 
            this.lblinfoIntro.ForeColor = System.Drawing.Color.Black;
            this.lblinfoIntro.Location = new System.Drawing.Point(188, 374);
            this.lblinfoIntro.Name = "lblinfoIntro";
            this.lblinfoIntro.Size = new System.Drawing.Size(917, 281);
            this.lblinfoIntro.TabIndex = 2;
            this.lblinfoIntro.Text = resources.GetString("lblinfoIntro.Text");
            this.lblinfoIntro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btncontinue
            // 
            this.btncontinue.BackColor = System.Drawing.Color.Transparent;
            this.btncontinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncontinue.FlatAppearance.BorderSize = 0;
            this.btncontinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontinue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btncontinue.Location = new System.Drawing.Point(436, 548);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(285, 39);
            this.btncontinue.TabIndex = 3;
            this.btncontinue.Text = "Click to continue";
            this.btncontinue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncontinue.UseVisualStyleBackColor = false;
            // 
            // btnexitIntro
            // 
            this.btnexitIntro.FlatAppearance.BorderSize = 0;
            this.btnexitIntro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexitIntro.ForeColor = System.Drawing.Color.Red;
            this.btnexitIntro.Location = new System.Drawing.Point(991, 608);
            this.btnexitIntro.Name = "btnexitIntro";
            this.btnexitIntro.Size = new System.Drawing.Size(206, 75);
            this.btnexitIntro.TabIndex = 4;
            this.btnexitIntro.Text = "Exit";
            this.btnexitIntro.UseVisualStyleBackColor = true;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1205, 701);
            this.Controls.Add(this.btnexitIntro);
            this.Controls.Add(this.btncontinue);
            this.Controls.Add(this.lblinfoIntro);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.picbxCUlogo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Intro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxCUlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxCUlogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblinfoIntro;
        private System.Windows.Forms.Button btncontinue;
        private System.Windows.Forms.Button btnexitIntro;
    }
}

