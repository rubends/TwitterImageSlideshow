using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class PresentationModel
    {
        private PresentationController _controller;
        private List<SlideController> _slides = new List<SlideController>();
        private int _currentSlide = 0;
        private SlideController _emptySlide;

        public SlideController EmptySlide
        {
            get
            {
                return _emptySlide;
            }
            set
            {
                _emptySlide = value;
            }
        }

        public PresentationModel(PresentationController cont)
        {
            _controller = cont;
        }

        public void addSlide(SlideController slideToAdd)
        {
            _slides.Add(slideToAdd);
        }

        public List<SlideController> Slides
        {
            get
            {
                return _slides;
            }
            set
            {
                _slides = value;
            }
        }

        public int CurrentSlide
        {
            get
            {
                return _currentSlide;
            }
            set
            {
                Console.WriteLine("Next slide: " + value);
                _currentSlide = value;
            }
        }

    }
}
