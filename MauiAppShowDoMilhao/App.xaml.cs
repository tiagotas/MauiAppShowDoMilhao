using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        static List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
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
                Enunciado = "Qual é a moeda oficial dos Estados Unidos?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ESCUDO"},
                    new Alternativa { Correta = false, Descricao = "COROA"},
                    new Alternativa { Correta = true, Descricao = "DÓLAR"},
                    new Alternativa { Correta = false, Descricao = "LIBRA"},
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "21 DE ABRIL"},
                    new Alternativa { Correta = false, Descricao = "12 DE OUTUBRO"},
                    new Alternativa { Correta = true, Descricao = "7 DE SETEMBRO"},
                    new Alternativa { Correta = false, Descricao = "25 DE DEZEMBRO"},
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Quem foi o criador dos personagens Pedrinho, Narizinho e Emília?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MAURÍCIO DE SOUSA"},
                    new Alternativa { Correta = false, Descricao = "ZIRALDO"},
                    new Alternativa { Correta = false, Descricao = "MACHADO DE ASSIS"},
                    new Alternativa { Correta = true, Descricao = "MONTEIRO LOBATO"},
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Em que ano os portugueses descobriram o Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1450"},
                    new Alternativa { Correta = true, Descricao = "1500"},
                    new Alternativa { Correta = false, Descricao = "1550"},
                    new Alternativa { Correta = false, Descricao = "1400"},
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "O violoncelo é um tipo de instrumento de?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "CORDAS"},
                    new Alternativa { Correta = false, Descricao = "SOPRO"},
                    new Alternativa { Correta = false, Descricao = "PERCUSSÃO"},
                    new Alternativa { Correta = false, Descricao = "REPERCUSSÃO"},
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Quantos dias tem um ano bissexto?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "364"},
                    new Alternativa { Correta = false, Descricao = "365"},
                    new Alternativa { Correta = true, Descricao = "366"},
                    new Alternativa { Correta = false, Descricao = "367"},
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Qual cantor ficou conhecido como “o rei do rock”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FRANK SINATRA"},
                    new Alternativa { Correta = false, Descricao = "LITTLE RICHARD"},
                    new Alternativa { Correta = true, Descricao = "ELVIS PRESLEY"},
                    new Alternativa { Correta = false, Descricao = "RICHIE VALENS"},
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Qual cantor é o pai da dupla Sandy e Júnior?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ZEZÉ DI CAMARGO"},
                    new Alternativa { Correta = false, Descricao = "LEONARDO"},
                    new Alternativa { Correta = false, Descricao = "CHITÃOZINHO"},
                    new Alternativa { Correta = true, Descricao = "XORORÓ"},
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PARANÁ"},
                    new Alternativa { Correta = false, Descricao = "SANTA CATARINA"},
                    new Alternativa { Correta = false, Descricao = "SÃO PAULO"},
                    new Alternativa { Correta = true, Descricao = "BAHIA"},
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Capixaba é quem nasce em qual estado brasileiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ESPÍRITO SANTO"},
                    new Alternativa { Correta = false, Descricao = "RIO GRANDE DO NORTE"},
                    new Alternativa { Correta = false, Descricao = "SANTA CATARINA"},
                    new Alternativa { Correta = false, Descricao = "PARANÁ"},
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "O dromedário tem quantas corcovas?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "UMA"},
                    new Alternativa { Correta = false, Descricao = "DUAS"},
                    new Alternativa { Correta = false, Descricao = "TRÊS"},
                    new Alternativa { Correta = false, Descricao = "NENHUMA"},
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "O dromedário tem quantas corcovas?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "UMA"},
                    new Alternativa { Correta = false, Descricao = "DUAS"},
                    new Alternativa { Correta = false, Descricao = "TRÊS"},
                    new Alternativa { Correta = false, Descricao = "NENHUMA"},
                }
            },

        };

        /**
         * Sorteia uma pergunta entre 1 e 20
         */
        public static Pergunta getRandomPerguntaFacil()
        {
            Random r = new Random();
            
            int sorteado = r.Next(1, 13);

            return perguntas_faceis[sorteado];
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
