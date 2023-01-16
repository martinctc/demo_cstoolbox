using cstoolbox;

public class ClassifiersTest
{
    public void TestClassifyAge(int age)
    {
        cstoolbox.Classifiers c_alg = new Classifiers();        
        string result = c_alg.ClassifyAge(age);        
        Console.WriteLine("Testing 'ClassifyAge' method: ");
        Console.Write("Input age:");
        Console.WriteLine(age);
        Console.Write("Output:");
        Console.WriteLine(result);
        Console.WriteLine("...");
    }
}