namespace Section03 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.bt16_6 = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.StatusStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt16_6
            // 
            this.bt16_6.Location = new System.Drawing.Point(27, 29);
            this.bt16_6.Name = "bt16_6";
            this.bt16_6.Size = new System.Drawing.Size(563, 33);
            this.bt16_6.TabIndex = 0;
            this.bt16_6.Text = "イベントハンドラを非同期にする(1)";
            this.bt16_6.UseVisualStyleBackColor = true;
            this.bt16_6.Click += new System.EventHandler(this.bt16_6_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(0, 428);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(800, 22);
            this.toolStripStatusLabel1.TabIndex = 1;
            this.toolStripStatusLabel1.Text = "statusStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(563, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStripStatusLabel1);
            this.Controls.Add(this.bt16_6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt16_6;
        private System.Windows.Forms.StatusStrip toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
    }
}

