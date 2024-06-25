namespace DateTimeApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpBirthday = new DateTimePicker();
            dtDateCount = new Button();
            dtDisp = new TextBox();
            nudDay = new NumericUpDown();
            btDayBefore = new Button();
            btDayAfter = new Button();
            btAge = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(98, 60);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            label1.Click += label1_Click;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Yu Gothic UI", 18F);
            dtpBirthday.Location = new Point(204, 60);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 39);
            dtpBirthday.TabIndex = 1;
            // 
            // dtDateCount
            // 
            dtDateCount.Location = new Point(277, 121);
            dtDateCount.Name = "dtDateCount";
            dtDateCount.Size = new Size(127, 62);
            dtDateCount.TabIndex = 2;
            dtDateCount.Text = "今日までのに日数";
            dtDateCount.UseVisualStyleBackColor = true;
            dtDateCount.Click += dtDateCount_Click;
            // 
            // dtDisp
            // 
            dtDisp.Font = new Font("Yu Gothic UI", 18F);
            dtDisp.Location = new Point(88, 288);
            dtDisp.Name = "dtDisp";
            dtDisp.Size = new Size(297, 39);
            dtDisp.TabIndex = 3;
            dtDisp.TextChanged += dtDisp_TextChanged;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 22F);
            nudDay.Location = new Point(88, 190);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 47);
            nudDay.TabIndex = 4;
            // 
            // btDayBefore
            // 
            btDayBefore.Font = new Font("Yu Gothic UI", 18F);
            btDayBefore.Location = new Point(277, 194);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(127, 41);
            btDayBefore.TabIndex = 5;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBefore_Click;
            // 
            // btDayAfter
            // 
            btDayAfter.Font = new Font("Yu Gothic UI", 18F);
            btDayAfter.Location = new Point(435, 194);
            btDayAfter.Name = "btDayAfter";
            btDayAfter.Size = new Size(127, 41);
            btDayAfter.TabIndex = 5;
            btDayAfter.Text = "日後";
            btDayAfter.UseVisualStyleBackColor = true;
            btDayAfter.Click += button1_Click;
            // 
            // btAge
            // 
            btAge.Font = new Font("Yu Gothic UI", 18F);
            btAge.Location = new Point(435, 121);
            btAge.Name = "btAge";
            btAge.Size = new Size(127, 42);
            btAge.TabIndex = 6;
            btAge.Text = "年齢";
            btAge.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btAge);
            Controls.Add(btDayAfter);
            Controls.Add(btDayBefore);
            Controls.Add(nudDay);
            Controls.Add(dtDisp);
            Controls.Add(dtDateCount);
            Controls.Add(dtpBirthday);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpBirthday;
        private Button dtDateCount;
        private TextBox dtDisp;
        private NumericUpDown nudDay;
        private Button btDayBefore;
        private Button btDayAfter;
        private Button btAge;
    }
}
