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

namespace InteraktionsDesignPro2
{
    /// <summary>
    /// Interaction logic for Publisher.xaml
    /// </summary>
    public partial class Publisher : Window
    {
        public Publisher()
        {
            InitializeComponent();

            List<PostData> data = new List<PostData>();
            data.Add(new PostData("H1", "Here"));
            data.Add(new PostData("H1", "Here"));
            data.Add(new PostData("H1", "Here"));
            data.Add(new PostData("H1", "Here"));
            data.Add(new PostData("H1", "Here"));
            data.Add(new PostData("H1", "Here"));
            data.Add(new PostData("H1", "Here"));
            data.Add(new PostData("H1", "Here"));
            listBox.ItemsSource = data;
        }

        private void Control_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var newForm = new Search(); //create your new form.
            newForm.SökText.Text = SökTexten.Text;
            newForm.Show(); //show the new form.

            this.Close(); //only if you want to close the current form.
        }
    }
}
