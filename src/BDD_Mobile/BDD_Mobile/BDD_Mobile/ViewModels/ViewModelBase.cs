using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.Annotations;
using Prism.Mvvm;
using Prism.Navigation;
using SpecFlow.XForms.IViewModel;
using Xamarin.Forms;

namespace BDDMobile.ViewModels
{
    public abstract class ViewModelBase : BindableBase, IViewModel, INavigationAware, INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }

        public abstract void SetViewModel();

        protected void Initialize()
        {
            // call  on derived constructor
            SetViewModel();
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
           
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
          
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
         
        }
    }
}