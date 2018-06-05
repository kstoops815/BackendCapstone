﻿using BackendCapstone.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace BackendCapstone.Services
{
    public class StudentsRepository
    {
        public IEnumerable<StudentModel> GetStudents()
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString))
            {
                db.Open();

                var listOfStudents = db.Query<StudentModel>(@"SELECT * from students");

                return listOfStudents;
            }
        }
    }
}