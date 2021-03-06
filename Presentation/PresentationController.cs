﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToTwitter;

namespace Presentation
{
    public class PresentationController
    {
        private PresentationView _view;
        private MainController _mainController;
        private PresentationModel _model;
        //private int AantalFotosTussenTweets = 2;
        Random rnd = new Random(DateTime.UtcNow.Millisecond);

        public PresentationController(MainController mainController)
        {
            _view = new PresentationView(this);
            _model = new PresentationModel(this);
            _view.Show();
            _mainController = mainController;

            // set empty slide 
            _model.EmptySlide = new SlideController();
            TweetController emptyTweet = new TweetController();
            emptyTweet.SetTweet("No slides", "Please load images or tweets?", "No profilepicture", "No given name");
            _model.EmptySlide.SetSlide(emptyTweet);
            _model.addSlide(_model.EmptySlide);

            loadTweets();
        }

        public PresentationView getView()
        {
            return _view;
        }

        public PresentationModel getModel()
        {
            return _model;
        }

        public MainController getMain()
        {
            return _mainController;
        }

        public void NextSlide()
        {
            
            if(_model.Slides.Count > 0)
            {
                if (_model.Slides.Count > _model.CurrentSlide + 1)
                {
                    // next slide is good
                    _model.CurrentSlide++;
                    Console.Write("current slide : " + _model.CurrentSlide);
                }
                else
                {
                    //start over
                    _model.CurrentSlide = 0;
                }
            } else
            {
                _model.CurrentSlide = 0;
            }

            _view.UpdateView();
        }

        public void PrevSlide()
        {
            if(_model.Slides.Count > 0)
            {
                if (_model.CurrentSlide - 1 >= 0)
                {
                    // prev slide is good
                    _model.CurrentSlide--;
                }
                else
                {
                    //start over
                    _model.CurrentSlide = _model.Slides.Count - 1;
                }
            } else
            {
                _model.CurrentSlide = 0;
            }
            _view.UpdateView();
        }
        //public void GetTweetSlide()
        //{
        //     _model.CurrentSlide = 7;
        //    _view.UpdateView();
        //}

        public void loadSlides()
        {
        }

        public void loadImages()
        {
            string imagesPath = _mainController.getSettingsController().getImagesFolderPath(); // image path uit settings Model
            if (imagesPath == null)
            {
                MessageBox.Show("No image folder path set!", "Error");
            }
            else
            {
                ImageDirectory imagesDir = new ImageDirectory(imagesPath);
                if (imagesDir.getLength() > 0)
                {
                    MessageBox.Show("Files loaded: " + imagesDir.getLength().ToString(), "Message");

                    // delete all image slides
                    deleteAllImages();

                    foreach (string imagePath in imagesDir.getImagePaths())
                    {
                        ImageController image = new ImageController(this);
                        image.SetImage(imagePath);
                        SlideController slide = new SlideController();
                        slide.SetSlide(image);
                        _model.addSlide(slide);
                    }
                    shuffleTweets();

                    //for (int i = 0; i < AantalFotosTussenTweets; i++)
                    //{
                    //    var imgs = imagesDir.getImagePaths();
                    //    //if (_model.PicIndex < imgs.Length)
                    //    //{
                    //    //    ImageController image = new ImageController(this);
                    //    //    image.SetImage(imgs[_model.PicIndex]);
                    //    //    SlideController slide = new SlideController();
                    //    //    slide.SetSlide(image);
                    //    //    _model.addSlide(slide);
                    //    //    _model.PicIndex++;
                    //    //}
                    //    //else
                    //    //{
                    //    //    _model.PicIndex = 0;
                    //    //}
                    //    var random = rnd.Next(imgs.Length);
                    //    ImageController image = new ImageController(this);
                    //    image.SetImage(imgs[random]);
                    //    SlideController slide = new SlideController();
                    //    slide.SetSlide(image);
                    //    _model.addSlide(slide);
                    //    _model.PicIndex++;
                    //    Console.WriteLine(_model.PicIndex);
                    //}

                }
                else
                {
                    MessageBox.Show("No files found.", "Error");
                }
            }
        }

