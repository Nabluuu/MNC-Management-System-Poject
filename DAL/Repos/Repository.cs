using DAL.EF;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;   

namespace DAL.Repos
{
        public class Repository<CLASS> : IRepo<CLASS> where CLASS : class
        {
            MNCContext db;
            DbSet<CLASS> table;
            public Repository(MNCContext db)
            {
                this.db = db;
                table = db.Set<CLASS>();
            }
            public bool Create(CLASS obj)
            {
                table.Add(obj);
                return db.SaveChanges() > 0;
            }
            public bool Delete(int id)
            {
                var existing = Get(id);
                if (existing == null) return false;
                table.Remove(existing);
                return db.SaveChanges() > 0;
            }
            public List<CLASS> Get()
            {
                return table.ToList();
            }
            public CLASS Get(int id)
            {
                return table.Find(id);
            }
            public bool Update(CLASS obj)
            {
                table.Update(obj);
                return db.SaveChanges() > 0;
            }


        }
    
}
