import interfaces.strategy;

public class OperationAdd implements strategy {
    @Override
    public int doOperation(int num1, int num2) {
        return num1 + num2;
    }
}
