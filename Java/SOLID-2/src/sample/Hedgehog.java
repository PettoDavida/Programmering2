package sample;

public class Hedgehog extends Animal {

    public Hedgehog(String color) {
        super(color);
    }

    void name(){
        System.out.println("Sonic?");
    }

    void speak() {
        System.out.println("Hedgehog is squeeking!");
    }

    void sleep() {
        System.out.println("Hedgehog is napping!");
    }

    void eat() {
        System.out.println("Hedgehog is omnomnoming!");
    }

    void walk(){
        System.out.println("Hedgehog is Walking!");
    }
}
