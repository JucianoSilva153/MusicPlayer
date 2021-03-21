namespace JPlayer
{
    partial class Form1
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
            this.xuiFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.playListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayList_CB = new Guna.UI.WinForms.GunaComboBox();
            this.nomeMusica = new System.Windows.Forms.Label();
            this.infoMusica = new System.Windows.Forms.Label();
            this.progressoMusica = new Bunifu.Framework.UI.BunifuProgressBar();
            this.duracaoAtual_lbl = new System.Windows.Forms.Label();
            this.duracaoCompleta_lbl = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCircleButton5 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton4 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaTrackBar1 = new Guna.UI.WinForms.GunaTrackBar();
            this.AbrirPlayList = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.anteriorBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PlayPauseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.proximoBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xuiFlatMenuStrip1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anteriorBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPauseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximoBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiFlatMenuStrip1
            // 
            this.xuiFlatMenuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.xuiFlatMenuStrip1.HoverBackColor = System.Drawing.SystemColors.ControlDark;
            this.xuiFlatMenuStrip1.HoverTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.ItemBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xuiFlatMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playListToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.xuiFlatMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatMenuStrip1.Name = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.SelectedBackColor = System.Drawing.SystemColors.ControlLight;
            this.xuiFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.DimGray;
            this.xuiFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.Size = new System.Drawing.Size(968, 24);
            this.xuiFlatMenuStrip1.TabIndex = 1;
            this.xuiFlatMenuStrip1.Text = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // playListToolStripMenuItem
            // 
            this.playListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playListToolStripMenuItem.Name = "playListToolStripMenuItem";
            this.playListToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.playListToolStripMenuItem.Text = "Adicionar PlayList";
            this.playListToolStripMenuItem.Click += new System.EventHandler(this.playListToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatórioToolStripMenuItem});
            this.opçõesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // aleatórioToolStripMenuItem
            // 
            this.aleatórioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aleatórioToolStripMenuItem.Name = "aleatórioToolStripMenuItem";
            this.aleatórioToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aleatórioToolStripMenuItem.Text = "Aleatório";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // PlayList_CB
            // 
            this.PlayList_CB.BackColor = System.Drawing.Color.Transparent;
            this.PlayList_CB.BaseColor = System.Drawing.Color.White;
            this.PlayList_CB.BorderColor = System.Drawing.Color.Silver;
            this.PlayList_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PlayList_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayList_CB.FocusedColor = System.Drawing.Color.Empty;
            this.PlayList_CB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PlayList_CB.ForeColor = System.Drawing.Color.Black;
            this.PlayList_CB.FormattingEnabled = true;
            this.PlayList_CB.IntegralHeight = false;
            this.PlayList_CB.ItemHeight = 25;
            this.PlayList_CB.Location = new System.Drawing.Point(12, 42);
            this.PlayList_CB.MaxDropDownItems = 100;
            this.PlayList_CB.Name = "PlayList_CB";
            this.PlayList_CB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PlayList_CB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.PlayList_CB.Size = new System.Drawing.Size(363, 31);
            this.PlayList_CB.TabIndex = 2;
            this.PlayList_CB.SelectedIndexChanged += new System.EventHandler(this.PlayList_CB_SelectedIndexChanged);
            // 
            // nomeMusica
            // 
            this.nomeMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeMusica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomeMusica.Location = new System.Drawing.Point(376, 125);
            this.nomeMusica.Name = "nomeMusica";
            this.nomeMusica.Size = new System.Drawing.Size(580, 38);
            this.nomeMusica.TabIndex = 3;
            this.nomeMusica.Text = "Insira uma PlayList";
            this.nomeMusica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoMusica
            // 
            this.infoMusica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoMusica.Location = new System.Drawing.Point(522, 175);
            this.infoMusica.Name = "infoMusica";
            this.infoMusica.Size = new System.Drawing.Size(307, 23);
            this.infoMusica.TabIndex = 4;
            this.infoMusica.Text = "Sem PlayList";
            this.infoMusica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressoMusica
            // 
            this.progressoMusica.BackColor = System.Drawing.Color.White;
            this.progressoMusica.BorderRadius = 5;
            this.progressoMusica.Location = new System.Drawing.Point(416, 380);
            this.progressoMusica.MaximumValue = 100;
            this.progressoMusica.Name = "progressoMusica";
            this.progressoMusica.ProgressColor = System.Drawing.Color.LightSkyBlue;
            this.progressoMusica.Size = new System.Drawing.Size(500, 10);
            this.progressoMusica.TabIndex = 8;
            this.progressoMusica.Value = 0;
            // 
            // duracaoAtual_lbl
            // 
            this.duracaoAtual_lbl.AutoSize = true;
            this.duracaoAtual_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.duracaoAtual_lbl.Location = new System.Drawing.Point(413, 364);
            this.duracaoAtual_lbl.Name = "duracaoAtual_lbl";
            this.duracaoAtual_lbl.Size = new System.Drawing.Size(34, 13);
            this.duracaoAtual_lbl.TabIndex = 9;
            this.duracaoAtual_lbl.Text = "00:00";
            // 
            // duracaoCompleta_lbl
            // 
            this.duracaoCompleta_lbl.AutoSize = true;
            this.duracaoCompleta_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.duracaoCompleta_lbl.Location = new System.Drawing.Point(881, 364);
            this.duracaoCompleta_lbl.Name = "duracaoCompleta_lbl";
            this.duracaoCompleta_lbl.Size = new System.Drawing.Size(34, 13);
            this.duracaoCompleta_lbl.TabIndex = 10;
            this.duracaoCompleta_lbl.Text = "00:00";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaCircleButton5);
            this.gunaPanel1.Controls.Add(this.gunaCircleButton4);
            this.gunaPanel1.Controls.Add(this.gunaTrackBar1);
            this.gunaPanel1.Location = new System.Drawing.Point(534, 396);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(265, 67);
            this.gunaPanel1.TabIndex = 11;
            // 
            // gunaCircleButton5
            // 
            this.gunaCircleButton5.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton5.AnimationSpeed = 0.03F;
            this.gunaCircleButton5.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton5.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton5.Image = global::JPlayer.Properties.Resources.VolumePlus;
            this.gunaCircleButton5.ImageSize = new System.Drawing.Size(45, 45);
            this.gunaCircleButton5.Location = new System.Drawing.Point(225, 2);
            this.gunaCircleButton5.Name = "gunaCircleButton5";
            this.gunaCircleButton5.OnHoverBaseColor = System.Drawing.SystemColors.ControlDark;
            this.gunaCircleButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton5.OnHoverImage = null;
            this.gunaCircleButton5.OnPressedColor = System.Drawing.SystemColors.ControlDark;
            this.gunaCircleButton5.Size = new System.Drawing.Size(38, 38);
            this.gunaCircleButton5.TabIndex = 14;
            // 
            // gunaCircleButton4
            // 
            this.gunaCircleButton4.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton4.AnimationSpeed = 0.03F;
            this.gunaCircleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaCircleButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton4.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton4.Image = global::JPlayer.Properties.Resources.VolumeLess;
            this.gunaCircleButton4.ImageSize = new System.Drawing.Size(45, 45);
            this.gunaCircleButton4.Location = new System.Drawing.Point(1, 2);
            this.gunaCircleButton4.Name = "gunaCircleButton4";
            this.gunaCircleButton4.OnHoverBaseColor = System.Drawing.SystemColors.ControlDark;
            this.gunaCircleButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton4.OnHoverImage = null;
            this.gunaCircleButton4.OnPressedColor = System.Drawing.SystemColors.ControlDark;
            this.gunaCircleButton4.Size = new System.Drawing.Size(38, 38);
            this.gunaCircleButton4.TabIndex = 13;
            // 
            // gunaTrackBar1
            // 
            this.gunaTrackBar1.Location = new System.Drawing.Point(15, 39);
            this.gunaTrackBar1.Name = "gunaTrackBar1";
            this.gunaTrackBar1.Size = new System.Drawing.Size(237, 23);
            this.gunaTrackBar1.TabIndex = 0;
            this.gunaTrackBar1.TrackColor = System.Drawing.Color.LightSkyBlue;
            this.gunaTrackBar1.TrackHoverColor = System.Drawing.Color.Gray;
            this.gunaTrackBar1.TrackIdleColor = System.Drawing.Color.WhiteSmoke;
            this.gunaTrackBar1.TrackPressedColor = System.Drawing.Color.Black;
            this.gunaTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gunaTrackBar1_Scroll);
            // 
            // AbrirPlayList
            // 
            this.AbrirPlayList.Filter = "Ficheiro Mp3|*.mp3";
            this.AbrirPlayList.Multiselect = true;
            this.AbrirPlayList.RestoreDirectory = true;
            this.AbrirPlayList.Title = "Abrir Músicas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.BackgroundImage = global::JPlayer.Properties.Resources.disco2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.BackColor = System.Drawing.Color.Transparent;
            this.anteriorBtn.Image = global::JPlayer.Properties.Resources.ForwardButton;
            this.anteriorBtn.ImageActive = null;
            this.anteriorBtn.Location = new System.Drawing.Point(558, 269);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(50, 50);
            this.anteriorBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anteriorBtn.TabIndex = 13;
            this.anteriorBtn.TabStop = false;
            this.anteriorBtn.Zoom = 10;
            this.anteriorBtn.Click += new System.EventHandler(this.anteriorBtn_Click);
            // 
            // PlayPauseBtn
            // 
            this.PlayPauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayPauseBtn.Image = global::JPlayer.Properties.Resources.PlayButton2;
            this.PlayPauseBtn.ImageActive = null;
            this.PlayPauseBtn.Location = new System.Drawing.Point(614, 239);
            this.PlayPauseBtn.Name = "PlayPauseBtn";
            this.PlayPauseBtn.Size = new System.Drawing.Size(100, 100);
            this.PlayPauseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayPauseBtn.TabIndex = 14;
            this.PlayPauseBtn.TabStop = false;
            this.PlayPauseBtn.Zoom = 10;
            this.PlayPauseBtn.Click += new System.EventHandler(this.PlayPauseBtn_Click_1);
            // 
            // proximoBtn
            // 
            this.proximoBtn.BackColor = System.Drawing.Color.Transparent;
            this.proximoBtn.Image = global::JPlayer.Properties.Resources.NextButton;
            this.proximoBtn.ImageActive = null;
            this.proximoBtn.Location = new System.Drawing.Point(720, 269);
            this.proximoBtn.Name = "proximoBtn";
            this.proximoBtn.Size = new System.Drawing.Size(50, 50);
            this.proximoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proximoBtn.TabIndex = 15;
            this.proximoBtn.TabStop = false;
            this.proximoBtn.Zoom = 10;
            this.proximoBtn.Click += new System.EventHandler(this.proximoBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(968, 547);
            this.Controls.Add(this.proximoBtn);
            this.Controls.Add(this.PlayPauseBtn);
            this.Controls.Add(this.anteriorBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.duracaoCompleta_lbl);
            this.Controls.Add(this.duracaoAtual_lbl);
            this.Controls.Add(this.progressoMusica);
            this.Controls.Add(this.infoMusica);
            this.Controls.Add(this.nomeMusica);
            this.Controls.Add(this.PlayList_CB);
            this.Controls.Add(this.xuiFlatMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.xuiFlatMenuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "J-Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.xuiFlatMenuStrip1.ResumeLayout(false);
            this.xuiFlatMenuStrip1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anteriorBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPauseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximoBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIFlatMenuStrip xuiFlatMenuStrip1;
        private Guna.UI.WinForms.GunaComboBox PlayList_CB;
        private System.Windows.Forms.Label nomeMusica;
        private System.Windows.Forms.Label infoMusica;
        private Bunifu.Framework.UI.BunifuProgressBar progressoMusica;
        private System.Windows.Forms.Label duracaoAtual_lbl;
        private System.Windows.Forms.Label duracaoCompleta_lbl;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar1;
        private System.Windows.Forms.ToolStripMenuItem playListToolStripMenuItem;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton5;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton4;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog AbrirPlayList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton anteriorBtn;
        private Bunifu.Framework.UI.BunifuImageButton PlayPauseBtn;
        private Bunifu.Framework.UI.BunifuImageButton proximoBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

