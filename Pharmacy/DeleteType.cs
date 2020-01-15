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
    public partial class DeleteType : Form
    {
        private PharmacyEntities1 _db;
        private ComboBox _cmb;
        public DeleteType(ComboBox cmb)
        {
            _cmb = cmb;
            _db = new PharmacyEntities1();
            InitializeComponent();
        }

       

        private void DeleteType_Load(object sender, EventArgs e)
        {
            FillCmb(cmbDeleteType);
        }

        private async void btnDeleteType_Click(object sender, EventArgs e)
        {
            int slcted_item_id = ((CB_DrugType)cmbDeleteType.SelectedItem).Id;
            DrugType type = _db.DrugTypes.First(dt => dt.Id == slcted_item_id);
            type.Deleted = true;
            //_db.DrugTypes.Remove(type);
            await _db.SaveChangesAsync();
            MessageBox.Show($"{cmbDeleteType.Text} deleted");
            FillCmb(cmbDeleteType);
            FillCmb(_cmb);
            cmbDeleteType.Text = "";

        }

        private void FillCmb(ComboBox cmb)
        {
            cmb.Items.Clear();
            cmb.Items.AddRange(_db.DrugTypes.Where(dt => dt.Deleted == false).Select(dt => new CB_DrugType
            {
                Id = dt.Id,
                Name = dt.Name
            }).ToArray());
        }
    }
}
