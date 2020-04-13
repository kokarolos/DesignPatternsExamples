using System;
using System.Collections.Generic;

namespace ObserverExample
{
    public class Newsletter : ISubject
    {
        public string CompanyName { get; set; }
        private string _announcement;

        public string Announcement
        {
            get
            {
                return _announcement;
            }
            set
            {
                _announcement = value;
                Notify();
            }
        }

        private List<IObserver> _subscibers;
        public Newsletter()
        {
            _subscibers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _subscibers.Add(observer);
            if(observer is Subscriber subscriber)
            {
                Console.WriteLine($"{subscriber.Name} Successfully Added To SubScribers List");
            }
        }

        public void Detach(IObserver observer)
        {
            _subscibers.Remove(observer);
            if(observer is Subscriber subscriber)
            Console.WriteLine($"{subscriber.Name} Successfully Removed From {CompanyName}");
        }

        public void Notify()
        {
            _subscibers.ForEach(observer => observer.Update(this));
        }
    }
}
