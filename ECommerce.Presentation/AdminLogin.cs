using E_Commerce.Application.Services;
using ECommerce.Presentation;

namespace E_Commerce.Preserntations;

public partial class AdminLogin : Form
{
    private readonly IAdminServices AdminServices;
    public AdminLogin()
    {

        InitializeComponent();
    }

   

    private void loginBtn_Click(object sender, EventArgs e)
    {
        if (AdminServices.check(txtPassword.Text, txtUserName.Text))
        {
            MessageBox.Show("Login successful");
            this.Hide();
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
        }
        
    }
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
