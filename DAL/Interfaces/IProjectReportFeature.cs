using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IProjectReportFeature
    {
        List<Project> GetProjectReports(int PId);
    }
}
