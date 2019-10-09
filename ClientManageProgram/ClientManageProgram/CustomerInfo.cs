using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManageProgram
{
    class CustomerInfo
    {
        public string _Name;
        public string _CustomerNum;
        public string _Password;
        public string _PersonalNum;
        public string _Address;
        public string _PhoneNum;
        public string _Bank;
        public string _Others;

        public CustomerInfo(string name, string customernum, string password, string personalnum, string address, string phonenum, string bank, string others)
        {
            _Name = name;
            _CustomerNum = customernum;
            _Password = password;
            _PersonalNum = personalnum;
            _Address = address;
            _PhoneNum = phonenum;
            _Bank = bank;
            _Others = others;

        }   

        public string CusSave()
        {
            return _Name;
             
        }

    }
}
