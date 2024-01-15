using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVMSCore.BAL.Models.OnlineCourse;

namespace CVMSCore.BAL.Repository
{
    //--------------------------------------------------Admin Signup-----------------------------------
    public class OnlineCourseRepo
    {
        private SqlConnection _conn;  //for sql connection
        private DapperConnection dapper = new DapperConnection(ConnectionFile.Connection_ANTSDB);
        public int AdminSignupRepository(AdminSignUpModel obj)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@Name", obj.Name);
            dynamicParameters.Add("@UserName", obj.UserName);
            dynamicParameters.Add("@Password", obj.Password);
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            var result = conn.QueryFirstOrDefault<int>("SAF_Adminsignup", dynamicParameters, commandType: CommandType.StoredProcedure);
            DapperConnection.CloseConnection(this._conn);

            return result;

        }
        //---------------------------------------------Admin Login--------------------------------------------//
        
        public int AdminLoginRepository(AdminLoginModel obj)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            
            dynamicParameters.Add("@UserName", obj.UserName);
            dynamicParameters.Add("@Password", obj.Password);
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            var result = conn.QueryFirstOrDefault<int>("SAF_AdminLogin", dynamicParameters, commandType: CommandType.StoredProcedure);
            DapperConnection.CloseConnection(this._conn);

