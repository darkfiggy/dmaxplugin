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
            var ctrl = new ToolStripMenuItem(Name);
            tools.DropDownItems.Add(ctrl);

            //var c2 = new ToolStripMenuItem($"{Name} sub form");
            //c2.Click += (s, e) => new Form().ShowDialog();
            //var c3 = new ToolStripMenuItem($"{Name} show message");
            //c3.Click += (s, e) => MessageBox.Show("Hello!");
            //var c4 = new ToolStripMenuItem($"Reset (all) Dynamax Adventures");


            ctrl.Click += (s, e) => unchecklairBTN_Click(s,e);

            //ctrl.DropDownItems.Add(c4);
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

        private void unchecklairBTN_Click(object sender, EventArgs e)
        {
            using (DynamaxResetForm form = new DynamaxResetForm())
            {
                form.SAV = (SAV8SWSH)SaveFileEditor.SAV;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }

            //var sav = SaveFileEditor.SAV;
            //var SAV = (SAV8SWSH)sav;
            ////Added by Lucas
            //foreach (var key in Lairkeys)
            //{
            //    var block = SAV.Blocks.GetBlock(key);
            //    //var cType = block.Type;
            //    //var cValue = SCTypeCode.Bool1;
            //    block.Type = SCTypeCode.Bool1;
               
            //    //if (cType == cValue)
            //    //    return;
            //    //block.Type = cValue;
            //    //UpdateBlockSummaryControls();


            //}

        }

    }    
}
