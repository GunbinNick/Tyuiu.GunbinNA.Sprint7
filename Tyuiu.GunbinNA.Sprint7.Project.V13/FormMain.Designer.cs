﻿
namespace Tyuiu.GunbinNA.Sprint7.Project.V13
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.textBoxEcoClass = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.toolTipNotice = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxDel = new System.Windows.Forms.TextBox();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(1234, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(35, 35);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Lime;
            this.panelButtons.Controls.Add(this.buttonInfo);
            this.panelButtons.Controls.Add(this.buttonHelp);
            this.panelButtons.Controls.Add(this.buttonNotes);
            this.panelButtons.Controls.Add(this.buttonStats);
            this.panelButtons.Controls.Add(this.panel1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(313, 693);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Lime;
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonInfo.Location = new System.Drawing.Point(0, 375);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(313, 71);
            this.buttonInfo.TabIndex = 1;
            this.buttonInfo.Text = "О нас";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Lime;
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonHelp.Location = new System.Drawing.Point(0, 304);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(313, 71);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.BackColor = System.Drawing.Color.Lime;
            this.buttonNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNotes.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonNotes.Location = new System.Drawing.Point(0, 233);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(313, 71);
            this.buttonNotes.TabIndex = 1;
            this.buttonNotes.Text = "Примечания";
            this.toolTipNotice.SetToolTip(this.buttonNotes, "Расширенное описание стран из файла от разработчика\r\n");
            this.buttonNotes.UseVisualStyleBackColor = false;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.BackColor = System.Drawing.Color.Lime;
            this.buttonStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStats.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonStats.Location = new System.Drawing.Point(0, 162);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(313, 71);
            this.buttonStats.TabIndex = 1;
            this.buttonStats.Text = "Статистика";
            this.buttonStats.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 162);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.MinimumSize = new System.Drawing.Size(265, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "TyuiuGeoGraphics";
            // 
            // buttonMusic
            // 
            this.buttonMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMusic.BackgroundImage")));
            this.buttonMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMusic.Location = new System.Drawing.Point(1234, 66);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(35, 35);
            this.buttonMusic.TabIndex = 2;
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(706, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(563, 399);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(464, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(357, 185);
            this.textBoxCountry.Multiline = true;
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 26);
            this.textBoxCountry.TabIndex = 5;
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(357, 253);
            this.textBoxCapital.Multiline = true;
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(100, 26);
            this.textBoxCapital.TabIndex = 5;
            // 
            // textBoxEcoClass
            // 
            this.textBoxEcoClass.Location = new System.Drawing.Point(357, 327);
            this.textBoxEcoClass.Multiline = true;
            this.textBoxEcoClass.Name = "textBoxEcoClass";
            this.textBoxEcoClass.Size = new System.Drawing.Size(100, 26);
            this.textBoxEcoClass.TabIndex = 5;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(357, 387);
            this.textBoxS.Multiline = true;
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(100, 26);
            this.textBoxS.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(982, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipNotice
            // 
            this.toolTipNotice.IsBalloon = true;
            this.toolTipNotice.ToolTipTitle = "Подсказка";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(780, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxDel
            // 
            this.textBoxDel.Location = new System.Drawing.Point(423, 66);
            this.textBoxDel.Multiline = true;
            this.textBoxDel.Name = "textBoxDel";
            this.textBoxDel.Size = new System.Drawing.Size(100, 26);
            this.textBoxDel.TabIndex = 5;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(319, 519);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(381, 60);
            this.buttonLoadFile.TabIndex = 8;
            this.buttonLoadFile.Text = "Открыть";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(319, 600);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(381, 60);
            this.buttonSaveFile.TabIndex = 8;
            this.buttonSaveFile.Text = "Сохранить";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // textBoxSort
            // 
            this.textBoxSort.Location = new System.Drawing.Point(612, 70);
            this.textBoxSort.Multiline = true;
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(100, 26);
            this.textBoxSort.TabIndex = 5;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(550, 327);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(119, 57);
            this.buttonSort.TabIndex = 9;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(706, 222);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(155, 28);
            this.textBoxSearch.TabIndex = 10;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.Location = new System.Drawing.Point(867, 221);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(31, 29);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1277, 693);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxEcoClass);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.textBoxSort);
            this.Controls.Add(this.textBoxDel);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.TextBox textBoxEcoClass;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipNotice;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxDel;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}

