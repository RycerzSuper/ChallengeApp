namespace ChallengeApp
{
    public class Employee1
    {
        private List<float> grades = new List<float>();  
        public Employee1(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
    }
}
