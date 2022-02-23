﻿using System.Windows;
using Prism.Ioc;
using fwv.Views;
using fwv.ViewModels;

namespace fwv
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry reg)
        {
            reg.RegisterForNavigation<Checkout>();
            reg.RegisterForNavigation<RepositoryList>();
            reg.RegisterDialog<NewRepositoryDialog, NewRepositoryDialogViewModel>();
        }
    }
}