namespace nemoandhaboba.models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> students { get; set;}

    }
}
