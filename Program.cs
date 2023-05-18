// where the Console.Write function is located
using System;

// similar to console.log from JS
Console.Write("Who would you like to say hello to? ");

// waiting for a response which it will convert to a string saved to the variable called name
string name = Console.ReadLine();

// if the response for name is not a string with characters
if (string.IsNullOrWhiteSpace(name))
{
    // respond with
    Console.WriteLine("Fine, don't say 'hello'!");
}
// otherwise
else
{
    // respond with 
    Console.WriteLine($"Hello, {name}!");
}