using ECommerce.Presentation;
namespace ECommerce.Presentation
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void proBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
        }

        private void ordBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }

        private void cliBtn_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
        }
    }
}
