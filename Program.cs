// Conditionals


Console.Clear();
string breakPoint = "----------------------------------------------------------------------------------";

// char myChar= 'S';

// string imEmpty = null;

// bool yesNO = true;

//Math Operators
// + - * / The usual suspects for mathmatics
// % Modulo = This is interested in finding the remainder of one number being didvided by another.
// 4%3 = remaninder operation reuslting in a 0 means that the first number is evenly divisible by the second number.

// Assignment Operators
// ++ --      This will take an integer and add or subtract exactly 1.

// += -= *= /=       
// Retain original value, and do some math for the new value to be saved.
// int exampleNum = 5;
// exampleNum *= 3;
// Console.WriteLine(exampleNum);
// Same as exampleNum = exampleNum * 3;

// += is special because we can use it for Concatenation!
// string favGame = "My favorite game is ";
// favGame += "Metroid Prime";
// favGame = "My favorite game is Metroid Prime";


// Comparison Operators
int firstInt = 9;
int secInt = 4;
Console.WriteLine(secInt < firstInt);

Console.WriteLine(9 > 4);
Console.WriteLine(9 < 4);
// Greater than (>) and Less than (<) are a couple of our basic comparison operators
// When we put two number values on either side of these operators, they evalute as a bool literal,
// in other words just a plain 'true' or 'false'
Console.WriteLine(3 <= 3);
Console.WriteLine(5 >= 5);
// Don't be fooled by the equal sign (=) being used here, these are NOT assignment operators, they are the operators for Greater than or Equal to, as well as Less then or Equal to. If the values are equal or on the right side of the comparison operator, they will evaluate to a true boolean.

Console.WriteLine(15 == 15);
Console.WriteLine(15 == 302);
// All of our other operators were pretty self explanatory, but double equals (==) may not be perfectly obvious at first. What are we gunna do, make the value equal to the other twice? No...
// Double equals asks the question: are these two values the same? This will evaluate to a boolean literal, or in other words 'true' or 'false'.
Console.WriteLine(breakPoint);
Console.WriteLine("banana" == "Cherry");
// Double equals (==) can not only compare numbers, but also strings! As long as the strings are the same, it will evaluate to a 'true' bool literal
Console.WriteLine("Steve" == "Steve");
Console.WriteLine("Steve" == "steve");
// This is a reminder that upper and lower case characters are considered completely different to our program. In other words, when comparing strings, they are case sensitive.
Console.WriteLine(true == false);

// You can compare any two pieces of data that are of the SAME TYPE with double equals, but  you cannot compare data of two differnt types.
// It is also worth noting that you cannot use greater than or less than comparisons on strings (and that wouldn't make any sense anyways)
// Console.WriteLine(2 == "2");
// Console.WriteLine("Banana" >= "Orange");

// Let's talk about the Not Operator (!)
// simply put, the Not Operator (!) essentially takes a boolean and flips it to the opposite.
Console.WriteLine(!true);
Console.WriteLine(!false);

// This Not Operator (!) also applies when paired with the assignment opperator (=) to become a comparison operator.
Console.WriteLine("There is,in fact, a difference between apples and oranges");
// more accurately to our purposes, "apples" do not equal "oranges'
Console.WriteLine("Apples" != "Oranges");
Console.WriteLine("same" != "same");
Console.WriteLine(breakPoint);

// And and Or Operators
// &&      ||
// && all comparisons need to be true in order to produce a "true" boolean literal value
// || at least one of the comparisons must be true to produce a "true" boolean literal value

Console.WriteLine(2 > 1 && 5< 3);
// Hey console, can you write me a line about: "is 2 greater than 1 AND is 5 less than 3?" False

Console.WriteLine("apple" == "apple" && 4 > 2);
// You can have more then one type of data being compared if the && or || operators are used as long as you're comparing the same data type for each comparison. The && in this case only wants a 'true' evaluation on either side of the && operator to return a 'true'.

Console.WriteLine(3 == 3 && 'F' != 'W' && 5 > 1);

Console.WriteLine(breakPoint);

// With the OR (||) operator, we only need One true evaluation to produce a 'true'.
Console.WriteLine(2 > 1 || 5< 3);

Console.WriteLine(5 <= 4 || 'b' == 'a' || "banana" == "watermelon");
// just like the && operator, we can string together a bunch of ||, and still only ONE of the comparisons needs to be true to produce 'true'. If all of the statements are false, like our example her, then it will finally produce a false.

// Mix and Match
// You can mix and match your && and || operators, but that can get sticky and unsuable very quickly-- unless we are able to group our comparisons. we can do this with parenthesis! ()
  Console.WriteLine((2 > 1 && "Needle" == "basketball") || (100 == 100));
//Console.WriteLine((true && false)                     || (100 == 100));
//Console.WriteLine((false)                             || (true));
//Console.WriteLine(false || true);
//Console.WriteLine(true);

Console.WriteLine(breakPoint);

// Conditional Logic || The Magical If Statement
// With an If statement, the statement will require a boolean value of true before executing any of the code it contains.
// If    this part is true      go inside the curly braces and execute the code
   if         (true)           {
    // Do this stuff
}
//Otherwise, the code will continue on without doing anything.

if("Elephant" == "Badger"){
    Console.WriteLine("These are the same animal!");
}
// If we have an if statement that will Never be true, we got a warning that we have unreachable code.

if("Elephant" == "Elephant"){
    Console.WriteLine("These animials are the same!");
}
// Else statements will listen for a previous if statement to fail, and if it does, then else statements fires instead.

if("Elephant" == "Badger"){
    Console.WriteLine("These are the same animal!");
}else{
    Console.WriteLine("Hey, these animals are not the same!");
}
// If (the statement is true) then run the code in the curly braces, OTHERWISE (else) run what's in the else block. 

string favIcecream = "Vanilla Bean";
favIcecream = "Strawberry";

if(favIcecream == "Chocolate"){
    Console.WriteLine("we have plenty of that! here is your icecream");
}else if(favIcecream == "Strawberry"){
    Console.WriteLine("we still have that in stock! Here you go!");
}else{
    Console.WriteLine("we dont have that any more.");
}

Console.Clear();

// An else listens for a previous if statement to fail in order to run, but you can add any number of 'else if' statements in order to ask further questions.

Console.WriteLine(breakPoint);

// Random Numbers:
// in some cases we may need a random number, be it for a game or some kind of random selection engine. We can do this pretty simply by using Random-New Random.

Random rng = new Random();
// we establish our rng variable so we can address a method from Random called "Next()"

int myRandomNumber = rng.Next(100);
// this will generate a random number between 0 and 99.
// Note: the end of the range specified is NOT INCLUSIVE.

int moreSpecificRandom = rng.Next(1, 11);
// this will generate a number between 1 (inculsive) and 11 (Non inclusive, or in otherwords 10)

Console.WriteLine(myRandomNumber);
Console.WriteLine(moreSpecificRandom);

// How can we use randoms to simulate a treasure chest/loot crate in a game using randoms and conditionals?

int lootNumber = rng.Next(100);
Console.WriteLine(lootNumber);
if(lootNumber > 90){
    Console.WriteLine("Holy smokes, we have found 1000 gold");
}else if(lootNumber > 50){
    Console.WriteLine("Oh hey, we found 100 gold");
}else{
    Console.WriteLine("Ah man, this chest only had 5 gold in it... what a waste");
}