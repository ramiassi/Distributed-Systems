using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChatClient.ServiceChatReference;

namespace ChatClient
{
    public partial class FormChatClient : Form
    {
        public FormChatClient()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ServiceChatClient proxy = new ServiceChatClient();

            if (!proxy.LoginUser(new UserType { UserName = textBoxUser.Text }))
            { MessageBox.Show("Login failed, please try again!");}
            else
            {
                timer1.Enabled = true;
                textBoxUser.Enabled = false;
            }            

            proxy.Close();

        }
        
        private UserType[] onlineUsers;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ServiceChatClient proxy = new ServiceChatClient();
            
            // Get Online Users
            onlineUsers = proxy.GetOnlineUsers();
            listBoxOnlineUsers.DataSource = onlineUsers;
            listBoxOnlineUsers.DisplayMember = "UserName";

            // Get Messages to logged in user
            listBoxMessages.DataSource = proxy.RecieveMessages(new UserType { UserName = textBoxUser.Text });
            listBoxMessages.DisplayMember = "Text";

            proxy.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            ServiceChatClient proxy = new ServiceChatClient();

            if (proxy.LogoutUser(new UserType { UserName = textBoxUser.Text }))
            {
                timer1.Enabled = false;
                listBoxOnlineUsers.DataSource = null;
                listBoxMessages.DataSource = null;
                textBoxUser.Enabled = true;
            }
            else
            {
                MessageBox.Show("Logout failed, try again!");
            }

            proxy.Close();
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            if (comboBoxOnlineUsers.SelectedValue == null)
            {
                MessageBox.Show("Select message destination first");
            }
            else
            {
                ServiceChatClient proxy = new ServiceChatClient();

                proxy.SendMessage(
                    new UserType { UserName = "Me" },
                    new UserType { UserName = textBoxUser.Text },
                    textBoxMessage.Text);

                proxy.SendMessage(
                    new UserType { UserName = textBoxUser.Text },
                    new UserType { UserName = ((UserType)comboBoxOnlineUsers.SelectedValue).UserName },
                    textBoxMessage.Text);

                proxy.Close();

                textBoxMessage.Text = string.Empty;
            }
        }

        private void comboBoxOnlineUsers_DropDown(object sender, EventArgs e)
        {
            comboBoxOnlineUsers.DataSource = listBoxOnlineUsers.DataSource;
            comboBoxOnlineUsers.DisplayMember = listBoxOnlineUsers.DisplayMember;
        }
    }
}
