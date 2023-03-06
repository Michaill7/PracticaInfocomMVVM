using PracticaInfocomMVVM.Models;
using PracticaInfocomMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticaInfocomMVVM.Infrastructure.Commands.CommandsMainWindowCollection
{
    internal abstract class DownoladButtonCommand
    {
        public static List<string> ActualListCom { get; set; }

        public static bool DownoladCanExecute(object o) =>  true;

        public static void DownoladExecuted(object o)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.DefaultExt = ".json";
            dialog.Filter = "JSON (.json)|*.json";
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                string filename = dialog.FileName;
                var a = JsonCustomer.Deserialization(filename);
                var b = new List<String> { };
                foreach (var item in a)
                {
                    b.Add
                        (
                           $"{item.Surname} {item.Name} {item.Patronymic}"
                        );
                }
                ActualListCom = b;
            }
        }
    }
}
