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
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();
        }

        //Link to the Mathgame page
        private void mathGame_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MathGame());
        }
    }
}