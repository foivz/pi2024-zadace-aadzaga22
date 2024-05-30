﻿using EcoRecycle_Manager.Models;
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
    public partial class FrmTransactions : Form
    {
        public FrmTransactions()
        {
            InitializeComponent();
        }

        private void FrmTransactions_Load(object sender, EventArgs e)
        {
            ShowTransactions();
        }
        private void ShowTransactions()
        {
            List<Transaction> transactions = TransactionRepository.GetTransactions();
            dgvTransactions.DataSource = transactions;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Prazna metoda referencira se na search bar
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            List<Transaction> transactions = TransactionRepository.SearchTransactions(searchTerm);
            dgvTransactions.DataSource = transactions;
        }


    }
}
