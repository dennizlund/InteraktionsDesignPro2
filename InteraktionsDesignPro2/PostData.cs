using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace InteraktionsDesignPro2
{
    class PostData
    {
        public string Title;
        public string Content;
        public BitmapImage ImgSource { get; set; }

        public PostData(string title, string content)
        {
            Title = title;
            Content = content;
            ImgSource = new BitmapImage();
        }
    }
}
