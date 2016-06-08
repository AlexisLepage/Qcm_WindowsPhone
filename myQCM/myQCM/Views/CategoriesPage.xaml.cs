﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MVVM.Views;

namespace myQCM.Views
{
    public partial class CategoriesPage : MVVMPhonePage
    {
        public CategoriesPage()
        {
            InitializeComponent();
            this.ViewModel = new ViewModels.ViewModelCategories();
        }

        protected override void OnBackKeyPress(CancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}