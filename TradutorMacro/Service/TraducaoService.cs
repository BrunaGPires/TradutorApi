using TradutorMacro.Model;

namespace TradutorMacro.Service
{
    public class TraducaoService
    {
        private static readonly Dictionary<string, TraducaoModel> Traducoes = new()
    {
        {"olá", new TraducaoModel
            {
                Ingles = "Hello",
                Frances = "Bonjour",
                Espanhol = "Hola",
                Portugues = "Olá"
            }
        },
        {"tchau", new TraducaoModel
            {
                Ingles = "Goodbye",
                Frances = "Au revoir",
                Espanhol = "Adiós",
                Portugues = "Tchau"
            }
        },
        {"pão", new TraducaoModel
            {
                Ingles = "Bread",
                Frances = "Pain",
                Espanhol = "Pan",
                Portugues = "Pão"
            }
        },
        {"bom dia", new TraducaoModel
            {
                Ingles = "Good morning",
                Frances = "Bonjour",
                Espanhol = "Buen día",
                Portugues = "Bom dia"
            }
        },
        {"boa tarde", new TraducaoModel
            {
                Ingles = "Good afternoon",
                Frances = "Bon après-midi",
                Espanhol = "Buenas tardes",
                Portugues = "Boa tarde"
            }
        },
        {"boa noite", new TraducaoModel
            {
                Ingles = "Good evening",
                Frances = "Bonne nuit",
                Espanhol = "Buenas noches",
                Portugues = "Boa noite"
            }
        },
    };

        public string Traduz(string palavra, string idioma)
        {
            var traducaoModel = Traducoes.ContainsKey(palavra.ToLowerInvariant()) ? Traducoes[palavra.ToLowerInvariant()] : null;
            if (traducaoModel == null)
            {
                return "Tradução indisponível para palavra informada..";
            }

            var palavraTraduzida = GetTraducaoIdioma(traducaoModel, idioma.ToLowerInvariant());

            return palavraTraduzida ?? "Tradução indisponível para idioma informado.";
        }

        private string GetTraducaoIdioma(TraducaoModel traducaoModel, string targetLanguage)
        {
            switch (targetLanguage)
            {
                case "en":
                    return traducaoModel.Ingles;
                case "fr":
                    return traducaoModel.Frances;
                case "es":
                    return traducaoModel.Espanhol;
                case "pt":
                    return traducaoModel.Portugues;
                default:
                    return null;
            }
        }
    }
}
