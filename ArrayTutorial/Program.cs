/*Code Commented Out
string[] names = new string[] { "Jack", "Erik", "Caleb", "Sam", "James", "Ian", "Billy","Josh"};
Console.WriteLine($"{names[0],5} | {names[1],5} | {names[2],5} | {names[3],5} | {names[4],5} | {names[5],5} | {names[6],5} | {names[7],5}");




int[] scores2 = new int[] { 100, 95, 97, 100, 93 };         //Don't have to include the "new int[]"
Console.WriteLine($"{scores2[0],5} | {scores2[1],5} | {scores2[2],5} | {scores2[3],5} | {scores2[4],5}");
//This does the same thing as the code below

int[] scores = new int[5];
scores[0] = 100;
scores[1] = 95;
scores[2] = 97;
scores[3] = 100;
scores[4] = 7;
Console.WriteLine($"{scores[0],5} | {scores[1],5} | {scores[2],5} | {scores[3],5} | {scores[4],5}");
/*
The 5 allocates x amount space for each value, in this case it is allocating 5 spaces for each value                             
We do this so the data lines up and looks nicer on print out

*You could do {scores[0],5,C} which would convert the value to Currency. This is refered to as formating

*Random.org - - - - - Gives you random numbers (Good if you need random numbers for exercises)



//Bowling Scores Array Exercise
int[] games = { 145, 264, 244 };
int GrandTotal = games[0] + games[1] + games[2];
Console.WriteLine("Series Total is" + " " + GrandTotal);

//Getting Input From The User       Console.Readline brings the stuff from the user
Console.Write("Enter a String and press enter: ");
string? response = Console.ReadLine();
Console.WriteLine($"You Typed {response}");

//The answer from a Console.ReadLine will always come back as a string
//Below is how you would convert it to the data type you wanted
Console.Write("Guess a Number between 1 and 10: ");
string answer = Console.ReadLine();
int myNumber = Convert.ToInt32(answer);
Console.WriteLine($"The number is {myNumber}");

*/


//Exercise: Allow user to input three values, add them up, and return the result to user
Console.Write("Enter the Score of the First Game: ");
string FirstGame = Console.ReadLine();

Console.Write("Enter the Score of the Second Game: ");
string SecondGame = Console.ReadLine();

Console.Write("Enter the Score of the Third Game: ");
string ThirdGame = Console.ReadLine();

int FirstGameInt = Convert.ToInt32(FirstGame);
int SecondGameInt = Convert.ToInt32(SecondGame);
int ThirdGameInt = Convert.ToInt32(ThirdGame);
int GrandTotal = FirstGameInt + SecondGameInt + ThirdGameInt;

Console.WriteLine($"The Score of the First Game was: {FirstGame} || The Score of the Second Game was: {SecondGame} || The Score of the Third Game was: {ThirdGame}");
Console.WriteLine($"The Grand Total for The Series is: {GrandTotal}");

//How Greg Did it with an Array
int[] scores = new int[3];

Console.Write("Enter 1st Score: ");
string answer = Console.ReadLine();
scores[0] = Convert.ToInt32(answer);

Console.Write("Enter 2nd Score: ");
answer = Console.ReadLine();
scores[1] = Convert.ToInt32(answer);

Console.Write("Enter 3rd Score: ");
answer = Console.ReadLine();
scores[2] = Convert.ToInt32(answer);

int total = scores[0]+ scores[1] + scores[2];
Console.WriteLine($"The Grand Total is: {total}");

