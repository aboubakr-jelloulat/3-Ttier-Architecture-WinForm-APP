using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Tier_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }

        private void _RefreshContactsList()
        {
            dgvAllContacts.DataSource = clsContact.GetAllContacts();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void dgvAllContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            FrmAddEditeContact frm = new FrmAddEditeContact(-1);
            frm.ShowDialog();
            _RefreshContactsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditeContact frm = new FrmAddEditeContact((int)dgvAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshContactsList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete contact [" + dgvAllContacts.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                
                if (clsContact.DeleteContact((int)dgvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshContactsList();
                }

                else
                    MessageBox.Show("Contact is not deleted.");

            }
        }
    }
}
