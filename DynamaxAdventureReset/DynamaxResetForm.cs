using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKHeX.Core;
using System.Windows.Forms;
using PKHeX.WinForms;
using static PKHeX.Core.SCBlockUtil;

namespace DynamaxAdventureReset
{
    public partial class DynamaxResetForm : Form
    {
        public DynamaxResetForm()
        {
            InitializeComponent();
        }

        public SAV8SWSH SAV;

        public uint KRegielekiOrRegidragoPattern = 0xCF90B39A;

        public uint[] RegiKeys = new uint[]
        {
            0xEE3F84E6, //Regirock
            0xDAB3DD3A, //Regice
            0xEE1FD86E, //Registeel
            0xC4308A93, //Regigigas

            0x4F4AEC32, //Regieleki
            0x4F30F174 //Regidrago
        };

        public uint[] Gen1Keys = new uint[]
            {
                0xF75E52CF, //Articuno
                0xF75E5635, //Zapdos
                0xF75E511C, //Moltres
                0xF75E4DB6 //Mewtwo
            };

        public uint[] Gen2Keys = new uint[]
        {
            0xF75E4C03, //Raikou
            0xF75E4A50, //Entei
            0xF75E4F69, //Suicune
            0xF75E621A, //Lugia
            0xF75E63CD //Ho-Oh
        };

        public uint[] Gen3Keys = new uint[]
        {
            0xF760963E, //Kyogre
            0xF76097F1, //Groudon
            0xF7609B57, //Rayquaza
            0xF760948B, //Latias
            0xF76092D8, //Latios
        };

        public uint[] Gen4Keys = new uint[]
        {
            0xF76086F3, //Dialga
            0xF7608540, //Palkia
            0xF7582170, //Giratina
            0xF76099A4, //Uxie
            0xF7609D0A, //Mesprit
            0xF7609EBD, //Azelf
            0xF7582323, //Heatran
            0xF75824D6, //Cresselia
        };

        public uint[] Gen5Keys = new uint[]
        {
            0xF7582BA2, //Reshiram
            0xF7582D55, //Zekrom
            0xF7582F08, //Kyurem
            0xF7582689, //Tornadus
            0xF758283C, //Thundurus
            0xF75829EF, //Landorus
        };

        public uint[] Gen5SOJKeys = new uint[]
        {
            0xBB305227, //Cobalion
            0x750C83A4, //Terrakion
            0x1A27DF2C, //Virizion
            0xA097DE31, //Keldeo
        };

        public uint[] Gen6Keys = new uint[]
        {
            0xF75830BB, //Xerneas
            0xF75B3AF9, //Yveltal
            0xF75B3946, //Zygarde
        };

        public uint[] Gen7Keys = new uint[]
        {
            0xF75B3E5F, //Solgaleo
            0xF75B3CAC, //Lunala
            0xF75B3793, //Tapu Koko
            0xF75B35E0, //Tapu Lele
            0xF75B41C5, //Tapu Bulu
            0xF75B4012, //Tapu Fini
        };
        public uint[] Gen7UBKeys = new uint[]
        {
            0xF75B46DE, //Nihilego
            0xF769AAC6, //Buzzwole
            0xF769AC79, //Pheromosa
            0xF769A760, //Xurkitree
            0xF769B192, //Celesteela
            0xF769A913, //Kartana
            0xF769B345, //Guzzlord
            0xF75B4891, //Necrozma
            0xF769B85E, //Stakataka
            0xF769AFDF, //Blacephalon
        };

