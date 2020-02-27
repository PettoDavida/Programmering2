import interfaces.strategy;

public class miniräknare {
    private strategy strategy;

    public miniräknare(strategy strategy){
        this.strategy = strategy;
    }

    public int executeStrategy(int num1, int num2){
        return strategy.doOperation(num1, num2);
    }
}
