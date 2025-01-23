
namespace FaceWinSkan1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeKameryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeBazyDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zdjęciaTwarzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelTerningowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrukcjaObsługiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxKamery = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.face4 = new System.Windows.Forms.PictureBox();
            this.buttonRecognize = new Guna.UI2.WinForms.Guna2Button();
            this.face3 = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.face2 = new System.Windows.Forms.PictureBox();
            this.txtFaceName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxRecognizedFace = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_model = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_ImageFace = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.TrainButton = new Guna.UI2.WinForms.Guna2Button();
            this.btnKamera = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.face3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.face2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecognizedFace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeKameryToolStripMenuItem,
            this.opcjeBazyDanychToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // opcjeKameryToolStripMenuItem
            // 
            this.opcjeKameryToolStripMenuItem.Name = "opcjeKameryToolStripMenuItem";
            this.opcjeKameryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.opcjeKameryToolStripMenuItem.Text = "Opcje kamery";
            // 
            // opcjeBazyDanychToolStripMenuItem
            // 
            this.opcjeBazyDanychToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zdjęciaTwarzyToolStripMenuItem,
            this.modelTerningowyToolStripMenuItem});
            this.opcjeBazyDanychToolStripMenuItem.Name = "opcjeBazyDanychToolStripMenuItem";
            this.opcjeBazyDanychToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.opcjeBazyDanychToolStripMenuItem.Text = "Baza danych";
            // 
            // zdjęciaTwarzyToolStripMenuItem
            // 
            this.zdjęciaTwarzyToolStripMenuItem.Name = "zdjęciaTwarzyToolStripMenuItem";
            this.zdjęciaTwarzyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.zdjęciaTwarzyToolStripMenuItem.Text = "Zdjęcia Twarzy";
            // 
            // modelTerningowyToolStripMenuItem
            // 
            this.modelTerningowyToolStripMenuItem.Name = "modelTerningowyToolStripMenuItem";
            this.modelTerningowyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.modelTerningowyToolStripMenuItem.Text = "Model terningowy";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeOProgramieToolStripMenuItem,
            this.instrukcjaObsługiToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // informacjeOProgramieToolStripMenuItem
            // 
            this.informacjeOProgramieToolStripMenuItem.Name = "informacjeOProgramieToolStripMenuItem";
            this.informacjeOProgramieToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.informacjeOProgramieToolStripMenuItem.Text = "Informacje o programie";
            // 
            // instrukcjaObsługiToolStripMenuItem
            // 
            this.instrukcjaObsługiToolStripMenuItem.Name = "instrukcjaObsługiToolStripMenuItem";
            this.instrukcjaObsługiToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.instrukcjaObsługiToolStripMenuItem.Text = "Instrukcja obsługi";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBoxKamery);
            this.groupBox2.Controls.Add(this.pictureBoxCamera);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 421);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PODGLĄD KAMERY";
            // 
            // comboBoxKamery
            // 
            this.comboBoxKamery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxKamery.Animated = true;
            this.comboBoxKamery.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxKamery.BorderColor = System.Drawing.Color.Black;
            this.comboBoxKamery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxKamery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKamery.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxKamery.FocusedState.Parent = this.comboBoxKamery;
            this.comboBoxKamery.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxKamery.ForeColor = System.Drawing.Color.Navy;
            this.comboBoxKamery.FormattingEnabled = true;
            this.comboBoxKamery.HoverState.Parent = this.comboBoxKamery;
            this.comboBoxKamery.ItemHeight = 30;
            this.comboBoxKamery.ItemsAppearance.Parent = this.comboBoxKamery;
            this.comboBoxKamery.Location = new System.Drawing.Point(6, 379);
            this.comboBoxKamery.Name = "comboBoxKamery";
            this.comboBoxKamery.ShadowDecoration.Parent = this.comboBoxKamery;
            this.comboBoxKamery.Size = new System.Drawing.Size(422, 36);
            this.comboBoxKamery.TabIndex = 2;
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCamera.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamera.Location = new System.Drawing.Point(6, 23);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(422, 350);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCamera.TabIndex = 1;
            this.pictureBoxCamera.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.guna2Separator1);
            this.groupBox3.Controls.Add(this.face4);
            this.groupBox3.Controls.Add(this.buttonRecognize);
            this.groupBox3.Controls.Add(this.face3);
            this.groupBox3.Controls.Add(this.statusLabel);
            this.groupBox3.Controls.Add(this.face2);
            this.groupBox3.Controls.Add(this.txtFaceName);
            this.groupBox3.Controls.Add(this.pictureBoxRecognizedFace);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.labelResult);
            this.groupBox3.Location = new System.Drawing.Point(452, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 318);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ROZPOZNANIE";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(6, 181);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(391, 16);
            this.guna2Separator1.TabIndex = 16;
            // 
            // face4
            // 
            this.face4.BackColor = System.Drawing.Color.White;
            this.face4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.face4.Location = new System.Drawing.Point(317, 92);
            this.face4.Name = "face4";
            this.face4.Size = new System.Drawing.Size(80, 83);
            this.face4.TabIndex = 15;
            this.face4.TabStop = false;
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Animated = true;
            this.buttonRecognize.BorderRadius = 5;
            this.buttonRecognize.BorderThickness = 1;
            this.buttonRecognize.CheckedState.Parent = this.buttonRecognize;
            this.buttonRecognize.CustomImages.Parent = this.buttonRecognize;
            this.buttonRecognize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRecognize.ForeColor = System.Drawing.Color.White;
            this.buttonRecognize.HoverState.Parent = this.buttonRecognize;
            this.buttonRecognize.Location = new System.Drawing.Point(303, 9);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.ShadowDecoration.Parent = this.buttonRecognize;
            this.buttonRecognize.Size = new System.Drawing.Size(93, 33);
            this.buttonRecognize.TabIndex = 0;
            this.buttonRecognize.Text = "ROZPOZNANIE";
            this.buttonRecognize.Visible = false;
            this.buttonRecognize.Click += new System.EventHandler(this.buttonRecognize_Click);
            // 
            // face3
            // 
            this.face3.BackColor = System.Drawing.Color.White;
            this.face3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.face3.Location = new System.Drawing.Point(230, 92);
            this.face3.Name = "face3";
            this.face3.Size = new System.Drawing.Size(80, 83);
            this.face3.TabIndex = 15;
            this.face3.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(262, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "label1";
            this.statusLabel.Visible = false;
            // 
            // face2
            // 
            this.face2.BackColor = System.Drawing.Color.White;
            this.face2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.face2.Location = new System.Drawing.Point(143, 92);
            this.face2.Name = "face2";
            this.face2.Size = new System.Drawing.Size(80, 83);
            this.face2.TabIndex = 15;
            this.face2.TabStop = false;
            // 
            // txtFaceName
            // 
            this.txtFaceName.Animated = true;
            this.txtFaceName.BorderColor = System.Drawing.Color.Black;
            this.txtFaceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaceName.DefaultText = "";
            this.txtFaceName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFaceName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFaceName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFaceName.DisabledState.Parent = this.txtFaceName;
            this.txtFaceName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFaceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFaceName.FocusedState.Parent = this.txtFaceName;
            this.txtFaceName.ForeColor = System.Drawing.Color.Blue;
            this.txtFaceName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFaceName.HoverState.Parent = this.txtFaceName;
            this.txtFaceName.Location = new System.Drawing.Point(143, 45);
            this.txtFaceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaceName.Name = "txtFaceName";
            this.txtFaceName.PasswordChar = '\0';
            this.txtFaceName.PlaceholderText = "Wpisz unikalną nazwę dla zdjęcia";
            this.txtFaceName.SelectedText = "";
            this.txtFaceName.ShadowDecoration.Parent = this.txtFaceName;
            this.txtFaceName.Size = new System.Drawing.Size(253, 40);
            this.txtFaceName.TabIndex = 13;
            // 
            // pictureBoxRecognizedFace
            // 
            this.pictureBoxRecognizedFace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRecognizedFace.BackColor = System.Drawing.Color.White;
            this.pictureBoxRecognizedFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRecognizedFace.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRecognizedFace.Image")));
            this.pictureBoxRecognizedFace.Location = new System.Drawing.Point(6, 45);
            this.pictureBoxRecognizedFace.Name = "pictureBoxRecognizedFace";
            this.pictureBoxRecognizedFace.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxRecognizedFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRecognizedFace.TabIndex = 0;
            this.pictureBoxRecognizedFace.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IDENTYFIKATOR";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "WYKRYTA TWARZ";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.AutoEllipsis = true;
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.Location = new System.Drawing.Point(5, 200);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(121, 40);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Etykieta : 0\r\nPewność: 65.28";
            // 
            // listBoxLog
            // 
            this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 468);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(844, 95);
            this.listBoxLog.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_model);
            this.groupBox1.Controls.Add(this.btn_ImageFace);
            this.groupBox1.Controls.Add(this.guna2Button2);
            this.groupBox1.Controls.Add(this.TrainButton);
            this.groupBox1.Controls.Add(this.btnKamera);
            this.groupBox1.Location = new System.Drawing.Point(452, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 97);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KONTROLA";
            // 
            // btn_model
            // 
            this.btn_model.CheckedState.Parent = this.btn_model;
            this.btn_model.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_model.HoverState.Parent = this.btn_model;
            this.btn_model.Image = ((System.Drawing.Image)(resources.GetObject("btn_model.Image")));
            this.btn_model.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_model.Location = new System.Drawing.Point(367, 58);
            this.btn_model.Name = "btn_model";
            this.btn_model.PressedState.Parent = this.btn_model;
            this.btn_model.Size = new System.Drawing.Size(30, 30);
            this.btn_model.TabIndex = 17;
            this.btn_model.Click += new System.EventHandler(this.btn_model_Click_1);
            // 
            // btn_ImageFace
            // 
            this.btn_ImageFace.CheckedState.Parent = this.btn_ImageFace;
            this.btn_ImageFace.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_ImageFace.HoverState.Parent = this.btn_ImageFace;
            this.btn_ImageFace.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImageFace.Image")));
            this.btn_ImageFace.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_ImageFace.Location = new System.Drawing.Point(367, 20);
            this.btn_ImageFace.Name = "btn_ImageFace";
            this.btn_ImageFace.PressedState.Parent = this.btn_ImageFace;
            this.btn_ImageFace.Size = new System.Drawing.Size(30, 30);
            this.btn_ImageFace.TabIndex = 17;
            this.btn_ImageFace.Click += new System.EventHandler(this.btn_ImageFace_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(110, 19);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(253, 33);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "1.  ZAPISZ TWARZ";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.Animated = true;
            this.TrainButton.BorderRadius = 5;
            this.TrainButton.BorderThickness = 1;
            this.TrainButton.CheckedState.Parent = this.TrainButton;
            this.TrainButton.CustomImages.Parent = this.TrainButton;
            this.TrainButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TrainButton.ForeColor = System.Drawing.Color.White;
            this.TrainButton.HoverState.Parent = this.TrainButton;
            this.TrainButton.Location = new System.Drawing.Point(110, 58);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.ShadowDecoration.Parent = this.TrainButton;
            this.TrainButton.Size = new System.Drawing.Size(253, 33);
            this.TrainButton.TabIndex = 0;
            this.TrainButton.Text = "2.  TRENOWANIE";
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // btnKamera
            // 
            this.btnKamera.Animated = true;
            this.btnKamera.BorderRadius = 5;
            this.btnKamera.BorderThickness = 1;
            this.btnKamera.CheckedState.Parent = this.btnKamera;
            this.btnKamera.CustomImages.Parent = this.btnKamera;
            this.btnKamera.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKamera.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKamera.ForeColor = System.Drawing.Color.White;
            this.btnKamera.HoverState.Parent = this.btnKamera;
            this.btnKamera.Location = new System.Drawing.Point(6, 19);
            this.btnKamera.Name = "btnKamera";
            this.btnKamera.ShadowDecoration.Parent = this.btnKamera;
            this.btnKamera.Size = new System.Drawing.Size(98, 72);
            this.btnKamera.TabIndex = 0;
            this.btnKamera.Text = "Kamera ON";
            this.btnKamera.Click += new System.EventHandler(this.btnKamera_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "LOGI PROGRAMU";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Połączenie OK";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel2.Text = "Status kamery: Aktywna";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(134, 17);
            this.toolStripStatusLabel3.Text = "Liczba wykrytych twarzy";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 588);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(812, 627);
            this.Name = "Form1";
            this.Text = "FaceWinScan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.face3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.face2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecognizedFace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeKameryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeBazyDanychToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeOProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrukcjaObsługiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxRecognizedFace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxKamery;
        private Guna.UI2.WinForms.Guna2TextBox txtFaceName;
        private Guna.UI2.WinForms.Guna2Button btnKamera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button TrainButton;
        private Guna.UI2.WinForms.Guna2Button buttonRecognize;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox face4;
        private System.Windows.Forms.PictureBox face3;
        private System.Windows.Forms.PictureBox face2;
        private System.Windows.Forms.ToolStripMenuItem zdjęciaTwarzyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelTerningowyToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_ImageFace;
        private Guna.UI2.WinForms.Guna2ImageButton btn_model;
        private System.Windows.Forms.Timer timer1;
    }
}

