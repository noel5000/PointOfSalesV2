﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Entities.Model
{
  public  class AppSettings
    {
        public string Domain { get; set; }
        public string TokenKey { get; set; }
        public short TokenTimeHours { get; set; }
    }
}
