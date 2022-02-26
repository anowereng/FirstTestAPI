using FirstTestApi.Controllers;

namespace FirstTestApi
{
    public static class StudentData
    {
        public static List<Student> GetStudentList()
        {
            var student = new Student()
            {
                Id = 1,
                Name = "anower"
            };

            var student1 = new Student()
            {
                Id = 2,
                Name = "nato"
            };
            var data = new List<Student>() { student, student1 };
            return data;
        }
    }
}
