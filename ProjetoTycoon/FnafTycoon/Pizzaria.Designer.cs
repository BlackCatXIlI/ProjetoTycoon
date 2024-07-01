namespace FnafTycoon
{
    partial class Pizzaria
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
            BTpizza = new Krypton.Toolkit.KryptonButton();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTpizza
            // 
            BTpizza.Location = new Point(434, 107);
            BTpizza.Name = "BTpizza";
            BTpizza.Size = new Size(144, 134);
            BTpizza.StateCommon.Back.Color1 = Color.Transparent;
            BTpizza.StateCommon.Back.Color2 = Color.Transparent;
            BTpizza.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Form;
            BTpizza.StateCommon.Back.Image = Properties.Resources.PizzaWheel2;
            BTpizza.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            BTpizza.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            BTpizza.StateCommon.Border.Color1 = Color.Transparent;
            BTpizza.StateCommon.Border.Color2 = Color.Transparent;
            BTpizza.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTpizza.StateCommon.Border.Rounding = 75F;
            BTpizza.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.LightLight;
            BTpizza.StateCommon.Content.Image.ImageColorMap = Color.White;
            BTpizza.StateCommon.Content.Image.ImageColorTo = Color.White;
            BTpizza.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            BTpizza.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            BTpizza.StateNormal.Border.Color1 = Color.Transparent;
            BTpizza.StateNormal.Border.Color2 = Color.Transparent;
            BTpizza.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTpizza.StatePressed.Border.Color1 = Color.Transparent;
            BTpizza.StatePressed.Border.Color2 = Color.Transparent;
            BTpizza.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTpizza.StateTracking.Border.Color1 = Color.Transparent;
            BTpizza.StateTracking.Border.Color2 = Color.Transparent;
            BTpizza.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTpizza.TabIndex = 1;
            BTpizza.Values.Text = "";
            BTpizza.Click += BTpizza_Click_1;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Dock = DockStyle.Fill;
            kryptonPictureBox1.Image = Properties.Resources.Chão;
            kryptonPictureBox1.Location = new Point(0, 0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(1035, 443);
            kryptonPictureBox1.TabIndex = 17;
            kryptonPictureBox1.TabStop = false;
            // 
            // Pizzaria
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Chão;
            ClientSize = new Size(1035, 443);
            Controls.Add(BTpizza);
            Controls.Add(kryptonPictureBox1);
            Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Pizzaria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria";
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Krypton.Toolkit.KryptonButton BTpizza;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}