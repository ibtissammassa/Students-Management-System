using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_etudiants
{
    public partial class StudentsData : Form
    {
        public StudentsData()
        {
            InitializeComponent();
        }

        public void LoadData(DataTable data)
        {
            dataGridView1.DataSource = data;
        }
    }
}
