using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine_Management_System.Repository.SubscriptionRepository;
using Magazine_Management_System.Repository.ArticleRepository;
using Magazine_Management_System.Model;

namespace Magazine_Management_System
{
    public partial class ReaderForm : Form
    {
        int ReaderID;

        SubscriptionRepository subscriptionRepository = new SubscriptionRepository();

        public ReaderForm(int readerID)
        {
            InitializeComponent();
            ReaderID = readerID;
            List<Magazine> toBeSubmagazines = subscriptionRepository.GetAllUserNotSubscribedMagazines(ReaderID);
            foreach (Magazine magazine in toBeSubmagazines)
            {
                toBeSubscribedMagazines.Items.Add(magazine.Name + " " + magazine.Id);
            }
            List<Magazine> readerMagazines = subscriptionRepository.GetAllUserSubscribedMagazines(ReaderID);
            foreach (Magazine magazine in readerMagazines)
            {
                subscribedMagazines.Items.Add(magazine.Name + " " + magazine.Id);
            }
            List<Article> readerArticles = subscriptionRepository.GetAllUserSubscribedMagazinesArticles(ReaderID);
            foreach (Article article in readerArticles)
            {
                userArticles.Items.Add(article.Title + " " + article.Id);
            }
        }




    }
}
