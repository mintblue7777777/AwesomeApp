using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class PrismMasterDetailPage1 : MasterDetailPage
    {
        public PrismMasterDetailPage1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.labelPageName.Text = ((Button)sender).Text;
            this.IsPresented = false;
        }
    }
}