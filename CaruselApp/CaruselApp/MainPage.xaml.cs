using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CaruselApp
{
    public partial class MainPage : CarouselPage
    {
        Image img;
        public MainPage()
        {
            //-----------------------------------------------------------------------------------------------------------------------------------------------
            var glavnajaContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Image
                        {
                            Source = "vpravo.png",
                            HorizontalOptions = LayoutOptions.Fill,
                        },

                        new Label
                        {
                            Text = "Главная страница, крути вправо!\nЗажми и крути! :)\nИ ты узнаешь кто такой:\nХолерик, Сангвиник, Флегматик, Меланхолик!",//Text
                            TextColor = Color.Black,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        },
                        new Image
                        {
                            Source = "home.png",
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }

                    }
                }
            };
            //-----------------------------------------------------------------------------------------------------------------------------------------------------
            var yellowContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                        Children =
                        {
                        new Image
                        {
                            Source = "holerik.jpg",
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                        },

                        new Label
                        {
                            Text = "Кто же такой холерик?",//Text
                            TextColor = Color.Black,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        },
                        new Button
                        {
                            BackgroundColor = Color.LightSkyBlue,
                            Text = "Нажми, чтобы узнать подробности :)",
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center,
                        }
                        
                        
                    }
                }
            };
            //-----------------------------------------------------------------------------------------------------------------------------------------------------
            var greenContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                        {
                        new Image
                        {
                            Source = "sangvinik.jpg",
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                        },

                        new Label
                        {
                            Text = "Кто же такой сангвиник?",//Text
                            TextColor = Color.Black,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        },
                        new Button
                        {
                            BackgroundColor = Color.LightSkyBlue,
                            Text = "Нажимай скорее!",
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center,
                        }
                    }
                }
            };
            //--------------------------------------------------------------------------------------------------------------------------------------------
            var blackContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                        {
                        new Image
                        {
                            Source = "flegmatik.jpg",
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                        },

                        new Label
                        {
                            Text = "Кто же такой флегматик?",//Text
                            TextColor = Color.Black,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        },
                        new Button
                        {
                            BackgroundColor = Color.LightSkyBlue,
                            Text = "Информация для тебя :)",
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center,
                        }
                    }
                }
            };
            //----------------------------------------------------------------------------------------------------------------------------------------------
            var orangeContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                        {
                        new Image
                        {
                            Source = "melanholik.png",
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                        },

                        new Label
                        {
                            Text = "Кто же такой меланхолик?",//Text
                            TextColor = Color.Black,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        },
                        new Button
                        {
                            BackgroundColor = Color.LightSkyBlue,
                            Text = "Кликай скорее!:)",
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center,
                        }
                    }
                }
            };
            //----------------------------------------------------------------------------------------------------------------------------------------------
            Children.Add(glavnajaContentPage);
            Children.Add(yellowContentPage);
            Children.Add(greenContentPage);
            Children.Add(blackContentPage);
            Children.Add(orangeContentPage);



        }
    }
}
