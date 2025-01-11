using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using LogicLayer;

namespace CSharpLayeredArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void List()
        {
            List<EntityPersonel> PersonList = LogicPersonel.logicLayerPersonelLst();
            dataGridView1.DataSource = PersonList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EntityPersonel entity = new EntityPersonel();
            entity.Ad = TxtAd.Text;
            entity.Soyad = TxtSoya.Text;
            entity.Sehir = TxtSehir.Text;
            entity.Görev = TxtGörev.Text;
            entity.Maas = short.Parse(TxtMaas.Text);
            LogicPersonel.logicLayerAddPersonel(entity);
            List();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel entity = new EntityPersonel();
            entity.Id = Convert.ToInt32(TextId.Text);
            LogicPersonel.logicLayerRemovePersonel(entity.Id);
        }
    }
}
