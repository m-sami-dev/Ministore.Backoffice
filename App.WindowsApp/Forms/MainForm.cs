using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.core.Services;
using App.WindowsaApp.Views;

namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private Button _activeNavButton;

        private readonly Color NavNormalBack = Color.FromArgb(244, 244, 255);
        private readonly Color NavActiveBack = Color.FromArgb(153, 153, 161);

        private readonly Color NavNormalfore = Color.Black;
        private readonly Color NavActiveFore = Color.Black;


        InMemoryProductService _productService = new InMemoryProductService();


        private readonly Dictionary<Type,UserControl> _views=new Dictionary<Type,UserControl>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void setActiveNavButton(Button btn)
        {
            if (btn == null) return;
            //RESET OLD ACTIVE
            if (_activeNavButton != null)
            {
                _activeNavButton.BackColor = NavNormalBack;
                _activeNavButton.ForeColor = NavNormalfore;
                _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Regular);
            }
            //set new active
            _activeNavButton = btn;
            _activeNavButton.BackColor = NavActiveBack;
            _activeNavButton.ForeColor = NavNormalfore;
            _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Bold);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelnav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpnav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            setActiveNavButton(btnDashboard);
            ShowView(()=> new  DashboardView());

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

            ShowView(() => new Productsview(_productService));
            setActiveNavButton(btnProducts);
            //ShowView(() => new Productsview());
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                _views[key] = view;
                view.Dock=DockStyle.Fill;
            }

            panelContent.Controls.Clear();  
            panelContent.Controls.Add(view);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            setActiveNavButton((Button)sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            setActiveNavButton((Button)sender);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            setActiveNavButton((Button)sender);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            setActiveNavButton((Button)sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            setActiveNavButton((Button)sender);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblministore_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsLabelStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
