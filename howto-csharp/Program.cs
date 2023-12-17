// <- Placing two slashes in front of a line of code makes it a comment
//   and it will not be run by the compiler. This is a comment!

// This is how you print to the console in C#!! Run the program
// and note that the output is "Hello, World!" in the bottom pane.
Console.WriteLine("Hello, World!"); // Every line ends with a semicolon
// You can put multiple lines in one with a semicolon
Console.WriteLine("Hello, World!"); Console.WriteLine("Hello, World!");
// These are also examples of function calls. A function is a block of code
// that you can call from anywhere in your program. In this case, "WriteLine"
// is the name of the function, and "Console" is the name of the object that
// contains the function. Don't worry about objects right now.
// When you call functions, you put the arguments in parentheses after the
// name of the function. Some functions don't take any arguments, like
// Console.WriteLine(). Functions can take any number of arguments, and they
// define how many arguments they take. If you give a function the wrong number
// of arguments or the wrong type of arguments, you'll get a compiler error.

// Note that all of the "Console.Writelines" in this program produce output
// in the console when you press run. The output is in the bottom pane. There
// is some extra output outside of the code you write, but you can ignore it.
// You can use the output from a program to debug it, give messages to the user,
// or just to see what's going on.

// This is how you declare variables in C#. Abstractly: type name = value;
// These are the basic types in C#; there are others. We'll get to them later.
int x = 5; // A simple integer
double y = 5.5; // Double precision floating point number represents decimals
// Strings are weird- they mostly behave like value types, but they are
// actually reference types. We'll get to that later.
string z = "Hello, World!"; // A string of characters, aka text.
bool a = true; // A boolean value, either true or false
char e = 'a'; // A single character, note the single quotes
Object f = new Object(); // An object- don't worry about this for now!!

// When assigning a value to a variable, it must be the right type!
//x = 5.5; // This will not work because x is an integer: uncomment to see
// You can also declare a variable without assigning a value:
int w; // This is fine
// But you can't use it until you assign a value:
// Console.WriteLine(w); // This will not work: uncomment to see
// You can assign values from other variables:
w = x; // w = 5
w = 6; // This is the general form to assign a variable that has already 
// been declared: you don't need to re-declare the type in front!!

// Arrays are a little more complicated, but you'll need them for this lesson
// An array is a list of values of the same type. You can access the values
// in an array by their index in square brackets, like: name[index]. Arrays
// start at index 0, so the first value in an array is at index 0, the second at 1, etc.
int[] b = {1, 2, 3, 4, 5}; // An array of integers
Console.WriteLine(b[0]); // Prints 1. Note how we use the index in square brackets
// With arrays, you declare the type of the array, then the name, then the values
// in curly braces. The values are separated by commas: type[] name = {values, ...};
string[] d = {"Hello", "World"}; // An array of strings
// You can also declare an empty array and fill it later
int[] c = new int[5]; // An empty array of integers with 5 slots
// 5 slots? But I thought arrays started at 0? They do, but the number you
// put in the brackets is the number of slots, not the highest index. So
// this array has 5 slots, but the highest index is 4.
// You can't access a position in an array that doesn't exist:
// Console.WriteLine(c[5]); // It will compile, but when you run, you'll get an error

// Loops are super useful! They let you repeat code without having to copy and paste
// While loops are the most basic type of loop. They repeat a block of code "while"
// a condition is true. The condition is in parentheses after the while keyword.
// The condition must be a boolean value, either true or false, or you'll get 
// a type error! After all, how can you repeat something while a condition is true
// if the condition isn't true or false?

bool condition = true;
while (condition) {
  // All this runs every loop "while" the loop is running
  Console.WriteLine("Looping!");
  // If condition gets set to false in the loop, the loop will stop running
  // and the program will continue after the loop. Remember, the while condition
  // gets evaluated (checking whether it's true or false) every time the loop runs.
  condition = return_a_random_boolean(); // This will be true or false
}

// For loops are a bit more complex. They are used when you know how many times
// you want to repeat a block of code. 
// The syntax is: for (<initialization>; <condition>; <repeat>) {}
// The initialization is code that runs before the loop starts. It usually
// declares a variable that will be used in the loop.
// The condition is the same as the while loop condition: it must be a boolean
// value, either true or false. The loop will run while the condition is true
// and stop when it is false, continuing after the loop.
// The repeat is code that runs after every loop. Usually it increments the
// variable declared in the initialization. Here's how to use a loop to print
// the numbers 0 through 4:
for (int i = 0; i < 5; i++) { // i++ means "i = i + 1" or "i += 1"
  Console.WriteLine(i);
  // i is only available in the loop. Each time the loop repeats, i is modified
  // by the repeat code, although the repeat code doesn't always have to modify i
}
// We initialize i to 0, then run the loop while i is less than or equal to 4.
// After every loop, we increment i by 1. So the loop runs 5 times, printing 
// 0, 1, 2, 3, and 4. Note that the condition is <= 4, not < 5. If we used < 5,
// we would get the same result.

