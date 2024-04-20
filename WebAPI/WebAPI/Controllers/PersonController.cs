using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;
using WebAPI.Models.VM;

namespace WebAPI.Controllers
{

    [EnableCors("http://localhost", "*", "*")]
    public class PersonController : ApiController
    {
        [Route("api/person/names")]
        [HttpGet]
        public List<string> PrNames()
        {
            var data = (from pr in new Sp24_CF_AEntities().People
                        select pr.Name).ToList();
            return data;
        }
        [Route("api/person/create")]
        [HttpPost]
        public string Post(Person p)
        {
            var db = new Sp24_CF_AEntities();
            db.People.Add(p);
            db.SaveChanges();
            return "added";

        }
        public List<PersonModel> Get()
        {
            Sp24_CF_AEntities db = new Sp24_CF_AEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<PersonModel>>(db.People.ToList());









            /* var data = new List<PersonModel>();
            foreach (var item in db.People)
            {
                var person = new PersonModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    DOB = item.DOB
                };
                data.Add(person);
            }*/
            return data;

        }
        public PersonModel Get(int id)
        {
            var data = new PersonModel();
            Sp24_CF_AEntities db = new Sp24_CF_AEntities();
            var e = db.People.FirstOrDefault(d => d.Id == id);
            var pr = new PersonModel()
            {
                Id = e.Id,
                Name = e.Name,
                DOB = e.DOB
            };
            return pr;
        }
    }
}
