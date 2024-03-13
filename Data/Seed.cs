using geosphere_api.Models;

namespace geosphere_api.Data
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            this._context = context;
        }

        public void SeedDataContext()
        {
            if (!_context.Places.Any())
            {
                //var places = new List<Place>() {
                //    new Place
                //    {
                //        Name = "National Mall",
                //        Description = "National Mall",
                //        Coordinates = [-77.0335578918457f, 38.887926299094204f],
                //        Ressources = new List<Ressource>()
                //        {
                //            new Ressource
                //            {
                //                Description = "Big Buck Bunny tells the story of a giant rabbit with a heart bigger than himself. When one sunny day three rodents rudely harass him, something snaps... and the rabbit ain't no bunny anymore! In the typical cartoon tradition he prepares the nasty rodents a comical revenge.\n\nLicensed under the Creative Commons Attribution license\nhttp://www.bigbuckbunny.org",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4",
                //                Name = "Big Buck Bunny",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "The first Blender Open Movie from 2006",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4",
                //                Name = "Elephant Dream",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "HBO GO now works with Chromecast -- the easiest way to enjoy online video on your TV. For when you want to settle into your Iron Throne to watch the latest episodes. For $35.\nLearn how to use Chromecast with HBO GO and more at google.com/chromecast.",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerBlazes.mp4",
                //                Name = "For Bigger Blazes",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "The first Blender Open Movie from 2006",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4",
                //                Name = "Elephant Dream",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "Introducing Chromecast. The easiest way to enjoy online video and music on your TV—for when Batman's escapes aren't quite big enough. For $35. Learn how to use Chromecast with Google Play Movies and more at google.com/chromecast.",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4",
                //                Name = "For Bigger Escape",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "Introducing Chromecast. The easiest way to enjoy online video and music on your TV. For $35.  Find out more at google.com/chromecast.",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerFun.mp4",
                //                Name = "For Bigger Fun",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "Introducing Chromecast. The easiest way to enjoy online video and music on your TV—for the times that call for bigger joyrides. For $35. Learn how to use Chromecast with YouTube and more at google.com/chromecast.",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerJoyrides.mp4",
                //                Name = "For Bigger Joyrides",
                //                Type = Enums.RessourceType.Video
                //            },
                //        }
                //    },
                //    new Place
                //    {
                //        Name = "American University",
                //        Description = "American University",
                //        Coordinates = [-77.08926200866699f, 38.93724724198066f],
                //        Ressources = new List<Ressource>()
                //        {
                //            new Ressource
                //            {
                //                Description = "Introducing Chromecast. The easiest way to enjoy online video and music on your TV—for when you want to make Buster's big meltdowns even bigger. For $35. Learn how to use Chromecast with Netflix and more at google.com/chromecast.",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerMeltdowns.mp4",
                //                Name = "For Bigger Meltdowns",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "Sintel is an independently produced short film, initiated by the Blender Foundation as a means to further improve and validate the free/open source 3D creation suite Blender. With initial funding provided by 1000s of donations via the internet community, it has again proven to be a viable development model for both open 3D technology as for independent animation film.\nThis 15 minute film has been realized in the studio of the Amsterdam Blender Institute, by an international team of artists and developers. In addition to that, several crucial technical and creative targets have been realized online, by developers and artists and teams all over the world.\nwww.sintel.org",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/Sintel.mp4",
                //                Name = "Sintel",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "Smoking Tire takes the all-new Subaru Outback to the highest point we can find in hopes our customer-appreciation Balloon Launch will get some free T-shirts into the hands of our viewers.",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/SubaruOutbackOnStreetAndDirt.mp4",
                //                Name = "Subaru Outback On Street And Dirt",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "Tears of Steel was realized with crowd-funding by users of the open source 3D creation tool Blender. Target was to improve and test a complete open and free pipeline for visual effects in film - and to make a compelling sci-fi film in Amsterdam, the Netherlands.  The film itself, and all raw material used for making it, have been released under the Creatieve Commons 3.0 Attribution license. Visit the tearsofsteel.org website to find out more about this, or to purchase the 4-DVD box with a lot of extras.  (CC) Blender Foundation - http://www.tearsofsteel.org",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/TearsOfSteel.mp4",
                //                Name = "Tears of Steel",
                //                Type = Enums.RessourceType.Video
                //            },
                //            new Ressource
                //            {
                //                Description = "The Smoking Tire heads out to Adams Motorsports Park in Riverside, CA to test the most requested car of 2010, the Volkswagen GTI. Will it beat the Mazdaspeed3's standard-setting lap time? Watch and see...",
                //                Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/VolkswagenGTIReview.mp4",
                //                Name = "Volkswagen GTI Review",
                //                Type = Enums.RessourceType.Video
                //            }
                //        }
                //    }
                //};

                //_context.Places.AddRange(places);
                //_context.SaveChanges();
            }
        }
    }
}
