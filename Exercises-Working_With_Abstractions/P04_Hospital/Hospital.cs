using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Hospital
    {
        public Hospital()
        {
            this.Doctors = new List<Doctor>();
            this.Departments = new List<Department>();
        }

        public List<Doctor> Doctors { get; set; }

        public List<Department> Departments { get; set; }

        public void AddDoctor(string firstName, string lastName)
        {
            if (! this.Doctors.Any(d => d.FirstName == firstName && d.LastName == lastName))
            {
                Doctor doctor = new Doctor(firstName, lastName);

                this.Doctors.Add(doctor);
            }
        }

        public void AddDepartment(string departmentName)
        {
            if (! this.Departments.Any(d=> d.Name == departmentName))
            {
                var department = new Department(departmentName);
                this.Departments.Add(department);
            }
        }

        public void AddPatient(string doctorName, string departmentName, string patientName)
        {
            var doctor = this.Doctors.FirstOrDefault(d => d.FullName == doctorName);
            var department = this.Departments.FirstOrDefault(x => x.Name == departmentName);

            var patient = new Patient(patientName);
            doctor.Patients.Add(patient);

            department.AddPatientInRoon(patient);
        }
    }
}
