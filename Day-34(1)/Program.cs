// See https://aka.ms/new-console-template for more information

class Person
{
    public string Name { get; set; }
    public List<Person> Friends = new List<Person>();
    public Person(string name)
    {
        Name = name;
    }
    public void AddFriend(Person friend)
    {
        if (!Friends.Contains(friend))
        {
            Friends.Add(friend);
            friend.Friends.Add(this);
        }
    }

    //public void Post
}
class SocialNetwork
{
    List<Person> _members = new List<Person>();
    public void AddMember(Person member)
    {
        _members.Add(member);
    }
    public void ShowNetwork()
    {
        foreach (var member in _members)
        {
            System.Console.Write(member.Name+ " -> ");
            List <string> friends = new List<string>();
            foreach (var friend in member.Friends)
            {
                friends.Add(friend.Name);
            }
            System.Console.WriteLine($"{string.Join(",", friends)}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        SocialNetwork network = new SocialNetwork();

        Person aman = new Person("Aman");
        Person bhaskar = new Person("Bhaskar");
        Person chetan = new Person("Chetan");
        Person divakar = new Person("Divakar");

        network.AddMember(aman);
        network.AddMember(bhaskar);
        network.AddMember(chetan);
        network.AddMember(divakar);

        aman.AddFriend(bhaskar);
        aman.AddFriend(chetan);
        bhaskar.AddFriend(chetan);
        divakar.AddFriend(chetan);

        network.ShowNetwork();
    }
}
