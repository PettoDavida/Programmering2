package sample;


public class Main   {

    public static void main(String[] args) {

        Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow"),
                            new Snake("Black and Yellow")};

        System.out.println("###############");
        System.out.println();

        for (Animal animal : animals) {
            activateAnimal(animal);
        }
    }

    private static void activateAnimal(Animal animal) {
        System.out.println();

        animal.name();
        animal.eat();
        animal.sleep();
        animal.speak();
        animal.walk();

        printAnimalName(animal);

        System.out.println("###############");
        System.out.println();
    }

}
