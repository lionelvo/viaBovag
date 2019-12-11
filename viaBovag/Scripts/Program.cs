using System;
using System.Collections.Generic;

namespace viaBovag
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonOperator jsonOperator = new JsonOperator();
            AdvertisementController advController = new AdvertisementController();

            //Testing purposes
            TestInput testInput = new TestInput();

            // This should be done by jsonoperator class.
            List<Advertisement> advList = testInput.testInput;

            // Advertisement advertisement = jsonOperator.deserializeJson("../../../Advertisements/Advertisement.json");
            for(int j = 0; j < advList.Count; j++)
            {
                advController.AddAdvertisement(advList[j]);
            }

            Console.WriteLine(AdvertisementList.advertisementList.Count);
            Console.ReadLine();

            // Generate new teasers;
            List<Teaser> newTeas = advController.newAdvs();

            // Write to file
            for(int i = 0; i < newTeas.Count; i++)
            {
                string json = jsonOperator.serializeJson(newTeas[i]);
                jsonOperator.teaserFile("../../../JSON/Teasers/teasers.json", json);
            }
        }
    }
}
