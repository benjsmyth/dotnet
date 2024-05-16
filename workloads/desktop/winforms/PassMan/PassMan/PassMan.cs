namespace PassMan
{
    public partial class PassMan : Form
    {
        public PassMan()
        {
            InitializeComponent();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Searching...";
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Editing...";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Loading...";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Saving...";
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Creating...";
        }

        private void destroyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Destroying...";
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Adding...";
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Removing...";
        }
    }
}
