using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class TextConnector : IDataConnection
    {
        // TODO - Write up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
