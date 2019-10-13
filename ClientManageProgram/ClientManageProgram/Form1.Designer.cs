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
            this.CName = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OthersLAB = new System.Windows.Forms.Label();
            this.BankLAB = new System.Windows.Forms.Label();
            this.PhonenumLAB = new System.Windows.Forms.Label();
            this.AddressLAB = new System.Windows.Forms.Label();
            this.PersonalNumLAB = new System.Windows.Forms.Label();
            this.PasswordLAB = new System.Windows.Forms.Label();
            this.ClinetNumLAB = new System.Windows.Forms.Label();
            this.nameLAB = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Newbt = new System.Windows.Forms.Button();
            this.editbt = new System.Windows.Forms.Button();
            this.editokbt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.ClientNumBox.Size = new System.Drawing.Size(131, 25);
            this.ClientNumBox.TabIndex = 2;
            this.ClientNumBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // PersonalNumBox
            // 
            this.PersonalNumBox.Location = new System.Drawing.Point(142, 150);
            this.PersonalNumBox.Name = "PersonalNumBox";
            this.PersonalNumBox.Size = new System.Drawing.Size(256, 25);
            this.PersonalNumBox.TabIndex = 4;
            this.PersonalNumBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // CName
            // 
            this.CName.AutoSize = true;
            this.CName.Location = new System.Drawing.Point(33, 29);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(37, 15);
            this.CName.TabIndex = 2;
            this.CName.Text = "이름";
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
            this.AddressBox.Size = new System.Drawing.Size(256, 25);
            this.AddressBox.TabIndex = 5;
            this.AddressBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // PhoneNumBox
            // 
            this.PhoneNumBox.Location = new System.Drawing.Point(142, 230);
            this.PhoneNumBox.Name = "PhoneNumBox";
            this.PhoneNumBox.Size = new System.Drawing.Size(256, 25);
            this.PhoneNumBox.TabIndex = 6;
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
            this.PasswordBox.Size = new System.Drawing.Size(131, 25);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // BankbookBox
            // 
            this.BankbookBox.Location = new System.Drawing.Point(142, 270);
            this.BankbookBox.Name = "BankbookBox";
            this.BankbookBox.Size = new System.Drawing.Size(256, 25);
            this.BankbookBox.TabIndex = 7;
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
            this.OthersBox.Location = new System.Drawing.Point(141, 310);
            this.OthersBox.Multiline = true;
            this.OthersBox.Name = "OthersBox";
            this.OthersBox.Size = new System.Drawing.Size(257, 113);
            this.OthersBox.TabIndex = 8;
            this.OthersBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(317, 432);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(83, 34);
            this.Save.TabIndex = 9;
            this.Save.Text = "저장";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "회원번호 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "비밀번호 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "주민등록번호 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "주소 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "핸드폰번호 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "통장번호 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "기타 :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OthersLAB);
            this.panel1.Controls.Add(this.BankLAB);
            this.panel1.Controls.Add(this.PhonenumLAB);
            this.panel1.Controls.Add(this.AddressLAB);
            this.panel1.Controls.Add(this.PersonalNumLAB);
            this.panel1.Controls.Add(this.PasswordLAB);
            this.panel1.Controls.Add(this.ClinetNumLAB);
            this.panel1.Controls.Add(this.nameLAB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 454);
            this.panel1.TabIndex = 4;
            // 
            // OthersLAB
            // 
            this.OthersLAB.AutoSize = true;
            this.OthersLAB.Location = new System.Drawing.Point(156, 316);
            this.OthersLAB.Name = "OthersLAB";
            this.OthersLAB.Size = new System.Drawing.Size(0, 15);
            this.OthersLAB.TabIndex = 1;
            // 
            // BankLAB
            // 
            this.BankLAB.AutoSize = true;
            this.BankLAB.Location = new System.Drawing.Point(156, 276);
            this.BankLAB.Name = "BankLAB";
            this.BankLAB.Size = new System.Drawing.Size(0, 15);
            this.BankLAB.TabIndex = 1;
            // 
            // PhonenumLAB
            // 
            this.PhonenumLAB.AutoSize = true;
            this.PhonenumLAB.Location = new System.Drawing.Point(156, 236);
            this.PhonenumLAB.Name = "PhonenumLAB";
            this.PhonenumLAB.Size = new System.Drawing.Size(0, 15);
            this.PhonenumLAB.TabIndex = 1;
            // 
            // AddressLAB
            // 
            this.AddressLAB.AutoSize = true;
            this.AddressLAB.Location = new System.Drawing.Point(156, 181);
            this.AddressLAB.MaximumSize = new System.Drawing.Size(250, 150);
            this.AddressLAB.Name = "AddressLAB";
            this.AddressLAB.Size = new System.Drawing.Size(0, 15);
            this.AddressLAB.TabIndex = 1;
            // 
            // PersonalNumLAB
            // 
            this.PersonalNumLAB.AutoSize = true;
            this.PersonalNumLAB.Location = new System.Drawing.Point(156, 141);
            this.PersonalNumLAB.Name = "PersonalNumLAB";
            this.PersonalNumLAB.Size = new System.Drawing.Size(0, 15);
            this.PersonalNumLAB.TabIndex = 1;
            // 
            // PasswordLAB
            // 
            this.PasswordLAB.AutoSize = true;
            this.PasswordLAB.Location = new System.Drawing.Point(156, 100);
            this.PasswordLAB.Name = "PasswordLAB";
            this.PasswordLAB.Size = new System.Drawing.Size(0, 15);
            this.PasswordLAB.TabIndex = 1;
            // 
            // ClinetNumLAB
            // 
            this.ClinetNumLAB.AutoSize = true;
            this.ClinetNumLAB.Location = new System.Drawing.Point(156, 59);
            this.ClinetNumLAB.Name = "ClinetNumLAB";
            this.ClinetNumLAB.Size = new System.Drawing.Size(0, 15);
            this.ClinetNumLAB.TabIndex = 1;
            // 
            // nameLAB
            // 
            this.nameLAB.AutoSize = true;
            this.nameLAB.Location = new System.Drawing.Point(156, 17);
            this.nameLAB.Name = "nameLAB";
            this.nameLAB.Size = new System.Drawing.Size(0, 15);
            this.nameLAB.TabIndex = 1;
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 15;
            this.CustomerList.Location = new System.Drawing.Point(419, 12);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(279, 409);
            this.CustomerList.TabIndex = 10;
            this.CustomerList.SelectedIndexChanged += new System.EventHandler(this.CustomerList_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(610, 432);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(88, 34);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "삭제";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Newbt
            // 
            this.Newbt.Location = new System.Drawing.Point(419, 432);
            this.Newbt.Name = "Newbt";
            this.Newbt.Size = new System.Drawing.Size(83, 34);
            this.Newbt.TabIndex = 10;
            this.Newbt.Text = "신규회원";
            this.Newbt.UseVisualStyleBackColor = true;
            this.Newbt.Click += new System.EventHandler(this.Newbt_Click);
            // 
            // editbt
            // 
            this.editbt.Location = new System.Drawing.Point(508, 432);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(96, 34);
            this.editbt.TabIndex = 11;
            this.editbt.Text = "수정하기";
            this.editbt.UseVisualStyleBackColor = true;
            this.editbt.Click += new System.EventHandler(this.Editbt_Click);
            // 
            // editokbt
            // 
            this.editokbt.Location = new System.Drawing.Point(317, 432);
            this.editokbt.Name = "editokbt";
            this.editokbt.Size = new System.Drawing.Size(82, 34);
            this.editokbt.TabIndex = 13;
            this.editokbt.Text = "수정하기";
            this.editokbt.UseVisualStyleBackColor = true;
            this.editokbt.Visible = false;
            this.editokbt.Click += new System.EventHandler(this.Editokbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editbt);
            this.Controls.Add(this.Newbt);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.Others);
            this.Controls.Add(this.Bankbook);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PersonalNum);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ClientNum);
            this.Controls.Add(this.OthersBox);
            this.Controls.Add(this.BankbookBox);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.PhoneNumBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PersonalNumBox);
            this.Controls.Add(this.ClientNumBox);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.editokbt);
            this.Name = "Form1";
            this.Text = "CientManageProgram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox ClientNumBox;
        private System.Windows.Forms.TextBox PersonalNumBox;
        private System.Windows.Forms.Label CName;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OthersLAB;
        private System.Windows.Forms.Label BankLAB;
        private System.Windows.Forms.Label PhonenumLAB;
        private System.Windows.Forms.Label AddressLAB;
        private System.Windows.Forms.Label PersonalNumLAB;
        private System.Windows.Forms.Label PasswordLAB;
        private System.Windows.Forms.Label ClinetNumLAB;
        private System.Windows.Forms.Label nameLAB;
        private System.Windows.Forms.ListBox CustomerList;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Newbt;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.Button editokbt;
    }
}

