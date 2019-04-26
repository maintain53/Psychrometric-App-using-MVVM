using System;
using System.Windows.Input;

namespace ModifiedPsychrometricApp.ViewModels
{
    class ResetCommand : ICommand
    {
        PsychrometricViewModel psychrometricViewModel;
        public ResetCommand(PsychrometricViewModel _psychrometricViewModel)
        {
            psychrometricViewModel = _psychrometricViewModel;

        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            psychrometricViewModel.ResetPropertes();
        }
    }
}
