
namespace Tyuiu.GunbinNA.Sprint7.Project.V13
{
    partial class FormAbout_GNA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_GNA));
            this.pictureBoxAva_GNA = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_GNA = new System.Windows.Forms.TextBox();
            this.buttonExit_GNA = new System.Windows.Forms.Button();
            this.labelAbout_GNA = new System.Windows.Forms.Label();
            this.labelCompany_GNA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_GNA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAva_GNA
            // 
            this.pictureBoxAva_GNA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_GNA.Image")));
            this.pictureBoxAva_GNA.Location = new System.Drawing.Point(12, 90);
            this.pictureBoxAva_GNA.Name = "pictureBoxAva_GNA";
            this.pictureBoxAva_GNA.Size = new System.Drawing.Size(357, 443);
            this.pictureBoxAva_GNA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAva_GNA.TabIndex = 0;
            this.pictureBoxAva_GNA.TabStop = false;
            // 
            // textBoxInfo_GNA
            // 
            this.textBoxInfo_GNA.BackColor = System.Drawing.Color.Green;
            this.textBoxInfo_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_GNA.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo_GNA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxInfo_GNA.Location = new System.Drawing.Point(375, 90);
            this.textBoxInfo_GNA.Multiline = true;
            this.textBoxInfo_GNA.Name = "textBoxInfo_GNA";
            this.textBoxInfo_GNA.ReadOnly = true;
            this.textBoxInfo_GNA.Size = new System.Drawing.Size(553, 443);
            this.textBoxInfo_GNA.TabIndex = 1;
            this.textBoxInfo_GNA.TabStop = false;
            this.textBoxInfo_GNA.Text = resources.GetString("textBoxInfo_GNA.Text");
            // 
            // buttonExit_GNA
            // 
            this.buttonExit_GNA.BackColor = System.Drawing.Color.Lime;
            this.buttonExit_GNA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit_GNA.Location = new System.Drawing.Point(-13, 539);
            this.buttonExit_GNA.Name = "buttonExit_GNA";
            this.buttonExit_GNA.Size = new System.Drawing.Size(957, 34);
            this.buttonExit_GNA.TabIndex = 2;
            this.buttonExit_GNA.TabStop = false;
            this.buttonExit_GNA.Text = "閉じる";
            this.buttonExit_GNA.UseVisualStyleBackColor = false;
            this.buttonExit_GNA.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAbout_GNA
            // 
            this.labelAbout_GNA.AutoSize = true;
            this.labelAbout_GNA.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout_GNA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelAbout_GNA.Location = new System.Drawing.Point(375, 12);
            this.labelAbout_GNA.MinimumSize = new System.Drawing.Size(250, 80);
            this.labelAbout_GNA.Name = "labelAbout_GNA";
            this.labelAbout_GNA.Size = new System.Drawing.Size(250, 80);
            this.labelAbout_GNA.TabIndex = 3;
            this.labelAbout_GNA.Text = "About Uss";
            // 
            // labelCompany_GNA
            // 
            this.labelCompany_GNA.AutoSize = true;
            this.labelCompany_GNA.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompany_GNA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelCompany_GNA.Location = new System.Drawing.Point(12, 9);
            this.labelCompany_GNA.MinimumSize = new System.Drawing.Size(300, 75);
            this.labelCompany_GNA.Name = "labelCompany_GNA";
            this.labelCompany_GNA.Size = new System.Drawing.Size(300, 75);
            this.labelCompany_GNA.TabIndex = 4;
            this.labelCompany_GNA.Text = "TyuiuGeoGraphics";
            // 
            // FormAbout_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(934, 570);
            this.Controls.Add(this.labelCompany_GNA);
            this.Controls.Add(this.labelAbout_GNA);
            this.Controls.Add(this.buttonExit_GNA);
            this.Controls.Add(this.textBoxInfo_GNA);
            this.Controls.Add(this.pictureBoxAva_GNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О нас";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_GNA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAva_GNA;
        private System.Windows.Forms.TextBox textBoxInfo_GNA;
        private System.Windows.Forms.Button buttonExit_GNA;
        private System.Windows.Forms.Label labelAbout_GNA;
        private System.Windows.Forms.Label labelCompany_GNA;
    }
}