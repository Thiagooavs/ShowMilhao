using ShowMilhao.Models;

namespace ShowMilhao.fim;

public partial class Parou : ContentPage
{
	public Parou(double? valor_ganho = 0)
	{
		InitializeComponent();

        pontuacao.Text = "R$ " + valor_ganho.ToString() + ",00";

    }

   
    private void comeco_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}