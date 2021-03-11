namespace WinoFix
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bdcTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.entrada = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRelatorios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCorrecao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo_min = new System.Windows.Forms.PictureBox();
            this.pnlTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_min)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.pnlMenu.Controls.Add(this.logo);
            this.pnlMenu.Controls.Add(this.bunifuFlatButton3);
            this.pnlMenu.Controls.Add(this.btnRelatorios);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.btnCorrecao);
            this.pnlMenu.Controls.Add(this.logo_min);
            this.panelAnimator.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(210, 542);
            this.pnlMenu.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bdcTop
            // 
            this.bdcTop.Fixed = true;
            this.bdcTop.Horizontal = true;
            this.bdcTop.TargetControl = this.pnlTop;
            this.bdcTop.Vertical = true;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.logoAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 1F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation4;
            this.logoAnimator.TimeStep = 0.01F;
            // 
            // pnlConteudo
            // 
            this.panelAnimator.SetDecoration(this.pnlConteudo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlConteudo, BunifuAnimatorNS.DecorationType.None);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(210, 35);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(880, 542);
            this.pnlConteudo.TabIndex = 2;
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation3;
            // 
            // entrada
            // 
            this.entrada.Enabled = true;
            this.entrada.Tick += new System.EventHandler(this.entrada_Tick);
            // 
            // logo
            // 
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = global::WinoFix.Properties.Resources.símbolo_sólido_white_min;
            this.logo.Location = new System.Drawing.Point(49, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(115, 111);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Humanus";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::WinoFix.Properties.Resources.humanus;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 239);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(210, 49);
            this.bunifuFlatButton3.TabIndex = 11;
            this.bunifuFlatButton3.Text = "Humanus";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorios.BorderRadius = 0;
            this.btnRelatorios.ButtonText = "Gerar Relatórios";
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnRelatorios, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnRelatorios, BunifuAnimatorNS.DecorationType.None);
            this.btnRelatorios.DisabledColor = System.Drawing.Color.Gray;
            this.btnRelatorios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Iconimage = global::WinoFix.Properties.Resources.relatorio_32_px;
            this.btnRelatorios.Iconimage_right = null;
            this.btnRelatorios.Iconimage_right_Selected = null;
            this.btnRelatorios.Iconimage_Selected = null;
            this.btnRelatorios.IconMarginLeft = 0;
            this.btnRelatorios.IconMarginRight = 0;
            this.btnRelatorios.IconRightVisible = true;
            this.btnRelatorios.IconRightZoom = 0D;
            this.btnRelatorios.IconVisible = true;
            this.btnRelatorios.IconZoom = 55D;
            this.btnRelatorios.IsTab = false;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 184);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRelatorios.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnRelatorios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRelatorios.selected = false;
            this.btnRelatorios.Size = new System.Drawing.Size(210, 45);
            this.btnRelatorios.TabIndex = 10;
            this.btnRelatorios.Text = "Gerar Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRelatorios.Textcolor = System.Drawing.Color.White;
            this.btnRelatorios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::WinoFix.Properties.Resources.menu_48;
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(174, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 9;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 5;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCorrecao
            // 
            this.btnCorrecao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnCorrecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.btnCorrecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrecao.BorderRadius = 0;
            this.btnCorrecao.ButtonText = "Tela de Correção";
            this.btnCorrecao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnCorrecao, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnCorrecao, BunifuAnimatorNS.DecorationType.None);
            this.btnCorrecao.DisabledColor = System.Drawing.Color.Gray;
            this.btnCorrecao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrecao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCorrecao.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCorrecao.Iconimage")));
            this.btnCorrecao.Iconimage_right = null;
            this.btnCorrecao.Iconimage_right_Selected = null;
            this.btnCorrecao.Iconimage_Selected = null;
            this.btnCorrecao.IconMarginLeft = 0;
            this.btnCorrecao.IconMarginRight = 0;
            this.btnCorrecao.IconRightVisible = true;
            this.btnCorrecao.IconRightZoom = 0D;
            this.btnCorrecao.IconVisible = true;
            this.btnCorrecao.IconZoom = 50D;
            this.btnCorrecao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCorrecao.IsTab = false;
            this.btnCorrecao.Location = new System.Drawing.Point(0, 125);
            this.btnCorrecao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCorrecao.Name = "btnCorrecao";
            this.btnCorrecao.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnCorrecao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnCorrecao.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCorrecao.Padding = new System.Windows.Forms.Padding(5);
            this.btnCorrecao.selected = false;
            this.btnCorrecao.Size = new System.Drawing.Size(210, 49);
            this.btnCorrecao.TabIndex = 3;
            this.btnCorrecao.Text = "Tela de Correção";
            this.btnCorrecao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCorrecao.Textcolor = System.Drawing.Color.White;
            this.btnCorrecao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrecao.Click += new System.EventHandler(this.btnCorrecao_Click);
            // 
            // logo_min
            // 
            this.logoAnimator.SetDecoration(this.logo_min, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.logo_min, BunifuAnimatorNS.DecorationType.None);
            this.logo_min.Image = global::WinoFix.Properties.Resources.símbolo_sólido_white_min;
            this.logo_min.Location = new System.Drawing.Point(5, 16);
            this.logo_min.Name = "logo_min";
            this.logo_min.Size = new System.Drawing.Size(42, 42);
            this.logo_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_min.TabIndex = 12;
            this.logo_min.TabStop = false;
            this.logo_min.Visible = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.Controls.Add(this.bunifuCustomLabel1);
            this.panelAnimator.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.pnlTop.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(32)))), ((int)(((byte)(104)))));
            this.pnlTop.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(32)))), ((int)(((byte)(104)))));
            this.pnlTop.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Quality = 10;
            this.pnlTop.Size = new System.Drawing.Size(1090, 35);
            this.pnlTop.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 6);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(301, 22);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "WinoWork: Modulo de Correção";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 577);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winowork: Modulo de Correção";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_min)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCorrecao;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTop;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bdcTop;
        private Bunifu.Framework.UI.BunifuFlatButton btnRelatorios;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.PictureBox logo_min;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Timer entrada;
    }
}