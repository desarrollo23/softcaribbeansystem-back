using SoftCaribbeanSystem.Model.Entities;
using SoftCaribbeanSystem.Model.Interfaces.Repositories;
using SoftCaribbeanSystem.Model.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaribbeanSystem.Service
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public List<Patient> GetPatientsRegistered()
        {
            return _patientRepository.FindAll().ToList();
        }
    }
}
