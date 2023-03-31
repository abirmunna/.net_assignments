using System;
using System.Collections.Generic;

public class Animal {
    protected string name;
    protected int speed;

    public virtual void Move() {
        Console.WriteLine("No movement");
    }
}

public class Cat : Animal {
    public Cat(string name, int speed) {
        this.name = name;
        this.speed = speed;
    }

    public override void Move() {
        Console.WriteLine("Cat named {0} runs at speed {1}", name, speed);
    }
}

public class Fish : Animal {
    public Fish(string name, int speed) {
        this.name = name;
        this.speed = speed;
    }

    public override void Move() {
        Console.WriteLine("Fish named {0} swims at speed {1}", name, speed);
    }
}

public class Program {
    static void Main() {
        List<Animal> animals = new List<Animal>();

        Animal animal = new Animal();
        Cat cat = new Cat("Frisky", 10);
        Fish fish = new Fish("Blob", 5);

        animals.Add(animal);
        animals.Add(cat);
        animals.Add(fish);

        foreach (Animal a in animals) {
            a.Move();
        }
    }
}
