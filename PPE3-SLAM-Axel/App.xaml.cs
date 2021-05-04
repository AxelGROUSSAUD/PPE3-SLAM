﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Model.Business;
using Model.Data;

namespace PPE3_SLAM_Axel
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {

        private Dbal thedbal;
        private daoReservation thedaoreservation;
        private DAOsalles thedaosalles;
        private DAOtheme theDaoTheme;
        private DAOutilisateurs theDaoUtilisateurs;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            thedbal = new Dbal("LSRGames");
            theDaoUtilisateurs = new DAOutilisateurs(thedbal);
            thedaoreservation = new daoReservation(thedbal);
            theDaoTheme = new DAOtheme(thedbal);
            thedaosalles = new DAOsalles(thedbal,theDaoTheme);

            Window1 wnd = new Window1(thedaoreservation, thedaosalles);
            wnd.Show();

            

        }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            e.Handled = true;
        }
    }
}
