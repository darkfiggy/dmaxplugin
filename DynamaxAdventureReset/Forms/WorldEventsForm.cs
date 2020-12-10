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
            SetupMain();
            SetupCrownTundra();
        }

        #region Main Game
        void SetupMain()
        {
            main_hours_NUD.Value = SAV.PlayedHours;
            main_minutes_NUD.Value = SAV.PlayedMinutes;
            main_seconds_NUD.Value = SAV.PlayedSeconds;

            main_tid_NUD.Value = SAV.TID;
            main_sid_NUD.Value = SAV.SID;

            main_trainername_TB.Text = SAV.OT;
            main_gender_CMB.SelectedIndex = SAV.Gender;
            main_game_CMB.SelectedIndex = SAV.Game - 45;

            main_money_NUD.Value = SAV.Money;

        }

        void SaveMain()
        {
            SAV.PlayedSeconds = (int)main_seconds_NUD.Value;
            SAV.PlayedMinutes = (int)main_minutes_NUD.Value;
            SAV.PlayedHours = (int)main_hours_NUD.Value;

            SAV.Game = (int)main_game_NUD.Value;
            SAV.Gender = (int)main_gender_NUD.Value;

            SAV.TID = (int)main_tid_NUD.Value;
            SAV.SID = (int)main_sid_NUD.Value;
            SAV.OT = main_trainername_TB.Text;
            SAV.Money = (uint)main_money_NUD.Value;
        }

        private void main_gender_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            main_gender_NUD.Value = main_gender_CMB.SelectedIndex;
        }

        private void main_game_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            main_game_NUD.Value = main_game_CMB.SelectedIndex + 45;
        }

        private void main_gender_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (main_gender_NUD.Value == 0 || main_gender_NUD.Value == 1)
            {
                main_gender_CMB.Enabled = true;
                main_gender_CMB.SelectedIndex = (int)main_gender_NUD.Value;
            }
            else
            {
                main_gender_CMB.Enabled = false;
            }
        }

        private void main_game_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (main_game_NUD.Value == 45 || main_game_NUD.Value == 46)
            {
                main_game_CMB.Enabled = true;
                main_game_CMB.SelectedIndex = (int)(main_game_NUD.Value - 45);

            }
            else
            {
                main_game_CMB.Enabled = false;
            }
        }

        private void main_trainer_forcelegal_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (main_trainer_forcelegal_CB.Checked)
            {
                if (!(main_game_NUD.Value == 45 || main_game_NUD.Value == 46))
                {
                    main_game_NUD.Value = SAV.Game;
                }

                if (!(main_gender_NUD.Value == 0 || main_gender_NUD.Value == 1))
                {
                    main_gender_NUD.Value = SAV.Gender;
                }
                main_gender_NUD.Enabled = false;
                main_game_NUD.Enabled = false;
            }
            else
            {
                main_gender_NUD.Enabled = true;
                main_game_NUD.Enabled = true;
            }
        }

        #endregion

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
            SaveMain();
            SaveCrownTundra();

            this.Close();
        }

    }
}
