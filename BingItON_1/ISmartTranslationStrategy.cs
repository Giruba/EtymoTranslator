using SmartBing.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBing
{
    interface ISmartTranslationStrategy
    {
        OutputData RetrieveSmartTranslation(InputData inputData);
    }
}
