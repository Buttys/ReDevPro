
using CefSharp;
using ReDevPro.Components;
using System;
using System.Windows.Forms;

namespace ReDevPro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Cef.EnableHighDPISupport();
            Cef.Initialize(new CefSettings()); //required for cefsharp to work, only needs to be called once

            //Add web tabs
            WebTab Chat = new WebTab("https://discord.gg/zUqJTYP") { Text = "Chat" };
            WebTab News = new WebTab("https://ygodevpro.com/index.php/NewsOverview/") { Text = "News" };
            WebTab BugTracker = new WebTab("https://ygodevpro.com/forum/bugs/") { Text = "BugTracker" };
            IntPtr h = MainTabControl.Handle; //required for insert to work
            MainTabControl.TabPages.Insert(0, Chat);
            MainTabControl.TabPages.Insert(1, News);
            MainTabControl.TabPages.Insert(2, BugTracker);
            MainTabControl.SelectedIndex = 0;

            //Server Select
            ServerSelect.Items.Add("LocalHost");
            ServerSelect.SelectedIndex = 0;

            //options
            AddOptions();
            YGOProOptionsControl.ItemCheck += UpdateOptions;
        }

        private void AddOptions()
        {
            YGOProOptionsControl.Items.Add("Auto Placement", Config.GetBool("Auto Placement", true));
            YGOProOptionsControl.Items.Add("Auto Chain", Config.GetBool("Auto Chain", true));
            YGOProOptionsControl.Items.Add("Random Placement", Config.GetBool("Auto-Placement", false));
            YGOProOptionsControl.Items.Add("Enable User Covers", Config.GetBool("Enable User Covers", true));
            YGOProOptionsControl.Items.Add("No Chain Delay", Config.GetBool("No Chain Delay", false));
            YGOProOptionsControl.Items.Add("Mute Opponents", Config.GetBool("Mute Opponents", false));
            YGOProOptionsControl.Items.Add("Mute Spectators", Config.GetBool("Mute Spectators", false));
            YGOProOptionsControl.Items.Add("Save Last Replay", Config.GetBool("Save Last Replay", true));
            YGOProOptionsControl.Items.Add("Mouse Mode", Config.GetBool("Mouse Mode", false));
            YGOProOptionsControl.Items.Add("Hide Setnames", Config.GetBool("Hide Setnames", false));
            YGOProOptionsControl.Items.Add("Hide Chain Buttons", Config.GetBool("Hide Chain Buttons", false));
            YGOProOptionsControl.Items.Add("Old Replay Mode", Config.GetBool("Old Replay Mode", true));
            YGOProOptionsControl.Items.Add("Enable Sound", Config.GetBool("Enable Sound", true));
            YGOProOptionsControl.Items.Add("Enable Music", Config.GetBool("Enable Music", true));
            YGOProOptionsControl.Items.Add("Enable Direct X", Config.GetBool("Enable Direct X", false));
        }

        private void UpdateOptions(object sender, ItemCheckEventArgs e)
        {
            Config.UpdateBool(YGOProOptionsControl.SelectedItem.ToString(), e.NewValue == CheckState.Checked);
        }

        private void DeckEditBtn_Click(object sender, EventArgs e)
        {
            YGOProHelper.OpenDeckEdit();
        }

        private void ReplayBtn_Click(object sender, EventArgs e)
        {
            YGOProHelper.OpenReplays();
        }

        private void AiBtn_Click(object sender, EventArgs e)
        {
            YGOProHelper.OpenAI();
        }
    }
}
