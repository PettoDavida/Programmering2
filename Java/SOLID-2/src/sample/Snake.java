package sample;

public class Snake extends Animal {

    public Snake(String color) {
        super(color);
    }

    void name(){
        System.out.println("Oh heck its a Snaek!");
    }

    void speak() {
        System.out.println("Snaek is barking!");
    }

    void sleep() {
        System.out.println("Snaek is sleeping!");
    }

    void eat() {
        System.out.println("Snaek is eating.");
    }

    void walk(){
        System.out.println("Snake is Slithering!");
    }

}
