namespace Assignment9
{
    public class StudentInfo
    {
        public List<Tuple<string, int, string>> Students { get; set; }

        public void AddStudent(Tuple<string, int, string> student)
        {
            this.Students.Add(student);
        }

        public void DisplayStudents()
        {
            foreach (var student in this.Students)
            {
                Console.WriteLine(student.Item1);
            }
        }

        public Tuple<string, int, string> SearchStudents(string name)
        {
            return this.Students.Where(s => s.Item1 == name).Single();
        }
    }
}
