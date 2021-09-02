using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class Admin_Login_ViewModel : INotifyPropertyChanged
    {
        Game_Add_Model model = new Game_Add_Model();
        private string email;
        private string password;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private RelayCommand add_game_command;
        public RelayCommand Add_Game_Command
        {
            get
            {
                return add_game_command ?? (add_game_command = new RelayCommand(obj => Add_Game_ViewModel()));
            }
        }

        public bool Check_Email_ViewModel()
        {
            try
            {
                model.
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Login_User_ViewModel()
        {
            try
            {
                if (Check_Email_ViewModel())
                {

                }
                model.Add_Game_Model(name, description, image_link, admin_ID);
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
