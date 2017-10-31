using System.Windows;
using WCF.Contrat.V1;
using System.ServiceModel;

namespace WCF.Client.V1
{
    public partial class MainWindow : Window
    {
        private IService1 Svc1 = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            string choixCanal = "";

            if (ChoixTcp.IsChecked.Value)
            {
                choixCanal = "TcpAcces";
            }
            else if (ChoixMemoire.IsChecked.Value)
            {
                choixCanal = "TcpMemoire";
            }
            var canal = new ChannelFactory<IService1>(choixCanal);             // Définition du contrat                
            Svc1 = canal.CreateChannel();
            // Svc1 = new Service1();
            TbResultat.Text = Svc1.Majuscule(txtTexte.Text);
        }


    }
}
