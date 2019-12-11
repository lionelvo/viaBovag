using System;
using System.Collections.Generic;
using System.Text;

namespace viaBovag
{
    class TestInput
    {
        public List<Advertisement> testInput = new List<Advertisement>();
        public TestInput()
        {
            // Input 1
            Advertisement advertisement = new Advertisement();
            advertisement.title = "Audi uit 2012 in topconditie!";
            advertisement.description = "Lorem ipsum dolor sit amet.";
            advertisement.price = 18575.0f;
            advertisement.advertiser = new AdvertiserJson();
            advertisement.advertiser.advertiser = new Advertiser();
            advertisement.advertiser.advertiser.name = "Audi Specialist Amsterdam";
            advertisement.advertiser.advertiser.emailAdress = "verkoop@audi-specialist.nl";
            advertisement.advertiser.advertiser.phoneNumber = "0208855221";
            advertisement.vehicle = new Vehicle();
            advertisement.vehicle.brand = "Audi";
            advertisement.vehicle.model = "A5 Sportback";
            advertisement.vehicle.year = 2012;
            advertisement.vehicle.vehicleRegistrationNumber = "92-TTL-2";
            advertisement.media = new MediaRoot();
            advertisement.media.mediaList = new List<Media>();
            Media media1 = new Media();
            media1.url = "https://bit.ly/2m4DYRg";
            media1.caption = "Achterkant";
            Media media2 = new Media();
            media2.url = "https://bit.ly/2kuGjVq";
            media2.caption = "Achterkant";
            advertisement.media.mediaList.Add(media1);
            advertisement.media.mediaList.Add(media2);
            testInput.Add(advertisement);

            // Input 2
            Advertisement advertisement2 = new Advertisement();
            advertisement2.title = "BMW";
            advertisement2.description = "Lorem ipsum dolor sit amet.";
            advertisement2.price = 18575.0f;
            advertisement2.advertiser = new AdvertiserJson();
            advertisement2.advertiser.advertiser = new Advertiser();
            advertisement2.advertiser.advertiser.name = "Audi Specialist Amsterdam";
            advertisement2.advertiser.advertiser.emailAdress = "verkoop@audi-specialist.nl";
            advertisement2.advertiser.advertiser.phoneNumber = "0208855221";
            advertisement2.vehicle = new Vehicle();
            advertisement2.vehicle.brand = "Audi";
            advertisement2.vehicle.model = "A5 Sportback";
            advertisement2.vehicle.year = 2012;
            advertisement2.vehicle.vehicleRegistrationNumber = "92-TTL-2";
            advertisement2.media = new MediaRoot();
            advertisement2.media.mediaList = new List<Media>();
            Media media3 = new Media();
            media3.url = "https://bit.ly/2m4DYRg";
            media3.caption = "Achterkant";
            Media media4 = new Media();
            media4.url = "https://bit.ly/2kuGjVq";
            media4.caption = "Achterkant";
            advertisement2.media.mediaList.Add(media3);
            advertisement2.media.mediaList.Add(media4);
            testInput.Add(advertisement2);

            // Input 3
            Advertisement advertisement3 = new Advertisement();
            advertisement3.title = "VW";
            advertisement3.description = "Lorem ipsum dolor sit amet.";
            advertisement3.price = 18575.0f;
            advertisement3.advertiser = new AdvertiserJson();
            advertisement3.advertiser.advertiser = new Advertiser();
            advertisement3.advertiser.advertiser.name = "Audi Specialist Amsterdam";
            advertisement3.advertiser.advertiser.emailAdress = "verkoop@audi-specialist.nl";
            advertisement3.advertiser.advertiser.phoneNumber = "0208855221";
            advertisement3.vehicle = new Vehicle();
            advertisement3.vehicle.brand = "Audi";
            advertisement3.vehicle.model = "A5 Sportback";
            advertisement3.vehicle.year = 2012;
            advertisement3.vehicle.vehicleRegistrationNumber = "92-TTL-2";
            advertisement3.media = new MediaRoot();
            advertisement3.media.mediaList = new List<Media>();
            Media media5 = new Media();
            media5.url = "https://bit.ly/2m4DYRg";
            media5.caption = "Achterkant";
            Media media6 = new Media();
            media6.url = "https://bit.ly/2kuGjVq";
            media6.caption = "Achterkant";
            advertisement3.media.mediaList.Add(media6);
            advertisement3.media.mediaList.Add(media5);
            testInput.Add(advertisement3);

            // Input 4
            Advertisement advertisement4 = new Advertisement();
            advertisement4.title = "Opel";
            advertisement4.description = "Lorem ipsum dolor sit amet.";
            advertisement4.price = 18575.0f;
            advertisement4.advertiser = new AdvertiserJson();
            advertisement4.advertiser.advertiser = new Advertiser();
            advertisement4.advertiser.advertiser.name = "Audi Specialist Amsterdam";
            advertisement4.advertiser.advertiser.emailAdress = "";
            advertisement4.advertiser.advertiser.phoneNumber = "0208855221";
            advertisement4.vehicle = new Vehicle();
            advertisement4.vehicle.brand = "Audi";
            advertisement4.vehicle.model = "A5 Sportback";
            advertisement4.vehicle.year = 2012;
            advertisement4.vehicle.vehicleRegistrationNumber = "92-TTL-2";
            advertisement4.media = new MediaRoot();
            advertisement4.media.mediaList = new List<Media>();
            Media media7 = new Media();
            media7.url = "https://bit.ly/2m4DYRg";
            media7.caption = "Achterkant";
            Media media8 = new Media();
            media8.url = "https://bit.ly/2kuGjVq";
            media8.caption = "Achterkant";
            advertisement4.media.mediaList.Add(media7);
            advertisement4.media.mediaList.Add(media8);
            testInput.Add(advertisement4);
        }
    }
}
