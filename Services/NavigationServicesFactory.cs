﻿using BetterNavigationServices.Core;
using BetterNavigationServices.MVVM.ViewModesl;
using BetterNavigationServices.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterNavigationServices.Services
{
    public class NavigationServicesFactory
    {
        private readonly AccountStore _accountStore;
        private readonly NavigationStore _navigationStore;

        public NavigationServicesFactory(AccountStore accountStore, NavigationStore navigationStore)
        {
            _accountStore = accountStore;
            _navigationStore = navigationStore;
        }

        public INavigationService CreateHomeNavigationService() => new NavigationServices<HomeViewModel>(_navigationStore, () => new HomeViewModel(this));
        public INavigationService CreateLoginNavigationService() => new NavigationServices<LoginViewModel>(_navigationStore, () => new LoginViewModel(this));
    }
}
