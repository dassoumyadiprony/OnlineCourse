using CVMSCore.BAL.Models.OnlineCourse;
using CVMSCore.BAL.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CVMS_Core.Controllers
{
    public class IndexController : BaseController
    {
        OnlineCourseService service = new OnlineCourseService();
        
        public IActionResult Index()
        {
            return View();
        }
        //-----------------------------------Admin Login----------------------------------------------
        public IActionResult AdminLog()
        {
            return View();
        }
        public IActionResult AdminLoginPage(AdminLoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = service.AdminLoginSer(model);

                if (result == 1)
                {
                    ViewBag.ReturnMessage = "Congrats Login successfull!!!";

                    return RedirectToAction("AdminMenuPage", "Index");
                    //ViewBag.ReturnMessage = "Login successfull";
                }
                else
                {
                    ViewBag.ReturnMessage = "Invalid credentials";
                    return View("AdminLog", model);
                }
            }

            return View("AdminLog", model);
        }


        //-----------------------------------------Admin Signup---------------------------------------------
        public IActionResult AdminSign()
        {
            return View();
        }

        public IActionResult AdminSignupPage(AdminSignUpModel model)
        {
            if (ModelState.IsValid)
            {
                var result = service.AdminSignupSer(model);

                if (result == 101)
                {
                    ViewBag.ReturnMessage = "Congrats Login successfull!!!";
                    return RedirectToAction("AdminLog", "Index");


                    //return RedirectToAction("EmployeeForm", "Payroll");
                    //ViewBag.ReturnMessage = "Login successfull";
                }
                else
                {
                    ViewBag.ReturnMessage = "Invalid credentials";
                    return View("AdminSign", model);
                }
            }

            return View("AdminSign", model);
        }
    //-----------------------------------------------Student Login-------------------------------------------
        public IActionResult StudentLog()
        {
            return View();
        }
        public IActionResult StudentLoginPage(StudentLoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = service.StudentLoginSer(model);

                if (result == 1)
                {
                    ViewBag.ReturnMessage = "Congrats Login successfull!!!";

                    return RedirectToAction("StudentMenuPage", "Index");
                    //ViewBag.ReturnMessage = "Login successfull";
                }
                else
                {
                    ViewBag.ReturnMessage = "Invalid credentials";
                    return View("StudentLog", model);
                }
            }

            return View("StudentLog", model);
        }




        //---------------------------Student Signup---------------------------------------------------

        public IActionResult StudentSign()
        {
            return View();
        }

        public IActionResult StudentSignupPage(StudentSignUpModel model)
        {
            if (ModelState.IsValid)
            {
                var result = service.StudentSignupSer(model);

                if (result == 101)
                {
                    ViewBag.ReturnMessage = "Congrats Signup successfull!!!";

                    //return RedirectToAction("EmployeeForm", "Payroll");
                    //ViewBag.ReturnMessage = "Login successfull";
                }
                else
                {
                    ViewBag.ReturnMessage = "Invalid credentials";
                    return View("StudentSign", model);
                }
            }

            return View("StudentSign", model);
        }


        //-------------------------------------------------------Teacher Login-----------------------------------------

        public IActionResult TeacherLog()
        {
            return View();
        }


        public IActionResult TeacherLoginPage(TeacherLoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = service.TeacherLoginSer(model);

                if (result == 1)
                {
                    ViewBag.ReturnMessage = "Congrats Login successfull!!!";

                    return RedirectToAction("TeacherMenuPage", "Index");
                    //ViewBag.ReturnMessage = "Login successfull";
                }
                else
                {
                    ViewBag.ReturnMessage = "Invalid credentials";
                    return View("TeacherLog", model);
                }
            }

            return View("TeacherLog", model);
        }

        //-------------------------------------------------Teacher Signup---------------------------------------------------
        public IActionResult TeacherSign()
        {
            return View();
        }
         public IActionResult TeacherSignupPage(TeacherSignUpModel model)
        {
            if (ModelState.IsValid)
            {
                var result = service.TeacherSignupSer(model);

                if (result == 101)
                {
                    ViewBag.ReturnMessage = "Congrats Signup successfull!!!";
                    return RedirectToAction("TeacherLog", "Index");


                    //return RedirectToAction("EmployeeForm", "Payroll");
                    //ViewBag.ReturnMessage = "Login successfull";
                }
                else
                {
                    ViewBag.ReturnMessage = "Invalid credentials";
                    return View("TeacherSign", model);
                }
            }

            return View("TeacherSign", model);
        }

        //----------------------------------------------------Student Subscribe Page---------------------------------------------------
        public IActionResult Studentaddcoursepage()
        {
            return View();
        }
        //----------------------------------------------------------Student From------------------------------------------------

        public IActionResult StudentRegfrom()
        {
            return View();
        }
        //--------------------------------------Teacher From--------------------------------------------------------

        public IActionResult TeacherRegfrom()
        {
            return View();
        }
        //--------------------------------------------------------Admin Page------------------------------------------
        public IActionResult AdminMenuPage(string LoggedInName)
        {
            ViewBag.LoggedInName = LoggedInName;
            return View();
        }

        //-----------------------------------------------------Student Page------------------------------------------------------

        public IActionResult StudentMenuPage(string LoggedInName)
        {
            ViewBag.LoggedInName = LoggedInName;

            return View();
        }
        //---------------------------------------Teacher Page-------------------------------------------------------

        public IActionResult TeacherMenuPage(string LoggedInName)
        {
            ViewBag.LoggedInName = LoggedInName;

            return View();
        }

        //----------------------------------------------------Admin Student Course View-------------------------------------
        public IActionResult Adminstudentchoosecoursedetails()
        {
            return View();
        }
        //---------------------------------------------------------Admin Add More---------------------------------------

        public IActionResult AdminAddmore()
        {
            return View();

        }





        //-------------------------------------Admin Teacher View-------------------------------------------

        public IActionResult AdminTeacherview()
        {
            return View();
        }
        //-----------------------------------------Admin Student View--------------------------------------
        public IActionResult AdminStudentview()
        {
            return View();
        }

        //-------------------------------Admine Addmore post----------------------------------

        public JsonResult Addmoreadminn(IFormCollection formcollection)
        {
            var result = 0;
            if (formcollection != null)
            {
                AdminAddmoreModel obj = new AdminAddmoreModel();//model object.........             // obj.EmpIdd = Convert.ToInt32(formcollection["EmpIdd"]);
                obj.SubjectId = Convert.ToString(formcollection["SubjectId"]);
                obj.SubjectName = Convert.ToString(formcollection["SubjectName"]);
                obj.Standard = Convert.ToString(formcollection["Standard"]);
                obj.TeacherName = Convert.ToString(formcollection["TeacherName"]);
                obj.Time = Convert.ToString(formcollection["Time"]);
                obj.CourseDuration = Convert.ToString(formcollection["CourseDuration"]);
                obj.Fees = Convert.ToString(formcollection["Fees"]);
                
                
                    result = service.AdminAddmoreService(obj);
                
            }
            return Json(new { result });

        }
        //------------------------Student Registration Form------------------------

        public JsonResult StudentReg(IFormCollection formcollection)
        {
            var result = 0;
            if (formcollection != null)
            {
                StudentRegistration obj = new StudentRegistration();//model object.........             // obj.EmpIdd = Convert.ToInt32(formcollection["EmpIdd"]);
                obj.Fullname = Convert.ToString(formcollection["Fullname"]);
                obj.Email = Convert.ToString(formcollection["Email"]);
                obj.Dateofbirth = Convert.ToString(formcollection["Dateofbirth"]);
                obj.Gender = Convert.ToString(formcollection["Gender"]);
                obj.Subject = Convert.ToString(formcollection["Subject"]);
                obj.Standard = Convert.ToString(formcollection["Standard"]);


                result = service.StudentformService(obj);

            }
            return Json(new { result });

        }
        //-------------------------------------Teacher Registration post----------------------------------------------

        public JsonResult TeacherReg(IFormCollection formcollection)
        {
            var result = 0;
            if (formcollection != null)
            {
                TeacherRegistration obj = new TeacherRegistration();//model object.........             // obj.EmpIdd = Convert.ToInt32(formcollection["EmpIdd"]);
                obj.Fullname = Convert.ToString(formcollection["Fullname"]);
                obj.Email = Convert.ToString(formcollection["Email"]);
                obj.Dateofbirth = Convert.ToString(formcollection["Dateofbirth"]);
                obj.Gender = Convert.ToString(formcollection["Gender"]);
                obj.Subject = Convert.ToString(formcollection["Subject"]);
                obj.Qualification = Convert.ToString(formcollection["Qualification"]);
                obj.Time = Convert.ToString(formcollection["Time"]);



                result = service.TeacherformService(obj);

            }
            return Json(new { result });

        }
        //------------------------------------------Student Registration get--------------------------------------------
        public JsonResult getalldata()
        {
            List<StudentRegistration> gdta = new List<StudentRegistration>();
            gdta = service.Getdataser();
            return Json(new { gdta = gdta });
        }
        //---------------------------------------Student Reg Delete---------------------------------------------------------

        public JsonResult DeleteStudentRegs(int Id)
        {
            try
            {
                int result = service.DeleteStudentregs(Id)
;

                if (result > 0)
                {
                    //Successfully deleted
                    return Json(new { success = true, message = "Student  deleted successfully" });
                }
                else
                {
                    //Employee with the specified ID was not found
                    return Json(new { success = false, message = "Student not found" });
                }
            }
            catch (Exception ex)
            {
                //Handle exceptions, log them, and return an error response
                return Json(new { success = false, message = "An error occurred while deleting the Student" });
            }


        }
        //--------------------------------------------Teacher Course Details---------------------------------------------------------
        public IActionResult CourseDetails()
        {
            return View();
        }
        //----------------------------------------------------------------Teacher Registration Details Get------------------------------

        public JsonResult getalldataa()
        {
            List<TeacherRegistration> gdta = new List<TeacherRegistration>();
            gdta = service.Getdataserr();
            return Json(new { gdta = gdta });
        }
        //----------------------------------------------------------------Techer Reg Delete-----------------------------------

        public JsonResult DeleteTeacherRegs(int Id)
        {
            try
            {
                int result = service.DeleteTeacherregs(Id)
;

                if (result > 0)
                {
                    //Successfully deleted
                    return Json(new { success = true, message = "Student  deleted successfully" });
                }
                else
                {
                    //Employee with the specified ID was not found
                    return Json(new { success = false, message = "Student not found" });
                }
            }
            catch (Exception ex)
            {
                //Handle exceptions, log them, and return an error response
                return Json(new { success = false, message = "An error occurred while deleting the Student" });
            }


        }


        //-------------------------------------------------Student Choose Course-----------------------------------------------------------------
        public JsonResult getalldataaa()
        {
            List<AdminAddmoreModel> gdta = new List<AdminAddmoreModel>();
            gdta = service.Getdataserrr();
            return Json(new { gdta = gdta });
        }

        //--------------------------------------------------------Edit Choose Course-------------------------------------------------
        public JsonResult EditCourse(int Id)
        {

            AdminAddmoreModel company = new AdminAddmoreModel();
            try
            {
                company = service.EditCourseebyId(Id);


            }
            catch (Exception ex)
            {

            }
            return Json(new { company });


        }
        //----------------------------------------------Edit post Controller----------------------------
        public JsonResult Editpost(IFormCollection formcollection)
        {
            var result = 0;
            if (formcollection != null)
            {
                AdminAddmoreModel obj = new AdminAddmoreModel();//model object.........             // obj.EmpIdd = Convert.ToInt32(formcollection["EmpIdd"]);
                obj.SubjectId = Convert.ToString(formcollection["SubjectId"]);
                obj.SubjectName = Convert.ToString(formcollection["SubjectName"]);
                obj.Standard = Convert.ToString(formcollection["Standard"]);
                obj.TeacherName = Convert.ToString(formcollection["TeacherName"]);
                obj.Time = Convert.ToString(formcollection["Time"]);
                obj.CourseDuration = Convert.ToString(formcollection["CourseDuration"]);
                obj.Fees = Convert.ToString(formcollection["Fees"]);


                result = service.editcoursepost(obj);

            }
            return Json(new { result });

        }
        //-------------------------------------------Joining Get-------------------------------------------------------
        public JsonResult coursejoining()
        {
            List<AdminAddmoreModel> gdta = new List<AdminAddmoreModel>();
            gdta = service.Joiningget();
            return Json(new { gdta = gdta });
        }
        //-------------------------------------------------------Choose Course Teacher View-------------------------------

        public JsonResult coursejoininn()
        {
            List<AdminAddmoreModel> gdta = new List<AdminAddmoreModel>();
            gdta = service.ChooseCourseet();
            return Json(new { gdta = gdta });
        }
        //------------------------------------------------------Add Course View Get ADDMORE------------------------------
        public JsonResult courseAddMore()
        {
            List<AdminAddmoreModel> gdta = new List<AdminAddmoreModel>();
            gdta = service.ChooseAddGet();
            return Json(new { gdta = gdta });
        }
        //---------------------------------------------Delete Course Details Teacher Views--------------------------------------------
        public JsonResult DeleteChooseCO(int Id)
        {
            try
            {
                int result = service.DeleteChooseCourse(Id)
;

                if (result > 0)
                {
                    //Successfully deleted
                    return Json(new { success = true, message = "Student  deleted successfully" });
                }
                else
                {
                    //Employee with the specified ID was not found
                    return Json(new { success = false, message = "Student not found" });
                }
            }
            catch (Exception ex)
            {
                //Handle exceptions, log them, and return an error response
                return Json(new { success = false, message = "An error occurred while deleting the Student" });
            }


        }
        //-----------------------------------------Admin Student Choose Course Delete--------------------------------------------------

        public JsonResult DeleteChooseCOAdmin(int Id)
        {
            try
            {
                int result = service.DeleteStudentCHoosecourseAdmin(Id)
;

                if (result > 0)
                {
                    //Successfully deleted
                    return Json(new { success = true, message = "Student  deleted successfully" });
                }
                else
                {
                    //Employee with the specified ID was not found
                    return Json(new { success = false, message = "Student not found" });
                }
            }
            catch (Exception ex)
            {
                //Handle exceptions, log them, and return an error response
                return Json(new { success = false, message = "An error occurred while deleting the Student" });
            }


        }
        //-----------------------------------------Admin Add more Delete--------------------------------------------------

        public JsonResult DeleteChooseCourseAdmin(int Id)
        {
            try
            {
                int result = service.Deletechoosrcoursead(Id)
;

                if (result > 0)
                {
                    //Successfully deleted
                    return Json(new { success = true, message = "Student  deleted successfully" });
                }
                else
                {
                    //Employee with the specified ID was not found
                    return Json(new { success = false, message = "Student not found" });
                }
            }
            catch (Exception ex)
            {
                //Handle exceptions, log them, and return an error response
                return Json(new { success = false, message = "An error occurred while deleting the Student" });
            }


        }
        //------------------------------------------Login2---------------------------------------------------------------------

        public IActionResult login(string UserName, string Password)
        {
            UserLogin userdt = new UserLogin();
            List<UserLogin> userdtt = new List<UserLogin>();
            if (UserName != null && Password != null)
            {
                userdt = service.AdminLogSer(UserName, Password);
                if (userdt != null)
                {
                    HttpContext.Session.SetString("LoggedUserInfo", JsonConvert.SerializeObject(userdt));
                    var value = HttpContext.Session.GetString("LoggedUserInfo");
                    //string _userDetail = Security.GetEncryptString(userdt.UserName.Trim() + "|" + encryptPassword.Trim());
                    ViewBag.LoggedInName = userdt.LoggedInName;
                    userdt = GetUserDetail();
                }

                if (userdt != null)
                {
                    if (userdt.UserSubType == "Admin")
                    {
                        ViewBag.ReturnMessage = "Congrats Login successfull!!!";


                        return RedirectToAction("AdminMenuPage", "Index", new { LoggedInName = userdt.LoggedInName });
                    }
                    else if (userdt.UserSubType == "Teacher")
                    {
                        ViewBag.ReturnMessage = "Congrats Login successfull!!!";

                        return RedirectToAction("TeacherMenuPage", "Index", new { LoggedInName = userdt.LoggedInName });
                    }
                    else if (userdt.UserSubType == "Student")
                    {
                        ViewBag.ReturnMessage = "Congrats Login successfull!!!";

                        return RedirectToAction("StudentMenuPage", "Index", new { LoggedInName = userdt.LoggedInName });
                    }
                    //else if (userdt.UserSubType == "Patient")
                    //{

                    //    return RedirectToAction("PatientDashBoardPage", "Hospital", new { Userid = userdt.Userid });
                    //}
                }
                //if(userdt != null)
                //{
                //    HttpContext.Session.SetString("LoggedUserInfo", JsonConvert.SerializeObject(userdt));
                //    var value = HttpContext.Session.GetString("LoggedUserInfo");
                //    //string _userDetail = Security.GetEncryptString(userdt.UserName.Trim() + "|" + encryptPassword.Trim());
                //    userdt = GetUserDetail();
                //}


                ViewData["ErrorMessage"] = "Invalid username or password";
                return View("AdminLog");
            }
            else
            {
                //ViewBag.ReturnMessage = "Invalid credentials";

                return View();
            }
        }
        //----------------------------------------------------------Add more Admin 2---------------------------------------------
        public IActionResult Addmoreadmin()
        {
            return View();
        }
        //-------------------------------------------------------------logout--------------------------------------------
        public IActionResult Addmo()
        {
            return View();
        }
    }
}
