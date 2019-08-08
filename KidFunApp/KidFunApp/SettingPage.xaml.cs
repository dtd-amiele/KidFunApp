using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KidFunApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();

            var assembly = typeof(SettingPage);
            soundImg.Source = ImageSource.FromResource("KidFunApp.Assets.images.sound.png", assembly);

        }

        private void SoundSetting_Tapped(object sender, EventArgs e)
        {
            // Change betwwen sound on and off when user clicks the button
            var assembly = typeof(SettingPage);
            if (soundText.Text == "SOUND : OFF")
            {
                soundText.Text = "SOUND : ON";
                soundImg.Source = ImageSource.FromResource("KidFunApp.Assets.images.sound.png", assembly);
            }
            else
            {
                soundText.Text = "SOUND : OFF";
                soundImg.Source = ImageSource.FromResource("KidFunApp.Assets.images.soundOff.png", assembly);
            }
        }
    }
}