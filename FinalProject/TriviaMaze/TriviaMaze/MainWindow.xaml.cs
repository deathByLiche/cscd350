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

namespace TriviaMaze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

           /* this.hideGameScreen();
            this.hideCreditsScreen();
            this.hideResultsScreen();
            this.hideHelpScreen();*/
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            this.hideTitleScreen();
            this.gameScreen.Visibility = System.Windows.Visibility.Visible;
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            this.hideTitleScreen();
            this.helpScreen.Visibility = System.Windows.Visibility.Visible;
        }

        private void creditsButton_Click(object sender, RoutedEventArgs e)
        {
            this.hideTitleScreen();
            this.creditsScreen.Visibility = System.Windows.Visibility.Visible;
        }

        private void showTitleScreen()
        {
            this.titleScreen.Visibility = System.Windows.Visibility.Visible;
        }

        private void hideTitleScreen()
        {
            this.titleScreen.Visibility = System.Windows.Visibility.Hidden;
        }

        private void hideGameScreen()
        {
            this.gameScreen.Visibility = System.Windows.Visibility.Hidden;
        }

        private void hideHelpScreen()
        {
            this.helpScreen.Visibility = System.Windows.Visibility.Hidden;
        }

        private void hideCreditsScreen()
        {
            this.creditsScreen.Visibility = System.Windows.Visibility.Hidden;
        }

        private void hideResultsScreen()
        {
            this.resultsScreen.Visibility = System.Windows.Visibility.Hidden;
        }

        private void doneButtonGameScreen_Click(object sender, RoutedEventArgs e)
        {
            this.hideGameScreen();
            this.titleScreen.Visibility = System.Windows.Visibility.Visible;
        }

        private void doneButtonHelpScreen_Click(object sender, RoutedEventArgs e)
        {
            this.hideHelpScreen();
            this.showTitleScreen();
        }

        private void doneButtonCreditsScreen_Click(object sender, RoutedEventArgs e)
        {
            this.hideCreditsScreen();
            this.showTitleScreen();
        }

        private void doneButtonResultsScreen_Click(object sender, RoutedEventArgs e)
        {
            this.hideResultsScreen();
            this.showTitleScreen();
        }
    }
}
