namespace FnafTycoon
{
    partial class MenuInicial
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            PnBotaoInicial = new Krypton.Toolkit.KryptonPanel();
            BtInicio = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            PnBotoes = new Krypton.Toolkit.KryptonPanel();
            BtSair = new Krypton.Toolkit.KryptonButton();
            BtIniciar = new Krypton.Toolkit.KryptonButton();
            BarraCarregamento = new Krypton.Toolkit.KryptonProgressBar();
            TmLoading = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PnBotaoInicial).BeginInit();
            PnBotaoInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PnBotoes).BeginInit();
            PnBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImage = Properties.Resources.Chão;
            kryptonPictureBox1.Dock = DockStyle.Fill;
            kryptonPictureBox1.Image = Properties.Resources.FnafMenu;
            kryptonPictureBox1.Location = new Point(0, 0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(736, 345);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // PnBotaoInicial
            // 
            PnBotaoInicial.Controls.Add(BtInicio);
            PnBotaoInicial.Location = new Point(-1, 344);
            PnBotaoInicial.MaximumSize = new Size(736, 63);
            PnBotaoInicial.MinimumSize = new Size(1, 63);
            PnBotaoInicial.Name = "PnBotaoInicial";
            PnBotaoInicial.Size = new Size(736, 63);
            PnBotaoInicial.StateCommon.Image = Properties.Resources.Chão;
            PnBotaoInicial.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            PnBotaoInicial.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            PnBotaoInicial.TabIndex = 1;
            // 
            // BtInicio
            // 
            BtInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtInicio.CornerRoundingRadius = 10F;
            BtInicio.Location = new Point(230, 6);
            BtInicio.Name = "BtInicio";
            BtInicio.Size = new Size(273, 43);
            BtInicio.StateCommon.Back.Color1 = Color.White;
            BtInicio.StateCommon.Back.Color2 = Color.White;
            BtInicio.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            BtInicio.StateCommon.Back.Image = Properties.Resources.fontbolt_removebg_preview;
            BtInicio.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            BtInicio.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            BtInicio.StateCommon.Border.Color1 = Color.Transparent;
            BtInicio.StateCommon.Border.Color2 = Color.Transparent;
            BtInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BtInicio.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            BtInicio.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            BtInicio.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.BottomRight;
            BtInicio.StateCommon.Border.Rounding = 10F;
            BtInicio.StateCommon.Content.Image.ImageColorMap = Color.Transparent;
            BtInicio.StateCommon.Content.Image.ImageColorTo = Color.Transparent;
            BtInicio.TabIndex = 0;
            BtInicio.Values.Text = "";
            BtInicio.Click += BtInicio_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonPictureBox1);
            kryptonPanel2.Location = new Point(-1, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(736, 345);
            kryptonPanel2.TabIndex = 2;
            // 
            // PnBotoes
            // 
            PnBotoes.Controls.Add(BtSair);
            PnBotoes.Controls.Add(BtIniciar);
            PnBotoes.Location = new Point(-1, 345);
            PnBotoes.MaximumSize = new Size(736, 63);
            PnBotoes.MinimumSize = new Size(1, 63);
            PnBotoes.Name = "PnBotoes";
            PnBotoes.Size = new Size(734, 63);
            PnBotoes.StateCommon.Image = Properties.Resources.Chão;
            PnBotoes.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            PnBotoes.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.BottomRight;
            PnBotoes.StateNormal.Image = Properties.Resources.Chão;
            PnBotoes.TabIndex = 3;
            // 
            // BtSair
            // 
            BtSair.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtSair.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            BtSair.ImeMode = ImeMode.NoControl;
            BtSair.Location = new Point(376, 8);
            BtSair.Name = "BtSair";
            BtSair.OverrideFocus.Border.Color1 = Color.Black;
            BtSair.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BtSair.OverrideFocus.Border.Rounding = 20F;
            BtSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            BtSair.Size = new Size(171, 46);
            BtSair.StateCommon.Back.Color1 = Color.White;
            BtSair.StateCommon.Back.Color2 = Color.IndianRed;
            BtSair.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            BtSair.StateCommon.Border.Color1 = Color.Black;
            BtSair.StateCommon.Border.Color2 = Color.Black;
            BtSair.StateCommon.Border.ColorAngle = 10F;
            BtSair.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            BtSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BtSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            BtSair.StateCommon.Border.Rounding = 30F;
            BtSair.StateCommon.Border.Width = 3;
            BtSair.StateCommon.Content.LongText.Color1 = Color.Black;
            BtSair.StateCommon.Content.LongText.Color2 = Color.FromArgb(64, 64, 64);
            BtSair.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            BtSair.StateCommon.Content.LongText.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            BtSair.StateCommon.Content.ShortText.Color1 = Color.Black;
            BtSair.StateCommon.Content.ShortText.Color2 = Color.Black;
            BtSair.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            BtSair.StateCommon.Content.ShortText.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtSair.StatePressed.Back.Color1 = Color.Black;
            BtSair.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            BtSair.StatePressed.Content.LongText.Color1 = Color.White;
            BtSair.StatePressed.Content.LongText.Color2 = Color.FromArgb(64, 64, 64);
            BtSair.StatePressed.Content.LongText.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            BtSair.StatePressed.Content.ShortText.Color1 = Color.White;
            BtSair.StatePressed.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            BtSair.StatePressed.Content.ShortText.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            BtSair.TabIndex = 15;
            BtSair.Values.Text = "Sair";
            BtSair.Click += BtSair_Click;
            // 
            // BtIniciar
            // 
            BtIniciar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtIniciar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            BtIniciar.ImeMode = ImeMode.NoControl;
            BtIniciar.Location = new Point(177, 8);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.OverrideFocus.Border.Color1 = Color.Black;
            BtIniciar.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BtIniciar.OverrideFocus.Border.Rounding = 20F;
            BtIniciar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            BtIniciar.Size = new Size(179, 46);
            BtIniciar.StateCommon.Back.Color1 = Color.White;
            BtIniciar.StateCommon.Back.Color2 = Color.IndianRed;
            BtIniciar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            BtIniciar.StateCommon.Border.Color1 = Color.Black;
            BtIniciar.StateCommon.Border.Color2 = Color.Black;
            BtIniciar.StateCommon.Border.ColorAngle = 10F;
            BtIniciar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            BtIniciar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BtIniciar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            BtIniciar.StateCommon.Border.Rounding = 30F;
            BtIniciar.StateCommon.Border.Width = 3;
            BtIniciar.StateCommon.Content.LongText.Color1 = Color.Black;
            BtIniciar.StateCommon.Content.LongText.Color2 = Color.FromArgb(64, 64, 64);
            BtIniciar.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            BtIniciar.StateCommon.Content.LongText.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            BtIniciar.StateCommon.Content.ShortText.Color1 = Color.Black;
            BtIniciar.StateCommon.Content.ShortText.Color2 = Color.Black;
            BtIniciar.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            BtIniciar.StateCommon.Content.ShortText.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtIniciar.StatePressed.Back.Color1 = Color.Black;
            BtIniciar.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            BtIniciar.StatePressed.Content.LongText.Color1 = Color.White;
            BtIniciar.StatePressed.Content.LongText.Color2 = Color.FromArgb(64, 64, 64);
            BtIniciar.StatePressed.Content.LongText.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            BtIniciar.StatePressed.Content.ShortText.Color1 = Color.White;
            BtIniciar.StatePressed.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            BtIniciar.StatePressed.Content.ShortText.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            BtIniciar.TabIndex = 14;
            BtIniciar.Values.Text = "Iniciar";
            BtIniciar.Click += BtIniciar_Click;
            // 
            // BarraCarregamento
            // 
            BarraCarregamento.CornerRoundingRadius = 10F;
            BarraCarregamento.Location = new Point(-1, 345);
            BarraCarregamento.Name = "BarraCarregamento";
            BarraCarregamento.Size = new Size(736, 63);
            BarraCarregamento.StateCommon.Back.Color1 = Color.FromArgb(192, 0, 0);
            BarraCarregamento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BarraCarregamento.StateCommon.Border.Rounding = 10F;
            BarraCarregamento.StateDisabled.Back.Color1 = Color.White;
            BarraCarregamento.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            BarraCarregamento.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BarraCarregamento.StateDisabled.Border.Rounding = 10F;
            BarraCarregamento.StateNormal.Back.Color1 = Color.Transparent;
            BarraCarregamento.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            BarraCarregamento.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BarraCarregamento.StateNormal.Border.Rounding = 10F;
            BarraCarregamento.Style = ProgressBarStyle.Blocks;
            BarraCarregamento.TabIndex = 16;
            BarraCarregamento.Values.Text = "";
            // 
            // TmLoading
            // 
            TmLoading.Tick += TmLoading_Tick;
            // 
            // MenuInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 406);
            Controls.Add(kryptonPanel2);
            Controls.Add(PnBotaoInicial);
            Controls.Add(PnBotoes);
            Controls.Add(BarraCarregamento);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuInicial";
            ShadowValues.Colour = SystemColors.ActiveCaptionText;
            StartPosition = FormStartPosition.CenterScreen;
            StateActive.Border.Color1 = Color.Black;
            StateActive.Border.Color2 = Color.Black;
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            StateActive.Border.Rounding = 10F;
            Text = "MenuInicial";
            Load += MenuInicial_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PnBotaoInicial).EndInit();
            PnBotaoInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PnBotoes).EndInit();
            PnBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonPanel PnBotaoInicial;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton BtInicio;
        private Krypton.Toolkit.KryptonPanel PnBotoes;
        private Krypton.Toolkit.KryptonButton BtIniciar;
        private Krypton.Toolkit.KryptonButton BtSair;
        private Krypton.Toolkit.KryptonProgressBar BarraCarregamento;
        private System.Windows.Forms.Timer TmLoading;
    }
}