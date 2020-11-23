using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CaruselApp
{
    public partial class MainPage : CarouselPage
    {
        Image img;
        Button btn1, btn2, btn3, btn4, btn5;
        Uri uri;
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
            btn1 = new Button
            {
                BackgroundColor = Color.LightSkyBlue,
                Text = "Нажми, чтобы узнать подробности :)",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
            };
            btn1.Clicked += Btn1_Clicked;
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
        btn1
                    }            
        }
            };
            //-----------------------------------------------------------------------------------------------------------------------------------------------------
            btn2 = new Button
            {
                BackgroundColor = Color.LightSkyBlue,
                Text = "Кликай скорее!:)",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
            };
            btn2.Clicked += Btn2_Clicked;
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
                        btn2
                    }
                }
            };
            //--------------------------------------------------------------------------------------------------------------------------------------------
            btn3 = new Button
            {
                BackgroundColor = Color.LightSkyBlue,
                Text = "Информация для тебя :)",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
            };
            btn3.Clicked += Btn3_Clicked;
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
                        btn3
                    }
                }
            };
            //----------------------------------------------------------------------------------------------------------------------------------------------
            btn4 = new Button
            {
                BackgroundColor = Color.LightSkyBlue,
                Text = "Кликай скорее!:)",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
            };
            btn4.Clicked += Btn4_Clicked;
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
                        btn4
                    }
                }
            };
            //----------------------------------------------------------------------------------------------------------------------------------------------
            btn5 = new Button
            {
                BackgroundColor = Color.LightSkyBlue,
                Text = "Тест на темперамент",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
            };
            btn5.Clicked += Btn5_Clicked;
            var ssilkaContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                        {
                        new Image
                        {
                            Source = "maxresdefault.jpg",
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                        },

                        new Label
                        {
                            Text = "Пройди тест на темперамент!",//Text
                            TextColor = Color.Black,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        },
                        btn5
                    }
                }
            };
        //----------------------------------------------------------------------------------------------------------------------------------------------
        Children.Add(glavnajaContentPage);
            Children.Add(yellowContentPage);
            Children.Add(greenContentPage);
            Children.Add(blackContentPage);
            Children.Add(orangeContentPage);
            Children.Add(ssilkaContentPage);
        }

        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(uri);
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            btn4.Text = @"Меланхо́лик (др.-греч. μελαγχολικός «одержимый меланхолией», от μελαγχολία «излияние чёрной жёлчи», ← μέλας «чёрный; тёмный» + χολή «жёлчь; гнев»; буквально: «чёрная жёлчь») — один из четырёх типов темперамента в классификации Гиппократа, характеризующийся инертностью нервной системы, слабостью процессов возбуждения и торможения при их неуравновешенности (характерно преобладание процессов торможения), повышенной чувствительностью и высокой реактивностью психики.";
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            btn3.Text = @"Флегматик (греч. φλέγμα [флегма] — мокрота, слизь) — один из четырёх типов темперамента в классификации Гиппократа. ";
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            btn2.Text = @"Сангвиник (лат. sanguis [сангвис], «кровь», «жизненная сила») — один из четырёх типов темперамента в классификации Гиппократа (преобладание крови).\nЧеловека сангвинического темперамента можно охарактеризовать как живого, подвижного,\nсравнительно легко переживающего неудачи и неприятности.\nТакой темперамент имели Александр Иванович Герцен, австрийский композитор Вольфганг Амадей Моцарт, а также Наполеон Бонапарт";
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            btn1.Text = @"Темпераментный, неуравновешенный человек, легко возбуждающийся\nпод действием каких-н. впечатлений.";
        }
    }
}
