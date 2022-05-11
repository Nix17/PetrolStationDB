using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;

namespace PetrolStationDB
{
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();
        }
        Point lastPoint;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Sienna;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.SeaGreen;
        }

        #region Перемещение окна
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void loginBtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show(DateTime.Now.ToString());
        }
    }
}