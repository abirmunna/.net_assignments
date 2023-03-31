using System;
using System.Collections.Generic;

public class Animal {
    public virtual void Move() {
        Console.WriteLine("No movement");
    }
}

public class Cat : Animal {
    public override void Move() {
        Console.WriteLine("Run");
    }
}

public class Fish : Animal {
    public override void Move() {
        Console.WriteLine("Swim");
    }
}

public class Program {
    static void Main() {
        List<Animal> animals = new List<Animal>();

        Animal animal = new Animal();
        Cat cat = new Cat();
        Fish fish = new Fish();

        animals.Add(animal);
        animals.Add(cat);
        animals.Add(fish);

        foreach (Animal a in animals) {
            a.Move();
        }
    }
}
