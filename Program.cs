namespace POO___Héritage;


public abstract class Animal
{
    protected short _legsCount;
    protected bool _hairy;
    protected string _name;

    public Animal(short legsCount, bool hairy, string name)
    {
        _legsCount = legsCount;
        _hairy = hairy;
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual void Move()
    {
        Console.WriteLine(_name + "");
    }

    public void Eat()
    {
        Console.WriteLine(_name + " eats.");
    }
}


public class Human : Animal
{
    public Human(string name) : base(2, true, name)
    { }

    public override void Move()
    {
        Console.WriteLine(_name + " as an human is bipedal.");
    }
}

public class Monkey : Animal
{
    public Monkey(string name) : base(2, true, name)
    { }

    public override void Move()
    {
        Console.WriteLine(_name + " as a monkey is bipedal.");
    }
}

public class Elephant : Animal
{
    public Elephant(string name) : base(4, true, name)
    { }

    public override void Move()
    {
        Console.WriteLine(_name + " as an elephant is quadrupedal.");
    }
}

public class Turtle : Animal
{
    public Turtle(string name) : base(4, false, name)
    { }

    public override void Move()
    {
        Console.WriteLine(_name + " as a turtle is quadrupedal.");
    }
}

public class Lizard : Animal
{
    public Lizard(string name) : base(4, false, name)
    { }

    public override void Move()
    {
        Console.WriteLine(_name + " as a lizard is quadrupedal.");
    }
}





class Program
{
    static void Main(string[] args)
    {
        Animal[] animalsSet = new Animal[5];
        Human human = new Human("Natacha");
        Monkey monkey = new Monkey("Ham");
        Elephant elephant = new Elephant("Babar");
        Turtle turtle = new Turtle("Donatello");
        Lizard lizard = new Lizard("Treecko");

        animalsSet[0] = human;
        animalsSet[1] = monkey;
        animalsSet[2] = elephant;
        animalsSet[3] = turtle;
        animalsSet[4] = lizard;

        foreach (Animal animal in animalsSet)
        {
            animal.Eat();
            animal.Move();

            Console.WriteLine();
        }

    }
}

