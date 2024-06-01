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
        private Transaction transactionToUpdate;

        public FrmAddTransaction()
        {
            InitializeComponent();
        }

        public FrmAddTransaction(Transaction transaction)
        {
            InitializeComponent();
            transactionToUpdate = transaction;
        }

        private void FrmAddTransaction_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            if (transactionToUpdate != null)
            {
                LoadTransactionData();
            }
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
        private void LoadTransactionData()
        {
            dtpDateTime.Value = transactionToUpdate.DateTime;
            cbCustomer.SelectedValue = transactionToUpdate.CustomerID;
            cbCenter.SelectedValue = transactionToUpdate.CenterID;
            cbEmployee.SelectedValue = transactionToUpdate.EmployeeID;
            cbWasteType.SelectedValue = transactionToUpdate.WasteTypeID;
            txtQuantity.Text = transactionToUpdate.Quantity.ToString();
            txtUnit.Text = transactionToUpdate.Unit;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (transactionToUpdate == null)
            {
                Transaction newTransaction = new Transaction
                {
                    DateTime = dtpDateTime.Value,
                    CustomerID = (int)cbCustomer.SelectedValue,
                    CenterID = (int)cbCenter.SelectedValue,
                    EmployeeID = (int)cbEmployee.SelectedValue,
                    WasteTypeID = (int)cbWasteType.SelectedValue,
                    Quantity = decimal.Parse(txtQuantity.Text),
                    Unit = txtUnit.Text
                };

                TransactionRepository.AddTransaction(newTransaction);
            }
            else
            {
                transactionToUpdate.DateTime = dtpDateTime.Value;
                transactionToUpdate.CustomerID = (int)cbCustomer.SelectedValue;
                transactionToUpdate.CenterID = (int)cbCenter.SelectedValue;
                transactionToUpdate.EmployeeID = (int)cbEmployee.SelectedValue;
                transactionToUpdate.WasteTypeID = (int)cbWasteType.SelectedValue;
                transactionToUpdate.Quantity = decimal.Parse(txtQuantity.Text);
                transactionToUpdate.Unit = txtUnit.Text;

                TransactionRepository.UpdateTransaction(transactionToUpdate);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
