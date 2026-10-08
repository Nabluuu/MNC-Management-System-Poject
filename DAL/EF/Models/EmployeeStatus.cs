using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.EF.Models
{
    public enum EmployeeStatus
    {
        Active = 1,

        Inactive = 2,

        OnLeave = 3,

        Resigned = 4
    }
}
