﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities;

public class Category
{

    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

    public  List<Course> Courses { get; set; } //bir kategoride birden fazla kurs bulunabilir.
}
