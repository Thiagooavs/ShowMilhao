namespace ShowMilhao.fim;

public partial class Perdeu : ContentPage
{
	public Perdeu(double? valor_ganho = 0)
	{
		InitializeComponent();

		pontuacao.Text = "R$ " + (valor_ganho / 2).ToString() + ",00";

	}
}