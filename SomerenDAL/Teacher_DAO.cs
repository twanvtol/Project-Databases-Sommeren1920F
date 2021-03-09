using System;
using System.Collections.Generic;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class Teacher_DAO : Base
    {
        public List<Teacher> Db_Get_All_Teachers()
        {
            string query = "SELECT student_id, student_name FROM [dbo].[Students]";
            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<Teacher> ReadTables(DataTable TeacherDataTable)
        {
            List<Teacher> lecturers = new List<Teacher>();

            if (TeacherDataTable == null)
            {
                throw new Exception("There are no items in the datatable!");
            }

            foreach (DataRow row in TeacherDataTable.Rows)
            {
                Teacher lecturer = new Teacher()
                {
                    Name = (string)row["student_name"],
                    Number = (int)row["student_id"]
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}
