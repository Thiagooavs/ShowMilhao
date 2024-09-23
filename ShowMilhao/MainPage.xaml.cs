using Plugin.Maui.Audio;

namespace ShowMilhao

{
    public partial class MainPage : ContentPage
    {
        double premio = 1000;
        int pergunta_count = 1;
        string nivel = "Fácil";
        

        public MainPage()
        {
            InitializeComponent();

            Stream track = FileSystem.OpenAppPackageFileAsync("abertura-show-do-milhao.mp3").Result;
            AudioManager.Current.CreatePlayer(track).Play();

            lbl_pergunta.Text = pergunta_count.ToString();
            lbl_nivel.Text = nivel.ToString();
            lbl_premio.Text = premio.ToString("C");

            this.BindingContext = App.getRendomPerguntaFacil();

            //Audio som
            
             
        }

        private void TocaSom()
        {
            string track = "";

            

            switch (pergunta_count)
            {
                case 1: 
                    track = "1000.wav";
                break;

                case 2:
                    track = "2000.wav";
                break;

                case 3:
                    track = "3000.wav";
                break;

                case 4:
                    track = "4000.wav";
                break;

                case 5:
                    track = "5000.wav";
                break;

                case 6:
                    track = "10000.wav";
                break;

                case 7:
                    track = "20000.wav";
                    break;

                case 8:
                    track = "30000.wav";
                    break;

                case 9:
                    track = "40000.wav";
                    break;

                case 10:
                    track = "50000.wav";
                    break;

                case 11:
                    track = "100000a.wav";
                    break;

                case 12:
                    track = "200000.wav";
                    break;

                case 13:
                    track = "300000.wav";
                    break;

                case 14:
                    track = "400000.wav";
                    break;

                case 15:
                    track = "500000.wav";
                    break;

                case 16:
                    track = "1000000.wav";
                    break;

                
            }

            AudioManager.Current.CreatePlayer(
                FileSystem.OpenAppPackageFileAsync(track).Result).Play();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext =  App.getRendomPerguntaFacil();
        }

        private async void Button_Clicked_Proximo(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if((bool) alt0.Value)
                {
                    acertou = true;
                    resp = alt0.Content.ToString();
                    
                }
            }

            if (alt1.IsChecked)
            {
                if ((bool)alt1.Value)
                {
                    acertou = true;
                    resp = alt1.Content.ToString();

                }
            }

            if (alt2.IsChecked)
            {
                if ((bool)alt2.Value)
                {
                    acertou = true;
                    resp = alt2.Content.ToString();

                }
            }

            if (alt3.IsChecked)
            {
                if ((bool)alt3.Value)
                {
                    acertou = true;
                    resp = alt3.Content.ToString();

                }
            }

            if (acertou)
            {
                Stream track = FileSystem.OpenAppPackageFileAsync("acertou.wav").Result;
                AudioManager.Current.CreatePlayer(track).Play();
                

                await DisplayAlert("ACERTOU !!", resp, "ok");                
                
                avanca_pergunta();
                
            }
            else
            {

                Stream track = FileSystem.OpenAppPackageFileAsync("errou.wav").Result;
                AudioManager.Current.CreatePlayer(track).Play();

                DisplayAlert("Você errou", "Você perdeu", "ok");
                
            }



        }

        void avanca_pergunta()
        {
           


            if (pergunta_count <= 5)
            {
                premio += 1000;
                this.BindingContext = App.getRendomPerguntaFacil();
            };

            if (pergunta_count == 6)
            {
                premio = 10000;
                this.BindingContext = App.getRendomPerguntaMedias();
                nivel = "Médio";
            };

            if (pergunta_count > 6 && pergunta_count <= 10)
            {
                premio += 10000;
                this.BindingContext = App.getRendomPerguntaMedias();
            };
            
            if (pergunta_count == 11)
            {
                premio = 100000;
                this.BindingContext = App.getRendomPerguntaDificeis();
                nivel="Difícil";
            };

            if (pergunta_count > 11 && pergunta_count <=15)
            {
                premio += 100000;
                this.BindingContext = App.getRendomPerguntaDificeis();
            };
            if (pergunta_count == 16)
            {
                premio = 1000000;
                this.BindingContext = App.getRendomPerguntaFinais();
                nivel = "Final";
            };
         
            lbl_pergunta.Text = pergunta_count.ToString();
            lbl_nivel.Text = nivel.ToString();
            lbl_premio.Text =  "R$ " + premio.ToString("C");

            pergunta_count++;
        }

       
    }

}
