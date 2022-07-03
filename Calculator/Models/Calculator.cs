public class Calculator
{

    private ICalculate calculatorStrategy;

    public double Calculate(double a, double b)
    {
        return calculatorStrategy.Calculate(a, b);
    }

    public void SetCalculate(ICalculate calculatorStrategy)
    {
        this.calculatorStrategy = calculatorStrategy;
    }

}
