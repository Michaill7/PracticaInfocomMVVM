using PracticaInfocomMVVM.Infrastructure;
using PracticaInfocomMVVM.Infrastructure.Commands.CommandsMainWindowCollection;
using PracticaInfocomMVVM.Models;
using PracticaInfocomMVVM.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PracticaInfocomMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        public ICommand DownoladButtonCommands { get; }


        private static List<string> actualList;
        public static List<string> ActualList 
        { 
            get => actualList;
            set 
            {
                actualList = value ;
                MessageBox.Show("aa");
                OnPropertyChange();
            }
        }

        public MainWindowViewModel()
        {
            DownoladButtonCommands = new LyambdaCommand(DownoladButtonCommand.DownoladExecuted, DownoladButtonCommand.DownoladCanExecute);

        }
        
    }
}
