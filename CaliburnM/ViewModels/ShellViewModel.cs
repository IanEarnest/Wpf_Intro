using Caliburn.Micro;
using CaliburnM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnM.ViewModels
{
    // App.xaml.cs = notes

    // Class Person - properties (FirstName, LastName)
    // ViewsModes = FirstChildViewModel, SecondChildViewModel inherit Screen
    // User Controls = FirstChildView, SecondChildView - (change background colour to see them)

    // Ctor - People.Add - Creates a list of People to populate ComboBox
    // (AddPeopleToList(), NewPerson()) - Both used by Ctor
    // LoadPageOne(), LoadPageTwo() - Loads views into a container on the page using ActivateItem
    // CanClearText() - auto makes button disabled? how?
    // ClearText() - Clears text from UI, uses properties to clear all locations of FirstName, LastName

    // FirstName, LastName, FullName properties - uses NotifyOfPropertyChange()
    // PersonModel SelectedPerson - used for ComboBox - displays selected into TextBlock, uses NotifyOfPropertyChange()
    // BindableCollection<PersonModel> People



    // Screen //Is just this screen
    // Conductor<object> //One child (inherit)
    public class ShellViewModel : Conductor<object>
    {
        private string _firstName = "Steve";
        private string _lastName = "Steve";
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _SelectedPerson;

        public ShellViewModel()
        {
            AddPeopleToList(); // Add 3 people to list
        }
        private void AddPeopleToList()
        {
            PersonModel person1 = newPerson("Steve1", "Smith1");
            PersonModel person2 = newPerson("Steve2", "Smith2");
            PersonModel person3 = newPerson("Steve3", "Smith3");
            //People.Add(new PersonModel { FirstName = "Steve", LastName = "Smith"});
            People.Add(person1);
            People.Add(person2);
            People.Add(person3);
        }
        private PersonModel newPerson(string firstName, string lastName)
        {
            return new PersonModel { FirstName = firstName, LastName = lastName };
        }

        public bool CanClearText(string firstName, string lastName)
        {
            //!String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName)
            // If both empty, CanClear is false
            // If one has something, CanClear is true
            if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }

        public void LoadPageOne()
        {
            ActivateItem(new FirstChildViewModel());
        }
        public void LoadPageTwo()
        {
            ActivateItem(new SecondChildViewModel());
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }


        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }


        public PersonModel SelectedPerson
        {
            get { return _SelectedPerson; }
            set 
            { 
                _SelectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }
    }
}
