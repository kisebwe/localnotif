
using LocalNotifications.Plugin;
using LocalNotifications.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        void WordNotif(object sender, EventArgs e)
        {

            // Handle when your app starts
            var notification = new LocalNotifications
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