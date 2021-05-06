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
using System.Windows.Shapes;
using Model.Business;
using Model.Data;

namespace PPE3_SLAM_Axel
{
    /// <summary>
    /// Logique d'interaction pour Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {

        private List<ComboBox> uneListeComboBox;
        public int NBobstacles;
        public int NbJoueur;
        public List<int> uneListeEntier;
        
        public Window3(DAOclients unDaoClient, daoObstacle unDaoObstacle, DateTime uneDate, salles uneSalle, Window1 uneWindow1,Window2 uneWindow2)
        {
            InitializeComponent();
            uneListeComboBox = new List<ComboBox>();
            uneListeComboBox.Add(cbx_position_un);
            uneListeComboBox.Add(cbx_position_deux);
            uneListeComboBox.Add(cbx_position_trois);
            uneListeComboBox.Add(cbx_position_quatre);
            uneListeComboBox.Add(cbx_position_cinq);
            uneListeComboBox.Add(cbx_position_six);
            uneListeComboBox.Add(cbx_position_sept);
            uneListeComboBox.Add(cbx_position_huit);
            uneListeComboBox.Add(cbx_position_neuf);
            uneListeComboBox.Add(cbx_position_dix);
            uneListeComboBox.Add(cbx_position_onze);
            uneListeComboBox.Add(cbx_position_douze);
            cbx_nbjoueurs.Items.Add(1);
            cbx_nbjoueurs.Items.Add(2);
            cbx_nbjoueurs.Items.Add(3);
            cbx_nbjoueurs.Items.Add(4);
            cbx_nbjoueurs.Items.Add(5);
            cbx_nbjoueurs.Items.Add(6);
            cbx_nbjoueurs.Items.Add(7);







            SelectionClient.DataContext = new viewModel.viewModelSelectionClient(unDaoObstacle,unDaoClient,uneDate,uneSalle,NbJoueur,NBobstacles,uneWindow1,uneWindow2,this);
            lst_clients.Visibility = Visibility.Hidden;
            ConfigurationReservation.DataContext = SelectionClient.DataContext;
        }

        private void txt_nom_GotFocus(object sender, RoutedEventArgs e)
        {
            lst_clients.Visibility = Visibility.Visible;
        }

        private void txt_nom_LostFocus(object sender, RoutedEventArgs e)
        {
            lst_clients.Visibility = Visibility.Hidden;
        }

        private void btn_suivant_Click(object sender, RoutedEventArgs e)
        {
            
            int newIndex = tabReservation.SelectedIndex + 1;
            
            if (newIndex >= tabReservation.Items.Count)
            {
                newIndex = 0;
            }
                    
            MessageBoxResult msg ;
            if(lst_clients.SelectedIndex == -1)
            {
                msg = MessageBox.Show("Vous n'avez pas sélectionner de client !");
            }
            else
            {
                tabReservation.SelectedIndex = newIndex;
            }
            

            

        }

        private static int RetourneNbObstacle(List<ComboBox> uneListCombobox)
        {
            int i = 0;
            foreach(ComboBox cbx in uneListCombobox)
            {
                if(cbx.SelectedItem!= null)
                {
                    i = i + 1;
                }
            }
            return i;
        }

        private void cbx_position_un_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_deux_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_trois_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_quatre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_cinq_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_six_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_sept_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_huit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_neuf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_dix_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_onze_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_position_douze_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NBobstacles = RetourneNbObstacle(uneListeComboBox);
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbObstacles(NBobstacles);
        }

        private void cbx_nbjoueurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NbJoueur = (int)cbx_nbjoueurs.SelectedItem;
            viewModel.viewModelSelectionClient unviewmodel = (viewModel.viewModelSelectionClient)SelectionClient.DataContext;
            unviewmodel.ReloadNbPlayers(NbJoueur);
        }

        
    }
}
