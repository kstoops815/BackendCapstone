﻿using BackendCapstone.Models;
using BackendCapstone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace BackendCapstone.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        [HttpGet, Route("")]
        public HttpResponseMessage DisplayStudents()
        {
            var studentRepo = new StudentsRepository();
            var displayStudents = studentRepo.GetStudents();

            return Request.CreateResponse(HttpStatusCode.OK, displayStudents);
        }

        [HttpGet, Route("{id}")]
        public HttpResponseMessage GetStudentsForSingleTeacher(int id)
        {
            var studentRepo = new StudentsRepository();
            var studentsAssignedToSingleTeacher = studentRepo.GetStudentsForSingleTeacher(id);

            return Request.CreateResponse(HttpStatusCode.OK, studentsAssignedToSingleTeacher);
        }

        [HttpPut, Route("markpresent/{id}")]
        public HttpResponseMessage MarkStudentPresent(int id)
        {
            var studentRepo = new StudentsRepository();
            var success = studentRepo.MarkStudentPresent(id);

            if (success)
            {
                return Request.CreateResponse(HttpStatusCode.OK, success);
            }

            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "did not work");
        }
    }

    
    
    
}