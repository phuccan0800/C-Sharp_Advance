using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    internal class Patients
    {
        string Department;
        string Doctor;
        string Patient;
        public Patients() { }

        public Patients(string department, string doctor, string patient)
        {
            Department = department;
            Doctor = doctor;
            Patient = patient;
        }
    }

}
