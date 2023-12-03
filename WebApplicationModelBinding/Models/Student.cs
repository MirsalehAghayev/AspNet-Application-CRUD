namespace WebApplicationModelBinding.Models
{
    public class Student
    {
        static int counter = 0;
        public Student() 
        { 

        }
        public Student(bool identity = false)
        {
            if (identity)
                this.Id = ++counter;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Speciality { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Surname}";
        }
    }
}
