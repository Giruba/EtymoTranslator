using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBing.DataModel;

namespace SmartBing
{
     class OrignPhonoMorphoStrategy : ISmartTranslationStrategy
     {
        public OrignPhonoMorphoStrategy() { }
        OutputData ISmartTranslationStrategy.RetrieveSmartTranslation(InputData inputData)
        {
            OutputData outputData = new OutputData();
            SmartTranslationProvider smartTranslationProvider = new SmartTranslationProvider();
            outputData.BasicTranslation = smartTranslationProvider.GetBasicTranslation(inputData);
            return smartTranslationProvider.AddSmartTranslation(outputData.BasicTranslation);
        }
    }
}
