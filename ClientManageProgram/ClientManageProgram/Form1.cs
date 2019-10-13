using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void Save_Click(object sender, EventArgs e)
        {
            string infofile = "Information.dat"; //dat파일 선언
            _Information = Path.Combine("Information", infofile); //info 폴더 안에 dat를 생성

            CustomerInfo Customer = new CustomerInfo(Namebox.Text, ClientNumBox.Text, PasswordBox.Text, PersonalNumBox.Text, AddressBox.Text, PhoneNumBox.Text, BankbookBox.Text, OthersBox.Text);
            //저장 

            Savecus();


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




        }

        private void Savecus()
        {
            

            FileStream namefs = new FileStream("Name.dat", FileMode.Append); //dat파일 생성, 파일모드는 append    
            FileStream cusnumfs = new FileStream("Cusnum.dat", FileMode.Append);
            FileStream passwordfs = new FileStream("Password.dat", FileMode.Append);
            FileStream personalfs = new FileStream("Personalnum.dat", FileMode.Append);
            FileStream addressfs = new FileStream("Address.dat", FileMode.Append);
            FileStream phonenumfs = new FileStream("Phonenum.dat", FileMode.Append);
            FileStream bankfs = new FileStream("Bank.dat", FileMode.Append);
            FileStream othersfs = new FileStream("Others.dat", FileMode.Append);
            StreamWriter namesw = new StreamWriter(namefs);//위에 생성한 dat파일에 쓰기 기능 이용하는 인스턴스 sw선언
            StreamWriter cusnumsw = new StreamWriter(cusnumfs);
            StreamWriter passwordsw = new StreamWriter(passwordfs);
            StreamWriter personalsw = new StreamWriter(personalfs);
            StreamWriter addresssw = new StreamWriter(addressfs);
            StreamWriter phonenumsw = new StreamWriter(phonenumfs);
            StreamWriter banksw = new StreamWriter(bankfs);
            StreamWriter otherssw = new StreamWriter(othersfs);
            namesw.WriteLine(Namebox.Text);
            cusnumsw.WriteLine(ClientNumBox.Text);
            passwordsw.WriteLine(PasswordBox.Text);
            personalsw.WriteLine(PersonalNumBox.Text);
            addresssw.WriteLine(AddressBox.Text);
            phonenumsw.WriteLine(PhoneNumBox.Text);
            banksw.WriteLine(BankbookBox.Text);
            otherssw.WriteLine(OthersBox.Text);
            namesw.Flush();           //값 담기  Flush 메모리에 존재하던걸 실제로 텍스트파일에 넣는것.
            cusnumsw.Flush();
            passwordsw.Flush();
            personalsw.Flush();
            addresssw.Flush();
            phonenumsw.Flush();
            banksw.Flush();
            otherssw.Flush();
            namesw.Close();   //끄기
            cusnumsw.Close();
            passwordsw.Close();
            personalsw.Close();
            addresssw.Close();
            phonenumsw.Close();
            banksw.Close();
            otherssw.Close();
            namefs.Close(); //fw 항목 끄기
            cusnumfs.Close();
            passwordfs.Close();
            personalfs.Close();
            addressfs.Close();
            phonenumfs.Close();
            bankfs.Close();
            othersfs.Close();
        }

        private void ShowCusInfo(CustomerInfo cus) //Customerinfo 라는 클래스변수
        {

            nameLAB.Text = cus._Name; 
            ClinetNumLAB.Text = cus._CustomerNum;
            PasswordLAB.Text = cus._Password;
            PersonalNumLAB.Text = cus._PersonalNum;
            AddressLAB.Text = cus._Address;
            PhonenumLAB.Text = cus._PhoneNum;
            BankLAB.Text = cus._Bank;
            OthersLAB.Text = cus._Others;


        }

       

        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            try
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
            catch
            { }
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream namefsd = new FileStream("Name.dat", FileMode.Append); //dat파일 생성 파일내용이 공백일때 오류방지
            FileStream cusnumfsd = new FileStream("Cusnum.dat", FileMode.Append);
            FileStream passwordfsd = new FileStream("Password.dat", FileMode.Append);
            FileStream personalfsd = new FileStream("Personalnum.dat", FileMode.Append);
            FileStream addressfsd = new FileStream("Address.dat", FileMode.Append);
            FileStream phonenumfsd = new FileStream("Phonenum.dat", FileMode.Append);
            FileStream bankfsd = new FileStream("Bank.dat", FileMode.Append);
            FileStream othersfsd = new FileStream("Others.dat", FileMode.Append);
            namefsd.Close(); //fw 항목 끄기
            cusnumfsd.Close();
            passwordfsd.Close();
            personalfsd.Close();
            addressfsd.Close();
            phonenumfsd.Close();
            bankfsd.Close();
            othersfsd.Close();

            FileStream namefs = new FileStream("Name.dat", FileMode.Open); //dat파일 오픈
            FileStream cusnumfs = new FileStream("Cusnum.dat", FileMode.Open);
            FileStream passwordfs = new FileStream("Password.dat", FileMode.Open);
            FileStream personalfs = new FileStream("Personalnum.dat", FileMode.Open);
            FileStream addressfs = new FileStream("Address.dat", FileMode.Open);
            FileStream phonenumfs = new FileStream("Phonenum.dat", FileMode.Open);
            FileStream bankfs = new FileStream("Bank.dat", FileMode.Open);
            FileStream othersfs = new FileStream("Others.dat", FileMode.Open);

            StreamReader namesr = new StreamReader(namefs);//fs 읽어서 sr에 담기
            StreamReader cusnumsr = new StreamReader(cusnumfs);
            StreamReader passwordsr = new StreamReader(passwordfs);
            StreamReader personalsr = new StreamReader(personalfs);
            StreamReader addresssr = new StreamReader(addressfs);
            StreamReader phonenumsr = new StreamReader(phonenumfs);
            StreamReader banksr = new StreamReader(bankfs);
            StreamReader otherssr = new StreamReader(othersfs);

            while (namesr.Peek() >= 0)
            {
                CustomerInfo cusload = new CustomerInfo(namesr.ReadLine(), cusnumsr.ReadLine(), passwordsr.ReadLine(), personalsr.ReadLine(), addresssr.ReadLine(), phonenumsr.ReadLine(), banksr.ReadLine(), otherssr.ReadLine());
                CustomerS.Add(cusload); //Cs배열에 위 값 넣어주기
                CustomerList.Items.Add(cusload._Name); //리스트에 이름 뿌려주기
            }

            namefs.Close();
            cusnumfs.Close();
            passwordfs.Close();
            personalfs.Close();
            addressfs.Close();
            phonenumfs.Close();
            bankfs.Close();
            othersfs.Close();

            namesr.Close();
            cusnumsr.Close();
            passwordsr.Close();
            personalsr.Close();
            addresssr.Close();
            phonenumsr.Close();
            banksr.Close();
            otherssr.Close();
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            FileStream namefs = new FileStream("Name.dat", FileMode.Create); //삭제시, 기존파일을 제거하기 위해 새로 생성
            FileStream cusnumfs = new FileStream("Cusnum.dat", FileMode.Create);
            FileStream passwordfs = new FileStream("Password.dat", FileMode.Create);
            FileStream personalfs = new FileStream("Personalnum.dat", FileMode.Create);
            FileStream addressfs = new FileStream("Address.dat", FileMode.Create);
            FileStream phonenumfs = new FileStream("Phonenum.dat", FileMode.Create);
            FileStream bankfs = new FileStream("Bank.dat", FileMode.Create);
            FileStream othersfs = new FileStream("Others.dat", FileMode.Create);
            StreamWriter namesw = new StreamWriter(namefs); // 위에 새로 생성한 파일에 삭제한 값 제외한 것들 넣어서 생성
            StreamWriter cusnumsw = new StreamWriter(cusnumfs);
            StreamWriter passwordsw = new StreamWriter(passwordfs);
            StreamWriter personalsw = new StreamWriter(personalfs);
            StreamWriter addresssw = new StreamWriter(addressfs);
            StreamWriter phonenumsw = new StreamWriter(phonenumfs);
            StreamWriter banksw = new StreamWriter(bankfs);
            StreamWriter otherssw = new StreamWriter(othersfs);

            try
            {
                string Cusname = CustomerList.SelectedItem.ToString(); //같은 이름 찾기위해 이름값 비교대상값 설정
                int index = 0;
                foreach (CustomerInfo customer in CustomerS) //CustomerS 안에 있는 내용을 customer안에 담아라 
                {
                    if (Cusname == customer._Name) // Cusname을 CS내용을 담은 customer._Name 값과 비교하라
                    {
                        CustomerList.Items.RemoveAt(index); //리스트에서 제거
                        CustomerS.RemoveAt(index); // 배열 내에서도 제거
                        
                        break;
                    }

                    index++;
                }
                index = 0;
                foreach(CustomerInfo customer in CustomerS)
                {
                    
                    namesw.WriteLine(customer._Name);
                    cusnumsw.WriteLine(customer._CustomerNum);
                    passwordsw.WriteLine(customer._Password);
                    personalsw.WriteLine(customer._PersonalNum);
                    addresssw.WriteLine(customer._Address);
                    phonenumsw.WriteLine(customer._PhoneNum);
                    banksw.WriteLine(customer._Bank);
                    otherssw.WriteLine(customer._Others);
                    namesw.Flush();           //값 담기  Flush 메모리에 존재하던걸 실제로 텍스트파일에 넣는것.
                    cusnumsw.Flush();
                    passwordsw.Flush();
                    personalsw.Flush();
                    addresssw.Flush();
                    phonenumsw.Flush();
                    banksw.Flush();
                    otherssw.Flush();
                 
                }
            }
            catch
            { }

            namesw.Close();   //끄기
            cusnumsw.Close();
            passwordsw.Close();
            personalsw.Close();
            addresssw.Close();
            phonenumsw.Close();
            banksw.Close();
            otherssw.Close();
            namefs.Close(); //fw 항목 끄기
            cusnumfs.Close();
            passwordfs.Close();
            personalfs.Close();
            addressfs.Close();
            phonenumfs.Close();
            bankfs.Close();
            othersfs.Close();
        }

        private void Newbt_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            editokbt.Visible = false;
            Namebox.Text = "";
            ClientNumBox.Text = "";
            PasswordBox.Text = "";
            PersonalNumBox.Text = "";
            AddressBox.Text = "";
            PhoneNumBox.Text = "";
            BankbookBox.Text = "";
            OthersBox.Text = "";
        }

        public int indexchk = 0;

        private void Editbt_Click(object sender, EventArgs e)
        {

            try
            {
                string cfname = CustomerList.SelectedItem.ToString();
                foreach (CustomerInfo customer in CustomerS)
                {
                    if (customer._Name == cfname)
                    {
                        panel1.Visible = false;
                        Namebox.Text = customer._Name;
                        ClientNumBox.Text = customer._CustomerNum;
                        PasswordBox.Text = customer._Password;
                        PersonalNumBox.Text = customer._PersonalNum;
                        AddressBox.Text = customer._Address;
                        PhoneNumBox.Text = customer._PhoneNum;
                        BankbookBox.Text = customer._Bank;
                        OthersBox.Text = customer._Others;

                        editokbt.Visible = true;
                        

                    }

                    indexchk++;

                }
            }
            catch { }
        }

        private void Editokbt_Click(object sender, EventArgs e)
        {
            

        }
    }

}
