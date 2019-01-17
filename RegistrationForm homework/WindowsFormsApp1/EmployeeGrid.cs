using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Enums;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class EmployeeGrid : Form
    {
        List<Employee> _employeeList = new List<Employee>();

        public EmployeeGrid()
        {
            InitializeComponent();
        }

        internal EmployeeGrid(Employee employee)
        {
            InitializeComponent();
            _employeeList.Add(employee);
            SetDataIntoGrid(_employeeList);
        }

        private DataTable GenerateTable(List<Employee> employeeList)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Surname", typeof(string));
            dataTable.Columns.Add("Birthday", typeof(string));
            dataTable.Columns.Add("SSN", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Country", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("Street", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(string));
            dataTable.Columns.Add("Full Address", typeof(string));

            foreach (var employee in employeeList)
            {
                dataTable.Rows.Add(
                employee.CommonInfo.Name,
                employee.CommonInfo.Surname,
                employee.CommonInfo.Birthday,
                employee.CommonInfo.Ssn,
                employee.CommonInfo.Gender,
                employee.ContactInfo.Email,
                employee.ContactInfo.Phone,
                employee.AddressInfo.Country,
                employee.AddressInfo.City,
                employee.AddressInfo.Street,
                employee.AddressInfo.ZipCode,
                employee.AddressInfo.FullAddress
                );
            }

            return dataTable;
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            //TODO: Implement Save functionality 

            try
            {
                var employeeList = new List<Employee>();

                var employee = new Employee
                {
                    CommonInfo = new CommonInfo
                    {
                        Name = dgwEmployee.Rows[0].Cells[0].Value.ToString(),
                        Surname = dgwEmployee.Rows[0].Cells[1].Value.ToString(),
                        Birthday = DateTime.Parse(dgwEmployee.Rows[0].Cells[2].Value.ToString()),
                        Ssn = dgwEmployee.Rows[0].Cells[3].Value.ToString(),
                        Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), dgwEmployee.Rows[0].Cells[4].Value.ToString(), true)

                    },
                    ContactInfo = new ContactInfo
                    {
                        Email = dgwEmployee.Rows[0].Cells[5].Value.ToString(),
                        Phone = dgwEmployee.Rows[0].Cells[6].Value.ToString()
                    },
                    AddressInfo = new AddressInfo
                    {
                        Country = (CountryEnum)Enum.Parse(typeof(CountryEnum), dgwEmployee.Rows[0].Cells[7].Value.ToString(), true),
                        City = dgwEmployee.Rows[0].Cells[8].Value.ToString(),
                        Street = dgwEmployee.Rows[0].Cells[9].Value.ToString(),
                        ZipCode = dgwEmployee.Rows[0].Cells[10].Value.ToString(),

                    }
                };

                var country = employee.AddressInfo.Country.ToString();
                var city = employee.AddressInfo.City.ToString();
                var street = employee.AddressInfo.Street.ToString();
                var zipcode = " Zip Code: " + employee.AddressInfo.ZipCode.ToString();

                employee.AddressInfo.FullAddress = country + " " + city + " " + street + zipcode;

               

                if (employee.IsValid())
                {
                    employeeList.Add(employee);

                    var message = DataBase.SaveEmployeeDataToDataBase(employeeList);

                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Please enter valid Employee information!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
                


        }

        private void btnGetFromDatabase_Click(object sender, EventArgs e)
        {
            var employee = DataBase.GetDataFromDatabase();
            SetDataIntoGrid(employee);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                MessageBox.Show("Please enter search criteria");
            }
            else
            {
                //TODO: Implement Search functionality 

                string searchName = txtSearchName.Text;

                var employee = DataBase.FindEmployee(searchName);
                SetDataIntoGrid(employee);
            }
        }

        private void SetDataIntoGrid(List<Employee> employeeList)
        {
            dgwEmployee.DataSource = null;
            dgwEmployee.Refresh();
            dgwEmployee.DataSource = GenerateTable(employeeList);
        }
    }
}
