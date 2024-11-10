using nemoandhaboba.Dto;
using nemoandhaboba.models;

namespace nemoandhaboba.Repo
{
    public interface Istudentrepo
    {
        Student Getuserbyid(int id);
        void Addstudent(StudentDto student);
        void Updatestudent(StudentDto student,int id);
        void Deletestudent(int id);
    }
}
