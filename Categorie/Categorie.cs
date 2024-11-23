namespace Categorie
{
    public partial class Categorie : Form
    {
        public Categorie()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Data.txt", true);
            string strPerson = txtID.Text + ";"
                             + txtName.Text;
                            
            sw.WriteLine(strPerson);
            sw.Close();
            MessageBox.Show("Added Successfully ");
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            txtID.Focus();
        }
    }
}
