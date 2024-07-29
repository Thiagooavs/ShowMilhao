using ShowMilhao.Models;

namespace ShowMilhao
{
    public partial class App : Application
    {


        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo? ",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO"},
                    new Alternativa { Correta = true, Descricao = "SÓLIDO"},
                    new Alternativa { Correta = false, Descricao = "GASOSO"},
                    new Alternativa { Correta = false, Descricao = "VAPOROSO"},
                }

            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARGARIDA"},
                    new Alternativa { Correta = true, Descricao = "MINNIE"},
                    new Alternativa { Correta = false, Descricao = "A PEQUENA SEREIA"},
                    new Alternativa { Correta = false, Descricao = "OLÍVIA PALITO"},
                }

            },
            new Pergunta
            {
                Id =3,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CUCA"},
                    new Alternativa { Correta = false, Descricao = "NEGRINHO DO PASTOREIO"},
                    new Alternativa { Correta = false, Descricao = "BOITATÁ"},
                    new Alternativa { Correta = true, Descricao = "SACI-PERERE"},
                }
            },
            new Pergunta
            {
                Id= 4,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAMAICA"},
                    new Alternativa { Correta = true, Descricao = "CUBA"},
                    new Alternativa { Correta = false, Descricao = "EL SALVADOR"},
                    new Alternativa { Correta = false, Descricao = "MÉXICO"},
                }
            },
            new Pergunta
            {
                Id=5,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=6,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "BARÃO DE MAUA"},
                    new Alternativa { Correta = true, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARQUES POMBAL"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=7,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=8,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=9,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=10,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=11,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=12,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=13,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=14,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=15,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
        };

        List<Pergunta> perguntas_medias = new()
        {


        };

        List<Pergunta> perguntas_dificeis = new()
        {


        };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
