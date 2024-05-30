using EcoRecycle_Manager.Models;
using EcoRecycle_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoRecycle_Manager
{
    public partial class FrmAddTransaction : Form
    {
        public FrmAddTransaction()
        {
            InitializeComponent();
        }

        private void FrmAddTransaction_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            var customers = CustomerRepository.GetCustomers();
            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "FullName"; 
            cbCustomer.ValueMember = "CustomerID";

            var centers = RecyclingCenterRepository.GetRecyclingCenters();
            cbCenter.DataSource = centers;
            cbCenter.DisplayMember = "Name";
            cbCenter.ValueMember = "CenterID";

            var employees = EmployeeRepository.GetEmployees();
            cbEmployee.DataSource = employees;
            cbEmployee.DisplayMember = "FullName"; 
            cbEmployee.ValueMember = "EmployeeID";

            var wasteTypes = WasteTypeRepository.GetWasteTypes();
            cbWasteType.DataSource = wasteTypes;
            cbWasteType.DisplayMember = "Name";
            cbWasteType.ValueMember = "WasteTypeID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction
            {
                DateTime = dtpDateTime.Value,
                CustomerID = (int)cbCustomer.SelectedValue,
                CenterID = (int)cbCenter.SelectedValue,
                EmployeeID = (int)cbEmployee.SelectedValue,
                WasteTypeID = (int)cbWasteType.SelectedValue,
                Quantity = decimal.Parse(txtQuantity.Text),
                Unit = txtUnit.Text
            };

            TransactionRepository.AddTransaction(transaction);
            this.Close();
        }
    }
}
