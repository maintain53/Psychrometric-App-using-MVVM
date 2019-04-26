using System;
using System.Windows.Input;

namespace ModifiedPsychrometricApp.ViewModels
{
    class CalculateCommand : ICommand

    {
        private PsychrometricViewModel psychrometricViewModel;

        public CalculateCommand(PsychrometricViewModel _psychrometricViewModel)
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
            psychrometricViewModel.CalculateProperties();


        }
    }
}
