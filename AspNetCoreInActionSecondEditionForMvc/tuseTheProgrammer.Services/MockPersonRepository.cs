using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Services
{
    public class MockPersonRepository : IPersonRepo
    {
        private List<tblPerson> _listOfPersons;
        public MockPersonRepository()
        {
            _listOfPersons = new List<tblPerson>()
            {
                new tblPerson()
                {
                    PersonId = 1,
                    Name = "Mike Simson",
                    Email = "m@m.com",
                    Age = 28,
                    Gender = new tblGender(){Name = "Male"},
                    City = new tblCity(){Name="New Georgia Estate"},
                    Department = new tblDepartment(){Name="Information Technology"}
                },

                new tblPerson()
                {
                    PersonId = 2,
                    Name = "Peter Robert",
                    Email = "p@p.com",
                    Age = 40,
                    Gender = new tblGender(){Name = "Male"},
                    City = new tblCity(){Name="Stephen Tolbert"},
                    Department = new tblDepartment(){Name="Information Technology"}
                },

                new tblPerson()
                {
                    PersonId = 3,
                    Name = "Mary Smith",
                    Email = "m@m.com",
                    Age = 30,
                    Gender = new tblGender(){Name = "Female"},
                    City = new tblCity(){Name="Old Road"},
                    Department = new tblDepartment(){Name="Human Resource"}
                },

                new tblPerson()
                {
                    PersonId = 4,
                    Name = "Sara Collins",
                    Email = "s@s.com",
                    Age = 25,
                    Gender = new tblGender(){Name = "Female"},
                    City = new tblCity(){Name="Bardnesville Estate"},
                    Department = new tblDepartment(){Name="Payroll"}
                }
            };
        }

        public tblPerson AddNewPerson(tblPerson tblPerson)
        {
            tblPerson.PersonId = _listOfPersons.Max(p => p.PersonId) + 1;
            if (tblPerson != null)
            {
                _listOfPersons.Add(tblPerson);
            }

            return tblPerson;
        }

        public tblPerson DeletePerson(int id)
        {
            tblPerson tblPerson = _listOfPersons.FirstOrDefault(p => p.PersonId == id);
            if(tblPerson != null)
            {
                _listOfPersons.Remove(tblPerson);
            }
            return tblPerson;
        }

        public IEnumerable<tblPerson> GetAllPersons()
        {
            return _listOfPersons.ToList();
        }

        public tblPerson GetPersonById(int id)
        {
            return _listOfPersons.FirstOrDefault(p => p.PersonId == id);
        }

        public tblPerson UpdatePerson(tblPerson personChanges)
        {
            var personFound = _listOfPersons.FirstOrDefault(p => p.PersonId == personChanges.PersonId);
            if (personFound != null)
            {
                personFound.Name = personChanges.Name;
                personFound.Email = personChanges.Email;
                personFound.Age = personChanges.Age;
                personFound.Department.Name = personChanges.Department.Name;
                personFound.Gender.Name = personChanges.Gender.Name;
                personFound.City.Name = personChanges.City.Name;
            }

            return personFound;
        }
    }
}
