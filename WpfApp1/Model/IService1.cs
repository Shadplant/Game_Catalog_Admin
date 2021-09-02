using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void Add_Game(string Game_Name, string Game_Description, string Game_Image_Link, int Publishing_Admin_ID);

        [OperationContract]
        string Login_Admin(string Email, string Password);

        [OperationContract]
        bool Check_Email(string Email);
    }
}
