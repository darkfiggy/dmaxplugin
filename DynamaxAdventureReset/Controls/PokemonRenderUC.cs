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
    public partial class PokemonRenderUC : UserControl
    {
        public PokemonRenderUC()
        {
            InitializeComponent();
        }

        private Image pokemon;
        private int pokemonsubform;

        public int PokemonSubForm
        {
            get
            {
                return pokemonsubform;
            }
            set
            {
                pokemonsubform = value;
                SetupPokemon();
            }
        }


        private int pokemonID;
        public int Pokemon
        {
            get
            {
                return pokemonID;
            }
            set
            {
                pokemonID = value;
                SetupPokemon();
            }
        }

        public enum LegalStatus { Illegal, Legal }
        private LegalStatus legalstatus;
        public LegalStatus Legalility
        {
            get { return legalstatus; }
            set
            {
                legalstatus = value;
            }
        }

        private bool messageicon;
        public bool ShowMessageIcon
        {
            get { return messageicon; }
            set
            {
                messageicon = value;
            }
        }

        private bool caught;
        public bool Caught
        {
            get { return caught; }
            set 
            {
                caught = value;
            }
        }
        void SetupPokemon()
        {
            pokemon?.Dispose();

            string pokemonstr = $"b_{pokemonID}";
            if (pokemonsubform != 0)
                pokemonstr += $"_{pokemonsubform}";

            pokemon = (Bitmap)Properties.Resources.ResourceManager.GetObject(pokemonstr);
            if (pokemon == null)
                pokemon = (Bitmap)Properties.Resources.ResourceManager.GetObject("0");
            this.Invalidate();

        }

        Point MousePos = new Point();
        public bool capturedMouse;

        private void PokemonRenderUC_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.LightGray);


            e.Graphics.DrawImage(pokemon, 0, 0);

            if (capturedMouse)
            {
                e.Graphics.DrawImage(Properties.Resources.slotHover68, 0, 0);
            }
            if (caught)
                e.Graphics.DrawImage(Properties.Resources._ball4, this.Width - 15, this.Height - 15, 15, 15);

            if (messageicon)
                e.Graphics.DrawImage(Properties.Resources.hint, this.Width - 16, 0);

            if (legalstatus == LegalStatus.Illegal)
                e.Graphics.DrawImage(Properties.Resources.warn, 0,0 );
            else
                e.Graphics.DrawImage(Properties.Resources.valid, 0, 0);
        }

        private void PokemonRenderUC_MouseMove(object sender, MouseEventArgs e)
        {
            MousePos.X = e.X;
            MousePos.Y = e.Y;
            this.Invalidate();

        }

        private void PokemonRenderUC_MouseEnter(object sender, EventArgs e)
        {
            capturedMouse = true;
            this.Invalidate();
        }

        private void PokemonRenderUC_MouseLeave(object sender, EventArgs e)
        {
            capturedMouse = false;
            this.Invalidate();
        }
    }
}
