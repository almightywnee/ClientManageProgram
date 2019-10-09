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
using System.Runtime.Serialization.Formatters.Binary;

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

        private List<CustomerInfo> CustomerS = new List<CustomerInfo>();
        private CustomerInfo Customer;

        private void Save_Click(object sender, EventArgs e)
        {
            string infofile = "Information.txt"; //txt파일 선언
            _Information = Path.Combine("Information", infofile); //info 폴더 안에 txt를 생성

            CustomerInfo Customer = new CustomerInfo(Namebox.Text, ClientNumBox.Text, PasswordBox.Text, PersonalNumBox.Text, AddressBox.Text, PhoneNumBox.Text, BankbookBox.Text, OthersBox.Text);
            //저장 


            CustomerList.Items.Add(Customer._Name); //리스트에 이름 입력

            CustomerS.Add(Customer); // 선언한 CS배열에 방금 입력한 Customer정보 입력.

            ShowCusInfo(Customer);

            Namebox.Text = "";
            ClientNumBox.Text = "";
            PasswordBox.Text = "";
            PersonalNumBox.Text = "";
            AddressBox.Text = "";
            PhoneNumBox.Text = "";
            BankbookBox.Text = "";
            OthersBox.Text = "";

            FileStream Savedata = new FileStream("DataFile.dat", FileMode.Append);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(Savedata, CustomerS);
            }
            catch
            {
                
            }
            finally
            {
                Savedata.Close();
            }



        }

        private void ShowCusInfo(CustomerInfo cus) //Customerinfo 라는 클래스변수
        {

            nameLAB.Text = cus._Name; 
            ClinetNumLAB.Text = cus._CustomerNum;
            PasswordLAB.Text = cus._Password;
            PersonalNumLAB.Text = cus._PhoneNum;
            AddressLAB.Text = cus._Address;
            PhonenumLAB.Text = cus._PhoneNum;
            BankLAB.Text = cus._Bank;
            OthersLAB.Text = cus._Others;


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
            string Cusname = CustomerList.SelectedItem.ToString();

            foreach (CustomerInfo customer in CustomerS) //CustomerS 안에 있는 내용을 customer안에 담아라 
            {
                if(Cusname == customer._Name) // Cusname을 CS내용을 담은 customer._Name 값과 비교하라
                {
                    ShowCusInfo(customer);
                    break;
                }
            }
        }

        private void 로드_Click(object sender, EventArgs e)
        { 

            FileStream Savedata = new FileStream("DataFile.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                CustomerS = (List<CustomerInfo>)formatter.Deserialize(Savedata);
                
                
            }
            catch
            {
                
            }
            finally
            {
                Savedata.Close();
            }

            //int cnt = CustomerS.Count;
            ///for (int i = 0; i < cnt; i++)
            //{
            //     CustomerList.Items.Add(CustomerS.);//데이터 차례로 담기.
            // }
            foreach (CustomerInfo customer in CustomerS)
            {
                    //CustomerList.Items.Add(customer._Name);
                if (CustomerList.Items == null)
                {
                    CustomerList.Items.Add(customer._Name);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
