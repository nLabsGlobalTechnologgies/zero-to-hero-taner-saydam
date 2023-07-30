namespace zero_to_hero_taner_saydam
{
    public class ExampleClass : ExampleInterface
    {
        public int Id { get; set; }
        public string Property { get; set; }
        public decimal Money { get; set; }
        public bool isActive { get; set; }

        public void Add()
        {
            Console.WriteLine("test Add method");
        }
    }
}
