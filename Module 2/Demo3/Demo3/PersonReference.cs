namespace Demo3
{
    public class PersonReference
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Override ToString() in order to make example work
        public override string ToString()
        {
            return $"Name: {Name} / Age: {Age}";
        }
    }
}
