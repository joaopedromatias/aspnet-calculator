
abstract class Operator { 
    public abstract int Operate(int a, int b);
}

class AddOperator: Operator { 
    public override int Operate(int a, int b) {
        return checked(a + b);
    }
}

class SubtractOperator : Operator { 
    public override int Operate(int a, int b) {
        return a - b;
    }
}

class MultiplyOperator : Operator { 
    public override int Operate(int a, int b) {
        return a * b;
    }
}

class DivideOperator : Operator { 
    public override int Operate(int a, int b) {
        return a / b;
    }
}