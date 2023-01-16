using cstoolbox;

public class StringManipulationTest
{
    public void TestReplaceSpaceWithUnderscore(string text)
    {
        cstoolbox.StringManipulation salg = new StringManipulation();        
        string result = salg.ReplaceSpaceWithUnderscore(text);        
        Console.WriteLine("Testing 'ReplaceSpaceWithUnderscore' method: ");
        Console.Write("Input text:");
        Console.WriteLine(text);
        Console.Write("Output text:");
        Console.WriteLine(result);
        Console.WriteLine("...");
    }
}