namespace ShowMilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 0;
        int pergunta_count = 1;
        string nivel = "Fácil";
        

        public MainPage()
        {
            InitializeComponent(); 
            lbl_pergunta.Text = pergunta_count.ToString();
            lbl_nivel.Text = nivel.ToString();
            lbl_premio.Text = premio.ToString("C");    
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
                await DisplayAlert("ACERTOU !!", resp, "ok");                
                pergunta_count++;
                avanca_pergunta();
                
            }
            else
            {
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

            if (pergunta_count > 11 && pergunta_count <15)
            {
                premio += 100000;
                this.BindingContext = App.getRendomPerguntaDificeis();
            };
            if (pergunta_count == 15)
            {
                premio += 100000;
                this.BindingContext = App.getRendomPerguntaFinais();
                nivel = "Final";
            };

            if (pergunta_count == 16)
            {
                premio = 1000000;
               
            };

            lbl_pergunta.Text = pergunta_count.ToString();
            lbl_nivel.Text = nivel.ToString();
            lbl_premio.Text =  "R$ " + premio.ToString("C");


        }

       
    }

}
