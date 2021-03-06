﻿using System;
using System.Collections.Generic;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class Student_DAO : Base
    {
        public List<Student> Db_Get_All_Students()
        {
            string query = "SELECT student_id, student_name FROM [dbo].[Students]";
            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<Student> ReadTables(DataTable StudentsDataTable)
        {
            List<Student> students = new List<Student>();

            if (StudentsDataTable == null)
            {
                throw new Exception("There are no items in the datatable!");
            }

            foreach (DataRow row in StudentsDataTable.Rows)
            {
                Student student = new Student()
                {
                    Name = (string)row["student_name"],
                    Number = (int)row["student_id"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}
