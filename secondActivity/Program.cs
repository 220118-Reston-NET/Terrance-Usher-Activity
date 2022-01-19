// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.Clear();
bool restart = true;
while (restart)
{
     Console.WriteLine("Hello user would you like to watch a show or movie?");
     Console.WriteLine("If show then input 1, if movie then input 2, if neither then input 3.");
     string input = Console.ReadLine();
     if (input == "1")
     {
         bool wrong = true;
         while (wrong)
         {
              Console.WriteLine("\n Awesome then you can watch the hit show The Adventures of Jimmy Neutron, Boy Genius." +
              "\n What episode number do you want to watch? (1 - 60)");
              int input2 = Convert.ToInt32(Console.ReadLine());

              if (1 <= input2 && input2 <= 60)
              {
                  Console.WriteLine("Ah, episode " + input2 + " good choice.");
                  wrong = false;
              }
              else if (1 > input2)
              {
                  Console.WriteLine("\n There are no episodes before episode 1!");
              }
              else if (60 < input2)
              {
                  Console.WriteLine("\n There are no episodes after episode 60!");
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
         Console.WriteLine("\n Booooo no Jimmy Neutron for you then. Bye.");
         restart = false;
     }
     
     else
     {
         Console.WriteLine("\n Please enter 1, 2, or 3.\n");
     }

}