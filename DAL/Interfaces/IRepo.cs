using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS> where CLASS: class
    {
        bool Create(CLASS obj);
        List<CLASS> Get();
        CLASS Get(int id);
        bool Update(CLASS obj);
        bool Delete(int id);
        
    }
}
