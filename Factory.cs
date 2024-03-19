namespace Calculator 
{ 
    public class Factory : IFactory
    { 
        public IOperator MakeOperator(string operatorInput) 
        {
            return operatorInput switch
            {
                "add" => new AddOperator(),
                "sub" => new SubtractOperator(),
                "mult" => new MultiplyOperator(),
                "div" => new DivideOperator(),
                _ => throw new Exception("Invalid operator"),
            };
        }

        public IGetInput MakeInputGetter() 
        {
            return new GetQueryString();
        }
    }
}
