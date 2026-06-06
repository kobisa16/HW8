using System.Data;

namespace HW8_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Store myStore = new Store();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dgvItems.DataSource;

            myStore.Update(table);

            MessageBox.Show("מסד הנתונים עודכן בהצלחה!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(btnDelete.Text);
                DataTable updatedTable = myStore.DeleteItem(code);

                if (updatedTable != null)
                {
                    dgvItems.DataSource = updatedTable;
                    MessageBox.Show("הפריט נמחק מהתצוגה.");
                }
                else
                {
                    MessageBox.Show("הקוד לא נמצא.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("אנא הזן קוד תקין.");
            }
        }
    }
}

