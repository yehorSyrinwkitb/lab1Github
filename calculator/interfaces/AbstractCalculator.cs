namespace calculator.interfaces;

public abstract class AbstractCalculator
{
    //available operations
    private Dictionary<string, IOperation> avaliableOperations = new Dictionary<string, IOperation>();

    //method for adding new operations
    public void AddOperation(IOperation operation)
    {
        avaliableOperations.Add(operation.GetKey(), operation);
    }

    //main method for performing each operation
    public abstract double PerformCalculation(string operation, double[] values);
    
}