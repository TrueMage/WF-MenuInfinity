namespace WF_MenuInfinity
{
    public partial class Form1 : Form
    {
        private int count = 2;
        public Form1()
        {
            InitializeComponent();
        }
        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem parent = sender as ToolStripMenuItem;

            ToolStripMenuItem newitem = new ToolStripMenuItem();
            newitem.Text = (count++).ToString();
            newitem.MouseHover += new EventHandler(toolStripMenuItem1_MouseHover);
            parent.DropDownItems.Add(newitem);
            parent.ShowDropDown();
        }
    }
}