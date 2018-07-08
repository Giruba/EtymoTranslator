using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBing.DataModel;

namespace SmartBing
{
    class Hindi : Language
    {
        IDictionary<string, string> WordDictionary = new Dictionary<string, string>
        {
            {"Avatar", "अवतार" },
            {"Chutney", " चटनी" },
            {"Yoga", "योग" },
            {"Cheetah","चीता"},
            {"Cot", "खाट" }
        };

        IDictionary<string, OutputData> SmartDictionary = new Dictionary<string, OutputData> {
            {"अवतार",
                new OutputData{
                    BasicTranslation = "अवतार",
                    OriginOfWord = "ORIGIN: Sanskrit/Hindi->English",
                    SpecialPhonology = "PHONETICS:avtar -> avətɑː",
                    GenderNeutrality = "GenderNeutral: Yes",
                    Morphology = "MORPHOLOGY: Lexeme <Noun>[Descent]",
                    DidYouKnowFacts = "The Hindu Deity Vishnu has 10 avatars!",
                    VideoLink = ""
                }
            },
            {"चटनी",
                new OutputData{
                    BasicTranslation = "चटनी",
                    OriginOfWord = "ORIGIN: Hindi->English[early 19th Century]",
                    SpecialPhonology = "PHONETICS: chutni/tʃʌtni",
                    GenderNeutrality = "GenderNeutral: No",
                    Morphology = "MORPHOLOGY: Word[lick]",
                    DidYouKnowFacts = "",
                    VideoLink = ""
                }
            },
            {"चीता",
                new OutputData{
                    BasicTranslation = "चीता",
                    OriginOfWord = "ORIGIN: Hindi->English",
                    SpecialPhonology = "PHONETICS: Cheetha/ˈtʃiːtə",
                    GenderNeutrality = "GenderNeutral: No <Feminine> [एक चीता चल रही है]",
                    Morphology = "MORPHOLOGY: Lexeme <Noun>[Variegated]",
                    DidYouKnowFacts = "Fastest animal",
                    VideoLink = "https://www.youtube.com/watch?v=V8vejjVgIHg"
                }
            },
            {"खाट",
                new OutputData{
                    BasicTranslation = "खाट",
                    OriginOfWord = "ORIGIN: Spanish->English[mid 17th Century]",
                    SpecialPhonology = "PHONETICS: khaat/kɒt",
                    GenderNeutrality = "GenderNeutral: No <Feminine> [खाट आ रही है]",
                    Morphology = "MORPHOLOGY: Lexeme <Noun>[Bed]",
                    DidYouKnowFacts = "Mattress and beds were invented in the Neolithic period!",
                    VideoLink = ""
                }
            },

            {"योग",
                new OutputData{
                    BasicTranslation = "योग",
                    OriginOfWord = "ORIGIN: Spanish->English[mid 16th Century]",
                    SpecialPhonology = "PHONETICS: yoga/ˈjoʊɡə",
                    GenderNeutrality = "GenderNeutral: No <Masculine> [योग मुझे आमंत्रित कर रहा है]",
                    Morphology = "MORPHOLOGY: <Verb->Noun> [To Attach/Join/Unite]",
                    DidYouKnowFacts = "Yoga is listed by UNESCO as an Intangible Culural heritage!",
                    VideoLink = "https://www.youtube.com/watch?v=8VwufJrUhic"
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
