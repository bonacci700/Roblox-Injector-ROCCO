using WeAreDevs_API;
namespace Rocco_s_Roblox_Injector_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ExploitAPI api = new ExploitAPI();

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            api.SendLuaCScript(richTextBox1.Text);
            api.SendLuaScript(richTextBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.DoBTools();
        }

        private void forceFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.AddForcefield();
        }

        private void jumpPowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.SetJumpPower(100);
        }

        private void fireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.AddFire();
        }

        private void smokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.AddSmoke();
        }

        private void clickTeleportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.ToggleClickTeleport();
        }

        private void injectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void injectedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creditsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}