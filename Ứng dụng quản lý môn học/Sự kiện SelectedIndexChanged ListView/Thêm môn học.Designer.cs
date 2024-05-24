namespace Sự_kiện_SelectedIndexChanged_ListView
{
    partial class Thêm_môn_học
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mon = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tín chỉ:";
            // 
            // txt_mon
            // 
            this.txt_mon.Location = new System.Drawing.Point(109, 54);
            this.txt_mon.Name = "txt_mon";
            this.txt_mon.Size = new System.Drawing.Size(265, 30);
            this.txt_mon.TabIndex = 2;
            this.txt_mon.TextChanged += new System.EventHandler(this.txt_mon_TextChanged);
            this.txt_mon.Enter += new System.EventHandler(this.txt_mon_Enter);
            this.txt_mon.Leave += new System.EventHandler(this.txt_mon_Leave);
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(109, 104);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(265, 30);
            this.txt_tc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thêm Môn Học:";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(109, 140);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(100, 45);
            this.bt_them.TabIndex = 5;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Thêm_môn_học
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.txt_mon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Thêm_môn_học";
            this.Text = "Thêm_môn_học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mon;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button button2;
    }
}