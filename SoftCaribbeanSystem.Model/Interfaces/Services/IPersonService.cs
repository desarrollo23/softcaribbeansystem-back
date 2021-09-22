using SoftCaribbeanSystem.Model.Entities;

namespace SoftCaribbeanSystem.Model.Interfaces.Services
{
    public interface IPersonService
    {
        void CreatePerson(Person request);
        void UpdatePerson(Person request);
    }
}
