using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using UserManagement.LIBRARY.Model;

namespace UserManagement.LIBRARY.Provider
{
    public class BaseProvider : RDBMDBContext
    {
        public RDBMDBContext db = null;
        public BaseProvider()
        {
            db = new RDBMDBContext();
        }
    }
}