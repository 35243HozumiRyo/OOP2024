namespace Exercise01 {
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
            btEx = new Button();
            button1 = new Button();
            tbDisp = new TextBox();
            SuspendLayout();
            // 
            // btEx
            // 
            btEx.FlatStyle = FlatStyle.System;
            btEx.Font = new Font("Yu Gothic UI", 18F);
            btEx.Location = new Point(106, 64);
            btEx.Name = "btEx";
            btEx.Size = new Size(103, 44);
            btEx.TabIndex = 0;
            btEx.Text = "問題8.1";
            btEx.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 18F);
            button1.Location = new Point(106, 119);
            button1.Name = "button1";
            button1.Size = new Size(103, 44);
            button1.TabIndex = 0;
            button1.Text = "問題8.2";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbDisp
            // 
            tbDisp.Location = new Point(106, 224);
            tbDisp.Multiline = true;
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(656, 193);
            tbDisp.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbDisp);
            Controls.Add(button1);
            Controls.Add(btEx);
            Enabled = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEx;
        private Button button1;
        private TextBox tbDisp;
    }
}
