// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EpisodeListFunction;
using SerializationFunction;


bool restart = true;
Dictionary<int,string> UserList = new Dictionary<int, string>();

while (restart)
{
    Console.Clear();
     Console.WriteLine("Hello user would you like to watch a show or movie?" + 
     "\nIf show then input 1, if movie then input 2, if you " + 
     "\nwould like to update your watchlist input 3,if you would like to " +
     "\nsearch an episode by number input 4, and if neither then input 0.");
     string input = Console.ReadLine();
     if (input == "1")
     {
         bool wrong = true;
         while (wrong)
         {
             Console.Clear();
              Console.WriteLine("\n Awesome then you can watch the hit show The Adventures of Jimmy Neutron, Boy Genius." +
              "\n What episode number do you want to watch? (1 - 60)");
              int input2 = Convert.ToInt32(Console.ReadLine());

              if (1 <= input2 && input2 <= 60)
              {
                  Console.WriteLine("\nAh, episode " +input2 + " " + EpisodeList._episode[input2] + " good choice.");
                  wrong = false;
              }
              else if (1 > input2)
              {
                  Console.WriteLine("\n There are no episodes before episode 1!");
                  Console.ReadLine();
              }
              else if (60 < input2)
              {
                  Console.WriteLine("\n There are no episodes after episode 60!");
                  Console.ReadLine();
              }

         }
         restart = false;
     }

     else if (input == "2")
     {
         Console.WriteLine("\n Cool then get ready to watch the hit movie Jimmy Neutron: Boy Genius!");
         restart = false;
     }

     else if (input == "3")
     {
         bool awl = true;
         while (awl)
         {
             Console.Clear();
             
             Console.WriteLine("\nWhat would you like to do with your Already Watched List (AWL)?" +
             "\nIf you would like to view your AWL input 1, if you would like to add an episode input 2," + 
             " if you would like to remove an episode" + "\nfrom your AWL input 3, if you would like to save your AWL input 4 " + 
             "and would like to escape this menu input 0.");

             string userAWLInput = Console.ReadLine();
             
             if (userAWLInput == "1")
             {
                 Console.WriteLine("\nThe following is your Already Watched List: \n");
                 EpisodeList.DisplayAWL(UserList);
             }
             
             else if (userAWLInput == "2")
             {
                 EpisodeList.AddEpisode(UserList);
             }

             else if (userAWLInput == "3")
             {
                 EpisodeList.RemoveEpisode(UserList);
             }
            
             else if (userAWLInput == "4")
             {
                 Serialization.EpisodeSerialize(UserList);
             }

             else if (userAWLInput == "0")
             {
                 awl = false;
             }

             else
             {
                 Console.WriteLine("Please input either 1, 2, 3, or 4.");
             }
         }

     }

     else if (input == "4")
     {
        EpisodeList.SearchEpisode();
     }
     
        else if (input == "0")
     {
        Console.WriteLine("\n Booooo no Jimmy Neutron for you then. Bye.");
        restart = false;
     }
     
     else
     {

        Console.WriteLine("\n Please enter 1, 2, or 3.\n");
     }

}