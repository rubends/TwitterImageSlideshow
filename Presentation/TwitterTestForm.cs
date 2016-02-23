using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using LinqToTwitter;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{

    public partial class TwitterTestForm : Form
    {

        public TwitterTestForm()
        {
            InitializeComponent();

            searchText.Text = "\"LINQ to Twitter\" OR Linq2Twitter OR LinqToTwitter";
        }

        private void TwitterTestForm_Load(object sender, EventArgs e)
        {

        }

        async private void button1_Click(object sender, EventArgs e)
        {
            var authorizer = new ApplicationOnlyAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore
                {
                    ConsumerKey = "KQrJnO8Sxc6098dm6OMSbQeoU",
                    ConsumerSecret = "gs7cQhxsMnNGukBnYmCoCPRgIXVTwEPDIjnwOfLUBY9smwsGVv"
                }
            };

            await authorizer.AuthorizeAsync();
            var ctx = new TwitterContext(authorizer);

            string searchString = searchText.Text;

            var searchResponse =
                await
                (from search in ctx.Search
                 where search.Type == SearchType.Search &&
                       search.Query == searchString &&
                       search.Count == 100
                 select search)
                .SingleOrDefaultAsync();

            var tweets =
                (from tweet in searchResponse.Statuses
                 select new TweetViewModel
                 {
                     ImageUrl = tweet.User.ProfileImageUrl,
                     ScreenName = tweet.User.ScreenNameResponse,
                     Text = tweet.Text
                 })
                .ToList();

            string result = "";
            foreach(TweetViewModel tweet in tweets)
            {
                result += tweet.Text + "\n";
            }
            label1.Text = result;

        }
    }
}