        public uint[] Gen8BirbKeys = new uint[]
        {
            0x4CAB7DA6, //Galarian Articuno
            0x284CBECF, //Galarian Zapdos
            0xF1E493AA, //Galarian Moltres
        };
        private void DynamaxResetForm_Load(object sender, EventArgs e)
        {
            //Check Regis
            for (int i = 0; i < RegiKeys.Length - 2; i++)
            {
                var block = SAV.Blocks.GetBlock(RegiKeys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    regi_clistbox.SetItemChecked(i, true);
            }

            if (SAV.Blocks.GetBlock(RegiKeys[4]).Type == SCTypeCode.Bool2 && SAV.Blocks.GetBlock(RegiKeys[5]).Type == SCTypeCode.Bool2)
            {
                MessageBox.Show($"Both Regieleki and Regigigas cannot be caught legally on the same profile", "Error", MessageBoxButtons.OK);
                SAV.Blocks.SetBlockValue(RegiKeys[5], SCTypeCode.Bool1);
            }
            var drago = SAV.Blocks.GetBlock(RegiKeys[5]);

            var eleki = SAV.Blocks.GetBlock(RegiKeys[4]);

            var pattern = SAV.Blocks.GetBlock(KRegielekiOrRegidragoPattern);

            if (eleki.Type == SCTypeCode.Bool2) //Regieleki
            {
                regieleki_RBTN.Checked = true;
                //Check if the pattern provided by the player matches the regi
                if (Convert.ToInt32(pattern.GetValue()) != 1) // 1 = regieleki pattern
                {
                    MessageBox.Show($"Discrepancy detected with the Regi received and the pattern required for it.\nValue:{pattern.GetValue()}", "Error", MessageBoxButtons.OK);
                    pattern.SetValue((UInt32)1);
                }
            }

            if (drago.Type == SCTypeCode.Bool2) //Regidrago
            {
                regidrago_RBTN.Checked = true;
                //Check if the pattern provided by the player matches the regi
                if (Convert.ToInt32(pattern.GetValue()) != 2) // 2 = regidrago pattern
                {
                    MessageBox.Show($"Discrepancy detected with the Regi received and the pattern required for it.\nValue:{pattern.GetValue()}", "Error", MessageBoxButtons.OK);
                    pattern.SetValue((UInt32)2);
                }
            }



            //Check gen 1
            for (int i = 0; i < Gen1Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen1Keys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    gen1_clistbox.SetItemChecked(i, true);
            }
            //Check gen 2
            for (int i = 0; i < Gen2Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen2Keys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    gen2_clistbox.SetItemChecked(i, true);
            }
            //Check gen 3
            for (int i = 0; i < Gen3Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen3Keys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    gen3_clistbox.SetItemChecked(i, true);
            }

            //Check gen 4
            for (int i = 0; i < Gen4Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen4Keys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    gen4_clistbox.SetItemChecked(i, true);
            }

            //Check gen 5
            for (int i = 0; i < Gen5Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen5Keys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    gen5_clistbox.SetItemChecked(i, true);
            }
            //Check gen 5 SOJ
            for (int i = 0; i < Gen5SOJKeys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen5SOJKeys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    soj_clistbox.SetItemChecked(i, true);
            }

            //Check gen 6
            for (int i = 0; i < Gen6Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen6Keys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    gen6_clistbox.SetItemChecked(i, true);
            }

            //Check gen 7
            for (int i = 0; i < Gen7Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen7Keys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    gen7_clistbox.SetItemChecked(i, true);
            }

            //Check gen 7 Ultra beasts
            for (int i = 0; i < Gen7UBKeys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen7UBKeys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    UB_clistbox.SetItemChecked(i, true);
            }

            //Check gen 8 birbs
            for (int i = 0; i < Gen8BirbKeys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen8BirbKeys[i]);
                if (block.Type == SCTypeCode.Bool2)
                    gen8b_clistbox.SetItemChecked(i, true);
            }



        }

