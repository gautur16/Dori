﻿using DoriVLN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 

namespace DoriVLN.Database
{
    public class BaseDatabase
    {
        public BaseDatabase()
        {
            _db = new ApplicationDbContext();
        }
        protected ApplicationDbContext _db;
    }
}