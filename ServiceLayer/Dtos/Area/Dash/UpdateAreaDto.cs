﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Dtos.Area.Dash
{
    public class UpdateAreaDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int widthSize { get; set; }
        public int lengthtSize { get; set; }

        public int StadiumId { get; set; }
    }
}
