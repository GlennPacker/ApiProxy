using System;
using System.Data;
using System.Linq;
using Api.Core;
using Api.Domain;

namespace Api.Infrastructure
{
    public class FooRepository : IFooRepository
    {
        private readonly DatabaseContext _db;

        public FooRepository(DatabaseContext db)
        {
            _db = db;
        }


        public Foo Find(int id)
        {
            var data = _db.Foos.Find(id);
            return data;
        }

        public IQueryable<Foo> List()
        {
            var data = _db.Foos;
            return data;
        }

        public bool Add(Foo item)
        {
            try
            {
                _db.Foos.Add(item);
                return Save();
            }
            catch (Exception ex)
            {
                // Logger goes here

                return false;
            }
        }

        public bool Update(Foo item)
        {
            try
            {
                _db.Entry(item).State = EntityState.Modified;
                return Save();
            }
            catch (Exception ex)
            {
                // Loger goes here

                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = Find(id);
                if (data == null) return true;  // not found nothing to delete so in essense the object is deleted already
                return Delete(data);
            }
            catch (Exception ex)
            {
                // Logger goes here
                return false;
            }
        }

        public bool Delete(Foo item)
        {
            try
            {
                _db.Foos.Remove(item);
                return Save();
            }
            catch (Exception ex)
            {
                // logger

                return false;
            }
        }

        public bool Save()
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                // logger


                return false;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
