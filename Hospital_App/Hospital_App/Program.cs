using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_App
{
    class Authority
    {
        public string AuthorityId;
        public string Name;
        public Authority(string I, string N)
        {
            AuthorityId = I;
            Name = N;
        }
        public void CalculateDrMonthlysalary(Doctor ob, Patient ob1)
        {
            if (ob.NoPatient >= 15)
            {
                double M = (ob1.AppointmentFee * 50) / 100;
                double T = M * 30;
                Console.WriteLine("{0} monthly salary: {1}/=", ob.Name, T);
            }
            else
            {
                double M = (ob1.AppointmentFee * 30) / 100;
                double T = M * 30;
                Console.WriteLine("{0} monthly salary: {1}/=", ob.Name, T);
            }
        }
    }
    class Doctor
    {
        public string DoctorId;
        public string Name;
        public string Experience;
        public string RoomNo;
        public int NoPatient;
        public Doctor(string I, string N, string E, string R, int NP)
        {
            DoctorId = I;
            Name = N;
            Experience = E;
            RoomNo = R;
            NoPatient = NP;
        }
    }
    class Patient
    {
        public string PatientId;
        public string Name;
        public int Age;
        public string Dr_Name;
        public double AppointmentFee;
        public Patient(string I, string N, int A, string DN, double F)
        {
            PatientId = I;
            Name = N;
            Age = A;
            Dr_Name = DN;
            AppointmentFee = F;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Authority ob = new Authority("196", "Raza");

            Doctor ob1 = new Doctor("652", "Mr. Alam", "15years", "502", 15);

            Patient ob2 = new Patient("151", "Mr. Ali", 45, "Mr.Alam", 1000);

            ob.CalculateDrMonthlysalary(ob1, ob2);

            Console.ReadLine();
        }
    }
}
