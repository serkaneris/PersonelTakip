﻿using PersonelTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PersonelTakip
{
    /// <summary>
    /// Interaction logic for SetEmployeesRol.xaml
    /// </summary>
    public partial class SetEmployeesRol : Window
    {
        public SetEmployeesRol()
        {
            InitializeComponent();
            LoadEmployeesGrid();
        }

        private void LoadEmployeesGrid()
        {
            dgEmployees.ItemsSource = null;
            dgEmployees.ItemsSource = Employee.Select();
        }

        private void DgEmployees_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Employee employee = (Employee)dgEmployees.SelectedItem;

            txtId.Text = employee.Id.ToString();
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
        }
    }
}
