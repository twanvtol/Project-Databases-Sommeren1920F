using System;
using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Teacher_Service
    {
        Teacher_DAO Lecturers_db = new Teacher_DAO();

        public List<Teacher> GetTeacher()
        {
            try
            {
                List<Teacher> Lectuers = Lecturers_db.Db_Get_All_Teachers();
                return Lectuers;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake Teacher to the list to make sure the rest of the application continues working!
                List<Teacher> teachers = new List<Teacher>();
                Teacher a = new Teacher();
                a.Name = "Mr. Test Teacher";
                a.Number = 474791;
                teachers.Add(a);
                Teacher b = new Teacher();
                b.Name = "Mrs. Test Teacher";
                b.Number = 197474;
                teachers.Add(b);
                return teachers;
                throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}
