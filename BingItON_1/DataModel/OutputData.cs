using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBing.DataModel
{
    class OutputData
    {
        public string BasicTranslation { get; set; }
        public string OriginOfWord { get; set; }
        public string SpecialPhonology { get; set; }
        public string GenderNeutrality { get; set; }
        public string Morphology { get; set; }
        public string DidYouKnowFacts { get; set; }
        public string VideoLink { get; set; }

        public override string ToString()
        {
            return BasicTranslation + "\r\n" +
                OriginOfWord + "\r\n" +
                SpecialPhonology + "\r\n" +
                GenderNeutrality + "\r\n" +
                Morphology + "\r\n" +
                DidYouKnowFacts + "\r\n" +
                VideoLink;
        }

        public OutputData EmptyOutputData(string empty) {
            return new OutputData {
                BasicTranslation = "",
                OriginOfWord= "",
                SpecialPhonology = "",
                Morphology = "",
                GenderNeutrality = "",
                DidYouKnowFacts = "",
                VideoLink = "" };
        }

    }
}
