using StudentServiceLib;

namespace TestingStudent
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void exception11_should_throw()
        {
            Student stu1 = new Student();
            stu1.Age = 20;
            stu1.Name = "Nhat";
            stu1.Id = 1;
            stu1.Score = 11;
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void exception8_shouldnot_throw()
        {
            Student stu1 = new Student();
            stu1.Age = 20;
            stu1.Name = "Nhat";
            stu1.Id = 1;
            stu1.Score = 8;
        }

        [TestMethod]
        public void score8_ShouldReturn_A()
        {
            Student stu1 = new Student();
            stu1.Age = 20;
            stu1.Name = "Nhat";
            stu1.Id = 1;
            stu1.Score = 8;

            char letter = stu1.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void score9_ShouldReturn_A()
        {
            Student stu1 = new Student();
            stu1.Age = 20;
            stu1.Name = "Nhat";
            stu1.Id = 1;
            stu1.Score = 9;

            char letter = stu1.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void score7_ShouldReturn_B()
        {
            Student stu1 = new Student();
            stu1.Age = 20;
            stu1.Name = "Nhat";
            stu1.Id = 1;
            stu1.Score = 7;

            char letter = stu1.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void score5_ShouldReturn_C()
        {
            Student stu1 = new Student();
            stu1.Age = 20;
            stu1.Name = "Nhat";
            stu1.Id = 1;
            stu1.Score = 5;

            char letter = stu1.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void score3andhalf_ShouldReturn_D()
        {
            Student stu1 = new Student();
            stu1.Age = 20;
            stu1.Name = "Nhat";
            stu1.Id = 1;
            stu1.Score = 3.5;

            char letter = stu1.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void score2_ShouldReturn_E()
        {
            Student stu1 = new Student();
            stu1.Age = 20;
            stu1.Name = "Nhat";
            stu1.Id = 1;
            stu1.Score = 2;

            char letter = stu1.getLetterScore();
            Assert.AreEqual('E', letter);
        }

        [TestMethod]
        public void AddFirstStudent_Should_True()
        {
            StudentService lis = new StudentService();
            Student stu1 = new Student();
            stu1.Age = 20;
            stu1.Name = "Nhat";
            stu1.Id = 1;
            stu1.Score = 2;

            bool status = lis.addStudent(stu1);
            Assert.IsTrue(status);
        }

    }
}