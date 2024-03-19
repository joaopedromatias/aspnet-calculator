namespace Calculator 
{ 
    class SubtractOperator : IOperator 
    { 
        public int Operate(int a, int b) 
        {
            return a - b;
        }
    }
}
