namespace EpisodeListFunction
{
        class EpisodeList
    {
        public string Title {get; set;}

        public Dictionary<int,EpisodeList> _episode = new Dictionary<int, EpisodeList>()
        {
            {01, new EpisodeList{ Title="When Pants Attack"} }, {02, new EpisodeList{ Title="Normal Boy/Birth fo a Salesman"} }, 
            {03, new EpisodeList{ Title="Brobot/The Big Pinch"} }, {04, new EpisodeList{ Title="Granny Baby/Time is Money"} }, 
            {05, new EpisodeList{ Title="Raise the Oozy Scab/ I Dream of Jimmy"} }, {06, new EpisodeList{ Title="Jimmy on Ice/Battle of the Band"} }, 
            {07, new EpisodeList{ Title="See Jimmy Run/Trading Faces"} }, {08, new EpisodeList{ Title="The Phantom of Retroland/My Son the Hamster"} }, 
            {09, new EpisodeList{ Title="Hall Monster/Hypno Birthday to You"} }, {10, new EpisodeList{ Title="Krunch Time/Substitute Creature"} }, 
            {11, new EpisodeList{ Title="Safety First/Crime Sheen Investigation"} }, {12, new EpisodeList{ Title="Journey to the Center of Carl/Aaughh!! Wilderness!!"} }, 
            {13, new EpisodeList{ Title="Party at Neutron's/Ultra Sheen"} }, {14, new EpisodeList{ Title="Broadcast Blues/Professor Calamitous, I Presume"} }, 
            {15, new EpisodeList{ Title="The Egg-pire Strikes Back"} }, {16, new EpisodeList{ Title="The Egg-pire Strikes Back"} }, 
            {17, new EpisodeList{ Title="Maxium Hugh/Sleepless in Retroville"} }, {18, new EpisodeList{ Title="Make Room for Daddy-O"} }, 
            {19, new EpisodeList{ Title="A Beautiful Mine"} }, {20, new EpisodeList{ Title="Sorry Wrong Era"} }, 
            {21, new EpisodeList{ Title="Beach Party Mummy"} }, {22, new EpisodeList{ Title="The Retroville 9/Grumpy Young Men"} }, 
            {23, new EpisodeList{ Title="Opperation Rescue Jet Fusion"} }, {24, new EpisodeList{ Title="Opperation Rescue Jet Fusion"} }, 
            {25, new EpisodeList{ Title="Nightmare in Retroville"} }, {26, new EpisodeList{ Title="Monster Hunt/Jimmy for President"} }, 
            {27, new EpisodeList{ Title="Return of the Nanobots"} }, {28, new EpisodeList{ Title="Holly Jolly Jimmy"} }, 
            {29, new EpisodeList{ Title="Love Potion 976/J"} }, {30, new EpisodeList{ Title="Sheen's Brain"} }, 
            {31, new EpisodeList{ Title="Maternotron Knows Best/Send in the Clones"} }, {32, new EpisodeList{ Title="The Great Egg Heist/The Feud"} }, 
            {33, new EpisodeList{ Title="Out, Darn Spotlight"} }, {34, new EpisodeList{ Title="The Junkman Cometh"} }, 
            {35, new EpisodeList{ Title="Foul Bull/The Science Fair Affair"} }, {36, new EpisodeList{ Title="Men at Work"} }, 
            {37, new EpisodeList{ Title="The Mighty Wheezers/Billion Dollar Boy"} }, {38, new EpisodeList{ Title="Win, Lose and Kaboom!"} }, 
            {39, new EpisodeList{ Title="Win, Lose and Kaboom!"} }, {40, new EpisodeList{ Title="Win, Lose and Kaboom!"} }, 
            {41, new EpisodeList{ Title="Attack of the Twonkies"} }, {42, new EpisodeList{ Title="Attack of the Twonkies"} }, 
            {43, new EpisodeList{ Title="The N-Men"} }, {44, new EpisodeList{ Title="Lights! Camera! Danger!"} }, 
            {45, new EpisodeList{ Title="Fundemonium"} }, {46, new EpisodeList{ Title="Stranded"} }, 
            {47, new EpisodeList{ Title="Jimmy Goes to College"} }, {48, new EpisodeList{ Title="The Tomorrow Boys"} }, 
            {49, new EpisodeList{ Title="The League of Villains"} }, {50, new EpisodeList{ Title="The League of Villains"} }, 
            {51, new EpisodeList{ Title="Who's Your Mommy/Clash of the Cousins"} }, {52, new EpisodeList{ Title="My Big Fat Spy Wedding"} }, 
            {53, new EpisodeList{ Title="Crouching Jimmy, Hidden Sheen"} }, {54, new EpisodeList{ Title="The Incredible Shrinking Town"} }, 
            {55, new EpisodeList{ Title="One of Us/Vanishing Act"} }, {56, new EpisodeList{ Title="The Trouble with Clones"} }, 
            {57, new EpisodeList{ Title="The Evil Beneath/Carl Wheezer Boy Genius"} }, {58, new EpisodeList{ Title="Who Framed Jimmy Neutron?/Flippy"} }, 
            {59, new EpisodeList{ Title="How to Sink a Sub/Lady Sings the News"} }, {60, new EpisodeList{ Title="King of Mars"} },
            {61, new EpisodeList{ Title="El Magnifico/Best in Show"} } 
        };

        public static void AddEpisode(Dictionary<int,string> userList)
        {
            Console.WriteLine("\nWhat episode would you like to add to your Already Watched List?");
            int EpisodeNumber = Console.ReadLine();
            userList.Add(EpisodeNumber,_episode[EpisodeNumber]);
            Console.WriteLine("\nAlright, I have now added Episode " + EpisodeNumber + " " + userList[EpisodeNumber] + " to you Already Watched List.");
        }

        public static void DisplayAWL(Dictionary<int,string> userList) // Display Already Watched List
        {
            foreach (KeyValuePair<int,string> episode in userList)
            {
                Console.WriteLine("Episode: " + episode.Key + " " + episode.Value);
            }
        }
        public static void DisplayEL() //Display Episode List
        {
            foreach (KeyValuePair<int,string> episode in _episode)
            {
                Console.WriteLine("Episode: " + episode.Key + " " + episode.Value);
            }
        }
    }
}

