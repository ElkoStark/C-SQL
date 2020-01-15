using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class CreateType : Form
    {
        private PharmacyEntities1 _db;
        private ComboBox _cmb;
        public CreateType(ComboBox cmb)
        {
            _cmb = cmb;
            _db = new PharmacyEntities1();
            InitializeComponent();
        }

        private async void btnCreateType_Click(object sender, EventArgs e)
        {
            string name = txtCreateTypeName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Fill all input");
                return;
            }
            if (_db.DrugTypes.Any(t=> t.Name == name)) 
            {
                
                    MessageBox.Show($"{name} already is exist");
                    return;
                
                
                
            }
            
            DrugType newType = new DrugType() { Name = name };
            _db.DrugTypes.Add(newType);
            await _db.SaveChangesAsync();
            _cmb.Items.Clear();
            _cmb.Items.AddRange(_db.DrugTypes.Select(dt => new CB_DrugType
            {
                Id = dt.Id,
                Name = dt.Name
            }).ToArray());
            MessageBox.Show($"{name} successfull added");
            txtCreateTypeName.Text = "";
        }
    }
}
