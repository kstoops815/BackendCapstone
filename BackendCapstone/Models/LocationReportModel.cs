﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendCapstone.Models
{
    public class LocationReportModel
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int NumberOfStudentsInLocation { get; set; }
    }
}