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
    public partial class QuestionsPage : MVVMPhonePage
    {
        public QuestionsPage()
        {
            InitializeComponent();
            this.ViewModel = new ViewModels.ViewModelQuestions();
        }
    }
}