using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Engine
    {
        private Hospital hospital;

        public Engine()
        {
            this.hospital = new Hospital();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] inputLine = command.Split();

                var department = inputLine[0];
                var firstName = inputLine[1];
                var lastName = inputLine[2];
                var patient = inputLine[3];

                var fullName = firstName +" " + lastName;

                this.hospital.AddDoctor(firstName, lastName);
                this.hospital.AddDepartment(department);
                this.hospital.AddPatient(fullName, department, patient);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (args.Length == 1)
                {
                    string departmentName = args[0];

                    Department department = this.hospital
                        .Departments
                        .FirstOrDefault(d => d.Name == departmentName);

                    Console.WriteLine(department);
                }

                else if (args.Length == 2)
                {
                    if (int.TryParse(args[1], out int targetRoom))
                    {
                        string departmentName = args[0];

                        Room room = this.hospital.Departments.FirstOrDefault(d => d.Name == departmentName).Rooms[targetRoom - 1];

                        Console.WriteLine(room);
                    }

                    else
                    {
                        string fullName = args[0] +" " + args[1];

                        Doctor doctor = this.hospital.Doctors.FirstOrDefault(d => d.FullName == fullName);

                        Console.WriteLine( doctor);
                    }
                }

                command = Console.ReadLine();
            }
        }

       
    }
}
