﻿using System;
using System.Collections.Generic;
using System.Text;

using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace fwv.ViewModels
{
    public class HistoryDialogViewModel : BindableBase, IDialogAware
    {
        public string Title => "History";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}
