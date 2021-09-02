using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Game_Add_Model : INotifyPropertyChanged
    {

        public void Add_Game_Model(string Game_Name, string Game_Description, string Game_Image_Link, int Publishing_Admin_ID)
        {
            Connection().Add_Game(Game_Name, Game_Description, Game_Image_Link, Publishing_Admin_ID);
        }

        private IService1 Connection()
        {
            Uri uri = new Uri("http://localhost:57268/Service1.svc");
            EndpointAddress endpointAddress = new EndpointAddress(uri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IService1> channelFactory = new ChannelFactory<IService1>(binding, endpointAddress);
            IService1 service = channelFactory.CreateChannel();
            return service;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
