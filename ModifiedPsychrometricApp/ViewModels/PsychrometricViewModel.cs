 using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Windows.Input;
using ModifiedPsychrometricApp.Models;

namespace ModifiedPsychrometricApp.ViewModels
{
    class PsychrometricViewModel : INotifyPropertyChanged
    {
        public CalculateCommand CalculateCommand;
        public ResetCommand resetCommand;
        public event PropertyChangedEventHandler PropertyChanged;
        ObservableCollection<String> _comboProperties;
        ObservableCollection<PsychrometricViewModel> dataGridDetails;
        private Visibility _wetBulbVisibility = Visibility.Visible;
        private Visibility _dewPointVisibility = Visibility.Collapsed;
        private Visibility _relHumidityVisibility = Visibility.Collapsed;
        private Visibility _wetBulbVisibility2 = Visibility.Visible;
        private Visibility _dewPointVisibility2 = Visibility.Collapsed;
        private Visibility _relHumidityVisibility2= Visibility.Collapsed;
        private int _selectedIndex;
        private string _dryBulb;
        private string _wetBulb;
        private string _relHumdity;
        private string _dewPoint;
        private string _enthalpy;
        private string _volume;
        private string _satPressure;
        private string _partialPressure;
        private string _humidityRatio;
        private string _density;

        public PsychrometricViewModel()
        {
            PopulateComboBox();
            CalculateCommand = new CalculateCommand(this);
            resetCommand = new ResetCommand(this);

        }

        public string DryBulb
        {
            get
            {
                return _dryBulb;
            }

            set
            {
                _dryBulb = value;
                RaisePropertyChanged("DryBulb");
            }
        }

        public string WetBulb
        {
            get
            {
                return _wetBulb;
            }

            set
            {
                _wetBulb = value;

                RaisePropertyChanged("WetBulb");
            }
        }

        public string RelHumidity
        {
            get
            {
                return _relHumdity;
            }

            set
            {
                _relHumdity = value;
                RaisePropertyChanged("RelHumidity");
            }
        }

        public string DewPoint
        {
            get
            {
                return _dewPoint;
            }

            set
            {
                _dewPoint = value;
                RaisePropertyChanged("DewPoint");
            }
        }

        public string Enthalpy
        {
            get
            {
                return _enthalpy;
            }

            set
            {
                _enthalpy = value;
                RaisePropertyChanged("Enthalpy");
            }
        }

        public string Volume
        {
            get
            {
                return _volume;
            }

            set
            {
                _volume = value;
                RaisePropertyChanged("Volume");
            }
        }

        public string SatPressure
        {
            get
            {
                return _satPressure;
            }

            set
            {
                _satPressure = value;
                RaisePropertyChanged("SatPressure");
            }
        }

        public string PartialPressure
        {
            get
            {
                return _partialPressure;
            }

            set
            {
                _partialPressure = value;
                RaisePropertyChanged("PartialPressure");
            }
        }
        public string HumidityRatio
        {
            get
            {
                return _humidityRatio;
            }

            set
            {
                _humidityRatio = value;
                RaisePropertyChanged("HumidityRatio");
            }
        }

        public string Density
        {
            get
            {
                return _density;
            }

            set
            {
                _density = value;
                RaisePropertyChanged("Density");
            }
        }


        public ICommand CalculateBtn
        {
            get
            {
                return CalculateCommand;
            }
        }

        public ICommand ResetBtn
        {
            get
            {
                return resetCommand;
            }

        }

        public ObservableCollection<string> ComboProperties
        {
            get
            {
                return _comboProperties;
            }

            set
            {
                _comboProperties = value;
                RaisePropertyChanged("ComboProperties");
            }
        }

        public ObservableCollection<PsychrometricViewModel> DataGridDetails
        {
            get
            {
                return dataGridDetails;
            }

            set
            {
                dataGridDetails = value;
                RaisePropertyChanged("DataGridDetails");
            }
        }

