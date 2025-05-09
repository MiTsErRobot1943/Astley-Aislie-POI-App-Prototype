using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using System;

namespace Astley_Aislie_POI_App_Prototype;

    public partial class MapPage : ContentPage
    {
        public MapPage()
        {

            InitializeComponent();
            blueDots = [.. buttonsContainer.Children.OfType<Button>()];
    }

        void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DisplayAlert("Identify", btn.CommandParameter.ToString(), "OK");
        }
    void LeftButton(object sender, EventArgs e)
    {
        Player.TranslationX -= 10;
        CheckForCollision();
        Console.WriteLine("Checking collision");
    }
    void UpButton(object sender, EventArgs e)
    {
        Player.TranslationY -= 10;
        CheckForCollision();
        Console.WriteLine("Checking collision");
    }
    void RightButton(object sender, EventArgs e)
    {
        Player.TranslationX += 10;
        CheckForCollision();
        Console.WriteLine("Checking collision");
    }
    void DownButton(object sender, EventArgs e)
    {
        Player.TranslationY += 10;
        CheckForCollision();
        Console.WriteLine("Checking collision");
    }
    private readonly List<Button> blueDots = [];
        private async void CheckForCollision()
        {
            var playerCenterX = Player.TranslationX + Player.Width / 2 +190;
            var playerCenterY = Player.TranslationY + Player.Height / 2 +190;
            Console.WriteLine($"Player: X={playerCenterX}, Y={playerCenterY}");
        Console.WriteLine($"Blue dots count: {blueDots.Count}");
        
        foreach (var dot in blueDots)
        {
            Console.WriteLine($"Dot parameter: {dot.CommandParameter}");
        }

        foreach (var button in blueDots)
            {
                var buttonCenterX = button.TranslationX + button.Width / 2;
                var buttonCenterY = button.TranslationY + button.Height / 2;
                Console.WriteLine($"Bluedots: Y={buttonCenterY}");
                Console.WriteLine($"Bluedots: X={buttonCenterX}");

            var distance = Math.Sqrt(Math.Pow(playerCenterX - buttonCenterX, 2) + Math.Pow(playerCenterY - buttonCenterY, 2));
                Console.WriteLine($"Distance: {distance}");
            if (distance < (Player.Width / 2 + button.Width / 2))
                {
                    await DisplayAlert("Notification", $"You found {button.CommandParameter}", "OK");

                    // Get the CommandParameter as a string
                    string param = button.CommandParameter.ToString();

                    // Navigate to a different page based on the parameter
                    if (param == "8")
                    {
                        await Navigation.PushAsync(new POIViews.POI8());
                    }
                    else if (param == "10")
                    {
                        await Navigation.PushAsync(new POIViews.POI10());
                    }
                    else if (param == "1")
                    {
                        await Navigation.PushAsync(new POIViews.POI1());
                    }
                else if (param == "2")
                {
                    await Navigation.PushAsync(new POIViews.POI2());
                }
                else if (param == "3")
                {
                    await Navigation.PushAsync(new POIViews.POI3());
                }
                else if (param == "4")
                {
                    await Navigation.PushAsync(new POIViews.POI4());
                }
                else if (param == "5")
                {
                    await Navigation.PushAsync(new POIViews.POI5());
                }
                else if (param == "6")
                {
                    await Navigation.PushAsync(new POIViews.POI6());
                }
                else if (param == "7")
                {
                    await Navigation.PushAsync(new POIViews.POI7());
                }
                else if (param == "9")
                {
                    await Navigation.PushAsync(new POIViews.POI9());
                }
                else if (param == "11")
                {
                    await Navigation.PushAsync(new POIViews.POI11());
                }
                else if (param == "12")
                {
                    await Navigation.PushAsync(new POIViews.POI12());
                }
                else if (param == "13")
                {
                    await Navigation.PushAsync(new POIViews.POI13());
                }
                else if (param == "14")
                {
                    await Navigation.PushAsync(new POIViews.POI14());
                }
                else if (param == "15")
                {
                    await Navigation.PushAsync(new POIViews.POI15());
                }
                else if (param == "16")
                {
                    await Navigation.PushAsync(new POIViews.POI16());
                }
                else if (param == "17")
                {
                    await Navigation.PushAsync(new POIViews.POI17());
                }
                else if (param == "18")
                {
                    await Navigation.PushAsync(new POIViews.POI18());
                }
                else if (param == "19")
                {
                    await Navigation.PushAsync(new POIViews.POI19());
                }
                else if (param == "20")
                {
                    await Navigation.PushAsync(new POIViews.POI20());
                }
                else if (param == "21")
                {
                    await Navigation.PushAsync(new POIViews.POI21());
                }
                else if (param == "22")
                {
                    await Navigation.PushAsync(new POIViews.POI22());
                }
                break;
                }
            }
        }
  
    }