        private void DynamaxResetForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void applyBTN_Click(object sender, EventArgs e)
        {
            //Check regis
            for (int i = 0; i < RegiKeys.Length - 2; i++)
            {
                var block = SAV.Blocks.GetBlock(RegiKeys[i]);

                if (regi_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }
            var eleki = SAV.Blocks.GetBlock(RegiKeys[4]);
            var drago = SAV.Blocks.GetBlock(RegiKeys[5]);
            var pattern = SAV.Blocks.GetBlock(KRegielekiOrRegidragoPattern);
            if (regidrago_RBTN.Checked)
            {
                drago.Type = SCTypeCode.Bool2;


                eleki.Type = SCTypeCode.Bool1;
                pattern.SetValue((UInt32)2);
            }
            else if (regieleki_RBTN.Checked)
            {
                drago.Type = SCTypeCode.Bool1;

                eleki.Type = SCTypeCode.Bool2;
                pattern.SetValue((UInt32)1);
            }
            else
            {
                drago.Type = SCTypeCode.Bool1;
                eleki.Type = SCTypeCode.Bool1;

                pattern.SetValue((UInt32)0);
            }

            //Check gen 1
            for (int i = 0; i < Gen1Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen1Keys[i]);
                
                if (gen1_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }

            //Check gen 2
            for (int i = 0; i < Gen2Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen2Keys[i]);
                if (gen2_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }

            //Check gen 3
            for (int i = 0; i < Gen3Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen3Keys[i]);
                if (gen3_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }

            //Check gen 4
            for (int i = 0; i < Gen4Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen4Keys[i]);
                if (gen4_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }

            //Check gen 5
            for (int i = 0; i < Gen5Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen5Keys[i]);
                if (gen5_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }
            //Check gen 5 Swords of Justice
            for (int i = 0; i < Gen5SOJKeys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen5SOJKeys[i]);
                if (soj_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }

            //Check gen 6
            for (int i = 0; i < Gen6Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen6Keys[i]);
                if (gen6_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }

            //Check gen 7
            for (int i = 0; i < Gen7Keys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen7Keys[i]);
                if (gen7_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }

            //Check gen 7 Ultra Beasts
            for (int i = 0; i < Gen7UBKeys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen7UBKeys[i]);
                if (UB_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }

            //Check gen 8 birbs
            for (int i = 0; i < Gen8BirbKeys.Length; i++)
            {
                var block = SAV.Blocks.GetBlock(Gen8BirbKeys[i]);
                if (gen8b_clistbox.GetItemChecked(i)) block.Type = SCTypeCode.Bool2;
                else block.Type = SCTypeCode.Bool1;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //Quori: This was a pain to set-up, there was probably a better way to do it, but oh well I'll do it later.
        enum Generations { Gen1, Gen2, Gen3, Gen4, Gen5, Gen5_SOJ, Gen6, Gen7, Gen7_UB, Gen8_Bird }
        void SetValue(Generations Generation, bool Value)
        {
            switch (Generation)
            {
                case (Generations.Gen1):
                    for (int i = 0; i < gen1_clistbox.Items.Count; i++) gen1_clistbox.SetItemChecked(i, Value);
                    break;
                case (Generations.Gen2):
                    for (int i = 0; i < gen2_clistbox.Items.Count; i++) gen2_clistbox.SetItemChecked(i, Value);
                    break;
                case (Generations.Gen3):
                    for (int i = 0; i < gen3_clistbox.Items.Count; i++) gen3_clistbox.SetItemChecked(i, Value);
                    break;
                case (Generations.Gen4):
                    for (int i = 0; i < gen4_clistbox.Items.Count; i++) gen4_clistbox.SetItemChecked(i, Value);
                    break;
                case (Generations.Gen5):
                    for (int i = 0; i < gen5_clistbox.Items.Count; i++) gen5_clistbox.SetItemChecked(i, Value);
                    break;
                case (Generations.Gen5_SOJ):
                    for (int i = 0; i < soj_clistbox.Items.Count; i++) soj_clistbox.SetItemChecked(i, Value);
                    break;
                case (Generations.Gen6):
                    for (int i = 0; i < gen6_clistbox.Items.Count; i++) gen6_clistbox.SetItemChecked(i, Value);
                    break;
                case (Generations.Gen7):
                    for (int i = 0; i < gen7_clistbox.Items.Count; i++) gen7_clistbox.SetItemChecked(i, Value);
                    break;
                case (Generations.Gen7_UB):
                    for (int i = 0; i < UB_clistbox.Items.Count; i++) UB_clistbox.SetItemChecked(i, Value);
                    break;
                case (Generations.Gen8_Bird):
                    for (int i = 0; i < gen8b_clistbox.Items.Count; i++) gen8b_clistbox.SetItemChecked(i, Value);
                    break;
            }

        }

        #region Found All / Reset All Buttons

        private void g1FA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen1, true);
        }
        private void g1RA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen1, false);
        }


        private void g2FA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen2, true);
        }
        private void g2RA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen2, false);
        }


        private void g3FA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen3, true);
        }
        private void g3RA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen3, false);
        }


        private void g4FA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen4, true);
        }
        private void g4RA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen4, false);
        }


        private void g5FA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen5, true);
        }
        private void g5RA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen5, false);
        }


        private void g5sojFA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen5_SOJ, true);
        }
        private void g5sojRA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen5_SOJ, false);
        }



        private void g6FA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen6, true);
        }
        private void g6RA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen6, false);
        }


        private void g7FA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen7, true);
        }
        private void g7RA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen7, false);
        }


        private void g7ubFA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen7_UB, true);
        }
        private void g7ubRA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen7_UB, false);
        }


        private void g8bFA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen8_Bird, true);
        }

        private void g8bRA_BTN_Click(object sender, EventArgs e)
        {
            SetValue(Generations.Gen8_Bird, false);
        }


        #endregion

        private void glFA_BTN_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to check everything?", "Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) for (int i = 0; i < (int)Generations.Gen8_Bird + 1; i++) SetValue((Generations)i, true);
        }

        private void glRA_BTN_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to un-check everything?", "Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) for (int i = 0; i < (int)Generations.Gen8_Bird + 1; i++) SetValue((Generations)i, false);
        }

        private void report_BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For help or to report issues and/or bugs, please contact \"Reshiquori#8124\" and/or \"Darthfiggy#9205\" on Discord.", "Help");
        }
    }
}
