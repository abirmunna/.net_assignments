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
    private int height;

    public Cat(string name, int speed, int height) {
        this.name = name;
        this.speed = speed;
        this.height = height;
    }

    public override void Move() {
        Console.WriteLine("Cat named {0} runs at speed {1}", name, speed);
    }

    public void Jump() {
        Console.WriteLine("Cat jumps at speed {0}", height);
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
        Cat cat = new Cat("Frisky", 10, 5);
        Fish fish = new Fish("Blob", 5);

        animals.Add(animal);
        animals.Add(cat);
        animals.Add(fish);

        foreach (Animal a in animals) {
            a.Move();

            if (a is Cat) {
                Cat c = (Cat)a;
                c.Jump();
            }
        }
    }
}
