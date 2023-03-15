namespace KataCSharp.Sandbox
{
    public class References
    {
        public void Start()
        {

            var m = new Mamal("Dog1",1);
            var m2 = m;
            m2.Name = "Dog2";
        }
    }

    class Mamal
    {
        public string Name { get; set; }
        public int Age { get; set; }

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
