namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        private Statistics statistics;
        [Test]
        public void WhenEmployeeCollectGrade_ThenCorrectGrade()
        {
            // arrange
            Employee employee = new Employee("Robert", "Kuniecki", 25);
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(5.00, statistics.Average);
        }

        [Test]
        public void WhenEmployee2CollectGrade_ThenCorrectGrade()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak", 33);
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(7, statistics.Max);
        }

        [Test]
        public void WhenEmployee3CollectGrade_ThenCorrectGrade()
        {
            // arrange
            Employee employee = new Employee("Marcin", "Lewandowski", 45);
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);
        }
    }
}