using System.Windows.Controls;

namespace ModifiedPsychrometricApp.Views
{
    /// <summary>
    /// Interaction logic for psychrometricProperties.xaml
    /// </summary>
    public partial class psychrometricProperties : UserControl
    {
        public psychrometricProperties()
        {
            InitializeComponent();
            DataContext = new ViewModels.PsychrometricViewModel();

           
        }
    }
}
