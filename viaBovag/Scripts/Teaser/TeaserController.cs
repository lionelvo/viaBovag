using System;
using System.Collections.Generic;
using System.Text;

namespace viaBovag
{
    /// <summary>
    /// Controller that handles all teaser operations.
    /// </summary>
    class TeaserController
    {
        /// <summary>
        /// Method that checks if there are no empty properties in a teaser
        /// </summary>
        /// <param name="adv">Advertisement that needs to be checked.</param>
        /// <returns>True if no empty properties.</returns>
        public bool checkEmptyReturnProps(Teaser teaser)
        {
            if (teaser.title == null || teaser.imageUrl == null || teaser.advertiser == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method that converts an advertisement to a teaser.
        /// </summary>
        /// <param name="adv">The to converted advertisement.</param>
        /// <returns>The converted teaser.</returns>
        public Teaser advToTeaser(Advertisement adv)
        {
            Teaser teaser = new Teaser();
            teaser.title = adv.title;
            teaser.imageUrl = adv.media.mediaList[0].url;
            teaser.advertiser = adv.advertiser.advertiser.name;
            return teaser;
        }
    }
}
