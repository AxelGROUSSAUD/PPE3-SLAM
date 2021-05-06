using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Model.Business;
using Model.Data;
using System.Windows;


namespace PPE3_SLAM_Axel.viewModel
{
    class viewModelSelectionClient : viewModelBase
    {
        
        private DAOclients vmdaoclient;
        private daoObstacle vmdaoobstacle;
        private ICommand validerCommand;
        private ObservableCollection<Obstacle> listObstacles;
        private Clients selectedClient = new Clients();
        private ObservableCollection<Clients> listClients;
        private salles laSalle;
        private DateTime DateReservation;
        private int nbJoueurs;
        private int nbObstacles;
        private Window1 wndReservation;
        private Window2 wndSalle;
        private Window3 wndClient;
        private Obstacle selectedObstacle_p_un;
        private Obstacle selectedObstacle_p_deux;
        private Obstacle selectedObstacle_p_trois;
        private Obstacle selectedObstacle_p_quatre;
        private Obstacle selectedObstacle_p_cinq;
        private Obstacle selectedObstacle_p_six;
        private Obstacle selectedObstacle_p_sept;
        private Obstacle selectedObstacle_p_huit;
        private Obstacle selectedObstacle_p_neuf;
        private Obstacle selectedObstacle_p_dix;
        private Obstacle selectedObstacle_p_onze;
        private Obstacle selectedObstacle_p_douze;

        public ObservableCollection<Clients> ListClients { get => listClients; set => listClients = value; }
        public ObservableCollection<Obstacle> ListObstacles { get => listObstacles; set => listObstacles = value; }
        public viewModelSelectionClient( daoObstacle unDaoObstacle,DAOclients unDaoClient, DateTime laDateReservation,salles uneSalle,int unNbJoueur, int unNbObstacle, Window1 uneWindow1, Window2 uneWindow2, Window3 uneWindow3)
        {
            vmdaoclient = unDaoClient;
            listClients = new ObservableCollection<Clients>(vmdaoclient.SelectAll());
            vmdaoobstacle = unDaoObstacle;
            listObstacles = new ObservableCollection<Obstacle>(vmdaoobstacle.SelectAll());
            DateReservation = laDateReservation;
            laSalle = uneSalle;
            nbJoueurs = unNbJoueur;
            nbObstacles = unNbObstacle;
            wndReservation = uneWindow1;
            wndSalle = uneWindow2;
            wndClient = uneWindow3;
        }
        //Binding customers
        public Clients SelectedClient
        {
            get => selectedClient;
            set
            {
                if(selectedClient!=value)
                {
                    selectedClient = value;
                    OnPropertyChanged("SelectedClient");
                    OnPropertyChanged("Nom");
                    OnPropertyChanged("Prenom");
                    OnPropertyChanged("DateNaissance");
                    OnPropertyChanged("Adresse");
                    OnPropertyChanged("Telephone");
                    OnPropertyChanged("Email");
                    OnPropertyChanged("Id");
                    OnPropertyChanged("Credit");
                }
            }
        }

