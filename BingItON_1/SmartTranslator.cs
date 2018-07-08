using SmartBing.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBing
{
    class SmartTranslator
    {
        private ISmartTranslationStrategy _SmartTranslationStrategy; 
        public SmartTranslator(ISmartTranslationStrategy strategy) {
            _SmartTranslationStrategy = strategy;
        }

        public OutputData SmartlyTranslate(InputData inputData) {
            return _SmartTranslationStrategy.RetrieveSmartTranslation(inputData);
        }

    }
}
