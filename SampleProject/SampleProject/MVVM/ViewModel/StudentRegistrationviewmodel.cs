using SampleProject.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SampleProject.MVVM.ViewModel
{
    public class StudentRegistrationviewmodel
    {
        public ObservableCollection<Students> Registeredstudents { get; set; }

        public StudentRegistrationviewmodel()
        {
            Registeredstudents = new ObservableCollection<Students>
            {

                new Students { Name = "Alice", Age = 20 },
                new Students { Name = "Bob", Age = 22 },
                new Students { Name = "Charlie", Age = 19 }
             };
        }
    }
}
