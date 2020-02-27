package sample;

public class Bird extends Animal {

    public Bird(String color) {
        super(color);
    }

    void name(){
        System.out.println("Its some kind of Bird!");
    }

    void speak() {
        System.out.println("Bird is chirping!");
    }

    void sleep() {
        System.out.println("Bird is sleeping!");
    }

    void eat() {
        System.out.println("Bird is peck-peck-pecking away!");
    }

    void walk(){
        System.out.println("Bird is Walking!");
    }
}
