using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.EmployeeManagement.UI.Data;
using WPF.EmployeeManagement.UI.Model;

namespace WPF.EmployeeManagement.UI.ViewModel
{
    public class NavigationViewModel : INotifyPropertyChanged, INavigationViewModel
    {
        private readonly IEmployeeDataService _employeeDataService;

        public ObservableCollection<Employee> Employees { get; private set; }

        public NavigationViewModel(IEmployeeDataService employeeDataService)
        {
            _employeeDataService = employeeDataService;
            Employees = new ObservableCollection<Employee>();
        }

        public async Task LoadEmployees()
        {
            var employees = await _employeeDataService.GetEmployees();
            Employees.Clear();
            foreach (var employee in employees)
            {
                Employees.Add(employee);
            }
        }

        private Employee _selectedEmployee;

        public event PropertyChangedEventHandler PropertyChanged;

        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                WhenPropertyChanged(nameof(SelectedEmployee));

            }
        }

        private void WhenPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
