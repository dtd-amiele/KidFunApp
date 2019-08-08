using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KidFunApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]



    public partial class MathGame : ContentPage
    {
       // var assembly = typeof(App).GetTypeInfo().Assembly;
       // Stream correctAudio = assembly.GetManifestResourceStream("KidFunApp.Assets.sound.correctA.wav");

        int num1 = 0, num2 = 0, result = 0, lives = 10;
        int HighScore = 0;
     //   int  2;

        int score = 0;
        int questionNum = 0;
 
        public MathGame()
        {
            InitializeComponent();



           


            RandomQuestion();

            //If any number is clicked , call the On ImageNumberCLicked to check the value
            img0.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                    OnImageNumberClicked(0);
                }),
                NumberOfTapsRequired = 1
            });

            img1.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                    OnImageNumberClicked(1);
                    
                }),
                NumberOfTapsRequired = 1
            });

            img2.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                     OnImageNumberClicked(2);
                }),
                NumberOfTapsRequired = 1
            });

            img3.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                     OnImageNumberClicked(3);
                }),
                NumberOfTapsRequired = 1
            });

            img4.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                     OnImageNumberClicked(4);
                }),
                NumberOfTapsRequired = 1
            });

            img5.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                     OnImageNumberClicked(5);
                }),
                NumberOfTapsRequired = 1
            });

            img6.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                     OnImageNumberClicked(6);
                }),
                NumberOfTapsRequired = 1
            });

            img7.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                     OnImageNumberClicked(7);
                }),
                NumberOfTapsRequired = 1
            });

            img8.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                     OnImageNumberClicked(8);
                }),
                NumberOfTapsRequired = 1
            });

            img9.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                     OnImageNumberClicked(9);
                }),
                NumberOfTapsRequired = 1
            });
            // Start.IsVisible = false; 

        }

        // Random the values for the question
        private void RandomQuestion()
        {
            //DisplayAlert("here", "rnd", "here");
            Random rnd = new Random();

            num1 = rnd.Next(10);
            num2 = rnd.Next(10);

            if (num1 < num2)
            {
                result = num2;
                num2 = result - num1;
                number1.Text = num1.ToString();
                number2.Text = num2.ToString();
            }

            else
            {
                result = num1;
                num1 = result - num2;
                number1.Text = num1.ToString();
                number2.Text = num2.ToString();
            }

            answer.Text = "?";
            answer.TextColor = Color.FromHex("FFFFFF");
            questionNum++;
            questionID.Text = "QUESTION " + questionNum.ToString();
        }

        //When user click continue button, do next question
        private void GameContinue_Clicked(object sender, EventArgs e)
        {
           // DisplayAlert("here", "here", "here");
            RandomQuestion();
            gameContinue.IsVisible = false;
        }

        private void RestartButton_Clicked(object sender, EventArgs e)
        {
            score = 0;
            lives = 10;
            gameFail.IsVisible = false;
            gameFailBorder.IsVisible = false;

            heart1.IsVisible = true; 
            heart2.IsVisible = true; 
            heart3.IsVisible = true;
            heart4.IsVisible = true; 
            heart5.IsVisible = true; 
            heart6.IsVisible = true; 
            heart7.IsVisible = true; 
            heart8.IsVisible = true;
            heart9.IsVisible = true; 
            heart10.IsVisible = true;
            gameScore.Text = "SCORE : " + score.ToString();
            gameContent.IsVisible = true;
            RandomQuestion();
            gameContinue.IsVisible = false;


        }


        //Disappear the starting page and appear the content page
        private void mathButton_Clicked(object sender, EventArgs e)
        {
            owl.IsVisible = false;
            gameButton.IsVisible = false;
            mathSymbol.IsVisible = false;
            mathName.IsVisible = false;

            gameContent.IsVisible = true;
            gameContinue.IsVisible = false;
        }

        //Check the result, show the response
        private void OnImageNumberClicked(int num)
        {

            answer.Text = num.ToString();
            if (num == result)
            {


                score += 5;
                gameScore.Text = "SCORE : " + score;
                gameContinue.IsVisible = true;
                answer.TextColor = Color.FromHex("#6232C3");
                //RandomQuestion();
            }

            else
            {
                answer.TextColor = Color.FromHex("#FF0000");
                switch (lives)
                {
                    case 1: heart1.IsVisible = false; break;
                    case 2: heart2.IsVisible = false; break;
                    case 3: heart3.IsVisible = false; break;
                    case 4: heart4.IsVisible = false; break;
                    case 5: heart5.IsVisible = false; break;
                    case 6: heart6.IsVisible = false; break;
                    case 7: heart7.IsVisible = false; break;
                    case 8: heart8.IsVisible = false; break;
                    case 9: heart9.IsVisible = false; break;
                    case 10: heart10.IsVisible = false; break;
                    default: break;
                }
                lives--;
                if (lives == 0)
                    FailGame();
            }
            

        }

        private void FailGame()
        {
            if (score > HighScore) HighScore = score;
            gameContent.IsVisible = false;

            highScore.Text = "HIGH SCORE : " + HighScore.ToString();
            currentScore.Text = "SCORE : " + score.ToString();
            gameFail.IsVisible = true;
            gameFailBorder.IsVisible = true;

        }
    }
}