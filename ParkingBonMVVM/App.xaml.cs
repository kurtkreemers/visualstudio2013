﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ParkingBonMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //Model.TekstMetOpmaak mijnTekst = new Model.TekstMetOpmaak();
            //ViewModel.TekstMetOpmaakVM vm = new ViewModel.TekstMetOpmaakVM(mijnTekst);
            //View.TextBoxView mijnTekstBoxView = new View.TextBoxView();
            //mijnTekstBoxView.DataContext = vm;
            //mijnTekstBoxView.Show();
        }
    }
}