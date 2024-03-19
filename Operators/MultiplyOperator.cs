namespace Calculator 
{ 
    class MultiplyOperator : IOperator 
    { 
        public int Operate(int a, int b) 
        {
            return a * b;
        }
    }
}
