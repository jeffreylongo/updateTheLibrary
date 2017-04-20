using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace updateTheLibrary.DataContext
{
    public class DataContext :DbContext
    {
        public DataContext():base("name=DefaultConnection")
        {

        }
    }
}