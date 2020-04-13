using System;

namespace ObserverExample
{
    public class Subscriber : IObserver
    {
        public string Name { get; set; }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if(value.Contains("@"))
                _email = value;
            }

        }
        public Subscriber(string name,string email)
        {
            Name = name;
            Email = email;
        }

        public void Update(ISubject subject)
        {
            if(subject is Newsletter newsletter)
            {
                Console.WriteLine($"New Topic Posted {newsletter.Announcement}");
            }
            else
            {
                Console.WriteLine($"{Name} with email {_email} succesfully added");
            }
        }
    }
}
