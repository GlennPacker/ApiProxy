using Api.Core;
using Api.Domain;
using ApiProxy.Models;

namespace Api.Services
{
    public class FooFactory : IFooFactory
    {
        public Foo Create(ApiFoo apiFoo)
        {
            var result = new Foo
            {
                Description = apiFoo.Description,
                Name = apiFoo.Name,
                Id = apiFoo.Id
            };
            return result;
        }

        public ApiFoo Create(Foo foo)
        {
            var result = new ApiFoo
            {
                Description = foo.Description,
                Name = foo.Name,
                Id = foo.Id
            };
            return result;
        }

    }
}
