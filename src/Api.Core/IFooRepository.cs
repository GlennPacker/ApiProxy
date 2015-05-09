using System.Linq;
using Api.Domain;

namespace Api.Core
{
    public interface IFooRepository
    {
        Foo Find(int id);
        IQueryable<Foo> List();
        bool Add(Foo item);
        bool Update(Foo item);
        bool Delete(int id);
        bool Delete(Foo item);
        bool Save();
        void Dispose();
    }
}