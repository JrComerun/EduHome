using HomeEduAspNetFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduAspNetFinal.ViewModels
{
    public class HomeVM
    {
        public List<NoticeBoard> NoticeBoards { get; set; }
        public VideoTour VideoTour { get; set; }
       
        public List<HomeSlider> HomeSliders { get; set; }
       
    }
}
