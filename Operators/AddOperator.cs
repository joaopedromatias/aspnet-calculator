namespace Calculator 
{ 
    class AddOperator : IOperator 
    { 
        public int Operate(int a, int b) 
        {
            return checked(a + b);
        }
    }
}
