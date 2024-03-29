﻿using System;
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
using Kursach.ObjClas;
using Kursach.ViewModel;
using Kursach.Model;

namespace Kursach.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminInterface.xaml
    /// </summary>
    public partial class AdminInterface : Page
    {
        public static DataGrid UserListst;
        public static string log_info { get; set; }
        public AdminInterface()
        {
            
            InitializeComponent();
            log_info = AuthorizationViewModel.Login;
            DataContext = new AdminViewModel();
            UserListst = dgdata;
          
          
        }
        #region nav
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {

            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Logout(object sender, MouseButtonEventArgs e)
        {

            ObjClas.Frame.FrameOBJ.Navigate(new AuthorizationPage());
        }
        private void Profile(object sender, MouseButtonEventArgs e)
        {
            ObjClas.Frame.FrameOBJ.Navigate(new ProfileUser());


        }

        #endregion


    }
}
