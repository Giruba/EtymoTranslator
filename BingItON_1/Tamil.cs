using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBing.DataModel;

namespace SmartBing
{
    class Tamil : Language
    {

        IDictionary<string, string> WordDictionary = new Dictionary<string, string> {
            {"Cheroot", "சுருட்டு" },
            {"Teak", "தேக்கு" },
            {"Culvert", "கல்வெட்டு"},
            {"Catamaran", "கட்டுமரம்" },
            {"Clay", "களி" }
        };

        IDictionary<string, OutputData> SmartDictionary = new Dictionary<string, OutputData> {
            {"சுருட்டு",
                new OutputData{
                    BasicTranslation = "சுருட்டு",
                    OriginOfWord = "ORIGIN: Tamil->French->English[17th Century]",
                    SpecialPhonology = "PHONETICS:[suruṭṭu]",
                    GenderNeutrality = "GenderNeutral: Yes",
                    Morphology = "MORPHOLOGY: Word Formation <Verb>[Roll]",
                    DidYouKnowFacts = "Cheroot Smoking Prevents Malaria!",
                    VideoLink = "On the road to Mandalay by Rudyrad Kipling[1892] --> https://en.wikipedia.org/wiki/Cheroot "
                }
            },
            {"தேக்கு",
                new OutputData{
                    BasicTranslation = "தேக்கு",
                    OriginOfWord = "ORIGIN: Tamil->Portuguese->English[17th Century]",
                    SpecialPhonology = "PHONETICS: tēkku",
                    GenderNeutrality = "GenderNeutral: Yes",
                    Morphology = "MORPHOLOGY: Word Formation <Noun>[Name]",
                    DidYouKnowFacts = "Biggest living teak is in Mynamar!",
                    VideoLink = " "
                }
            },
            {"கல்வெட்டு",
                new OutputData{
                    BasicTranslation = "கல்வெட்டு",
                    OriginOfWord = "ORIGIN: Tamil->English[18th Century]",
                    SpecialPhonology = "PHONETICS: ˈkʌlvət",
                    GenderNeutrality = "GenderNeutral: Yes",
                    Morphology = "MORPHOLOGY: Word Formation <Noun+Verb>[Cut Stone]",
                    DidYouKnowFacts = "",
                    VideoLink = " "
                }
            },
            {"கட்டுமரம்",
                new OutputData{
                    BasicTranslation = "கட்டுமரம்",
                    OriginOfWord = "ORIGIN: Tamil->English[17th Century]",
                    SpecialPhonology = "PHONETICS: ˈkattumaram",
                    GenderNeutrality = "GenderNeutral: Yes",
                    Morphology = "MORPHOLOGY: Word Formation <Noun+Verb>[Tied Wood]",
                    DidYouKnowFacts = "The DMK Leader Karunanidhi is trolled as Kattumaram!",
                    VideoLink = " "
                }
            },

            {"களி",
                new OutputData{
                    BasicTranslation = "களி",
                    OriginOfWord = "ORIGIN: Tamil->German->OldEnglish->Dutch->English[17th Century]",
                    SpecialPhonology = "PHONETICS: Kali",
                    GenderNeutrality = "GenderNeutral: Yes",
                    Morphology = "MORPHOLOGY: Word Formation <Noun>",
                    DidYouKnowFacts = "Kaolin clay is an anti-diarrheal medicine",
                    VideoLink = " "
                }
            }
        };
        public override OutputData GetSmartTranslation(string translatedWord)
        {
            try
            {
                return SmartDictionary[translatedWord];
            }
            catch {                
            }

            return new OutputData().EmptyOutputData("Empty");
        }

        public override string GetVernacularWord(InputData inputData)
        {
            try
            {
                return WordDictionary[inputData.InputWord];
            }
            catch {
            }

            return "";
        }
    }
}
