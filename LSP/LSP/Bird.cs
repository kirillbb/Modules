using System;

namespace LSP
{
    public abstract class Bird
    {
        public abstract void Move();
    }

    public abstract class FlyingBird : Bird
    {
        public override void Move()
        {
            Console.WriteLine("This is flying bird!");
        }
    }

    public class Duck : FlyingBird
    {
        public override void Move() => Console.WriteLine("Duck flies, quack-quack!");
    }

    public class Colibri : FlyingBird
    {
        public override void Move() => Console.WriteLine("Colibri flies very fast");
    }

    public class Ostrich : Bird
    {
        public override void Move() => Console.WriteLine("Ostrich can't fly, but run very fast");
    }

    public class Penguin : Bird
    {
        public override void Move() => Console.WriteLine("Penguin can't fly, but swims fast!");
    }
}
