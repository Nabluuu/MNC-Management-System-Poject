using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IManagerFeature
    {
        List<Maneger> GetWithAllEmployee();

        Maneger GetWithEmployeeId(int id);

        Maneger FindByName(string name);

       Maneger FindbyNameWithEmoployee (string name);

    }
}
