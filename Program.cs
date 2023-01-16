// This is used for running and testing the class library
using System;
using cstoolbox;
public class Test
{   
    static void Main()
    {
        AlgebraTest test = new AlgebraTest();
        test.TestAddition(100, 50);
        test.TestDivision(100, 3);
        
        StringManipulationTest test2 = new StringManipulationTest();
        test2.TestReplaceSpaceWithUnderscore("Make Me A Camel Case");

    }
}