using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVMSCore.BAL.Models.OnlineCourse
{
    public class OnlineCourseModel
    {



    }

    public class AdminSignUpModel
    {

        public string Name { get; set; }


        public string UserName { get; set; }


        public string Password { get; set; }
    }

    public class AdminLoginModel
    {

        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public class StudentSignUpModel
    {

        public string Name { get; set; }


        public string UserName { get; set; }


        public string Password { get; set; }
    }


    public class StudentLoginModel
    {

        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public class TeacherSignUpModel
    {

        public string Name { get; set; }


        public string UserName { get; set; }


        public string Password { get; set; }
    }

    public class TeacherLoginModel
    {

        public string UserName { get; set; }

        public string Password { get; set; }
    }


    public class AdminAddmoreModel
    {
        public int id { get; set; }
        public string Fullname { get; set; }

        public string SubjectId { get; set; }

        public string SubjectName { get; set; }

        public string Standard { get; set; }

        public string TeacherName { get; set; }

        public string Time { get; set; }

        public string CourseDuration { get; set; }

        public string Fees { get; set; }


    }
    public class StudentRegistration
    {
        public int id { get; set; }
        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Dateofbirth { get; set; }

        public string Gender { get; set; }

        public string Subject { get; set; }

        public string Standard { get; set; }


    }

    public class TeacherRegistration
    {
        public int id { get; set; }

        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Dateofbirth { get; set; }

        public string Gender { get; set; }

        public string Subject { get; set; }

        public string Qualification { get; set; }

        public string Time { get; set; }


    }
    public class UserLogin
    {
        public int Userid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string UserSubType { get; set; }
        public int IsAuthenticated { get; set; }
        public string LoggedInName { get; set; }


    }
}






