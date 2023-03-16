namespace KataCSharp.Sandbox
{
    public class References
    {
        public void Start()
        {

            var m1 = new Mamal("Dog1",1);
            m1.NextMamal = new Mamal("Dog2", 2);
            m1.NextMamal.NextMamal = new Mamal("Dog3", 3);
            var m2 = m1;
            m2.Name = "Changed"; // m name must be changed
            Console.WriteLine($"m1 name {m1.Name}, m2 name {m2.Name}");
            var m3 = m1;
            m1.NextMamal.Name = "New name22";// m1.NextMamal.Name must be New name
            m3.NextMamal.Name = "New name";// m1.NextMamal.Name must be New name


        }
    }

    class Mamal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Mamal NextMamal{ get; set; }

        public Mamal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        void SitDown()
        {
            Console.WriteLine( this.GetType().Name + " has sitted down");
        }
    }

    class Dog : Mamal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }
    }

}
