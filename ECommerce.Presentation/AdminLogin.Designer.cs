namespace E_Commerce.Preserntations;

partial class AdminLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        loginLabel = new Label();
        usernameLabel = new Label();
        txtUserName = new TextBox();
        txtPassword = new TextBox();
        loginBtn = new Button();
        passwordLabel = new Label();
        SuspendLayout();
        // 
        // loginLabel
        // 
        loginLabel.AutoSize = true;
        loginLabel.BackColor = SystemColors.ActiveCaption;
        loginLabel.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        loginLabel.ForeColor = Color.White;
        loginLabel.Location = new Point(234, 35);
        loginLabel.Name = "loginLabel";
        loginLabel.Padding = new Padding(10, 10, 10, 0);
        loginLabel.Size = new Size(149, 31);
        loginLabel.TabIndex = 0;
        loginLabel.Text = "Login DashBoard";
        loginLabel.TextAlign = ContentAlignment.TopCenter;
        loginLabel.Click += label1_Click;
        // 
        // usernameLabel
        // 
        usernameLabel.AutoSize = true;
        usernameLabel.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        usernameLabel.ForeColor = SystemColors.ControlDark;
        usernameLabel.Location = new Point(107, 141);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(87, 21);
        usernameLabel.TabIndex = 1;
        usernameLabel.Text = "UserName:";
        // 
        // txtUserName
        // 
        txtUserName.BackColor = SystemColors.InactiveCaption;
        txtUserName.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        txtUserName.Location = new Point(240, 138);
        txtUserName.Name = "txtUserName";
        txtUserName.Size = new Size(123, 29);
        txtUserName.TabIndex = 2;
        // 
        // txtPassword
        // 
        txtPassword.BackColor = SystemColors.InactiveCaption;
        txtPassword.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        txtPassword.Location = new Point(240, 221);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(123, 29);
        txtPassword.TabIndex = 3;
        txtPassword.TextChanged += textBox2_TextChanged;
        // 
        // loginBtn
        // 
        loginBtn.BackColor = SystemColors.InactiveCaption;
        loginBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        loginBtn.Location = new Point(169, 301);
        loginBtn.Name = "loginBtn";
        loginBtn.Size = new Size(278, 48);
        loginBtn.TabIndex = 4;
        loginBtn.Text = "Login";
        loginBtn.UseVisualStyleBackColor = false;
        loginBtn.Click += loginBtn_Click;
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        passwordLabel.ForeColor = SystemColors.AppWorkspace;
        passwordLabel.Location = new Point(114, 224);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(80, 21);
        passwordLabel.TabIndex = 5;
        passwordLabel.Text = "Password:";
        // 
        // AdminLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.SandyBrown;
        ClientSize = new Size(578, 450);
        Controls.Add(passwordLabel);
        Controls.Add(loginBtn);
        Controls.Add(txtPassword);
        Controls.Add(txtUserName);
        Controls.Add(usernameLabel);
        Controls.Add(loginLabel);
        Name = "AdminLogin";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label loginLabel;
    private Label usernameLabel;
    private TextBox txtUserName;
    private TextBox txtPassword;
    private Button loginBtn;
    private Label passwordLabel;
}
