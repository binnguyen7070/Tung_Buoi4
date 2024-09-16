namespace Tung_Buoi4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_nhap = new Button();
            txt_MaSV = new TextBox();
            txt_HT = new TextBox();
            txt_DC = new TextBox();
            txt_GT = new TextBox();
            dt_NS = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 76);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 120);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 174);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Ngày sinh ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 76);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 112);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(52, 15);
            label5.TabIndex = 0;
            label5.Text = "Giới tính";
            // 
            // btn_nhap
            // 
            btn_nhap.Location = new Point(578, 243);
            btn_nhap.Name = "btn_nhap";
            btn_nhap.Size = new Size(75, 58);
            btn_nhap.TabIndex = 1;
            btn_nhap.Text = "Nhập ";
            btn_nhap.UseVisualStyleBackColor = true;
            btn_nhap.Click += btn_nhap_Click;
            // 
            // txt_MaSV
            // 
            txt_MaSV.Location = new Point(213, 77);
            txt_MaSV.Name = "txt_MaSV";
            txt_MaSV.Size = new Size(100, 23);
            txt_MaSV.TabIndex = 2;
            // 
            // txt_HT
            // 
            txt_HT.Location = new Point(213, 112);
            txt_HT.Name = "txt_HT";
            txt_HT.Size = new Size(100, 23);
            txt_HT.TabIndex = 2;
            // 
            // txt_DC
            // 
            txt_DC.Location = new Point(566, 76);
            txt_DC.Name = "txt_DC";
            txt_DC.Size = new Size(100, 23);
            txt_DC.TabIndex = 2;
            // 
            // txt_GT
            // 
            txt_GT.Location = new Point(566, 117);
            txt_GT.Name = "txt_GT";
            txt_GT.Size = new Size(100, 23);
            txt_GT.TabIndex = 2;
            // 
            // dt_NS
            // 
            dt_NS.Location = new Point(213, 168);
            dt_NS.Name = "dt_NS";
            dt_NS.Size = new Size(200, 23);
            dt_NS.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dt_NS);
            Controls.Add(txt_GT);
            Controls.Add(txt_DC);
            Controls.Add(txt_HT);
            Controls.Add(txt_MaSV);
            Controls.Add(btn_nhap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_nhap;
        private TextBox txt_MaSV;
        private TextBox txt_HT;
        private TextBox txt_DC;
        private TextBox txt_GT;
        private DateTimePicker dt_NS;
    }
}
