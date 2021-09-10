﻿using DataAccess.lib.Internal;
using DataAccess.lib.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.lib.DataAccess.HR
{
    public class HRData
    {
        public EmployeeModel GetEmployeeById(int id)
        {
            SQLDataAccess sql = new SQLDataAccess();
            return sql.LoadData<EmployeeModel, dynamic>("dbo.spEmployeeLookUp", new { id = id }, "DefaultConnection").First();
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            SQLDataAccess sql = new SQLDataAccess();
            return sql.LoadData<EmployeeModel, dynamic>("dbo.spGetAllEmployees", new { }, "DefaultConnection");
        }
    }
}
