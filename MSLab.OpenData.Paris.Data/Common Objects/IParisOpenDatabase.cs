﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public interface IParisOpenDatabase
    {
        int nhits { get; set; }
        Parameters parameters { get; set; }
    }
}
