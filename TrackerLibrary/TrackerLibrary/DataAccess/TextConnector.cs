using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";



        // TODO - Write up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {

            // Load the text file
            // Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the ID
            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new ID
            prizes.Add(model);

            // Convert the prizes to list<string>
            // Save the list<string> to the text file

            prizes.SaveToPrizesFile(PrizesFile);

            return model;

        }
    }
}
