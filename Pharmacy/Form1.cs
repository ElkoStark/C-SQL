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
    public partial class Form1 : Form
    {
        private PharmacyEntities1 _db;
        public Form1()
        {
            _db = new PharmacyEntities1();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.DataSource = _db.Drugs.Select(d=>new 
            { 
            d.Id,
            d.Name,
            d.Price,
            d.DrugCount,
            Type = d.DrugType.Name
            }).ToList();

            cmbDragType.Items.AddRange(_db.DrugTypes.Where(dt=>dt.Deleted == false).Select(dt=> new CB_DrugType 
            {
                Id = dt.Id,
                Name = dt.Name
            } ).ToArray());
        }

        private void cmbDragType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_item_id = ((CB_DrugType)cmbDragType.SelectedItem).Id;
            dgv.DataSource = _db.Drugs.Where(d => d.TypeId == selected_item_id).Select(d => new
            {
                d.Id,
                d.Name,
                d.Price,
                d.DrugCount,
                Type = d.DrugType.Name
            }).ToList();

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateType createType = new CreateType(cmbDragType);
            createType.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteType deleteType = new DeleteType(cmbDragType);
            deleteType.ShowDialog();
        }
    }
}
