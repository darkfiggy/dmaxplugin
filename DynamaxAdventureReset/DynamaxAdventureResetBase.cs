using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PKHeX.Core;

using static PKHeX.Core.SCBlockUtil;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace DynamaxAdventureReset
{
    public class DynamaxAdventureResetBase : IPlugin
    {
        public string Name => "Sword/Shield Event Editor";
        
        public int Priority => 2;

        // Radix: TODO: Make this auto-increment
        public string VersionNumber = "1.2.1.0";


        // Initialized on plugin load
        public ISaveFileProvider SaveFileEditor { get; private set; } = null!;
        public IPKMView PKMEditor { get; private set; } = null!;


        public bool IsGameSwordShield
        {
            get
            {
                if (SaveFileEditor?.SAV is null)
                    return false;
                return SaveFileEditor.SAV.Version == GameVersion.SW || SaveFileEditor.SAV.Version == GameVersion.SH;
            }
        }


        public ToolStripMenuItem RootToolStripMenuItem { get; private set; } = null!;

        public ToolStripMenuItem SWSH_MainWorldEventsMenuItem { get; private set; } = null!;


        public void Initialize(params object[] args)
        {
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider);
            PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView);

            


            var menuToolStrip = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            LoadMenuStrip(menuToolStrip);


            // Radix: I won't remove this message, because it has some fond memories of programming in the living room, so please don't remove it <3

            //string localDirectory = Directory.GetParent(System.Reflection.Assembly.GetEntryAssembly().Location).ToString();

            //if (settings.Items["firstStart"] == "true")
            //{
            //    MessageBox.Show("Thank you for downloading the Dynamax Adventure Plugin!\nThis message box is here just to let you know that this plugin isn't perfect and we cannot promise you that your save will be 100% legal. However, we will try to improve as best we can!\n" +
            //        " ** We are not reponsible for any damage done to your save by this plugin. **", "First Time Opening", MessageBoxButtons.OK);
            //    settings.Items["firstStart"] = "false";
            //    settings.Write(dir);
            //}

            // END OF GENERIC NOSTALGIA
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
            RootToolStripMenuItem = new ToolStripMenuItem(Name);
            tools.DropDownItems.Add(RootToolStripMenuItem);


            //Do this quickly because they don't call the "Notify Save Change" function at startup
            RootToolStripMenuItem.Enabled = IsGameSwordShield;

            SWSH_MainWorldEventsMenuItem = new ToolStripMenuItem($"Base Game");


            foreach (var item in Assembly.GetCallingAssembly().GetManifestResourceNames())
            {
                Debug.WriteLine(item);
            }
            var main_worldEvents = new ToolStripMenuItem($"Edit World events");
            var ioa_worldevents = new ToolStripMenuItem($"Edit World events");
            var ct_worldevents = new ToolStripMenuItem($"Edit World events");

            var crownBTN = new ToolStripMenuItem($"Crown Tundra", Properties.Resources.crown);
            var armorBTN = new ToolStripMenuItem($"Isle of Armor", Properties.Resources.armor);


            var mlBTN = new ToolStripMenuItem($"Edit Max Lair");
            var regiBTN = new ToolStripMenuItem($"Edit Regis");
            var sojBTN = new ToolStripMenuItem($"Edit Swords of Justice");


            var wc8BTN = new ToolStripMenuItem("Convert Wondercard");

            var curryBTN = new ToolStripMenuItem("Edit Currydex/Pokecamp");

            var hlpBTN = new ToolStripMenuItem($"Help");

            main_worldEvents.Click += (s, e) => main_worldeventsBTN_Click(s, e);

            ioa_worldevents.Click += (s, e) => ioa_worldeventsBTN_Click(s, e);

            mlBTN.Click += (s, e) => mlBTN_Click(s, e);
            regiBTN.Click += (s, e) => regiBTN_Click(s, e);
            sojBTN.Click += (s, e) => sojBTN_Click(s, e);
            ct_worldevents.Click += (s, e) => ct_worldeventsBTN_Click(s, e);

            curryBTN.Click += (s, e) => curryBTN_Click(s, e);
            wc8BTN.Click += (s, e) => wc8BTN_Click(s, e);

            hlpBTN.Click += (s, e) => hlpBTN_Click(s, e);



            crownBTN.DropDownItems.Add(mlBTN);
            crownBTN.DropDownItems.Add(regiBTN);
            crownBTN.DropDownItems.Add(sojBTN);

            SWSH_MainWorldEventsMenuItem.DropDownItems.Add(main_worldEvents);
            armorBTN.DropDownItems.Add(ioa_worldevents);
            crownBTN.DropDownItems.Add(ct_worldevents);



            RootToolStripMenuItem.DropDownItems.Add(SWSH_MainWorldEventsMenuItem);
            RootToolStripMenuItem.DropDownItems.Add(armorBTN);
            RootToolStripMenuItem.DropDownItems.Add(crownBTN);
            RootToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            RootToolStripMenuItem.DropDownItems.Add(curryBTN);
            RootToolStripMenuItem.DropDownItems.Add(wc8BTN);
            RootToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            RootToolStripMenuItem.DropDownItems.Add(hlpBTN);
            Console.WriteLine($"{Name} added menu items.");


        }

        public void NotifySaveLoaded()
        {
            RootToolStripMenuItem.Enabled = IsGameSwordShield;
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
            using (HelpForm form = new HelpForm(VersionNumber))
                form.ShowDialog();
            

        }

        private void curryBTN_Click(object sender, EventArgs e)
        {
            using (Forms.PokeCampCurrydexForm form = new Forms.PokeCampCurrydexForm())
            {
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
                form.ShowDialog();
            }
        }
        private void wc8BTN_Click(object sender, EventArgs e)
        {
            using (Wonder2FashionForm form = new Wonder2FashionForm())
            {
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
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
            //using (SOJForm form = new SOJForm())
            //{
            //    SaveFileEditor.SAV.
            //    if (SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SH || SaveFileEditor.SAV.FileName == "Blank Save File")
            //    {
            //        var result = MessageBox.Show(
            //            $"The given save is null, or is not of Sword/Shield type. If you believe this to be a mistake, please contact the current repos maintainers.\nYou are running: {SaveFileEditor.SAV.Version}\nDo you wish to continue anyway?",
            //            $"Error",
            //            MessageBoxButtons.YesNo);
            //        if (result == DialogResult.No) return;
            //    }
            //    form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
            //    form.ShowDialog();
            //}
        }

        private void mlBTN_Click(object sender, EventArgs e)
        {
            using (DynamaxResetForm form = new DynamaxResetForm())
            {
                if (SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SH)
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
            //using (RegiForm form = new RegiForm())
            //{
            //    if (SaveFileEditor.SAV.Version != GameVersion.SW && SaveFileEditor.SAV.Version != GameVersion.SH || SaveFileEditor.SAV.FileName == "Blank Save File")
            //    {
            //        var result = MessageBox.Show(
            //            $"The given save is null, or is not of Sword/Shield type. If you believe this to be a mistake, please contact the current repos maintainers.\nYou are running: {SaveFileEditor.SAV.Version}\nDo you wish to continue anyway?",
            //            $"Error",
            //            MessageBoxButtons.YesNo);
            //        if (result == DialogResult.No) return;
            //    }
            //    form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
            //    form.ShowDialog();
            //}
        }
        #endregion
    }

}
