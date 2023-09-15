using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using notify.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace notify.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}