using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKHeX.Core;

namespace DynamaxAdventureReset
{
    public partial class WorldEventsForm : Form
    {
        public enum Pages { Main, IsleOfArmor, CrownTundra }
        public SAV8SWSH SAV;
        public WorldEventsForm(Pages StartingPage)
        {
            InitializeComponent();
            switch (StartingPage)
            {
                case (Pages.Main):
                    tabControl1.SelectedIndex = 0;
                    break;
                case (Pages.IsleOfArmor):
                    tabControl1.SelectedIndex = 1;
                    break;
                case (Pages.CrownTundra):
                    tabControl1.SelectedIndex = 2;
                    break;
            }

        }

        private void WorldEvents_Load(object sender, EventArgs e)
        {
            SetupCrownTundra();
        }

        #region Crown Tundra
        void SetupCrownTundra()
        {
            //Setup Birds
            ct_garticuno_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Articuno"]).Type == SCTypeCode.Bool2 ? true : false;
            ct_gzapdos_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Zapdos"]).Type == SCTypeCode.Bool2 ? true : false;
            ct_gmoltres_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Moltres"]).Type == SCTypeCode.Bool2 ? true : false;

            //Setup Cosmog
            ct_giftcosmog_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["z_wr0301_i0401_COSMOG"]).Type == SCTypeCode.Bool2 ? true : false;


        }

        void SaveCrownTundra()
        {
            var b_garticuno = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Articuno"]);
            var b_gzapdos = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Zapdos"]);
            var b_gmoltres = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Moltres"]);

            var b_giftcosmog = SAV.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["z_wr0301_i0401_COSMOG"]);

            b_garticuno.Type = ct_garticuno_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1;
            b_gzapdos.Type = ct_gzapdos_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1;
            b_gmoltres.Type = ct_gmoltres_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1;

            b_giftcosmog.Type = ct_giftcosmog_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1;


        }


        private void ct_birds_caughtBTN_Click(object sender, EventArgs e)
        {
            ct_garticuno_PB.Caught = true;
            ct_gzapdos_PB.Caught = true;
            ct_gmoltres_PB.Caught = true;
        }

        private void ct_birds_uncaughtBTN_Click(object sender, EventArgs e)
        {
            ct_garticuno_PB.Caught = false;
            ct_gzapdos_PB.Caught = false;
            ct_gmoltres_PB.Caught = false;
        }

        #endregion

        private void ts_applyBTN_Click(object sender, EventArgs e)
        {
            SaveCrownTundra();

            this.Close();
        }
    }
}
