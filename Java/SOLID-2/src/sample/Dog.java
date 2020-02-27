package sample;

public class Dog extends Animal {

    public Dog(String color) {
        super(color);
    }

    void name(){
        System.out.println("Its a dog!");
    }

    void speak() {
        System.out.println("Dog is barking!");
    }

    void sleep() {
        System.out.println("Dog is sleeping!");
    }

    void eat() {
        System.out.println("Dog is eating.");
    }

    void walk(){
        System.out.println("Dog is Walking!");
    }
}