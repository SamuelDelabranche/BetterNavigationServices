﻿using BetterNavigationServices.Core;
using BetterNavigationServices.Services;
using BetterNavigationServices.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterNavigationServices.MVVM.ViewModesl
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly NavigationServicesFactory _navigationServicesFactory;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViiewModel;

        public MainViewModel(NavigationStore navigationStore, NavigationServicesFactory navigationServicesFactory)
        {
            _navigationServicesFactory = navigationServicesFactory;
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