        public string Nom
        {
            get
            {
                if(selectedClient.NomClient!=null)
                {
                    return selectedClient.NomClient;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(selectedClient.NomClient!= value)
                {
                    selectedClient.NomClient = value;
                    OnPropertyChanged("Nom");
                }
            }
        }

        public string Prenom
        {
            get
            {
                if(selectedClient.PrenomClient!=null)
                {
                    return selectedClient.PrenomClient;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(selectedClient.PrenomClient != value)
                {
                    selectedClient.PrenomClient = value;
                    OnPropertyChanged("Prenom");
                }
            }
        }

        public string DateNaissance
        {
            get
            {
                if(selectedClient.DateNaissanceClient!=null)
                {
                    return selectedClient.DateNaissanceClient.ToString("f");
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(selectedClient.DateNaissanceClient.ToString("f")!=value)
                {
                    selectedClient.DateNaissanceClient = DateTime.Parse(value);
                    OnPropertyChanged("DateNaissance");
                }
            }
        }

        public string Adresse
        {
            get
            {
                if(selectedClient.AdresseClient!=null)
                {
                    return selectedClient.AdresseClient;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(selectedClient.AdresseClient!=value)
                {
                    selectedClient.AdresseClient = value;
                    OnPropertyChanged("Adresse");
                }
            }
        }

        public string Telephone
        {
            get
            {
                if(selectedClient.TelPortableCLient!=null)
                {
                    return selectedClient.TelPortableCLient;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(selectedClient.TelPortableCLient!=value)
                {
                    selectedClient.TelPortableCLient = value;
                    OnPropertyChanged("Telephone");
                }
            }
        }

        public string Email
        {
            get
            {
                if(selectedClient.EmailClient!=null)
                {
                    return selectedClient.EmailClient;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(selectedClient.EmailClient!=value)
                {
                    selectedClient.EmailClient = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public string Id
        {
            get
            {
                if(selectedClient.IdClient!=0)
                {
                    return selectedClient.IdClient.ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                if(selectedClient.IdClient.ToString()!=value)
                {
                    selectedClient.IdClient = int.Parse(value);
                    OnPropertyChanged("Id");
                }
            }
        }
        public string Credit
        {
            get
            {
                if(selectedClient.CreditCLient!=0)
                {
                    return selectedClient.CreditCLient.ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                if(selectedClient.CreditCLient.ToString()!=value)
                {
                    selectedClient.CreditCLient = double.Parse(value);
                    OnPropertyChanged("Credit");
                }
            }
        }

        //Binding 

        public Obstacle SelectedObstacle_p_un
        {
            get => selectedObstacle_p_un;
            set
            {
                if (selectedObstacle_p_un != value)
                {
                    selectedObstacle_p_un = value;
                }
            }
        }


        public Obstacle SelectedObstacle_p_deux
        {
            get => selectedObstacle_p_deux;
            set
            {
                if (selectedObstacle_p_deux != value)
                {
                    selectedObstacle_p_deux = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_trois
        {
            get => selectedObstacle_p_trois;
            set
            {
                if (selectedObstacle_p_trois != value)
                {
                    selectedObstacle_p_trois = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_quatre
        {
            get => selectedObstacle_p_quatre;
            set
            {
                if (selectedObstacle_p_quatre != value)
                {
                    selectedObstacle_p_quatre = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_cinq
        {
            get => selectedObstacle_p_cinq;
            set
            {
                if (selectedObstacle_p_cinq != value)
                {
                    selectedObstacle_p_cinq = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_six
        {
            get => selectedObstacle_p_six;
            set
            {
                if (selectedObstacle_p_six != value)
                {
                    selectedObstacle_p_six = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_sept
        {
            get => selectedObstacle_p_sept;
            set
            {
                if (selectedObstacle_p_sept != value)
                {
                    selectedObstacle_p_sept = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_huit
        {
            get => selectedObstacle_p_huit;
            set
            {
                if (selectedObstacle_p_huit != value)
                {
                    selectedObstacle_p_huit = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_neuf
        {
            get => selectedObstacle_p_neuf;
            set
            {
                if (selectedObstacle_p_neuf != value)
                {
                    selectedObstacle_p_neuf = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_dix
        {
            get => selectedObstacle_p_dix;
            set
            {
                if (selectedObstacle_p_dix != value)
                {
                    selectedObstacle_p_dix = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_onze
        {
            get => selectedObstacle_p_onze;
            set
            {
                if (selectedObstacle_p_onze != value)
                {
                    selectedObstacle_p_onze = value;
                }
            }
        }

        public Obstacle SelectedObstacle_p_douze
        {
            get => selectedObstacle_p_douze;
            set
            {
                if (selectedObstacle_p_douze != value)
                {
                    selectedObstacle_p_douze = value;
                }
            }
        }

        public ICommand ValiderCommand
        {
            get
            {
                if (this.validerCommand == null)
                {
                    this.validerCommand = new RelayCommand(() => Valider(), () => true);
                }
                return this.validerCommand;

            }

        }


        public void Valider()
        {
            List<Obstacle> mesObstacles = new List<Obstacle>();
            mesObstacles.Add(SelectedObstacle_p_un);
            mesObstacles.Add(SelectedObstacle_p_deux);
            mesObstacles.Add(SelectedObstacle_p_trois);
            mesObstacles.Add(SelectedObstacle_p_quatre);
            mesObstacles.Add(SelectedObstacle_p_cinq);
            mesObstacles.Add(SelectedObstacle_p_six);
            mesObstacles.Add(SelectedObstacle_p_sept);
            mesObstacles.Add(SelectedObstacle_p_huit);
            mesObstacles.Add(SelectedObstacle_p_neuf);
            mesObstacles.Add(SelectedObstacle_p_dix);
            mesObstacles.Add(SelectedObstacle_p_onze);
            mesObstacles.Add(SelectedObstacle_p_douze);


            MessageBoxResult msg;
            Dbal thedbal = new Dbal("LSRGames");
            DAOtheme thedaotheme = new DAOtheme(thedbal);
            DAOsalles thedaosalle = new DAOsalles(thedbal, thedaotheme);
            daoPositionObstacle thedaoPositionObstacle = new daoPositionObstacle(thedbal);
            
            daoReservation thedaoreservation = new daoReservation(thedbal);
            
            DAOtransactions thedaotransactions = new DAOtransactions(thedbal, vmdaoclient);
            int id = thedaotransactions.SelectLastId() + 1;
            
            if(SelectedClient == null || nbJoueurs == 0 || nbObstacles == 0)
            {
                if (SelectedClient == null && nbJoueurs == 0 && nbObstacles == 0)
                {
                    msg = MessageBox.Show("Vous n'avez pas sélectionner de client, ni un nombre de joueurs, ni des obstacles. Vous devez sélectionner au moins un client, un nombre de joueurs et un obstacle .");
                }
                if(SelectedClient == null && nbJoueurs == 0)
                {
                    msg = MessageBox.Show("Vous n'avez pas sélectionner de client ni un nombre de joueurs. Vous devez sélectionner au moins un client et un nombre de joueurs.");
                }
                if(SelectedClient == null && nbObstacles ==0)
                {
                    msg = MessageBox.Show("Vous n'avez pas sélectionner de client ni d'obstacles. Vous devez sélectionner au moins un client et un obstacle.");
                }
                if(nbJoueurs == 0 && nbObstacles==0)
                {
                    msg = MessageBox.Show("Vous n'avez pas sélectionner un nombre de joueurs ni d'obstacles. Vous devez sélectionner au moins un nombre de joueurs et un obstacle.");
                }
                if(SelectedClient==null)
                {
                    msg = MessageBox.Show("Vous n'avez pas sélectionner de client. Vous devez sélectionner un client.");
                }
                if(nbJoueurs == 0  && nbObstacles != 0)
                {
                    msg = MessageBox.Show("Vous n'avez pas sélectionner un nombre de joueur. Vous devez sélectionner un nombre de joueurs.");
                }
                if(nbObstacles == 0 && nbJoueurs !=0)
                {
                    msg = MessageBox.Show("Vous n'avez pas sélectionner d'obstacles. Vous devez sélectionner au moins un obstacle.");
                }
            }
            else
            {
                Clients leClient = SelectedClient;

                Transactions uneTransaction = new Transactions(id, leClient, 5.25);

                thedaotransactions.Insert(uneTransaction);
                id = thedaoreservation.SelectLastId() + 1;

                Reservation uneReservation = new Reservation(id, leClient, laSalle, uneTransaction, DateReservation, nbJoueurs, nbObstacles);
                thedaoreservation.Insert(uneReservation);

                id = thedaoPositionObstacle.SelectLastId() + 1;
                int n = 1;
                foreach (Obstacle o in mesObstacles)
                {
                    if (o == null)
                    {
                        n = n + 1;
                    }
                    else
                    {
                        PositionObstacle unePositionObstacle = new PositionObstacle(id, o, uneReservation, n);
                        thedaoPositionObstacle.Insert(unePositionObstacle);
                        id = thedaoPositionObstacle.SelectLastId() + 1;
                        n = n + 1;
                    }
                }

                wndClient.Close();
                wndSalle.Close();
              
            }
            

            


        }

        public void ReloadNbObstacles(int nb)
        {
            nbObstacles = nb;
        }

        public void ReloadNbPlayers(int nb)
        {
            nbJoueurs = nb;
        }

        

        

    }

}
