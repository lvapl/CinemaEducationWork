using CinemaRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CinemaRental.Views
{
    public abstract class ViewBase : UserControl
    {
        public object? ViewModel { get; set; }
    }

    public class ViewBase<VM> : ViewBase where VM : ViewModelBase, new()
    {
        public ViewBase()
        {
            ViewModel = new VM();
        }
    }
}
