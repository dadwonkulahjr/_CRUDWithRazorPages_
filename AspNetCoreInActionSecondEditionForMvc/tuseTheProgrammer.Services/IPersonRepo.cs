using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Services
{
    public interface IPersonRepo
    {
        IEnumerable<tblPerson> GetAllPersons();
        tblPerson DeletePerson(int id);
        tblPerson GetPersonById(int id);
        tblPerson UpdatePerson(tblPerson personChanges);
        tblPerson AddNewPerson(tblPerson tblPerson);
    }
}
