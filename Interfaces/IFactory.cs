namespace Calculator
{
    public interface IFactory
    {
        IOperator MakeOperator(string operatorType);
        IGetInput MakeInputGetter();
    }
}
