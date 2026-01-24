using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBall_CityDB_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSortAscPop_Click(object sender, EventArgs e)
        {
            try
            {
                //sorts by population ascending
                this.cityTableAdapter.FillByPopulationAsc(this.cityDBDataSet.City);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sorted data: " + ex.Message);
            }
        }

        private void btnSortDescPop_Click(object sender, EventArgs e)
        {
            try
            {
                //sorts by population Descending
                this.cityTableAdapter.FillByPopulationDesc(this.cityDBDataSet.City);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sorted data: " + ex.Message);
            }
        }

        private void btnSrtNameAsc_Click(object sender, EventArgs e)
        {
            try
            {
                //sorts by City Name ascending
                this.cityTableAdapter.FillByCityName(this.cityDBDataSet.City);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sorted data: " + ex.Message);
            }
        }

        private void btnSrtNameDec_Click(object sender, EventArgs e)
        {
            try
            {
                //sorts by City name Descending
                this.cityTableAdapter.FillByCityNameDec(this.cityDBDataSet.City);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sorted data: " + ex.Message);
            }
        }

        private void btnAvgPop_Click(object sender, EventArgs e)
        {
            //get average population

            double? total = cityTableAdapter.GetAveragePopulation();

            if (total.HasValue)
            {
                MessageBox.Show("Average population: " + total.Value.ToString("N2"));
            }
            else
            {
                MessageBox.Show("Trevor made a mistake");
            }
        }

        private void btnMinPop_Click(object sender, EventArgs e)
        {
            //get min population

            double? total = cityTableAdapter.GetMinPopulation();

            if (total.HasValue)
            {
                MessageBox.Show("Minimum population: " + total.Value.ToString("N0"));
            }
            else
            {
                MessageBox.Show("Trevor made a mistake");
            }
        }

        private void btnTotPop_Click(object sender, EventArgs e)
        {
            //get total population

            double? total = cityTableAdapter.GetTotalPopulation();

            if (total.HasValue)
            {
                MessageBox.Show("Total population: " + total.Value.ToString("N0"));
            }
            else
            {
                MessageBox.Show("Trevor has messed up again!");
            }
        }

        private void btnMaxPop_Click(object sender, EventArgs e)
        {

            //get max population

            double? total = cityTableAdapter.GetMaxPopulation();

            if (total.HasValue)
            {
                MessageBox.Show("Maximum population: " + total.Value.ToString("N0"));
            }
            else
            {
                MessageBox.Show("Trevor made a mistake");
            }
        }
    }
}