        public void deleteAllTweets()
        {
            foreach (SlideController slide in _model.Slides.ToArray())
            {
                if (slide.SlideType == GlobalVar.SLIDE_TYPE_TWEET)
                {
                    // remove slide
                    _model.Slides.Remove(slide);
                }
            }
        }

        public void deleteAllImages()
        {
            foreach (SlideController slide in _model.Slides.ToArray())
            {
                if (slide.SlideType == GlobalVar.SLIDE_TYPE_IMAGE)
                {
                    // remove slide
                    _model.Slides.Remove(slide);
                }
            }
        }

        public void shuffleTweets()
        {
            List<SlideController> imageSlides = new List<SlideController>();
            List<SlideController> tweetSlides = new List<SlideController>();


            // create two lists, one for images, one for tweets
            foreach(SlideController slide in _model.Slides)
            {
                if (slide.SlideType == GlobalVar.SLIDE_TYPE_IMAGE) imageSlides.Add(slide);

                if (slide.SlideType == GlobalVar.SLIDE_TYPE_TWEET) tweetSlides.Add(slide);
            }
            for (int i = 0; i < (imageSlides.Count*2); i=i+2)
            {
                _model.Slides[i] = imageSlides[i/2];
                _model.addSlide(_model.Slides[i + 1]);
                _model.Slides[i + 1] = tweetSlides[0];
            }

        }

        async public void loadTweets()
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

            int maxTweets = getMain().getSettingsController().getModel().MaxTweets;

            string searchString = getMain().getSettingsController().getModel().TwitterSearch;

            var searchResponse =
                await
                (from search in ctx.Search
                 where search.Type == SearchType.Search &&
                       search.Query == searchString &&
                       search.Count == maxTweets
                 select search)
                .SingleOrDefaultAsync();

            var tweets =
                (from tweet in searchResponse.Statuses
                 select new TweetViewModel
                 {
                     ImageUrl = tweet.User.ProfileImageUrl,
                     ScreenName = tweet.User.ScreenNameResponse,
                     Name = tweet.User.Name,
                     Text = tweet.Text
                 })
                .ToList();

            if(tweets.Count > 0)
            {
                // tweets found
                deleteAllTweets(); // delete all old tweets

                // add new tweets
                //foreach (TweetViewModel tweet in tweets)
                //{
                //    //result += tweet.Text + "\n";
                //    TweetController tweetToAdd = new TweetController();
                //    tweetToAdd.SetTweet(tweet.ScreenName, tweet.Text, tweet.ImageUrl, tweet.Name);
                //    SlideController slideToAdd = new SlideController();
                //    slideToAdd.SetSlide(tweetToAdd);
                //    _model.addSlide(slideToAdd);
                //}
                    //result += tweet.Text + "\n";
                    TweetController tweetToAdd = new TweetController();
                    tweetToAdd.SetTweet(tweets[0].ScreenName, tweets[0].Text, tweets[0].ImageUrl, tweets[0].Name);
                    tweetToAdd.SetTweet2(tweets[1].ScreenName,tweets[1].Text, tweets[1].ImageUrl, tweets[1].Name);
                    tweetToAdd.SetTweet3(tweets[2].ScreenName, tweets[2].Text, tweets[2].ImageUrl, tweets[2].Name);
                    tweetToAdd.SetTweet4(tweets[3].ScreenName, tweets[3].Text, tweets[3].ImageUrl, tweets[3].Name);
                    tweetToAdd.SetTweet5(tweets[4].ScreenName, tweets[4].Text, tweets[4].ImageUrl, tweets[4].Name);
                    SlideController slideToAdd = new SlideController();
                    slideToAdd.SetSlide(tweetToAdd);
                    _model.addSlide(slideToAdd);

                // shuffle tweets between images
                shuffleTweets();
            }
        }
    }
}
