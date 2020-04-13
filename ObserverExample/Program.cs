using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var sub = new Subscriber("Karol", "kokarolos@gmail.com");
            var sub1 = new Subscriber("George", "George@gmail.com");
            var sub2 = new Subscriber("John", "John@gmail.com");
            var sub3 = new Subscriber("Doe", "doe@gmail.com");
            var sub4 = new Subscriber("Foo", "foo@gmail.com");
            var sub5 = new Subscriber("Kacy", "Kacy@gmail.com");
            var sub6 = new Subscriber("Takis", "Takis@gmail.com");
            var sub7 = new Subscriber("Panos", "Panos@gmail.com");
            var newsLetter = new Newsletter
            {
                CompanyName = "News742",
                Announcement = "Hot New Topic"
            };

            newsLetter.Attach(sub);
            newsLetter.Attach(sub1);
            newsLetter.Attach(sub2);
            newsLetter.Attach(sub3);
            newsLetter.Attach(sub4);
            newsLetter.Attach(sub5);
            newsLetter.Attach(sub6);
            newsLetter.Attach(sub7);
            newsLetter.Notify();
            newsLetter.Detach(sub);
            newsLetter.Announcement = "This is just a test";
        }
    }
}
