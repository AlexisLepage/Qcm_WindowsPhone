﻿using MVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myQCM.Models
{
    public class Qcm : ObservableObject
    {

        #region Fields

        private int _IdServer;

        private string _Name;

        private DateTime _BeginningAt;

        private DateTime _FinishedAt;

        private int _Duration;

        private DateTime _CreatedAt;

        private DateTime _UpdatedAt;

        private Category _Category;

        #endregion

        #region Properties

        /// <summary>
        /// IdServer Qcm.
        /// Getter and Setter for IdServer.
        /// </summary>
        public int IdServer
        {
            get { return _IdServer; }
            set { SetProperty(nameof(IdServer), ref _IdServer, value); }
        }

        /// <summary>
        /// Name Qcm.
        /// Getter and Setter for Name.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { SetProperty(nameof(Name), ref _Name, value); }
        }

        /// <summary>
        /// BeginningAt Qcm.
        /// Getter and Setter for BeginningAt.
        /// </summary>
        public DateTime BeginningAt
        {
            get { return _BeginningAt; }
            set { SetProperty(nameof(BeginningAt), ref _BeginningAt, value); }
        }

        /// <summary>
        /// FinishedAt Qcm.
        /// Getter and Setter for FinishedAt.
        /// </summary>
        public DateTime FinishedAt
        {
            get { return _FinishedAt; }
            set { SetProperty(nameof(FinishedAt), ref _FinishedAt, value); }
        }

        /// <summary>
        /// IdServer Qcm.
        /// Getter and Setter for IdServer.
        /// </summary>
        public int Duration
        {
            get { return _Duration; }
            set { SetProperty(nameof(Duration), ref _Duration, value); }
        }

        /// <summary>
        /// CreatedAt Qcm.
        /// Getter and Setter for CreatedAt.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return _CreatedAt; }
            set { SetProperty(nameof(CreatedAt), ref _CreatedAt, value); }
        }

        /// <summary>
        /// UpdatedAt Qcm.
        /// Getter and Setter for UpdatedAt.
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return _UpdatedAt; }
            set { SetProperty(nameof(UpdatedAt), ref _UpdatedAt, value); }
        }

        /// <summary>
        /// Category Qcm.
        /// Getter and Setter for Category.
        /// </summary>
        public Category Category
        {
            get { return _Category; }
            set { SetProperty(nameof(Category), ref _Category, value); }
        }

        #endregion

        #region Constructors

        public Qcm(int id_server, string name, DateTime beginning_at, DateTime finished_at, int duration, DateTime created_at, DateTime updated_at, Category category)
        {
            IdServer = id_server;
            Name = name;
            BeginningAt = beginning_at;
            FinishedAt = finished_at;
            Duration = duration;
            CreatedAt = created_at;
            UpdatedAt = updated_at;
            Category = category;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}