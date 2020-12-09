using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PKHeX.Core;
using PKHeX.WinForms;
using static PKHeX.Core.SCBlockUtil;
using System.IO;

namespace DynamaxAdventureReset
{
    public class DynamaxAdventureResetBase : IPlugin
    {
        public string Name => nameof(DynamaxAdventureReset);
        
        public int Priority => 2;

        // Initialized on plugin load
        public ISaveFileProvider SaveFileEditor { get; private set; } = null!;
        public IPKMView PKMEditor { get; private set; } = null!;
        Settings settings = new Settings();


        string VersionNum = "1.1.2.0";
        public void Initialize(params object[] args)
        {
            Console.WriteLine($"Loading {Name}...");
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider);
            PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView);
            var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            LoadMenuStrip(menu);

            string dir = Directory.GetParent(System.Reflection.Assembly.GetEntryAssembly().Location).ToString();

            if (!File.Exists($"{dir}\\DynamaxAdventureReset.cfg"))
                settings.Write(dir);
            settings.Read(dir);
            if (settings.Items["firstStart"] == "true")
            {
                MessageBox.Show("Thank you for downloading the Dynamax Adventure Plugin!\nThis message box is here just to let you know that this plugin isn't perfect and we cannot promise you that your save will be 100% legal. However, we will try to improve as best we can!\n" +
                    " ** We are not reponsible for any damage done to your save by this plugin. **", "First Time Opening", MessageBoxButtons.OK);
                settings.Items["firstStart"] = "false";
                settings.Write(dir);
            }

            if (settings.Items["latest"] != VersionNum)
            {
                settings.Write(dir);
            }
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
            var ctrl = new ToolStripMenuItem(Name);
            tools.DropDownItems.Add(ctrl);

            if (SaveFileEditor.SAV.Version == GameVersion.SW || SaveFileEditor.SAV.Version == GameVersion.SH)
            { 
                var mainBTN = new ToolStripMenuItem($"Base Game");
                if (SaveFileEditor.SAV.Version == GameVersion.SW)
                {
                    mainBTN.Image = Properties.Resources.sword;
                }
                else if (SaveFileEditor.SAV.Version == GameVersion.SH)
                {
                    mainBTN.Image = Properties.Resources.shield;
                }


                var main_worldevents = new ToolStripMenuItem($"Edit World events");
                var ioa_worldevents = new ToolStripMenuItem($"Edit World events");
                var ct_worldevents = new ToolStripMenuItem($"Edit World events");

                var crownBTN = new ToolStripMenuItem($"Crown Tundra", Properties.Resources.crown);
                var armorBTN = new ToolStripMenuItem($"Isle of Armor", Properties.Resources.armor);


                var mlBTN = new ToolStripMenuItem($"Edit Max Lair");
                var regiBTN = new ToolStripMenuItem($"Edit Regis");
                var sojBTN = new ToolStripMenuItem($"Edit Swords of Justice");



                var hlpBTN = new ToolStripMenuItem($"Help");

                main_worldevents.Click += (s, e) => main_worldeventsBTN_Click(s, e);

                ioa_worldevents.Click += (s, e) => ioa_worldeventsBTN_Click(s, e);

                mlBTN.Click += (s, e) => mlBTN_Click(s, e);
                regiBTN.Click += (s, e) => regiBTN_Click(s, e);
                sojBTN.Click += (s, e) => sojBTN_Click(s, e);
                ct_worldevents.Click += (s, e) => ct_worldeventsBTN_Click(s, e);

                hlpBTN.Click += (s, e) => hlpBTN_Click(s, e);



                crownBTN.DropDownItems.Add(mlBTN);
                crownBTN.DropDownItems.Add(regiBTN);
                crownBTN.DropDownItems.Add(sojBTN);

                mainBTN.DropDownItems.Add(main_worldevents);
                armorBTN.DropDownItems.Add(ioa_worldevents);
                crownBTN.DropDownItems.Add(ct_worldevents);



                ctrl.DropDownItems.Add(mainBTN);
                ctrl.DropDownItems.Add(armorBTN);
                ctrl.DropDownItems.Add(crownBTN);
                ctrl.DropDownItems.Add(new ToolStripSeparator());
                ctrl.DropDownItems.Add(hlpBTN);
                Console.WriteLine($"{Name} added menu items.");
            }
            else
            {
                ctrl.Enabled = false;
            }

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
            using (HelpForm form = new HelpForm(VersionNum))
            {
                form.ShowDialog();
            }

        }
        private void main_worldeventsBTN_Click(object sender, EventArgs e)
        {
            using (WorldEventsForm form = new WorldEventsForm(WorldEventsForm.Pages.Main))
            {
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
                form.ShowDialog();
            }
        }

        private void ioa_worldeventsBTN_Click(object sender, EventArgs e)
        {
            using (WorldEventsForm form = new WorldEventsForm(WorldEventsForm.Pages.IsleOfArmor))
            {
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
                form.ShowDialog();
            }
        }
        #region Crown Tundra buttons
        private void ct_worldeventsBTN_Click(object sender, EventArgs e)
        {
            using (WorldEventsForm form = new WorldEventsForm(WorldEventsForm.Pages.CrownTundra))
            {
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
                form.ShowDialog();
            }
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

        private void mlBTN_Click(object sender, EventArgs e)
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
        #endregion
    }

}
