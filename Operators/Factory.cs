class OperatorFactory { 
    public static Operator makeOperator(string operatorInput) {
        return operatorInput switch
        {
            "add" => new AddOperator(),
            "sub" => new SubtractOperator(),
            "mult" => new MultiplyOperator(),
            "div" => new DivideOperator(),
            _ => throw new Exception("Invalid operator"),
        };
    }
}
