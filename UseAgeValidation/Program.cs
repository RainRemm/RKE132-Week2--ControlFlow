

//rakendus küsib kasutajal sisestada enda vanust    
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age");

string userAge = Console.ReadLine(); // "13" - heap, 13 - stack

int userAgeNum = 0;

//boolean - true/false  

bool isAgeNumber = Int32.TryParse (userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

Console.WriteLine($"Parse result{isAgeNumber}. User is {userAgeNum} years old."); //true/false (isAgeNumber);

if (isAgeNumber == true)
{
   if (userAgeNum >= 13)
   { 
        Console.WriteLine("Welcome to Instagram"); 
    
   }

   else
   { Console.WriteLine("you are to young to use Instagram");

   }

}

else //if (userAge < 13)
{
    Console.WriteLine("Could not read your age. ");
}