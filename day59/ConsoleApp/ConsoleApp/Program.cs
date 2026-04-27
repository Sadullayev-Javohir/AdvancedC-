// public interface ICalculateStrategy
// {
//     int Execute(int a, int b);
// }
//
// public class AddStrategy : ICalculateStrategy
// {
//     public int Execute(int a, int b) => a + b;
// }
//
// public class CalculatorContext
// {
//     private ICalculateStrategy _strategy;
//     public CalculatorContext(ICalculateStrategy strategy) => _strategy = strategy;
//
//     public int Run(int a, int b) => _strategy.Execute(a, b);
// }
//

public class Calculator
{
    public int Add(int a, int b) => a + b;
}