// Foreach loops are a special type of loop that are used to iterate over arrays
// and other objects that are "iterable". We'll get to what that means later.
// The syntax is: foreach (<type> <name> in <iterable>) {<code>}
string[] words = {"Hello", "World", "more", "strings", "here"};
foreach (string word in words) {
  Console.WriteLine(word);
  // The variable "word" is only available in the loop. Each time the loop
  // repeats, "word" is assigned to the next item in the array.
}

// This is a function definition!! Functions, as mentioned, are blocks of code
// that can be reused anywhere in your program. They are also called methods.
// Using a function is called calling or invoking the function, and the below 
// function definition is "defining" a function. 
// The syntax for a function definition is:
// <type> <name>(<type> <name>, ...) {<code>}. Note that the types and names
// in parentheses are the arguments that the function takes. As mentioned,
// you can have no arguments or as many as you want.
int add(int a, int b) {
  return a + b; // See below for "return"
  // Note that the type of the return value must match the type of the function
  // Syntax is always return <value>;. If the function doesn't return anything,
  // you can use "void" as the type, and return doesn't have to have a value
  // after it: "return;".
}
// "return" is a keyword that returns a value from a function. This means
// that the function call in the calling code will be replaced with the value
// that is returned. For example:
int sum = add(5, 6); // sum = 11
Console.WriteLine(add(5, 6));

// Here's the function that I call above in the while loop. Note that I can
// define a function after I call it, because the compilier actually reads
// the whole file before it compiles it.
bool return_a_random_boolean() {
  Random rand = new Random();
  return rand.Next(0, 2) == 0;  
}

// Ok, now it's your turn! Write a function that takes an array of integers
// and returns the sum of all the integers in the array. Here's a start:
int sum_array(int[] array) {
  return 0; // Your code here
}
// Here's some tests for your function. You can see the results by pressing
// run and checking the console.
int test3 = sum_array(new int[] {1, 1, 1, 1, 1}); // Notice I can make an array
int test2 = sum_array(new int[] {5, 4, 3, 2, 1}); // inside a function call and
int test1 = sum_array(new int[] {1, 2, 3, 4, 5}); // pass it in without ever
int test4 = sum_array(new int[] {}); // assigning it to a variable :)
// In syntactical terms (this is the coder way of saying "grammatical"), what
// english people call "phrases" are called "expressions". Expressions are
// blocks of code that evaluate to a value. For example, 1 + 1 is an expression,
// and it evaluates to 2. sum_array(new int[] {1, 2, 3, 4, 5}) is an expression,
// which should evaluate to 15. Expressions can be used anywhere a value is
// expected, like in a function call, or assigning a variable ie int x = <expression>;
 
// Here I check the result of testing your function:
if (test1 != 15) { // != means "not equal to"
  Console.WriteLine("Test 1 failed: expected 15, got " + test1);
}
if (test2 != 15) {
  Console.WriteLine("Test 2 failed: expected 15, got " + test2);
}
if (test3 != 5) {
  Console.WriteLine("Test 3 failed: expected 5, got " + test3);
}
if (test4 != 0) {
  Console.WriteLine("Test 4 failed: expected 0, got " + test4);
}

// Now write a function that takes an array of integers and returns the average
// of all the integers in the array. Here's a start:
// This one's a little harder but you got it!!
double average_array(int[] array) {
  return 0; // Your code here
}
// Tests:
double test5 = average_array(new int[] {1, 1, 1, 1, 1});
double test6 = average_array(new int[] {5, 4, 3, 2, 1});
double test7 = average_array(new int[] {1, 2, 3, 4, 5});
double test8 = average_array(new int[] {});
double test9 = average_array(new int[] {1});
if (test5 != 1) {
  Console.WriteLine("Test 5 failed: expected 1, got " + test5);
}
if (test6 != 3) {
  Console.WriteLine("Test 6 failed: expected 3, got " + test6);
}
if (test7 != 3) {
  Console.WriteLine("Test 7 failed: expected 3, got " + test7);
}
if (test8 != 0) {
  Console.WriteLine("Test 8 failed: expected 0, got " + test8);
}
if (test9 != 1) {
  Console.WriteLine("Test 9 failed: expected 1, got " + test9);
}

// Now write a function that tells us how many times a number can be divided
// by two before it is less than or equal to 1. For example, 8 can be divided
// by two three times before it is less than or equal to 1.
int divide_by_two(double number) {
  return 0; // Your code here
}
// Tests:
int test10 = divide_by_two(8);
int test11 = divide_by_two(7);
int test12 = divide_by_two(1);
int test13 = divide_by_two(0);
if (test10 != 3) {
  Console.WriteLine("Test 10 failed: expected 3, got " + test10);
}
if (test11 != 2) {
  Console.WriteLine("Test 11 failed: expected 2, got " + test11);
}
if (test12 != 0) {
  Console.WriteLine("Test 12 failed: expected 0, got " + test12);
}
if (test13 != 0) {
  Console.WriteLine("Test 13 failed: expected 0, got " + test13);
}

// Next task: write a function that takes x1, y1, x2, and y2 as arguments
// and returns the distance between the two points (use the pythagorean theorem!!).
// I'll leave the function definition and types to you. You'll also have to
// write some tests for this one to make sure it works!