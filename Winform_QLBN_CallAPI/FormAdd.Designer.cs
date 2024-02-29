namespace Winform_QLBN
{
    partial class FormAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            cbGender = new ComboBox();
            dateTime1 = new DateTimePicker();
            txtPpdt = new RichTextBox();
            btnSave = new Button();
            btnExit = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(103, 32);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 179);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 1;
            label2.Text = "Số ĐT:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 106);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(47, 398);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 3;
            label4.Text = "PPĐT:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(47, 325);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 4;
            label5.Text = "Thời gian:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(47, 252);
            label6.Name = "label6";
            label6.Size = new Size(133, 32);
            label6.TabIndex = 5;
            label6.Text = "Giới tính:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(221, 36);
            txtName.MaxLength = 1024;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nguyễn Văn A";
            txtName.RightToLeft = RightToLeft.No;
            txtName.Size = new Size(550, 29);
            txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(221, 109);
            txtAddress.MaxLength = 1024;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Vĩnh Lợi, Bạc Liêu...";
            txtAddress.RightToLeft = RightToLeft.No;
            txtAddress.Size = new Size(550, 29);
            txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = Color.Black;
            txtPhone.Location = new Point(221, 182);
            txtPhone.MaxLength = 11;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "0123456789";
            txtPhone.RightToLeft = RightToLeft.No;
            txtPhone.Size = new Size(550, 29);
            txtPhone.TabIndex = 8;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGender.Location = new Point(221, 255);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(151, 29);
            cbGender.TabIndex = 9;
            cbGender.Text = "Nam";
            // 
            // dateTime1
            // 
            dateTime1.Location = new Point(221, 325);
            dateTime1.Name = "dateTime1";
            dateTime1.Size = new Size(250, 29);
            dateTime1.TabIndex = 10;
            // 
            // txtPpdt
            // 
            txtPpdt.BorderStyle = BorderStyle.FixedSingle;
            txtPpdt.Location = new Point(221, 376);
            txtPpdt.Name = "txtPpdt";
            txtPpdt.Size = new Size(550, 54);
            txtPpdt.TabIndex = 11;
            txtPpdt.Text = "";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(221, 466);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(655, 466);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 34);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(438, 466);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(116, 34);
            btnReset.TabIndex = 15;
            btnReset.Text = "Xóa";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(txtPpdt);
            Controls.Add(dateTime1);
            Controls.Add(cbGender);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAdd";
            Text = "FormAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private ComboBox cbGender;
        private DateTimePicker dateTime1;
        private RichTextBox txtPpdt;
        private Button btnSave;
        private Button btnExit;
        private Button btnReset;
    }
}