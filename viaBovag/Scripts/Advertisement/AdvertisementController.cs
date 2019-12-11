using System;
using System.Collections.Generic;
using System.Text;

namespace viaBovag
{
    /// <summary>
    /// Controller that checks advertisements and returns correct advertisements.
    /// </summary>
    class AdvertisementController
    {
        TeaserController teaserController = new TeaserController();

        /// <summary>
        /// Adds a new advertisement to the advertisement list.
        /// </summary>
        public void AddAdvertisement(Advertisement advertisement) // To do: advertisement parameter should be json string
        {
            if (filterAdv(advertisement) != null)
            {
                AdvertisementList.advertisementList.Add(advertisement);
                Console.WriteLine("Advertisement added");
            }

        }
        /// <summary>
        /// Filter all advertisements using filterAdv.
        /// </summary>
        /// <param name="advertisements">List of all advertisements.</param>
        /// <returns>Returns list of correct advertisements.</returns>
        public List<Advertisement> filterAdvsList (List<Advertisement> advertisements)
        {
            // List with correct advs to be returned.
            List<Advertisement> corrAdvs = new List<Advertisement>();

            // Loop and check every adv if its a legit adv.
            for (int i = 0; i < advertisements.Count; i++)
            {
                Advertisement adv = filterAdv(advertisements[i]);
                if (adv != null)
                    corrAdvs.Add(adv);
            }

            return corrAdvs;
        }

        /// <summary>
        /// Filter single advertisement on correctness -> email and vrn not empty, price > 0
        /// </summary>
        /// <param name="advertisement">The to be checked advertisement.</param>
        /// <returns>Advertisement if correct, null if not correct.</returns>
        public Advertisement filterAdv (Advertisement advertisement)
        {
            if (checkEmptyVRNandEmail (advertisement) && checkPrice(advertisement))
                return advertisement;
            else
                return null;
        }

        /// <summary>
        /// Method that picks the 3 newest valid advs and make it a teaser.
        /// </summary>
        /// <returns>List with 3 newest advs as teasers</returns>
        public List<Teaser> newAdvs ()
        {
            // Get list with all advertisements and reverse it to get newest adv as first entries.
            List<Advertisement> revAdv = AdvertisementList.advertisementList;
            revAdv.Reverse();
            
            List<Teaser> returnTeasers = new List<Teaser>();

            // Run while not yet 3 teasers to return found.
            while(returnTeasers.Count < 3)
            {
                for (int i = 0; i < revAdv.Count; i++)
                {
                    Teaser teaser = teaserController.advToTeaser(revAdv[i]);

                    if (teaserController.checkEmptyReturnProps(teaser))
                        returnTeasers.Add(teaser);
                    else
                        break;
                }
            }

            return returnTeasers;
        }

        /// <summary>
        /// Method that checks if there are no empty properties for emailadress and vehicle reg number.
        /// </summary>
        /// <param name="adv">Advertisement that needs to be checked.</param>
        /// <returns>True if no empty properties.</returns>
        public bool checkEmptyVRNandEmail(Advertisement adv)
        {
            if (adv.vehicle.vehicleRegistrationNumber == string.Empty || adv.advertiser.advertiser.emailAdress == string.Empty) // To do: make checks for vehicle reg number and emailadress.
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method that checks if price is above 0;
        /// </summary>
        /// <param name="adv">Advertisement that needs to be checked.</param>
        /// <returns>True if price is above 0.</returns>
        public bool checkPrice(Advertisement adv)
        {
            if (adv.price > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Check given url is a correct url.
        /// </summary>
        /// <param name="adv">Advertisement with url that needs to be checked</param>
        /// <returns>True if correct url.</returns>
        public bool checkUrl(Advertisement adv)
        {
            string url = adv.media.mediaList[0].url;

            // Checks if starts with https
            string[] httpsplit = url.Split(':');
            bool https = httpsplit[0] == "https";

            // Checks if adress is bit.ly
            string[] slashsplit = httpsplit[1].Split('/');
            bool bitly = slashsplit[2] == "bit.ly";

            // Check if there is imagecode behind adress.
            bool image = slashsplit[3].Length > 0;

            if (https && bitly && image)
                return true;
            else
                return false;
        }
    }
}
