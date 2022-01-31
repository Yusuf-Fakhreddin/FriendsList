using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendsList
{
    public partial class Form1 : Form
    {
        List<String> myFriends = new List<String>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
        }

        private void btn_addFriend_Click(object sender, EventArgs e)
        {
            myFriends.Add(txt_newFriend.Text);
            listBox1.DataSource=bs;
            bs.ResetBindings(false);
            label1.Text = myFriends.Count + (myFriends.Count > 1 ? " Friends":" Friend");
            txt_newFriend.Clear();  
            txt_newFriend.Focus();
        }

        List<String> fiveFriends = new List<String>() { "Modric" , "Kroos" , "Messi" , "Ronaldo" , "Benzema" };
        private void btn_addFive_Click(object sender, EventArgs e)
        {
            foreach (string friend in fiveFriends)
            {
                myFriends.Add(friend);
                listBox1.DataSource = bs;
                bs.ResetBindings(false);
                label1.Text = myFriends.Count + (myFriends.Count > 1 ? " Friends" : " Friend");
            }
        }

        private void btn_asc_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bs.ResetBindings(false);
            lbl_sort.Text = "Sorted in ascending order";
        }

        private void btn_desc_Click(object sender, EventArgs e)
        {
            myFriends.Sort((a, b) => b.CompareTo(a));
            bs.ResetBindings(false);
            lbl_sort.Text = "Sorted in descending order";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            myFriends.Clear();
            bs.ResetBindings(false);
            txt_newFriend.Clear();
            label1.Text = "0 Friends";
        }
    }
}
