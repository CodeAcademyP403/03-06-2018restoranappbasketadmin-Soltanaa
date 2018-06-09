using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RestoranOrderSystem
{
    public partial class Form1 : Form
    {
        private AdminForm _Form;
        public Form1(AdminForm adminForm):this()
        {
            _Form = adminForm;
        }

        public Form1()

        {
            InitializeComponent();
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbx_Category.DataSource = Enum.GetValues(typeof(ProductCategory));

        }

        
        //ArrayList MyArrayList = new ArrayList();

        List<Product> list = new List<Product>();
        

        public void MakeFood()
        {
            list.AddRange(new Product[]
            {
                new Product{Name = "Kabab",Count = 2,ProductCategory= ProductCategory.MainFoods},
                new Product{Name = "Sezar",Count = 5,ProductCategory= ProductCategory.Salats},
                new Product{Name = "Cola",Count = 12,ProductCategory= ProductCategory.Drinks},
                new Product{Name = "Merci",Count = 2,ProductCategory= ProductCategory.Soups}

            });
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbx_Name.Text="";//cmbx_Name metnini sil,ve elave et basket systemi duzeldib ora.
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbx_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeFood();

            string selectedvalue = (sender as ComboBox).SelectedItem.ToString();
            ProductCategory selectingcategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), selectedvalue);
            cmbx_Name.Items.Clear();

            foreach (Product item in list)
            {
                if (item.ProductCategory == selectingcategory)
                {
                    cmbx_Name.Items.Clear();
                    cmbx_Name.Items.Add(item.Name);
                }

            }

        }

       
    }
}
