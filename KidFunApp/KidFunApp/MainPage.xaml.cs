using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KidFunApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
 
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);
            // Use to assign the source for the images of the main page
            kidsImg.Source = ImageSource.FromResource("KidFunApp.Assets.images.kids.png", assembly);
            giraffeImg.Source = ImageSource.FromResource("KidFunApp.Assets.images.giraffe.png", assembly);
            kidsTitleImg.Source = ImageSource.FromResource("KidFunApp.Assets.images.kids2.png", assembly);
            settingImg.Source = ImageSource.FromResource("KidFunApp.Assets.images.setting.png", assembly);
        }


        //When setting button is clicked, navigatte to the setting page
        private void SettingImg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());
        }
        // When user click "Play and Learn", navigate to the Home Page
        private void Player1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}
