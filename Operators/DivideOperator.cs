namespace Calculator 
{ 
    class DivideOperator : IOperator 
    { 
        public int Operate(int a, int b) {
            return a / b;
        }
    }
}
