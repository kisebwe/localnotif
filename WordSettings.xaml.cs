
using LocalNotifications.Plugin;
using LocalNotifications.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeafWords.Classes.SettingsLeaf
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WordSettings : ContentPage
    {
        public WordSettings()
        {
            InitializeComponent();


        }

        void WordNotif(object sender, EventArgs e ) {

            // Handle when your app starts
            var notification = new LocalNotification
            {
                Text = "Hello Plugin",
                Title = "Nbation Plugin",
                Id = 2,

                NotifyTime = DateTime.Now
            };

            var notifier = CrossLocalNotifications.CreateLocalNotifier();
            notifier.Notify(notification);

          

        }




    }
}