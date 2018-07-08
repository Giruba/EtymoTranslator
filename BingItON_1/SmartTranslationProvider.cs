using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBing.DataModel;

namespace SmartBing
{
    class SmartTranslationProvider : OrignPhonoMorphoStrategy
    {
        Language language;
        public string GetBasicTranslation(InputData inputData)
        {
            switch (inputData.Language) {

                case "Tamil":
                    language = new Tamil();
                    break;
                case "Spanish":
                    language = new Spanish();
                    break;
                case "Hindi":
                    language = new Hindi();
                    break;
            }
            return language.GetVernacularWord(inputData);
        }
        public OutputData AddSmartTranslation(string translatedWord)
        {
            return language.GetSmartTranslation(translatedWord);
        }
    }
}
