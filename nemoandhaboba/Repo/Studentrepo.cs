using nemoandhaboba.Dto;
using nemoandhaboba.models;

namespace nemoandhaboba.Repo
{
    public class Studentrepo : Istudentrepo
    {
        private readonly Appdbcontext _context;
        public Studentrepo(Appdbcontext context)
        {
            _context = context;
        }
        public void Addstudent(StudentDto student)
        {
            var students = new Student
            {
                S_Id = student.S_Id,
                S_Name = student.S_Name,
                S_Age = student.S_Age,

            };
            _context.Students.Add(students);
             _context.SaveChanges();
        }

        public void Deletestudent(int id)
        {
          var stu=Getuserbyid(id);
            if(stu!=null)
            { 
                _context.Students.Remove(stu);
                _context.SaveChanges();
            }
        }

        public Student Getuserbyid(int id)
        {
            var student = _context.Students.FirstOrDefault(x=> x.S_Id == id);
            return student;
               
        }

        public void Updatestudent(StudentDto student,int id)
        {
            var student1 = Getuserbyid(id);
            if(student1 != null)
            {
                student1.S_Id = student.S_Id;
               student1.S_Name= student.S_Name;
                student.S_Age = student.S_Age;
                 _context.Students.Update(student1);
            _context.SaveChanges();
            }
           

        }
    }
}
