﻿using MVVM.Interfaces;
using myQCM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myQCM.ViewModels.Interfaces
{
    public interface IViewModelQuestion : IViewModelItem<Question>
    {
        IViewModelAnswers ViewModelAnswers { get; }
    }
}
