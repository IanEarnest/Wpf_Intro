using Caliburn.Micro;
using MyLib1;
using MyLib1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnM.ViewModels
{
    public class FirstChildViewModel : Screen
    {
        public BindableCollection<PersonModel> People
        {
            get;
            set;
        }


        public FirstChildViewModel()
        {
            DataAccess da = new DataAccess();
            People = new BindableCollection<PersonModel>(da.GetPeople());
        }

        public void AddPerson()
        {
            DataAccess da = new DataAccess();
            int maxId = 0;

            if (People.Count > 0)
            {
                maxId = People.Max(x => x.PersonId);
            }
            People.Add(da.GetPerson(maxId + 1));
        }

        public void RemovePerson()
        {
            DataAccess da = new DataAccess();
            int maxId = 0;

            if (People.Count == 0)
            {
                return;
            }

            maxId = People.Max(x => x.PersonId);
            People.RemoveAt(People.Count-1); // Remove last 
            Debug.WriteLine($"ID A: {maxId} - removed");
        }
    }
}
