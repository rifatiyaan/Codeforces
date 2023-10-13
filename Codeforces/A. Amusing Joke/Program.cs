var inputOne = Console.ReadLine();
var inputTwo = Console.ReadLine();
var inputThree = Console.ReadLine().ToList();
inputThree.Sort();
var unionOfInputs = inputOne + inputTwo;
var output = unionOfInputs.ToList();
output.Sort();
var result = (output.SequenceEqual(inputThree)) ? "YES" : "NO";
Console.WriteLine(result);

