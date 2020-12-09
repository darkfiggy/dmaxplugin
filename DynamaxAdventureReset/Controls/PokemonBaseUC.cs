using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamaxAdventureReset.Controls
{
    public partial class PokemonBaseUC : UserControl
    {
        public PokemonBaseUC()
        {
            InitializeComponent();
        }

        public int Pokemon
        {
            get { return pokemonRenderUC1.Pokemon; }
            set
            {
                pokemonRenderUC1.Pokemon = value;
            }
        }
        public int PokemonSubform
        {
            get { return pokemonRenderUC1.PokemonSubForm; }
            set
            {
                pokemonRenderUC1.PokemonSubForm = value;
            }
        }

        public PokemonRenderUC.LegalStatus Legalility
        {
            get { return pokemonRenderUC1.Legalility; }
            set
            {
                pokemonRenderUC1.Legalility = value;
            }
        }

        public bool Caught
        {
            get { return pokemonRenderUC1.Caught; }
            set
            {
                pokemonRenderUC1.Caught = value;

                caught_CB.Checked = value;
                caughtToolStripMenuItem.Checked = value;
                pokemonRenderUC1.Invalidate();
            }
        }
        private void caught_CB_CheckedChanged(object sender, EventArgs e)
        {
            Caught = caught_CB.Checked;
        }

        private void caughtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caught = caughtToolStripMenuItem.Checked;
        }
    }
}