            return result;

        }


        //-----------------------------------Student Signup----------------------------------------------


        public int StudentSignupRepository(StudentSignUpModel obj)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@Name", obj.Name);
            dynamicParameters.Add("@UserName", obj.UserName);
            dynamicParameters.Add("@Password", obj.Password);
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            var result = conn.QueryFirstOrDefault<int>("SAF_Studentsignup", dynamicParameters, commandType: CommandType.StoredProcedure);
            DapperConnection.CloseConnection(this._conn);

            return result;

        }

        //--------------------------------------Student Login------------------------------------------


        public int StudentLoginRepository(StudentLoginModel obj)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();

            dynamicParameters.Add("@UserName", obj.UserName);
            dynamicParameters.Add("@Password", obj.Password);
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            var result = conn.QueryFirstOrDefault<int>("SAF_StudentLogin", dynamicParameters, commandType: CommandType.StoredProcedure);
            DapperConnection.CloseConnection(this._conn);

            return result;

        }

        //--------------------------------------------Teacher Signup---------------------------------------
        public int TeacherSignupRepository(TeacherSignUpModel obj)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@Name", obj.Name);
            dynamicParameters.Add("@UserName", obj.UserName);
            dynamicParameters.Add("@Password", obj.Password);
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            var result = conn.QueryFirstOrDefault<int>("SAF_Teachersignup", dynamicParameters, commandType: CommandType.StoredProcedure);
            DapperConnection.CloseConnection(this._conn);

            return result;

        }
        //--------------------------------------------------Teacher Login------------------------------
        public int TeacherLoginRepository(TeacherLoginModel obj)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();

            dynamicParameters.Add("@UserName", obj.UserName);
            dynamicParameters.Add("@Password", obj.Password);
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            var result = conn.QueryFirstOrDefault<int>("SAF_TeacherLogin", dynamicParameters, commandType: CommandType.StoredProcedure);
            DapperConnection.CloseConnection(this._conn);

            return result;

        }

        //-------------------------------------------------Admin Addmore POST--------------

        

            public int AdminAddmorerepo(AdminAddmoreModel ct)
            {
                int num = 0;
                try
                {
                    DynamicParameters dynamicParameters1 = new DynamicParameters();
                    //  dynamicParameters1.Add("EmpIdd", (object)0, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    dynamicParameters1.Add("SubjectId", (object)ct.SubjectId, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    dynamicParameters1.Add("SubjectName", (object)ct.SubjectName, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    dynamicParameters1.Add("Standard", (object)ct.Standard, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    dynamicParameters1.Add("TeacherName", (object)ct.TeacherName, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    dynamicParameters1.Add("Time", (object)ct.Time, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    dynamicParameters1.Add("CourseDuration", (object)ct.CourseDuration, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    dynamicParameters1.Add("Fees", (object)ct.Fees, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());

                    //dynamicParameters1.Add("CountryId", (object)0, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());

                    //dynamicparameters1.add("status", (object)ct.status, new dbtype?(), new parameterdirection?(), new int?(), new byte?(), new byte?());
                    //dynamicParameters1.Add("USERTYPE", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    //dynamicParameters1.Add("SUBUSERTYPE", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    //dynamicParameters1.Add("USERID", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    // dynamicParameters1.Add("Citycode", (object)ct.Citycode, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                    this._conn = this.dapper.GetConnection();
                    DapperConnection.OpenConnection(this._conn);
                    SqlConnection conn = this._conn;
                    DynamicParameters dynamicParameters2 = dynamicParameters1;
                    CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
                    int? nullable2 = new int?();
                    CommandType? nullable3 = nullable1;
                    string? str = SqlMapper.ExecuteScalar((IDbConnection)conn, "SAF_Adminaddmore", (object)dynamicParameters2, (IDbTransaction)null, nullable2, nullable3).ToString();
                    DapperConnection.CloseConnection(this._conn);
                    num = Convert.ToInt32(str);

                }
                catch (Exception ex)
                {

                }

                return num;
            }
        //---------------------------------Student Registration Form post-----------------------
        public int StudentRegistrationrepo(StudentRegistration ct)
        {
            int num = 0;
            try
            {
                DynamicParameters dynamicParameters1 = new DynamicParameters();
                //  dynamicParameters1.Add("EmpIdd", (object)0, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Fullname", (object)ct.Fullname, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Email", (object)ct.Email, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Dateofbirth", (object)ct.Dateofbirth, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Gender", (object)ct.Gender, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Subject", (object)ct.Subject, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Standard", (object)ct.Standard, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("Fees", (object)ct.Fees, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());

                //dynamicParameters1.Add("CountryId", (object)0, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());

                //dynamicparameters1.add("status", (object)ct.status, new dbtype?(), new parameterdirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("USERTYPE", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("SUBUSERTYPE", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("USERID", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                // dynamicParameters1.Add("Citycode", (object)ct.Citycode, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                this._conn = this.dapper.GetConnection();
                DapperConnection.OpenConnection(this._conn);
                SqlConnection conn = this._conn;
                DynamicParameters dynamicParameters2 = dynamicParameters1;
                CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
                int? nullable2 = new int?();
                CommandType? nullable3 = nullable1;
                string? str = SqlMapper.ExecuteScalar((IDbConnection)conn, "SAF_Studentregistrationfrom", (object)dynamicParameters2, (IDbTransaction)null, nullable2, nullable3).ToString();
                DapperConnection.CloseConnection(this._conn);
                num = Convert.ToInt32(str);

            }
            catch (Exception ex)
            {

            }

            return num;
        }
        //--------------------------------------------------------Teacher Registration form post-----

        public int TeacherRegistrationrepo(TeacherRegistration ct)
        {
            int num = 0;
            try
            {
                DynamicParameters dynamicParameters1 = new DynamicParameters();
                //  dynamicParameters1.Add("EmpIdd", (object)0, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Fullname", (object)ct.Fullname, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Email", (object)ct.Email, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Dateofbirth", (object)ct.Dateofbirth, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Gender", (object)ct.Gender, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Subject", (object)ct.Subject, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Qualification", (object)ct.Qualification, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Time", (object)ct.Time, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());

                //dynamicParameters1.Add("CountryId", (object)0, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());

                //dynamicparameters1.add("status", (object)ct.status, new dbtype?(), new parameterdirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("USERTYPE", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("SUBUSERTYPE", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("USERID", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                // dynamicParameters1.Add("Citycode", (object)ct.Citycode, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                this._conn = this.dapper.GetConnection();
                DapperConnection.OpenConnection(this._conn);
                SqlConnection conn = this._conn;
                DynamicParameters dynamicParameters2 = dynamicParameters1;
                CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
                int? nullable2 = new int?();
                CommandType? nullable3 = nullable1;
                string? str = SqlMapper.ExecuteScalar((IDbConnection)conn, "SAF_Teacherregistrationfrom", (object)dynamicParameters2, (IDbTransaction)null, nullable2, nullable3).ToString();
                DapperConnection.CloseConnection(this._conn);
                num = Convert.ToInt32(str);

            }
            catch (Exception ex)
            {

            }

            return num;
        }
        //---------------------Student Registration Get------------------------------------------------

        public List<StudentRegistration> getdtarepo()   //list creating using the controller method getdata//
        {
            DynamicParameters dynamicparameters1 = new DynamicParameters();
            List<StudentRegistration> store = new List<StudentRegistration>();
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            DynamicParameters dynamicparameters2 = dynamicparameters1;
            CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
            // int? nullable2 = new int?();
            CommandType? nullable3 = nullable1;
            store = _conn.Query<StudentRegistration>("SAF_getstudentreg", commandType: CommandType.StoredProcedure).ToList();
            DapperConnection.CloseConnection(this._conn);
            //int num = convert.toint32(str);
            return store;

        }
        //------------------------------------------Student Reg Delete-------------------------------------------

        public int DeleteStuReg(int Id)
        {
            try
            {
                using (this._conn = dapper.GetConnection())
                {
                    DapperConnection.OpenConnection(this._conn);

                    // Implement your delete logic using Dapper and a stored procedure here
                    // Example:
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", Id);

                    var result = _conn.Execute("Saf_StudentRegDelete", parameters, commandType: CommandType.StoredProcedure);

                    DapperConnection.CloseConnection(this._conn);
                    return result; // The stored procedure should return the number of affected rows
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and log them
                throw ex;
            }
        }
            //----------------------------------Student Registration Get--------------------------------------------------------

            public List<TeacherRegistration> getdtarepoo()   //list creating using the controller method getdata//
            {
                DynamicParameters dynamicparameters1 = new DynamicParameters();
                List<TeacherRegistration> store = new List<TeacherRegistration>();
                this._conn = this.dapper.GetConnection();
                DapperConnection.OpenConnection(this._conn);
                SqlConnection conn = this._conn;
                DynamicParameters dynamicparameters2 = dynamicparameters1;
                CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
                // int? nullable2 = new int?();
                CommandType? nullable3 = nullable1;
                store = _conn.Query<TeacherRegistration>("SAF_getTeacherreg", commandType: CommandType.StoredProcedure).ToList();
                DapperConnection.CloseConnection(this._conn);
                //int num = convert.toint32(str);
                return store;

            }
        //---------------------------------------------Delete Teacher Reg-----------------------------------------------------------------------

        public int DeleteTecReg(int Id)
        {
            try
            {
                using (this._conn = dapper.GetConnection())
                {
                    DapperConnection.OpenConnection(this._conn);

                    // Implement your delete logic using Dapper and a stored procedure here
                    // Example:
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", Id);

                    var result = _conn.Execute("Saf_TeacherRegDelete", parameters, commandType: CommandType.StoredProcedure);

                    DapperConnection.CloseConnection(this._conn);
                    return result; // The stored procedure should return the number of affected rows
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and log them
                throw ex;
            }
        }
        //--------------------------------------------------------Student Choose Course----------------------------------------

        public List<AdminAddmoreModel> getdtarepooo()   //list creating using the controller method getdata//
        {
            DynamicParameters dynamicparameters1 = new DynamicParameters();
            List<AdminAddmoreModel> store = new List<AdminAddmoreModel>();
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            DynamicParameters dynamicparameters2 = dynamicparameters1;
            CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
            // int? nullable2 = new int?();
            CommandType? nullable3 = nullable1;
            store = _conn.Query<AdminAddmoreModel>("SAF_StuChooseCourse", commandType: CommandType.StoredProcedure).ToList();
            DapperConnection.CloseConnection(this._conn);
            //int num = convert.toint32(str);
            return store;

        }
        //---------------------------------------------Edit Course------------------------------------------------------------------------------------------
        public AdminAddmoreModel EditCourseById(int id)
        {
            try
            {
                using (this._conn = dapper.GetConnection())
                {
                    DapperConnection.OpenConnection(this._conn);


                    var parameters = new DynamicParameters();
                    parameters.Add("@id", id);

                    var employee = _conn.QueryFirstOrDefault<AdminAddmoreModel>("SAF__EditChooseCourse", parameters, commandType: CommandType.StoredProcedure);

                    DapperConnection.CloseConnection(this._conn);
                    return employee;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and log them
                throw ex;
            }
        }
        //--------------------------------------------Edit Post Repo---------------------------------
        public int Editpostrepo(AdminAddmoreModel ct)
        {
            int num = 0;
            try
            {
                DynamicParameters dynamicParameters1 = new DynamicParameters();
                //  dynamicParameters1.Add("EmpIdd", (object)0, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("SubjectId", (object)ct.SubjectId, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("SubjectName", (object)ct.SubjectName, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Standard", (object)ct.Standard, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("TeacherName", (object)ct.TeacherName, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Time", (object)ct.Time, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("CourseDuration", (object)ct.CourseDuration, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                dynamicParameters1.Add("Fees", (object)ct.Fees, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());

                //dynamicParameters1.Add("CountryId", (object)0, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());

                //dynamicparameters1.add("status", (object)ct.status, new dbtype?(), new parameterdirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("USERTYPE", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("SUBUSERTYPE", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                //dynamicParameters1.Add("USERID", (object)"", new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                // dynamicParameters1.Add("Citycode", (object)ct.Citycode, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
                this._conn = this.dapper.GetConnection();
                DapperConnection.OpenConnection(this._conn);
                SqlConnection conn = this._conn;
                DynamicParameters dynamicParameters2 = dynamicParameters1;
                CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
                int? nullable2 = new int?();
                CommandType? nullable3 = nullable1;
                string? str = SqlMapper.ExecuteScalar((IDbConnection)conn, "SAF_Studentaddmore", (object)dynamicParameters2, (IDbTransaction)null, nullable2, nullable3).ToString();
                DapperConnection.CloseConnection(this._conn);
                num = Convert.ToInt32(str);

            }
            catch (Exception ex)
            {

            }

            return num;
        }
        //--------------------------------------------------Joining Get-----------------------------------------------
        public List<AdminAddmoreModel> Joining()   //list creating using the controller method getdata//
        {
            DynamicParameters dynamicparameters1 = new DynamicParameters();
            List<AdminAddmoreModel> store = new List<AdminAddmoreModel>();
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            DynamicParameters dynamicparameters2 = dynamicparameters1;

            CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
            // int? nullable2 = new int?();
            CommandType? nullable3 = nullable1;
            store = _conn.Query<AdminAddmoreModel>("SAF_Joiningget", commandType: CommandType.StoredProcedure).ToList();
            DapperConnection.CloseConnection(this._conn);
            //int num = convert.toint32(str);
            return store;

        }
        //---------------------------------------------------------GET Choose Course------------------------------------
        public List<AdminAddmoreModel> ChooseCourseGet()   //list creating using the controller method getdata//
        {
            DynamicParameters dynamicparameters1 = new DynamicParameters();
            List<AdminAddmoreModel> store = new List<AdminAddmoreModel>();
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            DynamicParameters dynamicparameters2 = dynamicparameters1;

            CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
            // int? nullable2 = new int?();
            CommandType? nullable3 = nullable1;
            store = _conn.Query<AdminAddmoreModel>("SAF_Joiningget", commandType: CommandType.StoredProcedure).ToList();
            DapperConnection.CloseConnection(this._conn);
            //int num = convert.toint32(str);
            return store;

        }
        //--------------------------------------------------Add Course Get-----------------------------------------
        public List<AdminAddmoreModel> ChooseAddGett()   //list creating using the controller method getdata//
        {
            DynamicParameters dynamicparameters1 = new DynamicParameters();
            List<AdminAddmoreModel> store = new List<AdminAddmoreModel>();
            this._conn = this.dapper.GetConnection();
            DapperConnection.OpenConnection(this._conn);
            SqlConnection conn = this._conn;
            DynamicParameters dynamicparameters2 = dynamicparameters1;

            CommandType? nullable1 = new CommandType?(CommandType.StoredProcedure);
            // int? nullable2 = new int?();
            CommandType? nullable3 = nullable1;
            store = _conn.Query<AdminAddmoreModel>("SAF_StuChooseCourse", commandType: CommandType.StoredProcedure).ToList();
            DapperConnection.CloseConnection(this._conn);
            //int num = convert.toint32(str);
            return store;

        }

        //-----------------------------Delete Course Details Teacher Views---------------------------------------------------

        public int DeleteChooseCoursee(int Id)
        {
            try
            {
                using (this._conn = dapper.GetConnection())
                {
                    DapperConnection.OpenConnection(this._conn);

                    // Implement your delete logic using Dapper and a stored procedure here
                    // Example:
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", Id);

                    var result = _conn.Execute("Saf_CourseDetailsTeacherView", parameters, commandType: CommandType.StoredProcedure);

                    DapperConnection.CloseConnection(this._conn);
                    return result; // The stored procedure should return the number of affected rows
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and log them
                throw ex;
            }
        }
        //-----------------------------------------Admin Student Choose Course Delete--------------------------------------------------
        public int DeleteadminChooseCoursee(int Id)
        {
            try
            {
                using (this._conn = dapper.GetConnection())
                {
                    DapperConnection.OpenConnection(this._conn);

                    // Implement your delete logic using Dapper and a stored procedure here
                    // Example:
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", Id);

                    var result = _conn.Execute("Saf_CourseDetailsAdminView", parameters, commandType: CommandType.StoredProcedure);

                    DapperConnection.CloseConnection(this._conn);
                    return result; // The stored procedure should return the number of affected rows
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and log them
                throw ex;
            }
        }
        //-----------------------------------------Admin Add more Delete--------------------------------------------------
        public int Deletechoosrcourseadmin(int Id)
        {
            try
            {
                using (this._conn = dapper.GetConnection())
                {
                    DapperConnection.OpenConnection(this._conn);

                    // Implement your delete logic using Dapper and a stored procedure here
                    // Example:
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", Id);

                    var result = _conn.Execute("Saf_AdminAddMoreCourse", parameters, commandType: CommandType.StoredProcedure);

                    DapperConnection.CloseConnection(this._conn);
                    return result; // The stored procedure should return the number of affected rows
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and log them
                throw ex;
            }
        }
        //---------------------------------------------Login2----------------------------------------------------

        public UserLogin AdminLoginRepo(string UserName, string Password)
        {
            UserLogin userDetail = null;

            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@UserName", UserName);
                dynamicParameters.Add("@Password", Password);

                using (this._conn = this.dapper.GetConnection())
                {
                    DapperConnection.OpenConnection(this._conn);

                    userDetail = _conn.Query<UserLogin>("ValidateUserLogin", dynamicParameters, commandType: CommandType.StoredProcedure)
                                      .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log, or rethrow if needed
            }
            finally
            {
                DapperConnection.CloseConnection(this._conn);
            }

            return userDetail;
        }

    }
}
