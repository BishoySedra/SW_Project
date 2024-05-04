using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine_Management_System.Repository.MagazineRepository;
using Magazine_Management_System.Repository.ArticleRepository;
using Magazine_Management_System.Repository.SubscriptionRepository;
using Magazine_Management_System.Model;
using Oracle.DataAccess.Types;

namespace Magazine_Management_System
{
    public partial class SubscriptionForm : Form
    {
        SubscriptionRepository subscriptionRepository = new SubscriptionRepository();
        ArticleRepository articleRepository = new ArticleRepository();
        MagazineRepository magazineRepository = new MagazineRepository();

        int ReaderID;
        public SubscriptionForm(int readerID)
        {
            InitializeComponent();
            ReaderID = readerID;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SubscriptionForm_Load(object sender, EventArgs e)
        {
            //get all magazines u r not subscribed to using ur id
            List<Magazine> notSubscribedMagazines = subscriptionRepository.GetAllMagazinesNotSubscribedTo(ReaderID);
            List<Magazine> subscribedMagazines = subscriptionRepository.GetAllMagazinesSubscribedTo(ReaderID);

            List<Article> articlesOfYourMagazines = subscriptionRepository.GetArticlesOfYourSubscriptionMagazines(ReaderID);

            //check if not null for each one
            if(notSubscribedMagazines != null && notSubscribedMagazines.Count > 0)
            {

                foreach (Magazine magazine in notSubscribedMagazines)
                {
                    suggestedMagazines.Items.Add(magazine.Id + " " + magazine.Name);
                }
            }
            if (subscribedMagazines != null && subscribedMagazines.Count > 0)
            {
                foreach (Magazine magazine in subscribedMagazines)
                {
                    subscribedMagazinesComboBox.Items.Add(magazine.Id + " " + magazine.Name);
                }
            }
            if(articlesOfYourMagazines != null && articlesOfYourMagazines.Count > 0)
            {
                foreach (Article article in articlesOfYourMagazines)
                {
                    articles.Items.Add(article.Id + " " + article.Title + " " + article.Content);
                }
            }

        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            //get the selected magazine
            string magazine = suggestedMagazines.SelectedItem.ToString();
            //get the magazine id
            int magazineId = Convert.ToInt32(magazine.Split(' ')[0]);

            ////get current oracle date 
            
            OracleDate startOracleDate = new OracleDate(DateTime.Now);
            OracleDate endDracleDate = new OracleDate(DateTime.Now.AddDays(30));
            int r = subscriptionRepository.SaveSubscription(ReaderID,magazineId,startOracleDate,endDracleDate);
            if(r != -1)
            {
                MessageBox.Show("Subscribed successfully");
                subscribedMagazinesComboBox.Items.Add(magazineId + " " + magazine.Split(' ')[1]);
                List<Article> articlesOfYourMagazines = subscriptionRepository.GetArticlesOfYourSubscriptionMagazines(ReaderID);
                //clear articles and make it again
                articles.Items.Clear();
                foreach (Article article in articlesOfYourMagazines)
                {
                    articles.Items.Add(article.Id + " " + article.Title + " " + article.Content);
                }
            }
            else
            {
                MessageBox.Show("Error subscribing");
            }
        }
    }
}
