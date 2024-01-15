using CVMSCore.BAL.Models.OnlineCourse;
using CVMSCore.BAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVMSCore.BAL.Service
{
    //----------------------------------Admin Signup--------------------------------
    public class OnlineCourseService
    {
        OnlineCourseRepo _repo = new OnlineCourseRepo();
        public int AdminSignupSer(AdminSignUpModel obj)
        {
            return _repo.AdminSignupRepository(obj);
        }


        //---------------------------------------------------Admin Login-----------------------



        public int AdminLoginSer(AdminLoginModel obj)
        {
            return _repo.AdminLoginRepository(obj);
        }


        //-------------------------------Student Signup-----------------------------------


        public int StudentSignupSer(StudentSignUpModel obj)
        {
            return _repo.StudentSignupRepository(obj);
        }
        //-----------------------------------Student Login----------------------------------------

        public int StudentLoginSer(StudentLoginModel obj)
        {
            return _repo.StudentLoginRepository(obj);
        }

        //---------------------------------------Teacher Signup---------------------------------------------

        public int TeacherSignupSer(TeacherSignUpModel obj)
        {
            return _repo.TeacherSignupRepository(obj);
        }
        //------------------------------------------------------------Teacher Login------------------------------------
        public int TeacherLoginSer(TeacherLoginModel obj)
        {
            return _repo.TeacherLoginRepository(obj);
        }
        //----------------------Admin Add More Post-------------------------------------------------

        public int AdminAddmoreService(AdminAddmoreModel obj)
        {
            int num = 102;
            try
            {
                return _repo.AdminAddmorerepo(obj);


            }
            catch
            {

            }
            return num;
        }
        //---------------------------------------Student Registration From Post---------------
        public int StudentformService(StudentRegistration obj)
        {
            int num = 102;
            try
            {
                return _repo.StudentRegistrationrepo(obj);


            }
            catch
            {

            }
            return num;
        }
        //-----------------------------------------Teacher Registration From Post--------------------
        public int TeacherformService(TeacherRegistration obj)
        {
            int num = 102;
            try
            {
                return _repo.TeacherRegistrationrepo(obj);


            }
            catch
            {

            }
            return num;
        }
        //--------------------------Student Registration Get-----------------
        public List<StudentRegistration> Getdataser()
        {
            List<StudentRegistration> list = new List<StudentRegistration>();
            list = _repo.getdtarepo();

            return list;
        }
        //--------------------------------Student Reg Delete---------------------------------------------
        public int DeleteStudentregs(int Id)
        {
            try
            {
                return _repo.DeleteStuReg(Id)
;
            }
            catch (Exception ex)
            {
                //Handle exceptions and log them
                throw ex;
            }
        }
        //------------------------Teacher Registration Get--------------------------------------------
        public List<TeacherRegistration> Getdataserr()
        {
            List<TeacherRegistration> list = new List<TeacherRegistration>();
            list = _repo.getdtarepoo();

            return list;
        }


        //-----------------------------------------------Delete Teacher Reg-----------------------------------------------------

        public int DeleteTeacherregs(int Id)
        {
            try
            {
                return _repo.DeleteTecReg(Id)
;
            }
            catch (Exception ex)
            {
                //Handle exceptions and log them
                throw ex;
            }
        }


        //--------------------------------------------------------------------------

        //------------------------Choose Course Get--------------------------------------------


         public List<AdminAddmoreModel> Getdataserrr()
        {
            List<AdminAddmoreModel> list = new List<AdminAddmoreModel>();
            list = _repo.getdtarepooo();

            return list;
        }
        //-----------Edit Choose Course---------------------------------------------
        public AdminAddmoreModel EditCourseebyId(int CountryId)
        {
            try
            {
                return _repo.EditCourseById(CountryId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //----------------------------------------Edit Course Post--------------------------------------
        public int editcoursepost(AdminAddmoreModel obj)
        {
            int num = 102;
            try
            {
                return _repo.Editpostrepo(obj);


            }
            catch
            {

            }
            return num;
        }
        //---------------------------------------------------Joining Get-------------------------------------------------
        public List<AdminAddmoreModel> Joiningget()
        {
            List<AdminAddmoreModel> list = new List<AdminAddmoreModel>();
            list = _repo.Joining();

            return list;
        }
        //------------------------------------------------------------Choose Course-------------------------------

        public List<AdminAddmoreModel> ChooseCourseet()
        {
            List<AdminAddmoreModel> list = new List<AdminAddmoreModel>();
            list = _repo.ChooseCourseGet();

            return list;
        }
        //------------------------------------------------------Add more-----------------------------------------------

        public List<AdminAddmoreModel> ChooseAddGet()
        {
            List<AdminAddmoreModel> list = new List<AdminAddmoreModel>();
            list = _repo.ChooseAddGett();

            return list;
        }
        //---------------------------------------------Delete Course Details Teacher Views-------------------------------------------

        public int DeleteChooseCourse(int Id)
        {
            try
            {
                return _repo.DeleteChooseCoursee(Id)
;
            }
            catch (Exception ex)
            {
                //Handle exceptions and log them
                throw ex;
            }
        }
        //-----------------------------------------Admin Student Choose Course Delete--------------------------------------------------

        public int DeleteStudentCHoosecourseAdmin(int Id)
        {
            try
            {
                return _repo.DeleteadminChooseCoursee(Id)
;
            }
            catch (Exception ex)
            {
                //Handle exceptions and log them
                throw ex;
            }
        }
        //-----------------------------------------Admin Add more Delete--------------------------------------------------

        public int Deletechoosrcoursead(int Id)
        {
            try
            {
                return _repo.Deletechoosrcourseadmin(Id)
;
            }
            catch (Exception ex)
            {
                //Handle exceptions and log them
                throw ex;
            }
        }
        //--------------------------------------------------------------Login2------------------------------------------

        public UserLogin AdminLogSer(string UserName, string Password)
        {
            return _repo.AdminLoginRepo(UserName, Password);
        }
    }
}

