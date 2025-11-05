using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phonebook
{
    public partial class Phonebook : Form
    {
        List<contacts> contacts = new List<contacts>
        {
            new contacts
            {
                id = 1,
                name = "sara",
                number = "09934653567",
                email="",
                address="",

            }
        };



        bool editing = false;
        int id = 0;

        public Phonebook()
        {
            InitializeComponent();
        }

        private void phonebook_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contacts.ToList();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            //newbutton
            if (!editing)
            {
               
                if (nametextBox.Text == string.Empty || numbertextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please enter name and number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;


                }
                if (numbertextBox.Text.Length != 11)
                {
                    MessageBox.Show("!شماره وارد شده باید 11 رقم باشد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int newid;
                try
                {
                    newid = contacts.OrderByDescending(a => a.id).FirstOrDefault().id;
                }

                catch (Exception)
                {
                    newid = 0;
                }






                contacts contact = new contacts()
                {
                    id = newid + 1,
                    name = nametextBox.Text,
                    number = numbertextBox.Text,
                    email = emailtextBox.Text,
                    address = addresstextBox.Text,

                };

                contacts.Add(contact);
            }




            else if (editing)
            {
                var qcontact = contacts.Where(a => a.id == id).FirstOrDefault();
                qcontact.name = nametextBox.Text;
                qcontact.number = numbertextBox.Text;
                qcontact.email = emailtextBox.Text;
                qcontact.address = addresstextBox.Text;

                editing = false;
            }

                cleardatas();
            dataGridView1.DataSource = contacts.ToList();

            }
            
        
        private void infodataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            //این خط کد داره شناسه (id) ردیف فعلی انتخاب شده در دیتاگرید ویو رو می‌گیره و به صورت عدد صحیح در متغیر id ذخیره می‌کنه.
            id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            //از لیست مخاطبین، اولین مخاطبی که شناسه‌اش برابر مقدار id است را پیدا کن و در متغیر qcontact ذخیره کن.
            var qcontact = contacts.Where(a => a.id == id).FirstOrDefault();
            if(qcontact != null)
            {
                nametextBox.Text = qcontact.name;
                numbertextBox.Text = qcontact.number;
                emailtextBox.Text = qcontact.email;
                addresstextBox.Text = qcontact.address;

                editing = true;
            }
        }
       private void cleardatas()
        {
            nametextBox.Text = string.Empty;
            numbertextBox.Text = string.Empty;
            emailtextBox.Text = string.Empty;
            addresstextBox.Text = string.Empty;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            var qcontact = contacts.Where(a => a.id == id).FirstOrDefault();

            if (contacts != null)
            {
                contacts.Remove(qcontact);
            }
            dataGridView1.DataSource = contacts.ToList();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string searchText = searchtextBox.Text.ToLower(); 

            var filteredContacts = contacts
                .Where(c => c.name.ToLower().Contains(searchText))
                .ToList();

            dataGridView1.DataSource = filteredContacts;
        }

        private void laodbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contacts.ToList();
            searchtextBox.Text = string.Empty;
        }

      
    }
}
