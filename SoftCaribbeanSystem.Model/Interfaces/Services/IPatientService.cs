using SoftCaribbeanSystem.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaribbeanSystem.Model.Interfaces.Services
{
    public interface IPatientService
    {
        List<Patient> GetPatientsRegistered();
    }
}
