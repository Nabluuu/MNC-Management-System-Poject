using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManegerRepo : IRepo<Maneger> , IManagerFeature
    {
        MNCContext db;
        public ManegerRepo(MNCContext db)
        {
            this.db = db;
        }

       
        
        public bool Create(Maneger m)
        {
            db.Manegers.Add(m);
            return db.SaveChanges() > 0;
        }

        public List<Maneger> Get()
        {
            return db.Manegers.ToList();
        }

        public Maneger Get(int id)
        {
            return db.Manegers.Find(id);
        }

        public bool Update(Maneger m)
        {
            var ex = Get(m.MId);
            db.Entry(ex).CurrentValues.SetValues(m);
            return db.SaveChanges() > 0;
               
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Manegers.Remove(ex);
            return db.SaveChanges() > 0;
        }

        
        
        
        public List<Maneger> GetWithAllEmployee()
        {
            return db.Manegers.Include(m=>m.Employees).ToList();
        }
       
        public Maneger FindByName(string name)
        {
            var Man = (from m in db.Manegers
                       where m.ManName.Contains(name)
                       select m).SingleOrDefault();
            return Man;
        }

        public Maneger GetWithEmployeeId(int id)
        {
            var Man = (from m in db.Manegers.Include(mngr => mngr.Employees)
                       where m.MId == id
                       select m).SingleOrDefault();
            return Man;
        }

        public Maneger FindbyNameWithEmoployee(string name)
        {
            var Man = db.Manegers.Include(mngr => mngr.Employees)
                .SingleOrDefault(m => m.ManName.Contains(name));
            return Man;
        }
    }
}
