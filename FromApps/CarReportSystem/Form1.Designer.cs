namespace CarReportSystem {
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
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbAuther = new ComboBox();
            rbToyota = new RadioButton();
            groupBox1 = new GroupBox();
            cbCarName = new ComboBox();
            label6 = new Label();
            btPicOpen = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            rbNissan = new RadioButton();
            rbHonda = new RadioButton();
            rbSubaru = new RadioButton();
            rbImport = new RadioButton();
            rbOther = new RadioButton();
            label7 = new Label();
            dgvCarReport = new DataGridView();
            tbReport = new TextBox();
            btAddReport = new Button();
            btDeleteReport = new Button();
            btReportOpen = new Button();
            btReportSave = new Button();
            btModfyReport = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14F);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "日付:";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14F);
            dtpDate.Location = new Point(90, 5);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(191, 32);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14F);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 0;
            label2.Text = "記録者:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14F);
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14F);
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14F);
            label5.Location = new Point(12, 167);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // cbAuther
            // 
            cbAuther.Font = new Font("Yu Gothic UI", 14F);
            cbAuther.FormattingEnabled = true;
            cbAuther.Location = new Point(91, 49);
            cbAuther.Name = "cbAuther";
            cbAuther.Size = new Size(272, 33);
            cbAuther.TabIndex = 2;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 17);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 3;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(90, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 40);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14F);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(90, 127);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(273, 33);
            cbCarName.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14F);
            label6.Location = new Point(514, 10);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 0;
            label6.Text = "画像";
            // 
            // btPicOpen
            // 
            btPicOpen.Location = new Point(593, 11);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(75, 23);
            btPicOpen.TabIndex = 5;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = true;
            // 
            // btPicDelete
            // 
            btPicDelete.Location = new Point(683, 11);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 5;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.FromArgb(192, 192, 255);
            pbPicture.Location = new Point(545, 40);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(213, 186);
            pbPicture.TabIndex = 6;
            pbPicture.TabStop = false;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(62, 17);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 3;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(117, 17);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 3;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(176, 16);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 3;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(236, 17);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 3;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(303, 17);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 3;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14F);
            label7.Location = new Point(16, 277);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 0;
            label7.Text = "一覧";
            // 
            // dgvCarReport
            // 
            dgvCarReport.AllowUserToAddRows = false;
            dgvCarReport.AllowUserToDeleteRows = false;
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(85, 277);
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.ReadOnly = true;
            dgvCarReport.Size = new Size(673, 150);
            dgvCarReport.TabIndex = 7;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(85, 172);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(444, 99);
            tbReport.TabIndex = 9;
            // 
            // btAddReport
            // 
            btAddReport.Font = new Font("Yu Gothic UI", 12F);
            btAddReport.Location = new Point(545, 232);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(57, 39);
            btAddReport.TabIndex = 10;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = true;
            // 
            // btDeleteReport
            // 
            btDeleteReport.Font = new Font("Yu Gothic UI", 12F);
            btDeleteReport.Location = new Point(707, 232);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(57, 39);
            btDeleteReport.TabIndex = 11;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = true;
            // 
            // btReportOpen
            // 
            btReportOpen.Font = new Font("Yu Gothic UI", 14F);
            btReportOpen.Location = new Point(12, 340);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(68, 40);
            btReportOpen.TabIndex = 12;
            btReportOpen.Text = "開く...";
            btReportOpen.UseVisualStyleBackColor = true;
            // 
            // btReportSave
            // 
            btReportSave.Font = new Font("Yu Gothic UI", 14F);
            btReportSave.Location = new Point(12, 386);
            btReportSave.Name = "btReportSave";
            btReportSave.Size = new Size(68, 40);
            btReportSave.TabIndex = 13;
            btReportSave.Text = "保存..";
            btReportSave.UseVisualStyleBackColor = true;
            // 
            // btModfyReport
            // 
            btModfyReport.Font = new Font("Yu Gothic UI", 12F);
            btModfyReport.Location = new Point(626, 232);
            btModfyReport.Name = "btModfyReport";
            btModfyReport.Size = new Size(57, 39);
            btModfyReport.TabIndex = 10;
            btModfyReport.Text = "修正";
            btModfyReport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btReportSave);
            Controls.Add(btReportOpen);
            Controls.Add(btDeleteReport);
            Controls.Add(btModfyReport);
            Controls.Add(btAddReport);
            Controls.Add(tbReport);
            Controls.Add(dgvCarReport);
            Controls.Add(pbPicture);
            Controls.Add(btPicDelete);
            Controls.Add(btPicOpen);
            Controls.Add(groupBox1);
            Controls.Add(cbCarName);
            Controls.Add(cbAuther);
            Controls.Add(dtpDate);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "Form1";
            Text = "試乗レポート管理システム";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbAuther;
        private RadioButton rbToyota;
        private GroupBox groupBox1;
        private ComboBox cbCarName;
        private Label label6;
        private Button btPicOpen;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbOther;
        private Label label7;
        private DataGridView dgvCarReport;
        private TextBox tbReport;
        private Button btAddReport;
        private Button btDeleteReport;
        private Button btReportOpen;
        private Button btReportSave;
        private Button btModfyReport;
    }
}
