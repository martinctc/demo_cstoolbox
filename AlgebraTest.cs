using cstoolbox;
public class AlgebraTest
{
    public void TestAddition(double number1, double number2)
    {
        cstoolbox.Algebra alg = new Algebra();
        double result = alg.Addition(number1, number2);
        Console.WriteLine("Testing 'Addition' method: ");
        Console.Write(number1);
        Console.Write(" + ");
        Console.Write(number2);
        Console.Write(" = ");
        Console.WriteLine(result);
        Console.WriteLine("...");
    }
    
    public void TestDivision(double number1, double number2)
    {
        cstoolbox.Algebra alg = new Algebra();
        double result = alg.Division(number1, number2);
        Console.WriteLine("Testing 'Division' method: ");
        Console.Write(number1);
        Console.Write(" / ");
        Console.Write(number2);
        Console.Write(" = ");
        Console.WriteLine(result);
        Console.WriteLine("...");
    }
}