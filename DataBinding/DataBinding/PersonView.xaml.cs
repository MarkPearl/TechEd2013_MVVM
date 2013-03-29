﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : Window
    {
        public PersonView()
        {
            InitializeComponent();

            var personVM = new PersonViewModel
                {
                    PersonID = "123",
                    FirstName = "Mark"
                };

            DataContext = personVM;
        }


    }
}
