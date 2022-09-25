namespace Multithreading {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bDancingProgressBars = new System.Windows.Forms.Button();
            this.nBars = new System.Windows.Forms.NumericUpDown();
            this.Hourse1 = new System.Windows.Forms.ProgressBar();
            this.Hourse2 = new System.Windows.Forms.ProgressBar();
            this.Hourse3 = new System.Windows.Forms.ProgressBar();
            this.Hourse4 = new System.Windows.Forms.ProgressBar();
            this.Hourse5 = new System.Windows.Forms.ProgressBar();
            this.bHourseRace = new System.Windows.Forms.Button();
            this.gbHourse = new System.Windows.Forms.GroupBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.bFibonacci = new System.Windows.Forms.Button();
            this.lbFibonacci = new System.Windows.Forms.ListBox();
            this.lMax = new System.Windows.Forms.Label();
            this.nMaxFibo = new System.Windows.Forms.NumericUpDown();
            this.bFile = new System.Windows.Forms.Button();
            this.bDir = new System.Windows.Forms.Button();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nBars)).BeginInit();
            this.gbHourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxFibo)).BeginInit();
            this.SuspendLayout();
            // 
            // bDancingProgressBars
            // 
            this.bDancingProgressBars.Location = new System.Drawing.Point(139, 10);
            this.bDancingProgressBars.Name = "bDancingProgressBars";
            this.bDancingProgressBars.Size = new System.Drawing.Size(365, 23);
            this.bDancingProgressBars.TabIndex = 0;
            this.bDancingProgressBars.Text = "Dancing Progress Bars";
            this.bDancingProgressBars.UseVisualStyleBackColor = true;
            this.bDancingProgressBars.Click += new System.EventHandler(this.bDancingProgressBars_Click);
            // 
            // nBars
            // 
            this.nBars.Location = new System.Drawing.Point(13, 13);
            this.nBars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nBars.Name = "nBars";
            this.nBars.Size = new System.Drawing.Size(120, 20);
            this.nBars.TabIndex = 1;
            this.nBars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Hourse1
            // 
            this.Hourse1.Location = new System.Drawing.Point(6, 19);
            this.Hourse1.Name = "Hourse1";
            this.Hourse1.Size = new System.Drawing.Size(479, 23);
            this.Hourse1.TabIndex = 2;
            // 
            // Hourse2
            // 
            this.Hourse2.Location = new System.Drawing.Point(6, 48);
            this.Hourse2.Name = "Hourse2";
            this.Hourse2.Size = new System.Drawing.Size(479, 23);
            this.Hourse2.TabIndex = 2;
            // 
            // Hourse3
            // 
            this.Hourse3.Location = new System.Drawing.Point(6, 77);
            this.Hourse3.Name = "Hourse3";
            this.Hourse3.Size = new System.Drawing.Size(479, 23);
            this.Hourse3.TabIndex = 2;
            // 
            // Hourse4
            // 
            this.Hourse4.Location = new System.Drawing.Point(6, 106);
            this.Hourse4.Name = "Hourse4";
            this.Hourse4.Size = new System.Drawing.Size(479, 23);
            this.Hourse4.TabIndex = 2;
            // 
            // Hourse5
            // 
            this.Hourse5.Location = new System.Drawing.Point(6, 135);
            this.Hourse5.Name = "Hourse5";
            this.Hourse5.Size = new System.Drawing.Size(479, 23);
            this.Hourse5.TabIndex = 2;
            // 
            // bHourseRace
            // 
            this.bHourseRace.Location = new System.Drawing.Point(13, 59);
            this.bHourseRace.Name = "bHourseRace";
            this.bHourseRace.Size = new System.Drawing.Size(491, 23);
            this.bHourseRace.TabIndex = 0;
            this.bHourseRace.Text = "Start";
            this.bHourseRace.UseVisualStyleBackColor = true;
            this.bHourseRace.Click += new System.EventHandler(this.bHourseRace_Click);
            // 
            // gbHourse
            // 
            this.gbHourse.Controls.Add(this.Hourse1);
            this.gbHourse.Controls.Add(this.Hourse5);
            this.gbHourse.Controls.Add(this.Hourse2);
            this.gbHourse.Controls.Add(this.Hourse4);
            this.gbHourse.Controls.Add(this.Hourse3);
            this.gbHourse.Location = new System.Drawing.Point(13, 88);
            this.gbHourse.Name = "gbHourse";
            this.gbHourse.Size = new System.Drawing.Size(491, 174);
            this.gbHourse.TabIndex = 3;
            this.gbHourse.TabStop = false;
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(12, 268);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(486, 69);
            this.lbResults.TabIndex = 4;
            // 
            // bFibonacci
            // 
            this.bFibonacci.Location = new System.Drawing.Point(12, 351);
            this.bFibonacci.Name = "bFibonacci";
            this.bFibonacci.Size = new System.Drawing.Size(289, 23);
            this.bFibonacci.TabIndex = 5;
            this.bFibonacci.Text = "Fibonacci";
            this.bFibonacci.UseVisualStyleBackColor = true;
            this.bFibonacci.Click += new System.EventHandler(this.bFibonacci_Click);
            // 
            // lbFibonacci
            // 
            this.lbFibonacci.FormattingEnabled = true;
            this.lbFibonacci.Location = new System.Drawing.Point(12, 383);
            this.lbFibonacci.Name = "lbFibonacci";
            this.lbFibonacci.Size = new System.Drawing.Size(486, 160);
            this.lbFibonacci.TabIndex = 6;
            // 
            // lMax
            // 
            this.lMax.AutoSize = true;
            this.lMax.Location = new System.Drawing.Point(307, 356);
            this.lMax.Name = "lMax";
            this.lMax.Size = new System.Drawing.Size(30, 13);
            this.lMax.TabIndex = 7;
            this.lMax.Text = "Max:";
            // 
            // nMaxFibo
            // 
            this.nMaxFibo.Location = new System.Drawing.Point(343, 354);
            this.nMaxFibo.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.nMaxFibo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxFibo.Name = "nMaxFibo";
            this.nMaxFibo.Size = new System.Drawing.Size(155, 20);
            this.nMaxFibo.TabIndex = 1;
            this.nMaxFibo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bFile
            // 
            this.bFile.Location = new System.Drawing.Point(510, 38);
            this.bFile.Name = "bFile";
            this.bFile.Size = new System.Drawing.Size(355, 23);
            this.bFile.TabIndex = 8;
            this.bFile.Text = "How many words in a file";
            this.bFile.UseVisualStyleBackColor = true;
            this.bFile.Click += new System.EventHandler(this.bOpenFileDialog);
            // 
            // bDir
            // 
            this.bDir.Location = new System.Drawing.Point(510, 67);
            this.bDir.Name = "bDir";
            this.bDir.Size = new System.Drawing.Size(355, 23);
            this.bDir.TabIndex = 8;
            this.bDir.Text = "How many words in a direction";
            this.bDir.UseVisualStyleBackColor = true;
            this.bDir.Click += new System.EventHandler(this.bDir_Click);
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(552, 12);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(313, 20);
            this.tbWord.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Word:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 554);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.bDir);
            this.Controls.Add(this.bFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lMax);
            this.Controls.Add(this.lbFibonacci);
            this.Controls.Add(this.bFibonacci);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.gbHourse);
            this.Controls.Add(this.nMaxFibo);
            this.Controls.Add(this.nBars);
            this.Controls.Add(this.bHourseRace);
            this.Controls.Add(this.bDancingProgressBars);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nBars)).EndInit();
            this.gbHourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nMaxFibo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDancingProgressBars;
        private System.Windows.Forms.NumericUpDown nBars;
        private System.Windows.Forms.ProgressBar Hourse1;
        private System.Windows.Forms.ProgressBar Hourse2;
        private System.Windows.Forms.ProgressBar Hourse3;
        private System.Windows.Forms.ProgressBar Hourse4;
        private System.Windows.Forms.ProgressBar Hourse5;
        private System.Windows.Forms.Button bHourseRace;
        private System.Windows.Forms.GroupBox gbHourse;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button bFibonacci;
        private System.Windows.Forms.ListBox lbFibonacci;
        private System.Windows.Forms.Label lMax;
        private System.Windows.Forms.NumericUpDown nMaxFibo;
        private System.Windows.Forms.Button bFile;
        private System.Windows.Forms.Button bDir;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Label label1;
    }
}

