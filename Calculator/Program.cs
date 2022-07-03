Calculator calculator = new Calculator();

double numberA = 20;
double numberB = 5;
calculator.SetCalculate(new Plus());
Console.WriteLine(numberA + " + " + numberB + " = " + calculator.Calculate(numberA, numberB));

calculator.SetCalculate(new Minus());
Console.WriteLine(numberA + " - " + numberB + " = " + calculator.Calculate(numberA, numberB));

calculator.SetCalculate(new Multiply());
Console.WriteLine(numberA + " * " + numberB + " = " + calculator.Calculate(numberA, numberB));

calculator.SetCalculate(new Divide());
Console.WriteLine(numberA + " / " + numberB + " = " + calculator.Calculate(numberA, numberB));
