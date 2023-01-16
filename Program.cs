// This is used for running and testing the class library
using System;
using cstoolbox;
public class Test
{   
    static void Main()        
    {
        // Print header
        Console.WriteLine("Running tests for `cstoolbox`: ");
        Console.WriteLine("==============================================================");
        Console.WriteLine("...");

        // Test Algebra class
        AlgebraTest test = new AlgebraTest();
        test.TestAddition(100, 50);
        test.TestDivision(100, 3);
        
        // Test String Manipulation class
        StringManipulationTest test2 = new StringManipulationTest();
        test2.TestReplaceSpaceWithUnderscore("Make Me A Camel Case");

        // Test Classifier class
        ClassifiersTest test3 = new ClassifiersTest();
        test3.TestClassifyAge(20);

    }
}