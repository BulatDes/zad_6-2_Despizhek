using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zad6_2_Des
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TwoPage :ContentPage
    {
        public TwoPage (Hotel hotel)
        {
            InitializeComponent();
        }
    }
}