﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoWorkshop.Business.Dtos.Responses
{
    public class GetAllCourseResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsFree { get; set; }

        public string PictureUrl { get; set; }
    }
}
