using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ViewModel();
        }

    }
    public class ViewModel : INotifyPropertyChanged
    {
        private Car _car;
        public Car Car
        {
            get
            {
                return _car;
            }
            set
            {
                _car = value;
                OnPropertyChanged("Car");
            }
        }

        private ICommand _changeCommand;
        public ICommand ChangeCommand
        {
            get
            {
                return _changeCommand ??
                    (_changeCommand = new RelayCommand(obj =>
                    {
                        Car.Name = new Random().Next(1, 5).ToString();
                    },
                    (obj) =>
                    {
                        if(obj is Car)
                        {
                            if ((obj as Car).Name == "3") 
                            {
                                Car.Name = "3";
                                return false;
                            }
                        }
                        return true;
                    }
                    ));
            }
        }

        private string _someText = "";

        public string SomeText
        {
            get 
            {
                return  _someText; 
            }
            set
            {
                //if (!string.Equals(this._someText, value))
                //{
                    _someText = value;
                    OnPropertyChanged("SomeText");
                //}
                //TextButton.RaiseCanExecuteChanged();
                //TextButton.CanExecuteChanged += TextButton_CanExecuteChanged;
            }
        }

        private void TextButton_CanExecuteChanged(object sender, EventArgs e)
        {
            
        }

        private string text;

        private ICommand _textButton;

        public ICommand TextButton
        {
            get 
            {
                return _textButton ??
                    (_textButton = new RelayCommand(obj =>
                    {
                        //Console.WriteLine("Clicked");
                        //text = (obj as String);
                    }, 
                    obj => 
                    {
                        return !String.IsNullOrEmpty(SomeText);
                    }
                    ));
            }
        }

        private int counter = 0;
        public ICommand CounterCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Car.Name = counter.ToString();
                    counter++;
                },
                obj => counter < 5); 
            }
        }

        public ICommand CancelCommand
        {
            get
            {
                return new RelayCommand(obj => counter = 0);
            }
        }


        public ViewModel()
        {
            Car = new Car() { Name = "Fuck" };
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
