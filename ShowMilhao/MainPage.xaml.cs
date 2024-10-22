
using Plugin.Maui.Audio;
using ShowMilhao.Models;

namespace ShowMilhao

{
    public partial class MainPage : ContentPage
    {
        double premio = 1000;
        int pergunta_count = 1;
        string nivel = "Fácil";
        double ganho = 0;

        
        public MainPage()
        {
            InitializeComponent();


            lbl_pergunta.Text = pergunta_count.ToString();
            lbl_nivel.Text = nivel.ToString();
            lbl_premio.Text = premio.ToString("C");
            


            //Audio som
            AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync("0.mp3").Result).Play();

        }

        private void TocaSom()
        {
            string track = "";

            

            switch (pergunta_count)
            {
                case 1: 
                    track = "2.wav";
                break;

                case 2:
                    track = "3.wav";
                break;

                case 3:
                    track = "4.wav";
                break;

                case 4:
                    track = "5.wav";
                break;

                case 5:
                    track = "6.wav";
                break;

                case 6:
                    track = "7.wav";
                break;

                case 7:
                    track = "8.wav";
                    break;

                case 8:
                    track = "9.wav";
                    break;

                case 9:
                    track = "10.wav";
                    break;

                case 10:
                    track = "11.wav";
                    break;

                case 11:
                    track = "12.wav";
                    break;

                case 12:
                    track = "13.wav";
                    break;

                case 13:
                    track = "14.wav";
                    break;

                case 14:
                    track = "15.wav";
                    break;

                case 15:
                    track = "16.wav";
                    break;

                

                
            }

            AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync(track).Result).Play();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext =  App.getRendomPerguntaFacil();
            
            tabela.IsVisible = true;
            texto1.IsVisible = false;
            text2.IsVisible = false;
            texto3.IsVisible = false;
            texto4.IsVisible = false;
            comeco.IsVisible = false; 
            alterna.IsVisible = true;
          enuncia.IsVisible = true;
            continua.IsVisible = true;
            para.IsVisible = true;
            rank.IsVisible = false;

            
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

                Stream track = FileSystem.OpenAppPackageFileAsync("naofoi.wav").Result;
                AudioManager.Current.CreatePlayer(track).Play();

                DisplayAlert("Você errou", "Você perdeu", "ok");

                pergunta_count = 0;
                premio = 0;
                Navigation.PushAsync(new fim.Perdeu(ganho));
                
            }



        }

        void avanca_pergunta()
        {
           


            if (pergunta_count < 5)
            {
                ganho = premio;
                premio += 1000;
                this.BindingContext = App.getRendomPerguntaFacil();
                TocaSom();
                
            };

            if (pergunta_count == 5)
            {
                ganho = premio;
                premio = 10000;
                this.BindingContext = App.getRendomPerguntaMedias();
                nivel = "Médio";
                TocaSom() ;
            };

            if (pergunta_count > 5 && pergunta_count < 10)
            {
                ganho = premio;
                premio += 10000;
                this.BindingContext = App.getRendomPerguntaMedias();
                TocaSom();
            };
            
            if (pergunta_count == 10)
            {
                ganho = premio;
                premio = 100000;
                this.BindingContext = App.getRendomPerguntaDificeis();
                nivel="Difícil";
                TocaSom();
            };

            if (pergunta_count > 10 && pergunta_count <15)
            {
                ganho = premio;
                premio += 100000;
                this.BindingContext = App.getRendomPerguntaDificeis();
                TocaSom();
            };
            if (pergunta_count == 15)
            {
                ganho = premio;
                premio = 1000000;
                this.BindingContext = App.getRendomPerguntaFinais();
                nivel = "Final";
                TocaSom();
            };
            if(pergunta_count == 16)
            {
                ganho = premio;
                Navigation.PushAsync(new fim.Ganhou());
            };
         
            pergunta_count++;

            lbl_pergunta.Text = pergunta_count.ToString();
            lbl_nivel.Text = nivel.ToString();
            lbl_premio.Text = premio.ToString("C");

            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {         
            Navigation.PushAsync(new fim.Parou(ganho));
        }
    }

}
