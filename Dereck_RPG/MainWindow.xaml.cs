﻿using Dereck_RPG.database;
using Dereck_RPG.logger;
using Dereck_RPG.views;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Dereck_RPG
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Logger logger = new Logger("myLogger", LogMode.CURRENT_FOLDER, AlertMode.OVERLAY, "MaintWindows", true);
        MySQLFullDB msload = new MySQLFullDB();
        public MainWindow()
        {
            InitializeComponent();

            // Background image
            Image BgMenuI = new Image();
            ImageBrush BgMenuIB = new ImageBrush();

            BgMenuI.Source = new BitmapImage(new Uri(@"../../images/DereckRPGBackground.jpg", UriKind.Relative));
            BgMenuIB.ImageSource = BgMenuI.Source;
            menuGrid.Background = BgMenuIB;

            // Menu image
            imgTitle.Source = new BitmapImage(new Uri(@"images/DereckRPGMenu.png", UriKind.Relative));

            //logger.Log("Test1");
            //logger.Log("Test2", LogMode.NONE, AlertMode.TOAST);
            //logger.Log("Test3", LogMode.NONE, AlertMode.MESSAGE_BOX);
            //logger.Log("Test4", LogMode.NONE, AlertMode.MESSAGE_BOX_CUSTOM);
            //logger.Log("MainWindows loaded", LogMode.NONE, AlertMode.CONSOLE);
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();

            int height = 500;
            int width = 730;

            window.MaxHeight = height;
            window.MaxWidth = width;
            window.MinHeight = height;
            window.MinWidth = width;
            window.Content = new MenuPlay();
            window.Show();
        }

        private void btnAdministration_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            int height = 500;
            int width = 730;

            window.MaxHeight = height;
            window.MaxWidth = width;
            window.MinHeight = height;
            window.MinWidth = width;
            window.Content = new MenuAdministration();
            window.Show();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
