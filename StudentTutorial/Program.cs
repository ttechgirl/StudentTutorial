using StudentTutorial;
using static StudentTutorial.DelegateType;


//var delegates = new DelegateType();
////instantiation of delegate
//CalculatorDelegate calculatorDelegate = new CalculatorDelegate(delegates.Calculator);

CalculatorDelegate calculatorDelegate = new CalculatorDelegate(Calculator);
calculatorDelegate(19, 60);