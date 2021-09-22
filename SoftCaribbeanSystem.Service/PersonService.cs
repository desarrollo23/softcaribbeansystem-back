using SoftCaribbeanSystem.Model.Entities;
using SoftCaribbeanSystem.Model.Interfaces.Repositories;
using SoftCaribbeanSystem.Model.Interfaces.Services;

namespace SoftCaribbeanSystem.Service
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void CreatePerson(Person request)
        {
            _personRepository.Add(request);
        }

        public void UpdatePerson(Person request)
        {
            _personRepository.Update(request);
        }
    }
}
