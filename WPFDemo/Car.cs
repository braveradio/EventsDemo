using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo
{
    public class Car : INotifyPropertyChanged
    {
		private string _Name = "Me";

		public string Name
		{
			get 
			{ 
				return _Name; 
			}
			set 
			{
				_Name = value;
				OnPropertyChanged("Name");
			}
		}

		private int _Year;
		public int Year
		{
			get
			{
				return _Year;
			}
			set
			{
				_Year = value;
				OnPropertyChanged("Year");
			}
		}


		private void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}

		public event PropertyChangedEventHandler PropertyChanged;
    }
}
