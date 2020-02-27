public class StrategyPatternDemo {
    public static void main(String[] args) {
        miniräknare context = new miniräknare(new OperationAdd());
        System.out.println("10 + 5 = " + context.executeStrategy(10, 5));

        context = new miniräknare(new OperationSubtract());
        System.out.println("10 - 5 = " + context.executeStrategy(10, 5));

        context = new miniräknare(new OperationMultiply());
        System.out.println("10 * 5 = " + context.executeStrategy(10, 5));

        context = new miniräknare(new OperationDivide());
        System.out.println("10 / 5 = " + context.executeStrategy(10, 5));
    }

}