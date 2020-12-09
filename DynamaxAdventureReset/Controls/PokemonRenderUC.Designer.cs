namespace DynamaxAdventureReset.Controls
{
    partial class PokemonRenderUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PokemonRenderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(68, 56);
            this.MinimumSize = new System.Drawing.Size(68, 56);
            this.Name = "PokemonRenderUC";
            this.Size = new System.Drawing.Size(68, 56);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PokemonRenderUC_Paint);
            this.MouseEnter += new System.EventHandler(this.PokemonRenderUC_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PokemonRenderUC_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PokemonRenderUC_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
