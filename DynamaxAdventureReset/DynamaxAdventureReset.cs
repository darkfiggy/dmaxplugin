using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PKHeX.Core;
using PKHeX.WinForms;
using static PKHeX.Core.SCBlockUtil;

namespace DynamaxAdventureReset
{
    public class DynamaxAdventureReset : IPlugin
    {
        public string Name => nameof(DynamaxAdventureReset);
        
        public int Priority => 2;

        // Initialized on plugin load
        public ISaveFileProvider SaveFileEditor { get; private set; } = null!;
        public IPKMView PKMEditor { get; private set; } = null!;

        public void Initialize(params object[] args)
        {
            Console.WriteLine($"Loading {Name}...");
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider);
            PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView);
            var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            LoadMenuStrip(menu);
        }

        private void LoadMenuStrip(ToolStrip menuStrip)
        {
            var items = menuStrip.Items;
            if (!(items.Find("Menu_Tools", false)[0] is ToolStripDropDownItem tools))
                throw new ArgumentException(nameof(menuStrip));
            AddPluginControl(tools);
        }

        private void AddPluginControl(ToolStripDropDownItem tools)
        {
            var ctrl = new ToolStripMenuItem("Block Editor EX");
            tools.DropDownItems.Add(ctrl);

            var mainBTN = new ToolStripMenuItem($"Edit Max Lair");
            var regiBTN = new ToolStripMenuItem($"Edit Regis");
            var sojBTN = new ToolStripMenuItem($"Edit Swords of Justice");
            var hlpBTN = new ToolStripMenuItem($"Help");

            mainBTN.Click += (s, e) => mainBTN_Click(s, e);
            regiBTN.Click += (s, e) => regiBTN_Click(s, e);
            sojBTN.Click += (s, e) => sojBTN_Click(s, e);
            hlpBTN.Click += (s, e) => hlpBTN_Click(s, e);

            ctrl.DropDownItems.Add(mainBTN);
            ctrl.DropDownItems.Add(regiBTN);
            ctrl.DropDownItems.Add(sojBTN);
            ctrl.DropDownItems.Add(hlpBTN);

            Console.WriteLine($"{Name} added menu items.");
        }

        public void NotifySaveLoaded()
        {
            Console.WriteLine($"{Name} was notified that a Save File was just loaded.");
        }

        private void ModifySaveFile()
        {
            var sav = SaveFileEditor.SAV;
            //sav.ModifyBoxes(ModifyPKM);
            SaveFileEditor.ReloadSlots();
        }

        public bool TryLoadFile(string filePath)
        {
            Console.WriteLine($"{Name} was provided with the file path, but chose to do nothing with it.");
            return false; // no action taken
        }
        private void hlpBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To report any bugs or issues, or to suggest features please contact the maintainers on Discord at \"Reshiquori#8124\" and \" Darthfiggy#9205\"", "Help");
        }
        private void sojBTN_Click(object sender, EventArgs e)
        {
            using (SOJForm form = new SOJForm())
            {
                if (SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SH || SaveFileEditor.SAV.FileName == "Blank Save File")
                {
                    var result = MessageBox.Show(
                        $"The given save is null, or is not of Sword/Shield type. If you believe this to be a mistake, please contact the current repos maintainers.\nYou are running: {SaveFileEditor.SAV.Version}\nDo you wish to continue anyway?",
                        $"Error",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;
                }
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
                form.ShowDialog();
            }
        }

        private void mainBTN_Click(object sender, EventArgs e)
        {
            using (DynamaxResetForm form = new DynamaxResetForm())
            {
                if (SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SH || SaveFileEditor.SAV.FileName == "Blank Save File")
                {
                    var result = MessageBox.Show(
                        $"The given save is null, or is not of Sword/Shield type. If you believe this to be a mistake, please contact the current repos maintainers.\nYou are running: {SaveFileEditor.SAV.Version}\nDo you wish to continue anyway?",
                        $"Error",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;
                }
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
                form.ShowDialog();
            }
        }
        private void regiBTN_Click(object sender, EventArgs e)
        {
            using (RegiForm form = new RegiForm())
            {
                if (SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SH || SaveFileEditor.SAV.FileName == "Blank Save File")
                {
                    var result = MessageBox.Show(
                        $"The given save is null, or is not of Sword/Shield type. If you believe this to be a mistake, please contact the current repos maintainers.\nYou are running: {SaveFileEditor.SAV.Version}\nDo you wish to continue anyway?",
                        $"Error",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;
                }
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
                form.ShowDialog();
            }
        }
    }    

}
