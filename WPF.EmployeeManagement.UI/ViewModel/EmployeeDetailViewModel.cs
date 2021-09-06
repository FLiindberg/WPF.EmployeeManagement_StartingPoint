using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.EmployeeManagement.UI.Data;
using WPF.EmployeeManagement.UI.Model;

namespace WPF.EmployeeManagement.UI.ViewModel
{
    public class EmployeeDetailViewModel : INotifyPropertyChanged, IEmployeeDetailViewModel
    {
        private readonly IEmployeeDataService _employeeDataService;

        public EmployeeDetailViewModel(IEmployeeDataService employeeDataService)
        {
            _employeeDataService = employeeDataService;
        }

        public async Task LoadEmployeeById(int employeeId)
        {
            Employee = await _employeeDataService.GetEmployeeById(employeeId);

        }

        private Employee _employee;

        public event PropertyChangedEventHandler PropertyChanged;

        public Employee Employee
        {
            get { return _employee; }
            set
            {
                _employee = value;
                WhenPropertyChanged(nameof(Employee));
            }
        }

        private void WhenPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
