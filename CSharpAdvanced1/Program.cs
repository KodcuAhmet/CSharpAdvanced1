using System;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;
using System.Reflection;

//06:10 - Explaining the classic FizzBuzz with an Imperative Implementation

//for (var i = 0; i < 100; i++)
//{
//    var div3 = i % 3 == 0;
//    var div5 = i % 5 == 0;

//    if (div3 && div5)
//        Console.WriteLine("FizzBuzz");
//    else if (div3)
//        Console.WriteLine("Fizz");
//    else if (div5)
//        Console.WriteLine("Buzz");
//    else Console.WriteLine(i);
//}

//08:24 - Object - Oriented Representation of FizzBuzz with an Interface

public class Program
{
    public static void Main()
    {
        var fizzBuzz = new FizzBuzz(new ConsoleFizzOutput());
        fizzBuzz.RunFizzBuzzOOP(1, 100);
        Console.ReadKey();
    }
}

public interface IFizzOutput
{
    void Write(string output);
}

public class FizzBuzz
{
    private readonly IFizzOutput _output;

    public FizzBuzz(IFizzOutput output)
    {
        _output = output;
    }

    public void RunFizzBuzzOOP(int fromNumber, int countNumber)
    {
        for (var i = fromNumber; i < countNumber; i++)
        {
            var div3 = i % 3 == 0;
            var div5 = i % 5 == 0;

            if (div3 && div5)
                _output.Write("FizzBuzz");
            else if (div3)
                _output.Write("Fizz");
            else if (div5)
                _output.Write("Buzz");
            else
                _output.Write(i.ToString());
        }
    }
}

public class ConsoleFizzOutput : IFizzOutput
{
    public void Write(string output)
    {
        Console.WriteLine(output);
    }
}



//12:38 - Understanding Delegates in C#
//14:28 - Using a Delegate to Increase Readability
//16:10 - Understanding Delegates and Invoking Methods
//18:45 - Exploring Method Groups in C#
//20:39 - Understanding Method Groups and Lambdas
//22:43 - Understanding Method Groups and Delegates
//24:45 - Benefits of Abstraction in Code
//26:52 - Reusing Delegate Types and Debugging
//28:43 - Debugging with Delegates
//31:03 - The Usefulness of FizzBuzz
//32:56 - Naming Conventions for Delegates
//34:56 - Working with Instantiated Classes and Invocation Lists
//36:47 - Understanding C# Delegates and Method Groups
//38:57 - Understanding Delegates and Invoking Methods
//40:49 - Working with Objects
//42:48 - Delegates and Static vs Instance Methods
//44:50 - Understanding the Method "Run"
//47:12 - Exploring Method Groups and Delegates
//49:13 - Accessing Properties of a Delegate
//51:17 - Explaining the Compiler Method
//53:30 - Invoking a Delegate with an Instance Method
//55:46 - Explaining the Invocation of a Delegate
//58:22 - Understanding Target Plus Method
//1:00:33 - Exploring Method Groups in C#
//1:04:38 - Multicast Delegates and Invocation Lists
//1:06:32 - Packaging Up Functionality with Method Groups
//1:08:45 - Assigning a Method Group to a Delegate
//1:10:46 - Using Delegates and Invocation Lists
//1:12:27 - Explaining Delegates and Filtering with an Enumerable
//1:14:00 - Using Delegates and Predicate Methods
//1:16:00 - Understanding Invocation Lists and Delegates
//1:19:13 - Exploring the Use of Invocation Lists
//1:21:05 - Multicast Delegates and WPF/Winforms
//1:23:01 - Using Delegates to Invoke Behaviors: Simulate a Button Click
//1:25:01 - Understanding C# Delegates
//1:27:19 - Working with Delegates
//1:27:42 - The Problems with Public Fields
//1:29:36 - Solving the Final Big Problem
//1:31:40 - Exploring Events in C#
//1:33:50 - Understanding Events and Delegates
//1:35:56 - Exploring the Relationship Between Delegates and Events
//1:37:40 - Explaining Events in C#
//1:39:42 - Understanding Events and Delegates
//1:41:41 - Events as Protected Delegates
//1:43:00 - Protecting the Delegate with an Event
//1:45:53 - Understanding Events and Delegates
//1:47:59 - Understanding Events in C#
//1:49:55 - Accessing Private Setters from Outside a Class
//1:51:49 - Contrast Between Delegates and Events in Button
//1:53:34 - Garbage Collection and Event Handlers
//1:55:46 - Anonymous Delegates in C#
//1:57:51 - Understanding Anonymous Delegates
//1:59:51 - Lambda Syntax vs Anonymous Delegates
//2:01:00 - Exploring Lambdas in C#
//2:04:01 - Implicitly Converting a Lambda to a Delegate Type
//2:05:00 - Understanding Lambda Syntax
//2:07:34 - Lambda Syntax and Parameters
//2:09:00 - Using Multi - Line Lambdas
//2:11:59 - Understanding Lambdas in C#
//2:14:18 - Unspeakable Methods in C# and IL
//2:16:00 - Explaining Hoisting in C# Lambdas
//2:18:39 - Value Types vs Reference Types
//2:20:48 - Understanding Hoisting and Value Types
//2:23:06 - Hoisting in C#
//2:25:29 - Understanding Hoisting in C#
//2:27:00 - Hoisting Variables and Garbage Collection Issues
//2:29:00 - Understanding Hoisting and Deferred Execution
//2:31:16 - Understanding Delegates and Generics
//2:33:10 - Exploring Different Types of Delegates
//2:35:23 - Using Built - In Delegate Types
//2:37:28 - Passing in Return Types with Delegates
//2:39:00 - Explaining Generics and Delegates
//2:41:51 - Understanding Delegates
//2:43:39 - Introduction to the Project and Logistics