using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBing.DataModel;

namespace SmartBing
{
    class Spanish : Language
    {
        IDictionary<string, string> WordDictionary = new Dictionary<string, string>
        {
            {"Breeze", "brisa" },
            {"Cafeteria", "cafetería" },
            {"Cigarette", "cigarette" },
            {"Cockroach","cucaracha"},
            {"Hurricane", "huracán" }
        };

        IDictionary<string, OutputData> SmartDictionary = new Dictionary<string, OutputData> {
            {"brisa",
                new OutputData{
                    BasicTranslation = "brisa",
                    OriginOfWord = "ORIGIN: Spanish->English[16th Century]",
                    SpecialPhonology = "PHONETICS:brisa -> briːz",
                    GenderNeutrality = "GenderNeutral: No <Feminine> [la brisa]",
                    Morphology = "MORPHOLOGY: Lexeme <Noun>[breeze]",
                    DidYouKnowFacts = "Brisa is a popular baby name in Spain!",
                    VideoLink = "Song : Brisa del mar --> https://www.youtube.com/watch?v=rxEopNltKeQ "
                }
            },
            {"cafetería",
                new OutputData{
                    BasicTranslation = "cafetería",
                    OriginOfWord = "ORIGIN: Spanish->English[mid 19th Century]",
                    SpecialPhonology = "PHONETICS: cafetereeria/kafɪˈtɪərɪə",
                    GenderNeutrality = "GenderNeutral: No <Feminine> [la cafetería]",
                    Morphology = "MORPHOLOGY: Compound Noun[Coffee shop]",
                    DidYouKnowFacts = "",
                    VideoLink = "https://www.youtube.com/watch?v=zhyVUMUKGBE "
                }
            },
            {"cigarette",
                new OutputData{
                    BasicTranslation = "cigarette",
                    OriginOfWord = "ORIGIN: Spanish/French->English[mid 19th Century]",
                    SpecialPhonology = "PHONETICS: ˈsigarret/sɪɡəˈrɛt",
                    GenderNeutrality = "GenderNeutral: No <Feminine> [la cigarette]",
                    Morphology = "MORPHOLOGY: Lexeme <Noun>[Cigare]",
                    DidYouKnowFacts = "",
                    VideoLink = " "
                }
            },
            {"cucaracha",
                new OutputData{
                    BasicTranslation = "cucaracha",
                    OriginOfWord = "ORIGIN: Spanish->English[early 17th Century]",
                    SpecialPhonology = "PHONETICS: kukaracha/kɒkrəʊtʃ",
                    GenderNeutrality = "GenderNeutral: No <Feminine> [la cucaracha]",
                    Morphology = "MORPHOLOGY: Lexeme <Noun>[Cockroach]",
                    DidYouKnowFacts = "La cucaracha is a traditional folk song which became poular during Mexican revolution!",
                    VideoLink = "https://en.wikipedia.org/wiki/La_Cucaracha "
                }
            },

            {"huracán",
                new OutputData{
                    BasicTranslation = "huracán",
                    OriginOfWord = "ORIGIN: Spanish->English[mid 16th Century]",
                    SpecialPhonology = "PHONETICS: hoorakan/hʌrɪkeɪn",
                    GenderNeutrality = "GenderNeutral: No <Masculine> [la huracán]",
                    Morphology = "MORPHOLOGY: <Noun> [God of the Storm]",
                    DidYouKnowFacts = "The Lamborgini Huracán was named the Supercar of the year 2014!",
                    VideoLink = "https://edition.cnn.com/videos/spanish/2017/09/06/cnnee-vo-cafe-alerta-por-el-huracan-irma-en-el-caribe-y-la-florida.cnn "
                }
            }
        };
        public override OutputData GetSmartTranslation(string translatedWord)
        {
            try
            {
                return SmartDictionary[translatedWord];
            }
            catch
            {
            }

            return new OutputData().EmptyOutputData("Empty");
        }

        public override string GetVernacularWord(InputData inputData)
        {
            try
            {
                return WordDictionary[inputData.InputWord];
            }
            catch
            {
            }

            return "";
        }
    }
}
