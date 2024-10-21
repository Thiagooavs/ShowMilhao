using ShowMilhao.Models;

namespace ShowMilhao.fim;

public partial class Parou : ContentPage
{
	public Parou(double? valor_ganho = 0)
	{
		InitializeComponent();

        pontuacao.Text = valor_ganho.ToString();

    }
}