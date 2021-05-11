using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //The mediator pattern acts like the controller in MVC
            //where the model and the view communicate through the controller instead of communicating directly
            //The mediator is essentially an object that encapsulates how one or more objects interact with each other
            //This helps to reduce the dependencies between objects and promotes loose coupling

            var mediator = new ConcreteMediator();

            var manager = new ConcreteParticipant(mediator);
            var worker = new ConcreteParticipant2(mediator);

            mediator.AddParticipant(manager);
            mediator.AddParticipant(worker);

            manager.SendMessage("Hey worker, can you send me the report before close of business?");
            worker.SendMessage("Hey manager, sure! I will work on that now!");

            Console.ReadLine();
        }
    }
}
