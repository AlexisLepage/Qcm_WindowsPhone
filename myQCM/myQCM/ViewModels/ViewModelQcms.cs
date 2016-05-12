﻿using MVVM.Interfaces;
using MVVM.Service;
using MVVM.ViewModels;
using myQCM.Models;
using myQCM.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myQCM.ViewModels
{
    public class ViewModelQcms : ViewModelList<Qcm>, IViewModelQcms
    {
        #region Fields

        private Category _Category;

        #endregion

        #region Properties

        /// <summary>
        /// Getter and Setter category
        /// </summary>
        public Category Category
        {
            get { return _Category; }
            set { SetProperty(nameof(Category), ref _Category, value); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Load data category
        /// </summary>
        public override void LoadData()
        {
            ObservableCollection<Qcm> qcms = new ObservableCollection<Qcm>();

            foreach (Qcm qcm in this.Category.Qcms)
            {
                qcms.Add(qcm);
            }

            this.ItemsSource = qcms;
        }

        /// <summary>
        /// Tracker property
        /// </summary>
        protected override void InitializePropertyTrackers()
        {
            base.InitializePropertyTrackers();

            this.AddPropertyTrackerAction(nameof(SelectedItem), (sender, args) =>
            {
                if (SelectedItem != null)
                {
                    ServiceResolver.GetService<INavigationService>().Navigate(new Uri("/Views/QuestionsPage.xaml", UriKind.Relative));
                }
            });
        }

        #region Navigation

        /// <summary>
        /// On navigated to
        /// </summary>
        /// <param name="viewModel"></param>
        public override void OnNavigatedTo(IViewModel viewModel)
        {
            base.OnNavigatedTo(viewModel);
        }

        /// <summary>
        /// On navigated from
        /// </summary>
        /// <param name="viewModel"></param>
        public override void OnNavigatedFrom(IViewModel viewModel)
        {
            base.OnNavigatedFrom(viewModel);

            if (viewModel is IViewModelQuestions)
            {
                ((IViewModelQuestions)viewModel).Qcm = this.SelectedItem;
                ((IViewModelQuestions)viewModel).LoadData();
                SelectedItem = null;
            }
        }


        #endregion

        #endregion
    }
}
