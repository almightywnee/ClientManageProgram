using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClientManageProgram
{
    public partial class Form1 : Form
    {

        public string _Information;

        

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists("Information")) //info폴더 없으면 생성
                Directory.CreateDirectory("Information");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PersonalNum_Click(object sender, EventArgs e)
        {

        }


        private CustomerInfo[ ] Customer = new CustomerInfo[10];
        public int CustomerArrayIndex = 0;

        private void Save_Click(object sender, EventArgs e)
        {
            string infofile = "Information.txt"; //txt파일 선언
            _Information = Path.Combine("Information", infofile); //info 폴더 안에 txt를 생성

            Customer[CustomerArrayIndex] = new CustomerInfo(Namebox.Text, ClientNumBox.Text, PasswordBox.Text, PersonalNumBox.Text, AddressBox.Text, PhoneNumBox.Text, BankbookBox.Text, OthersBox.Text);

            ShowCusInfo(CustomerArrayIndex);
        }

        public void ShowCusInfo(int CustomerArrayIndex)
        {

            nameLAB.Text = Customer[CustomerArrayIndex]._Name; //To. Customerinfo Class
            ClinetNumLAB.Text = Customer[CustomerArrayIndex]._CustomerNum;//To. This Class -> CAN NOT LOAD
            PasswordLAB.Text = Customer[CustomerArrayIndex]._Password;
            PersonalNumLAB.Text = Customer[CustomerArrayIndex]._PhoneNum;
            AddressLAB.Text = Customer[CustomerArrayIndex]._Address;
            PhonenumLAB.Text = Customer[CustomerArrayIndex]._PhoneNum;
            BankLAB.Text = Customer[CustomerArrayIndex]._Bank;
            OthersLAB.Text = Customer[CustomerArrayIndex]._Others;

            CustomerList.Items.Add(Customer[CustomerArrayIndex]._Name);

            CustomerArrayIndex++;
        }

        private void WriteLine(string data)
        {
            using (StreamWriter writer = new StreamWriter(_Information, true)) 
            {
                try
                {
                    writer.WriteLine(data);
                }
                catch (Exception ex)
                { }

            }
        }

        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CusName = CustomerList.SelectedItem.ToString();

            for(int index = 0; index < CustomerArrayIndex; index++)
            {
                if(Customer[index]._Name == CusName)
                {
                    ShowCusInfo(index);
                }
            }
        }
    }
}
