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
    public partial class RegiForm : Form
    {
        public RegiForm()
        {
            InitializeComponent();
        }

        public SAV8SWSH SAV;

        private void RegiForm_Load(object sender, EventArgs e)
        {
            //Check Regi values
            for (int i = 0; i < Definitions.RegiKeys.Length - 2; i++) //-2 so we do all of them except for Regieleki and regidrago
            {
                if (SAV.Blocks.GetBlock(Definitions.RegiKeys[i]).Type == SCTypeCode.Bool2) regi_clistbox.SetItemChecked(i, true);

            }

            forcematchCB.Checked = true;


            var eleki = SAV.Blocks.GetBlock(Definitions.RegiKeys[4]);
            var drago = SAV.Blocks.GetBlock(Definitions.RegiKeys[5]);
            var pattern = SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern);


            if (eleki.Type == SCTypeCode.Bool2) //Regieleki
            {
                regieleki_RBTN.Checked = true;
                //Check if the pattern provided by the player matches the regi
                if (Convert.ToInt32(pattern.GetValue()) != 1) // 1 = regieleki pattern
                {
                    if (ShowPatternMisMatchMSG() == DialogResult.Yes) pattern.SetValue((UInt32)1);
                    else forcematchCB.Checked = false;
                }
            }

            if (drago.Type == SCTypeCode.Bool2) //Regidrago
            {
                regidrago_RBTN.Checked = true;
                //Check if the pattern provided by the player matches the regi
                if (Convert.ToInt32(pattern.GetValue()) != 2) // 2 = regidrago pattern
                {
                    if (ShowPatternMisMatchMSG() == DialogResult.Yes) pattern.SetValue((UInt32)2);
                    else forcematchCB.Checked = false;

                }
            }

            MatchRegiPattern();
            regipatternNUD.Value = Convert.ToInt32(pattern.GetValue());

        }


        /// <summary>
        /// Match the regi (drago or eleki or neither) to the pattern value
        /// </summary>
        void MatchRegiPattern()
        {

            if (regieleki_RBTN.Checked)
            {
                regieleki_patrBTN.Checked = true;
            }
            else if (regidrago_RBTN.Checked)
            {
                regidrago_patrBTN.Checked = true;
            }


        }

        DialogResult ShowPatternMisMatchMSG()
        {
            return MessageBox.Show($"Discrepancy detected with the Regi received and the pattern required for it.\nDo you wish to autocorrect this?", "Error", MessageBoxButtons.YesNo);
        }

        private void regiother_patrBTN_CheckedChanged(object sender, EventArgs e)
        {
            regipatternNUD.Enabled = regiother_patrBTN.Checked;
        }

        private void reginone_patrBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (forcematchCB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regidrago_patrBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (forcematchCB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regieleki_patrBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (forcematchCB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regipatternNUD_ValueChanged(object sender, EventArgs e)
        {
            if (forcematchCB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        void CheckLegality()
        {
            if (regidrago_patrBTN.Checked && regidrago_RBTN.Checked || reginone_RBTN.Checked && regidrago_patrBTN.Checked || regidrago_RBTN.Checked && regipatternNUD.Value == 2)
            {
                legalLBL.Text = "Legal Status: Legal!";
            }
            else if (regieleki_patrBTN.Checked && regieleki_RBTN.Checked || reginone_RBTN.Checked && regieleki_patrBTN.Checked || regieleki_RBTN.Checked && regipatternNUD.Value == 1)
            {
                legalLBL.Text = "Legal Status: Legal!";
            }
            else
            {
                if (reginone_RBTN.Checked && reginone_patrBTN.Checked)
                {
                    legalLBL.Text = "Legal Status: Legal!";
                }
                else
                {

                    legalLBL.Text = "Legal Status: Potentially Illegal!";
                }

            }
        }


        private void reginone_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (forcematchCB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regidrago_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (forcematchCB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void regieleki_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (forcematchCB.Checked) MatchRegiPattern();
            CheckLegality();
        }


        private void forcematchCB_CheckedChanged(object sender, EventArgs e)
        {
            if (forcematchCB.Checked) MatchRegiPattern();
            CheckLegality();
        }

        private void applyBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Definitions.RegiKeys.Length - 2; i++) //do all except for eleki and drago
            {
                SAV.Blocks.GetBlock(Definitions.RegiKeys[i]).Type = regi_clistbox.GetItemChecked(i) ? SCTypeCode.Bool2 : SCTypeCode.Bool1;
            }

            SAV.Blocks.GetBlock(Definitions.RegiKeys[4]).Type = regieleki_RBTN.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1;
            SAV.Blocks.GetBlock(Definitions.RegiKeys[5]).Type = regidrago_RBTN.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1;

            //If you don't cast the int, you will get an exeception that will crash the plugin.
            if (regieleki_patrBTN.Checked) SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)1);
            else if (regidrago_patrBTN.Checked) SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)2);
            else if (reginone_patrBTN.Checked) SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)0);
            else SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)regipatternNUD.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
