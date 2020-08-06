using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeesApplication
{
    public partial class MainForm : Form
    {

        private List<Bee> _bees;

        public MainForm()
        {
            _bees = new List<Bee>();

            for (int i = 0; i < 10; i++)
            {
                _bees.Add(new WorkerBee());
            }


            for (int i = 0; i < 10; i++)
            {
                _bees.Add(new QueenBee());
            }


            for (int i = 0; i < 10; i++)
            {
                _bees.Add(new DroneBee());
            }

            InitializeComponent();
            UpdateListView();
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (Bee bee in _bees)
            {
                bee.Damage(random.Next(0, 80));
            }

            UpdateListView();
        }

        private void UpdateListView()
        {
            BeeListView.Items.Clear();
            
            foreach (Bee bee in _bees)
            {
                ListViewItem beeItem = new ListViewItem(bee.ToString());
                BeeListView.Items.Add(beeItem);
            }
        }
    }
}
