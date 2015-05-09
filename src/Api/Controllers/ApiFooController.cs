using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api.Core;
using ApiProxy.Models;

namespace Api.Controllers
{
    public class ApiFooController : ApiController
    {
        private readonly IFooRepository _fooRepo;
        private readonly IFooFactory _fooFactory;

        public ApiFooController(IFooRepository fooRepo, IFooFactory fooFactory)
        {
            _fooRepo = fooRepo;
            _fooFactory = fooFactory;
        }

        public HttpResponseMessage GetFoo(int id)
        {
            var foo = _fooRepo.Find(id);

            if (foo == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Foo not found");
            }
            return Request.CreateResponse(HttpStatusCode.OK, _fooFactory.Create(foo));
        }

        public HttpResponseMessage PostAppointment(ApiFoo apiFoo)
        {
            var data = _fooFactory.Create(apiFoo);
            if (!_fooRepo.Add(data))
                return Request.CreateResponse(HttpStatusCode.BadRequest, apiFoo);

            return Request.CreateResponse(HttpStatusCode.OK, _fooFactory.Create(data));
        }

        // carry on for delete and put
        // ..
        // ..
    }
}
