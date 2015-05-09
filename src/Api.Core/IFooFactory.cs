using Api.Domain;
using ApiProxy.Models;

namespace Api.Core
{
    public interface IFooFactory
    {
        Foo Create(ApiFoo apiFoo);
        ApiFoo Create(Foo foo);
    }
}