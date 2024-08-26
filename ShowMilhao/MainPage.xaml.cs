namespace ShowMilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 0;
        int pergunta_count = 0;

        public MainPage()
        {
            InitializeComponent();
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
                avanca_pergunta();
                pergunta_count++;
                
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
            }

            if (pergunta_count > 5 && pergunta_count <= 10)
            {
                premio += 10000;
                this.BindingContext = App.getRendomPerguntaMedias();
            }

            if (pergunta_count > 10 && pergunta_count <=15)
            {
                premio += 100000;
                this.BindingContext = App.getRendomPerguntaDificeis();
            }

           

        }

       
    }

}
