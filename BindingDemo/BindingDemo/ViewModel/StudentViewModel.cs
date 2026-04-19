using BindingDemo.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BindingDemo.ViewModel
{
    public partial class StudentViewModel : ObservableObject
    {
        private Student? _student;

        private string? _firstName;

        public string FirstName
        {
            get => _student.FirstName
        }
    }
}