        public Visibility WetBulbVisibility
        {
            get
            {
                return _wetBulbVisibility;
            }

            set
            {
                _wetBulbVisibility = value;
                RaisePropertyChanged("WetBulbVisibility");
            }
        }

        public Visibility DewPointVisibility
        {
            get
            {
                return _dewPointVisibility;
            }

            set
            {
                _dewPointVisibility = value; RaisePropertyChanged("DewPointVisibility");
            }
        }

        public Visibility RelHumidityVisibility
        {
            get
            {
                return _relHumidityVisibility;
            }

            set
            {

                _relHumidityVisibility = value;
                RaisePropertyChanged("RelHumidityVisibility");

            }
        }


        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }

            set
            {

                _selectedIndex = value;
                RaisePropertyChanged("SelectedIndex"); HideTextBoxes();
            }
        }

      

        public Visibility WetBulbVisibility2
        {
            get
            {
                return _wetBulbVisibility2;
            }

            set
            {
                _wetBulbVisibility2 = value;
                RaisePropertyChanged("WetBulbVisibility2");

            }
        }

        public Visibility DewPointVisibility2
        {
            get
            {
                return _dewPointVisibility2;
            }

            set
            {
                _dewPointVisibility2 = value;
                RaisePropertyChanged("DewPointVisibility2");
            }
        }

        public Visibility RelHumidityVisibility2
        {
            get
            {
                return _relHumidityVisibility2;
            }

            set
            {
                _relHumidityVisibility2 = value;
                RaisePropertyChanged("RelHumidityVisibility2");
            }
        }

        private void RaisePropertyChanged(string _property)
        {
            //if (PropertyChanged != null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs(_property));
            //}

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_property));
        }

        public void CheckInput()
        {

            if (String.IsNullOrEmpty(DryBulb))
            {
                throw new ArgumentException("Enter the dry bulb temperature");
            }

            if (String.IsNullOrEmpty(WetBulb) && String.IsNullOrEmpty(RelHumidity) && String.IsNullOrEmpty(DewPoint))

            {
                throw new ArgumentException("Enter the dry bulb temperature and either wetbulb temperature,dew point temperature or relative humdity");
            }
            if (!String.IsNullOrEmpty(WetBulb))
            {
                if (Convert.ToDouble(DryBulb) < Convert.ToDouble(WetBulb))
                {
                    throw new ArgumentException("wet bulb temperature cannot be greater than drybulb temperaure");
                }
            }

        }

        public void CalculateProperties()
        {

            try
            {
                CheckInput();
                GetGridDetails();

            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Errror", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


        }

        public void ResetPropertes()
        {
            WetBulb = "";
            DryBulb = "";
            RelHumidity = "";
            DewPoint = "";
            if (DataGridDetails != null)
            {
                DataGridDetails.Clear();
            }

        }
        public void PopulateComboBox()
        {
            ComboProperties = new ObservableCollection<string>() { "WETBULB TEMPERATURE", "RELATIVE HUMIDITY", "DEWPOINT TEMPERATURE" };
        }

        public void HideTextBoxes()
        {
            if (SelectedIndex == 0)
            {
                ResetPropertes();
                WetBulbVisibility = Visibility.Visible;
                DewPointVisibility = Visibility.Collapsed;
                RelHumidityVisibility = Visibility.Collapsed;
                WetBulbVisibility2= Visibility.Visible;
                DewPointVisibility2 = Visibility.Collapsed;
                RelHumidityVisibility2= Visibility.Collapsed;
            }
            if (SelectedIndex == 1)
            {
                ResetPropertes();
                WetBulbVisibility = Visibility.Collapsed;
                DewPointVisibility = Visibility.Collapsed;
                RelHumidityVisibility = Visibility.Visible;
                WetBulbVisibility2 = Visibility.Collapsed;
                DewPointVisibility2 = Visibility.Collapsed;
                RelHumidityVisibility2 = Visibility.Visible;
            }
            if (SelectedIndex == 2)
            {
                ResetPropertes();
                WetBulbVisibility = Visibility.Collapsed;
                DewPointVisibility = Visibility.Visible;
                RelHumidityVisibility = Visibility.Collapsed;
                WetBulbVisibility2 = Visibility.Collapsed;
                DewPointVisibility2= Visibility.Visible;
                RelHumidityVisibility2 = Visibility.Collapsed;
            }


        }
        public ObservableCollection<PsychrometricViewModel> GetGridDetails()
        {


            DataGridDetails = new ObservableCollection<PsychrometricViewModel>();
            if (!String.IsNullOrEmpty(WetBulb))
            {
               WetBulbProperties wetBulbProperties = new WetBulbProperties();
                wetBulbProperties.Drybulb = Convert.ToDouble(DryBulb);
                wetBulbProperties.Wetbulb = Convert.ToDouble(WetBulb);
                DataGridDetails.Add(new PsychrometricViewModel()
                {
                    Enthalpy = wetBulbProperties.CalculateEnthalpy().ToString(),
                    Volume = wetBulbProperties.CalculateVolume().ToString(),
                    HumidityRatio = wetBulbProperties.CalculateHumidityRatio().ToString(),
                    SatPressure = wetBulbProperties.CalculateDryBulbSatPressure().ToString(),
                    PartialPressure = wetBulbProperties.CalculateDewSatPressure().ToString(),
                    Density = wetBulbProperties.CalculateDensity().ToString(),
                    DewPoint = wetBulbProperties.CalculateDewPointTemperature().ToString(),
                    RelHumidity = wetBulbProperties.CalculateRelativeHumidity().ToString(), WetBulb = WetBulb
            });
            }
            else if (!String.IsNullOrEmpty(RelHumidity))
            {


                RelHumidityProperties relHumidityProperties = new RelHumidityProperties();
                relHumidityProperties.Drybulb = Convert.ToDouble(DryBulb);
                relHumidityProperties.Relhumidity = Convert.ToDouble(RelHumidity);
                DataGridDetails.Add(new PsychrometricViewModel()
                {
                    Enthalpy = relHumidityProperties.CalculateEnthalpy().ToString(),
                    Volume = relHumidityProperties.CalculateVolume().ToString(),
                    HumidityRatio = relHumidityProperties.CalculateHumidityRatio().ToString(),
                    SatPressure = relHumidityProperties.CalculateDryBulbSatPressure().ToString(),
                    PartialPressure = relHumidityProperties.CalculateDewSatPressure().ToString(),
                    Density = relHumidityProperties.CalculateDensity().ToString(),
                    DewPoint = relHumidityProperties.CalculateDewPointTemperature().ToString(),RelHumidity = RelHumidity,
                WetBulb = relHumidityProperties.CalculateWetBulbTemperature().ToString()
            });
            }
            else if (!String.IsNullOrEmpty(DewPoint))
            {
                DewPointProperties dewPointProperties = new DewPointProperties();
                dewPointProperties.Drybulb = Convert.ToDouble(DryBulb);
                dewPointProperties.Dewpoint = Convert.ToDouble(DewPoint);
                DataGridDetails.Add(new PsychrometricViewModel()
                {
                    Enthalpy = dewPointProperties.CalculateEnthalpy().ToString(),
                    Volume = dewPointProperties.CalculateVolume().ToString(),
                    HumidityRatio = dewPointProperties.CalculateHumidityRatio().ToString(),
                    SatPressure = dewPointProperties.CalculateDryBulbSatPressure().ToString(),
                    PartialPressure = dewPointProperties.CalculateDewSatPressure().ToString(),
                    Density = dewPointProperties.CalculateDensity().ToString(),
                    WetBulb = dewPointProperties.CalculateWetBulbTemperature().ToString(),
                RelHumidity = dewPointProperties.CalculateRelativeHumidity().ToString(),DewPoint= DewPoint
            });
            }

            return DataGridDetails;


        }
    }
}


