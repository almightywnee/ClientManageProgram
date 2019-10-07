namespace ClientManageProgram
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Namebox = new System.Windows.Forms.TextBox();
            this.ClientNumBox = new System.Windows.Forms.TextBox();
            this.PersonalNumBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.ClientNum = new System.Windows.Forms.Label();
            this.PersonalNum = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.PhoneNumBox = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.BankbookBox = new System.Windows.Forms.TextBox();
            this.Bankbook = new System.Windows.Forms.Label();
            this.Others = new System.Windows.Forms.Label();
            this.OthersBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namebox
            // 
            this.Namebox.Location = new System.Drawing.Point(142, 26);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(100, 25);
            this.Namebox.TabIndex = 0;
            this.Namebox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ClientNumBox
            // 
            this.ClientNumBox.Location = new System.Drawing.Point(142, 68);
            this.ClientNumBox.Name = "ClientNumBox";
            this.ClientNumBox.Size = new System.Drawing.Size(100, 25);
            this.ClientNumBox.TabIndex = 1;
            this.ClientNumBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // PersonalNumBox
            // 
            this.PersonalNumBox.Location = new System.Drawing.Point(142, 150);
            this.PersonalNumBox.Name = "PersonalNumBox";
            this.PersonalNumBox.Size = new System.Drawing.Size(100, 25);
            this.PersonalNumBox.TabIndex = 1;
            this.PersonalNumBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(33, 29);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(37, 15);
            this.Name.TabIndex = 2;
            this.Name.Text = "이름";
            // 
            // ClientNum
            // 
            this.ClientNum.AutoSize = true;
            this.ClientNum.Location = new System.Drawing.Point(33, 71);
            this.ClientNum.Name = "ClientNum";
            this.ClientNum.Size = new System.Drawing.Size(67, 15);
            this.ClientNum.TabIndex = 2;
            this.ClientNum.Text = "회원번호";
            // 
            // PersonalNum
            // 
            this.PersonalNum.AutoSize = true;
            this.PersonalNum.Location = new System.Drawing.Point(33, 153);
            this.PersonalNum.Name = "PersonalNum";
            this.PersonalNum.Size = new System.Drawing.Size(97, 15);
            this.PersonalNum.TabIndex = 2;
            this.PersonalNum.Text = "주민등록번호";
            this.PersonalNum.Click += new System.EventHandler(this.PersonalNum_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(33, 193);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(37, 15);
            this.Address.TabIndex = 2;
            this.Address.Text = "주소";
            this.Address.Click += new System.EventHandler(this.Label1_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(142, 190);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 25);
            this.AddressBox.TabIndex = 1;
            this.AddressBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // PhoneNumBox
            // 
            this.PhoneNumBox.Location = new System.Drawing.Point(142, 230);
            this.PhoneNumBox.Name = "PhoneNumBox";
            this.PhoneNumBox.Size = new System.Drawing.Size(100, 25);
            this.PhoneNumBox.TabIndex = 1;
            this.PhoneNumBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // PhoneNum
            // 
            this.PhoneNum.AutoSize = true;
            this.PhoneNum.Location = new System.Drawing.Point(33, 233);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(82, 15);
            this.PhoneNum.TabIndex = 2;
            this.PhoneNum.Text = "핸드폰번호";
            this.PhoneNum.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(33, 112);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 15);
            this.Password.TabIndex = 2;
            this.Password.Text = "비밀번호";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(142, 109);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 25);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // BankbookBox
            // 
            this.BankbookBox.Location = new System.Drawing.Point(142, 270);
            this.BankbookBox.Name = "BankbookBox";
            this.BankbookBox.Size = new System.Drawing.Size(257, 25);
            this.BankbookBox.TabIndex = 1;
            this.BankbookBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Bankbook
            // 
            this.Bankbook.AutoSize = true;
            this.Bankbook.Location = new System.Drawing.Point(33, 273);
            this.Bankbook.Name = "Bankbook";
            this.Bankbook.Size = new System.Drawing.Size(67, 15);
            this.Bankbook.TabIndex = 2;
            this.Bankbook.Text = "통장번호";
            this.Bankbook.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Others
            // 
            this.Others.AutoSize = true;
            this.Others.Location = new System.Drawing.Point(33, 313);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(37, 15);
            this.Others.TabIndex = 2;
            this.Others.Text = "기타";
            this.Others.Click += new System.EventHandler(this.Label1_Click);
            // 
            // OthersBox
            // 
            this.OthersBox.Location = new System.Drawing.Point(142, 310);
            this.OthersBox.Multiline = true;
            this.OthersBox.Name = "OthersBox";
            this.OthersBox.Size = new System.Drawing.Size(257, 113);
            this.OthersBox.TabIndex = 1;
            this.OthersBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(311, 437);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(88, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "저장";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 483);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Others);
            this.Controls.Add(this.Bankbook);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PersonalNum);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ClientNum);
            this.Controls.Add(this.OthersBox);
            this.Controls.Add(this.BankbookBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.PhoneNumBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PersonalNumBox);
            this.Controls.Add(this.ClientNumBox);
            this.Controls.Add(this.Namebox);
            this.Name = "Form1";
            this.Text = "CientManageProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox ClientNumBox;
        private System.Windows.Forms.TextBox PersonalNumBox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label ClientNum;
        private System.Windows.Forms.Label PersonalNum;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox PhoneNumBox;
        private System.Windows.Forms.Label PhoneNum;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox BankbookBox;
        private System.Windows.Forms.Label Bankbook;
        private System.Windows.Forms.Label Others;
        private System.Windows.Forms.TextBox OthersBox;
        private System.Windows.Forms.Button Save;
    }
}

