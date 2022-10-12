namespace calculator.interfaces;

public interface IOperation
{
    //method for calculation
    public double Perform(double[] values);
    //method for operation search
    public string GetKey();
}