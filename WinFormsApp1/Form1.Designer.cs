namespace WinFormsApp1
{
    public class AssetName
    {
        public string Domain { get; set; }
        public string AssetType { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Example { get; set; }
        public string ExceptionText { get; set; }

        public AssetName(string assetType, string prefix, string suffix, string example)
        {                                   
            AssetType = assetType;
            Prefix = prefix;
            Suffix = suffix;
            Example = example;
        }

        public AssetName(string domain, string assetType, string prefix, string suffix, string example, string exception = "")
        {
            Domain = domain;
            AssetType = assetType;
            Prefix = prefix;
            Suffix = suffix;
            Example = example;
            ExceptionText = exception;
        }
    }

    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            SearchBox = new TextBox();
            label3 = new Label();
            VerText = new TextBox();
            ExceptionLabel = new Label();
            ExBox = new TextBox();
            ExPanel = new Panel();
            NameField = new Label();
            button2 = new Button();
            label2 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            ClassBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            VariationBox = new ComboBox();
            VariantBox = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ExPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 5;
            button1.Location = new Point(482, 36);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 0;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 21);
            label1.TabIndex = 1;
            label1.Text = "Select the file or place file's name.";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(12, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 29);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(12, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 292);
            panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.ColumnWidth = 270;
            listBox1.Cursor = Cursors.Hand;
            listBox1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.On;
            listBox1.ItemHeight = 21;
            listBox1.Items.AddRange(new object[] { "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1", "Item 1" });
            listBox1.Location = new Point(0, 0);
            listBox1.Margin = new Padding(5);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(579, 277);
            listBox1.Sorted = true;
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(331, 70);
            comboBox1.MaxDropDownItems = 12;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 23);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // SearchBox
            // 
            SearchBox.Cursor = Cursors.IBeam;
            SearchBox.Location = new Point(74, 70);
            SearchBox.MaxLength = 32;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(180, 23);
            SearchBox.TabIndex = 4;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F);
            label3.Location = new Point(465, 394);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 6;
            label3.Text = "Version:";
            // 
            // VerText
            // 
            VerText.Cursor = Cursors.IBeam;
            VerText.Location = new Point(465, 418);
            VerText.Name = "VerText";
            VerText.Size = new Size(106, 23);
            VerText.TabIndex = 7;
            VerText.TextAlign = HorizontalAlignment.Center;
            VerText.TextChanged += VerText_TextChanged;
            // 
            // ExceptionLabel
            // 
            ExceptionLabel.AutoSize = true;
            ExceptionLabel.Font = new Font("Segoe UI Black", 12F);
            ExceptionLabel.Location = new Point(2, 3);
            ExceptionLabel.Margin = new Padding(0);
            ExceptionLabel.Name = "ExceptionLabel";
            ExceptionLabel.RightToLeft = RightToLeft.No;
            ExceptionLabel.Size = new Size(162, 21);
            ExceptionLabel.TabIndex = 8;
            ExceptionLabel.Text = "Color Order: ARMH";
            ExceptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExBox
            // 
            ExBox.Location = new Point(3, 27);
            ExBox.Name = "ExBox";
            ExBox.Size = new Size(144, 23);
            ExBox.TabIndex = 9;
            ExBox.TextChanged += ExBox_TextChanged;
            // 
            // ExPanel
            // 
            ExPanel.Controls.Add(ExBox);
            ExPanel.Controls.Add(ExceptionLabel);
            ExPanel.Location = new Point(12, 452);
            ExPanel.Name = "ExPanel";
            ExPanel.Size = new Size(194, 50);
            ExPanel.TabIndex = 10;
            // 
            // NameField
            // 
            NameField.AutoSize = true;
            NameField.Font = new Font("Segoe UI", 15F);
            NameField.Location = new Point(12, 505);
            NameField.Name = "NameField";
            NameField.Size = new Size(64, 28);
            NameField.TabIndex = 11;
            NameField.Text = "Name";
            // 
            // button2
            // 
            button2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            button2.Location = new Point(12, 554);
            button2.Name = "button2";
            button2.Size = new Size(600, 35);
            button2.TabIndex = 12;
            button2.Text = "Copy To Clipboard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 13;
            label2.Text = "Search:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(260, 70);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 14;
            label4.Text = "Domain:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(482, 68);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 25);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Auto Selection";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ClassBox
            // 
            ClassBox.Cursor = Cursors.IBeam;
            ClassBox.Location = new Point(12, 418);
            ClassBox.Name = "ClassBox";
            ClassBox.Size = new Size(106, 23);
            ClassBox.TabIndex = 17;
            ClassBox.TextAlign = HorizontalAlignment.Center;
            ClassBox.TextChanged += ClassBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F);
            label5.Location = new Point(12, 394);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 16;
            label5.Text = "Class Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F);
            label6.Location = new Point(155, 394);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 18;
            label6.Text = "Variation:";
            // 
            // VariationBox
            // 
            VariationBox.Font = new Font("Segoe UI", 9F);
            VariationBox.FormattingEnabled = true;
            VariationBox.Location = new Point(155, 418);
            VariationBox.MaxDropDownItems = 12;
            VariationBox.Name = "VariationBox";
            VariationBox.Size = new Size(120, 23);
            VariationBox.TabIndex = 19;
            // 
            // VariantBox
            // 
            VariantBox.Font = new Font("Segoe UI", 9F);
            VariantBox.FormattingEnabled = true;
            VariantBox.Location = new Point(319, 418);
            VariantBox.MaxDropDownItems = 12;
            VariantBox.Name = "VariantBox";
            VariantBox.Size = new Size(111, 23);
            VariantBox.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F);
            label7.Location = new Point(319, 394);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 20;
            label7.Text = "Variant:";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(624, 601);
            Controls.Add(VariantBox);
            Controls.Add(label7);
            Controls.Add(VariationBox);
            Controls.Add(label6);
            Controls.Add(ClassBox);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(NameField);
            Controls.Add(ExPanel);
            Controls.Add(VerText);
            Controls.Add(label3);
            Controls.Add(SearchBox);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form";
            Text = "Name Corrector";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ExPanel.ResumeLayout(false);
            ExPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private string[] Domains = new[] {"All",
                                          "AI",
                                          "Gameplay",
                                          "Animation",
                                          "Misc",
                                          "Plugin",
                                          "Audio",
                                          "Blueprint",
                                          "Texture",
                                          "Datasmith",
                                          "Physics",
                                          "UI",
                                          "Enhanced Input",
                                          "Material",
                                          "Niagara",
                                          "Paper2D",
                                          "Procedural"};

        private const string SupportedItem = "All Supported Items (*.3g2;*.3gp;*.3gpp;*.3g2;*.ac3;*.amr;*.abc;*.m4a;*.m4v;*.mov;*.asf;*.upack;*.as;*.adts;*.au;*.aif;*.aiff;*.avi;*.bwf;"
            +"*.csv;*.cda;*.caf;*.exr;*.exr;*.fbx;*.fbx;*.fbx;*.fbx;*.fbx;*.fbx;*.upack;*.fga;*.flac;*.ies;*.json;*.aac;*.mp3;*.mp4;*.ogg;*.ogv;*.otf;*.otc;*.vdb;*.sdv;*.snd;*.st;*.st;"
            +"*.st;*.json;*.paper2dsprites;*.srt;*.sami;*.smi;*.bmp;*.jpeg;*.jpg;*.pcx;*.png;*.psd;*.tga;*.dds;*.hdr;*.tif;*.tiff;*.json;*.ttc;*.ttf;*.wav;*.webm;*.webm;*.wma;*.wmv;*.gltf;"
            +"*.glb;*.obj;*.mtlx;*.png;*.bmp;*.exr;*.hdr;*.tif;*.tiff;*.tga;*.dds;*.jpg;*.jpeg;*.pcx;*.psd;*.ies)|*.3g2;*.3gp;*.3gpp;*.3g2;*.ac3;*.amr;*.abc;*.m4a;*.m4v;*.mov;*.asf;*.upack;"
            +"*.as;*.adts;*.au;*.aif;*.aiff;*.avi;*.bwf;*.csv;*.cda;*.caf;*.exr;*.exr;*.fbx;*.fbx;*.fbx;*.fbx;*.fbx;*.fbx;*.upack;*.fga;*.flac;*.ies;*.json;*.aac;*.mp3;*.mp4;*.ogg;*.ogv;"
            +"*.otf;*.otc;*.vdb;*.sdv;*.snd;*.st;*.st;*.st;*.json;*.paper2dsprites;*.srt;*.sami;*.smi;*.bmp;*.jpeg;*.jpg;*.pcx;*.png;*.psd;*.tga;*.dds;*.hdr;*.tif;*.tiff;*.json;*.ttc;*.ttf;"
            +"*.wav;*.webm;*.webm;*.wma;*.wmv;*.gltf;*.glb;*.obj;*.mtlx;*.png;*.bmp;*.exr;*.hdr;*.tif;*.tiff;*.tga;*.dds;*.jpg;*.jpeg;*.pcx;*.psd;*.ies|"
            +"3G2 Multimedia Stream (*.3g2)|*.3g2|3GP Video Stream (*.3gp)|*.3gp|3GPP Multimedia File (*.3gpp)|*.3gpp|3GPP2 Multimedia File (*.3g2)|*.3g2|AC-3 Audio File (*.ac3)|*.ac3|"
            +"Adaptive Multi-Rate Audio (*.amr)|*.amr|Alembic (*.abc)|*.abc|Apple MPEG-4 Audio (*.m4a)|*.m4a|Apple MPEG-4 Video (*.m4v)|*.m4v|Apple QuickTime Movie (*.mov)|*.mov|"
            +"ASF Media File (*.asf)|*.asf|Asset Pack (*.upack)|*.upack|Audio amplitude curve (*.as)|*.as|Audio Data Transport Stream (*.adts)|*.adts|Audio File (*.au)|*.au|"
            +"Audio Interchange File (*.aif)|*.aif|Audio Interchange File Format (*.aiff)|*.aiff|Audio Video Interleave File (*.avi)|*.avi|Broadcast Wave Audio (*.bwf)|*.bwf|"
            +"Comma-separated values (*.csv)|*.csv|Compact Disc digital audio (*.cda)|*.cda|Core Audio (*.caf)|*.caf|EXR image HDR texture2d (*.exr)|*.exr|EXR ImgMedia Image Sequence (*.exr)|*.exr|"
            +"FBX animation (*.fbx)|*.fbx|FBX meshes and animations (*.fbx)|*.fbx|Fbx Scene (*.fbx)|*.fbx|FBX skeletal meshes (*.fbx)|*.fbx|FBX static meshes (*.fbx)|*.fbx|Feature Pack (*.upack)|*.upack|"
            +"FluidGridAscii (*.fga)|*.fga|Free Lossless Audio Codec (*.flac)|*.flac|IES Texture (Standard light profiles) (*.ies)|*.ies|JavaScript Object Notation (*.json)|*.json|"
            +"MPEG-2 Advanced Audio Coding File (*.aac)|*.aac|MPEG-4 Audio (*.mp3)|*.mp3|MPEG-4 Movie (*.mp4)|*.mp4|OGG Vorbis bitstream format (*.ogg)|*.ogg|OGG Vorbis bitstream format (*.ogv)|*.ogv|"
            +"OpenType Font (*.otf)|*.otf|OpenType Font (*.otc)|*.otc|OpenVDB Format (*.vdb)|*.vdb|Samsung Digital Video (*.sdv)|*.sdv|Sound File (*.snd)|*.snd|SpeedTree v8 (*.st)|*.st|"
            +"SpeedTree v8 (*.st)|*.st|SpeedTree v8 (*.st)|*.st|Spritesheet JSON file (*.json)|*.json|Spritesheet JSON file (*.paper2dsprites)|*.paper2dsprites|SubRip Subtitles (*.srt)|*.srt|"
            +"Synchronized Accessible Media Interchange (SAMI) File (*.sami)|*.sami|Synchronized Multimedia Integration (SMIL) File (*.smi)|*.smi|Texture (*.bmp)|*.bmp|Texture (*.jpeg)|*.jpeg|"
            +"Texture (*.jpg)|*.jpg|Texture (*.pcx)|*.pcx|Texture (*.png)|*.png|Texture (*.psd)|*.psd|Texture (*.tga)|*.tga|Texture (Cubemap or 2D) (*.dds)|*.dds|"
            +"Texture (HDR) (LongLat unwrap or 2D) (*.hdr)|*.hdr|Texture (TIFF) (*.tif)|*.tif|Texture (TIFF) (*.tiff)|*.tiff|Tiled JSON file (*.json)|*.json|TrueType Font (*.ttc)|*.ttc|"
            +"TrueType Font (*.ttf)|*.ttf|Wave Audio File (*.wav)|*.wav|WEBM Movie (*.webm)|*.webm|WebM Multimedia File (*.webm)|*.webm|Windows Media Audio (*.wma)|*.wma|Windows Media Video (*.wmv)|*.wmv|"
            +"GL Transmission Format (*.gltf)|*.gltf|GL Transmission Format (Binary) (*.glb)|*.glb|OBJ File Format (*.obj)|*.obj|MaterialX File Format (*.mtlx)|*.mtlx|Portable Network Graphic (*.png)|*.png|"
            +"Bitmap image (*.bmp)|*.bmp|OpenEXR image (*.exr)|*.exr|High Dynamic Range image (*.hdr)|*.hdr|Tag Image File Format (*.tif)|*.tif|Tag Image File Format (*.tiff)|*.tiff|Targa image (*.tga)|*.tga|"
            +"DirectDraw Surface (*.dds)|*.dds|JPEG image (*.jpg)|*.jpg|JPEG image (*.jpeg)|*.jpeg|Picture Exchange (*.pcx)|*.pcx|Photoshop Document (*.psd)|*.psd|IES light profile (*.ies)|*.ies";

        private readonly List<AssetName> AssetNames = new List<AssetName>
        {
            {new AssetName("AI","AI Controller","AIC_",string.Empty,"AIC_{0}")},
            {new AssetName("AI","Behavior Tree","BT_",string.Empty,"BT_{0}")},
            {new AssetName("AI","Blackboard","BB_",string.Empty,"BB_{0}")},
            {new AssetName("AI","Decorator","BTD_",string.Empty,"BTD_{0}")},
            {new AssetName("AI","Environment Query","EQS_",string.Empty,"EQS_{0}")},
            {new AssetName("AI","Environment Query Context","EQS_","_Context","EQS_{0}_Context")},
            {new AssetName("AI","Service","BTS_",string.Empty,"BTS_{0}")},
            {new AssetName("AI","Task","BTT_",string.Empty,"BTT_{0}")},
            {new AssetName("Gameplay","Ability Set","AS_",string.Empty,"AS_{0}")},
            {new AssetName("Gameplay","Game Phase Abilities","Phase_",string.Empty,"Phase_{0}")},
            {new AssetName("Gameplay","Gameplay Abilities","GA_",string.Empty,"GA_{0}")},
            {new AssetName("Gameplay","Gameplay Cue Notifies","GCN_",string.Empty,"GCN_{0}")},
            {new AssetName("Gameplay","Gameplay Effects","GE_",string.Empty,"GE_{0}")},
            {new AssetName("Gameplay","Latent Gameplay Cue Notifies","GCNL_",string.Empty,"GCNL_{0}")},
            {new AssetName("Animation","Aim Offset","AO_",string.Empty,"AO_{0}")},
            {new AssetName("Animation","Aim Offset 1D","AO_",string.Empty,"AO_{0}")},
            {new AssetName("Animation","Animation Blueprint","ABP_",string.Empty,"ABP_{0}")},
            {new AssetName("Animation","Animation Composite","AC_",string.Empty,"AC_{0}")},
            {new AssetName("Animation","Animation Montage","AM_",string.Empty,"AM_{0}")},
            {new AssetName("Animation","Animation Notify","AN_",string.Empty,"AN_{0}")},
            {new AssetName("Animation","Animation Sequence","AS_",string.Empty,"AS_{0}")},
            {new AssetName("Animation","Blend Space","BS_",string.Empty,"BS_{0}")},
            {new AssetName("Animation","Blend Space 1D","BS_",string.Empty,"BS_{0}")},
            {new AssetName("Animation","Level Sequence","LS_",string.Empty,"LS_{0}")},
            {new AssetName("Animation","Morph Target","MT_",string.Empty,"MT_{0}")},
            {new AssetName("Animation","Paper Flipbook","PFB_",string.Empty,"PFB_{0}")},
            {new AssetName("Animation","Rig","Rig_",string.Empty,"Rig_{0}")},
            {new AssetName("Animation","Skeletal Mesh","SK_",string.Empty,"SK_{0}")},
            {new AssetName("Animation","Skeleton","S_",string.Empty,"SKEL_{0}")},
            {new AssetName("Misc","Animated Vector Field","VFA_",string.Empty,"VFA_{0}")},
            {new AssetName("Misc","Blink Media Player","BMP_",string.Empty,"BMP_{0}")},
            {new AssetName("Misc","Camera Anim","CA_",string.Empty,"CA_{0}")},
            {new AssetName("Misc","Color Curve","Curve_","_Color","Curve_{0}_Color")},
            {new AssetName("Misc","Curve Atlas","Curve_","_Atlas","Curve_{0}_Atlas")},
            {new AssetName("Misc","Curve Table","Curve_","_Table","Curve_{0}_Table")},
            {new AssetName("Misc","Data Asset","DA_",string.Empty,"DA_{0}")},
            {new AssetName("Misc","Data Registry","DR_",string.Empty,"DR_{0}")},
            {new AssetName("Misc","Data Table","DT_",string.Empty,"DT_{0}")},
            {new AssetName("Misc","File Media Source","FMS_",string.Empty,"FMS_{0}")},
            {new AssetName("Misc","Float Curve","Curve_","_Float","Curve_{0}_Float")},
            {new AssetName("Misc","Foliage Type","FT_",string.Empty,"FT_{0}")},
            {new AssetName("Misc","Force Feedback Effect","FFE_",string.Empty,"FFE_{0}")},
            {new AssetName("Misc","Landscape Grass Type","LG_",string.Empty,"LG_{0}")},
            {new AssetName("Misc","Landscape Layer","LL_",string.Empty,"LL_{0}")},
            {new AssetName("Misc","Level","L_",string.Empty,"L_{0}")},
            {new AssetName("Misc","Level (World Partition)","L_","_WP","L_{0}_WP")},
            {new AssetName("Misc","Level Instance","LI_",string.Empty,"LI_{0}")},
            {new AssetName("Misc","Media Player","MP_",string.Empty,"MP_{0}")},
            {new AssetName("Misc","Object Library","OL_",string.Empty,"OL_{0}")},
            {new AssetName("Misc","Redirector","RE_",string.Empty,"RE_{0}")},
            {new AssetName("Misc","Static Mesh","SM_",string.Empty,"SM_{0}")},
            {new AssetName("Misc","Static Vector Field","VF_",string.Empty,"VF_{0}")},
            {new AssetName("Misc","Geometry Cache","GC_",string.Empty,"GC_{0}")},
            {new AssetName("Misc","Touch Interface Setup","TI_",string.Empty,"TI_{0}")},
            {new AssetName("Misc","Vector Curve","Curve_","_Vector","Curve_{0}_Vector")},
            {new AssetName("Plugin","Asset Placement Palette","APP_",string.Empty,"APP_{0}")},
            {new AssetName("Plugin","Substance Graph Instance","SGI_",string.Empty,"SGI_{0}")},
            {new AssetName("Plugin","Substance Instance Factor","SIF_",string.Empty,"SIF_{0}")},
            {new AssetName("Audio","Attenuation",string.Empty,"_ATT","{0}_ATT")},
            {new AssetName("Audio","Dialogue Voice","DV_",string.Empty,"DV_{0}")},
            {new AssetName("Audio","Dialogue Wave","DW_",string.Empty,"DW_{0}")},
            {new AssetName("Audio","Media Sound Wave","MSW_",string.Empty,"MSW_{0}")},
            {new AssetName("Audio","Reverb Effect","Reverb_",string.Empty,"Reverb_{0}")},
            {new AssetName("Audio","Sound Attenuation","ATT_",string.Empty,"ATT_{0}")},
            {new AssetName("Audio","Sound Class","SCL_",string.Empty,"SCL_{0}")},
            {new AssetName("Audio","Sound Concurrency","SCL_","_CO","SCL_{0}_CO")},
            {new AssetName("Audio","Sound Cue","A_","_Cue","A_{0}_Cue")},
            {new AssetName("Audio","Sound Mix","Mix_",string.Empty,"Mix_{0}")},
            {new AssetName("Audio","Sound Wave","A_",string.Empty,"A_{0}")},
            {new AssetName("Audio","Soundscape Color","SC_",string.Empty,"SC_{0}")},
            {new AssetName("Audio","Soundscape Palette","SP_",string.Empty,"SP_{0}")},
            {new AssetName("Blueprint","Blueprint","BP_",string.Empty,"BP_{0}")},
            {new AssetName("Blueprint","Blueprint Actor Component","BP_","_AC","BP_{0}_AC")},
            {new AssetName("Blueprint","Blueprint Scene Component","BP_","_SC","BP_{0}_SC")},
            {new AssetName("Blueprint","Blueprint Function Library","BPFL_",string.Empty,"BPFL_{0}")},
            {new AssetName("Blueprint","Blueprint Interface","BPI_",string.Empty,"BPI_{0}")},
            {new AssetName("Blueprint","Blueprint Macro Library","BPML_",string.Empty,"BPML_{0}")},
            {new AssetName("Blueprint","Enumerator","E",string.Empty,"E{0}")},
            {new AssetName("Blueprint","Structure","S",string.Empty,"S{0}")},
            {new AssetName("Blueprint","Tutorial Blueprint","TBP_",string.Empty,"TBP_{0}")},
            {new AssetName("Texture","Cube Render Target","RTC_",string.Empty,"RTC_{0}")},
            {new AssetName("Texture","Media Texture","MT_",string.Empty,"MT_{0}")},
            {new AssetName("Texture","Render Target","RT_",string.Empty,"RT_{0}")},
            {new AssetName("Texture","Texture","T_",string.Empty,"T_{0}")},
            {new AssetName("Texture","Texture (Alpha/Opacity)","T_","_A","T_{0}_A")},
            {new AssetName("Texture","Texture (Ambient Occlusion)","T_","_AO","T_{0}_AO")},
            {new AssetName("Texture","Texture (Base Color)","T_","_BC","T_{0}_BC")},
            {new AssetName("Texture","Texture (Displacement)","T_","_D","T_{0}_D")},
            {new AssetName("Texture","Texture (Emissive)","T_","_E","T_{0}_E")},
            {new AssetName("Texture","Texture (Flow Map)","T_","_F","T_{0}_F")},
            {new AssetName("Texture","Texture (Height)","T_","_H","T_{0}_H")},
            {new AssetName("Texture","Texture (Light Map)","T_","_L","T_{0}_L")},
            {new AssetName("Texture","Texture (Mask)","T_","_Mask","T_{0}_Mask")},
            {new AssetName("Texture","Texture (Metallic)","T_","_M","T_{0}_M")},
            {new AssetName("Texture","Texture (Normal)","T_","_N","T_{0}_N")},
            {new AssetName("Texture","Texture (Packed)","T_","_{1}","T_{0}_{1}","Color Order: ARMH")},
            {new AssetName("Texture","Texture (Roughness)","T_","_R","T_{0}_R")},
            {new AssetName("Texture","Texture (Specular)","T_","_S","T_{0}_S")},
            {new AssetName("Texture","Texture Cube","TC_",string.Empty,"TC_{0}")},
            {new AssetName("Texture","Texture Light Profile","TLP_",string.Empty,"TLP_{0}")},
            {new AssetName("Datasmith","Dataprep Asset","DPA_",string.Empty,"DPA_{0}")},
            {new AssetName("Physics","Destructable Mesh","DM_",string.Empty,"DM_{0}")},
            {new AssetName("Physics","Physical Material","PM_",string.Empty,"PM_{0}")},
            {new AssetName("Physics","Physics Asset","PHYS_",string.Empty,"PHYS_{0}")},
            {new AssetName("UI","Editor Utility Widget Blueprint","EUW_",string.Empty,"EUW_{0}")},
            {new AssetName("UI","Font","Font_",string.Empty,"Font_{0}")},
            {new AssetName("UI","Slate Brush","SB_",string.Empty,"SB_{0}")},
            {new AssetName("UI","Slate Widget Style","SWS_",string.Empty,"SWS_{0}")},
            {new AssetName("UI","Widget Blueprint","W_",string.Empty,"W_{0}")},
            {new AssetName("Enhanced Input","Input Action","IA_",string.Empty,"IA_{0}")},
            {new AssetName("Enhanced Input","Input Mapping Context","IMC_",string.Empty,"IMC_{0}")},
            {new AssetName("Material","Material","M_",string.Empty,"M_{0}")},
            {new AssetName("Material","Material (Decal)","M_","_Decal","M_{0}_Decal")},
            {new AssetName("Material","Material (Light Function)","M_","_LF","M_{0}_LF")},
            {new AssetName("Material","Material (Post Process)","M_","_PP","M_{0}_PP")},
            {new AssetName("Material","Material (User Interface)","M_","_UI","M_{0}_UI")},
            {new AssetName("Material","Material (Volume)","M_","_Vol","M_{0}_Vol")},
            {new AssetName("Material","Material Function","MF_",string.Empty,"MF_{0}")},
            {new AssetName("Material","Material Instance","MI_",string.Empty,"MI_{0}")},
            {new AssetName("Material","Material Instance (Decal)","MI_","_Decal","MI_{0}_Decal")},
            {new AssetName("Material","Material Instance (Light Function)","MI_","_LF","MI_{0}_LF")},
            {new AssetName("Material","Material Instance (Post Process)","MI_","_PP","MI_{0}_PP")},
            {new AssetName("Material","Material Instance (User Interface)","MI_","_UI","MI_{0}_UI")},
            {new AssetName("Material","Material Instance (Volume)","MI_","_Vol","MI_{0}_Vol")},
            {new AssetName("Material","Material Parameter Collection","MPC_",string.Empty,"MPC_{0}")},
            {new AssetName("Material","Subsurface Profile","SP_",string.Empty,"SP_{0}")},
            {new AssetName("Niagara","Niagara Dynamic Input Script","NDIS_",string.Empty,"NDIS_{0}")},
            {new AssetName("Niagara","Niagara Effect Type","NET_",string.Empty,"NET_{0}")},
            {new AssetName("Niagara","Niagara Emitter","NE_",string.Empty,"NE_{0}")},
            {new AssetName("Niagara","Niagara Function Script","NFS_",string.Empty,"NFS_{0}")},
            {new AssetName("Niagara","Niagara Module Script","NMS_",string.Empty,"NMS_{0}")},
            {new AssetName("Niagara","Niagara Parameter Collection","NPC_",string.Empty,"NPC_{0}")},
            {new AssetName("Niagara","Niagara Parameter Collection Instance","NPCI_",string.Empty,"NPCI_{0}")},
            {new AssetName("Niagara","Niagara System","NS_",string.Empty,"NS_{0}")},
            {new AssetName("Paper2D","Paper Flipbook","PFB_",string.Empty,"PFB_{0}")},
            {new AssetName("Paper2D","Sprite","SPR_",string.Empty,"SPR_{0}")},
            {new AssetName("Paper2D","Sprite Atlas Group","SPRG_",string.Empty,"SPRG_{0}")},
            {new AssetName("Paper2D","Tile Map","TM_",string.Empty,"TM_{0}")},
            {new AssetName("Paper2D","Tile Set","TS_",string.Empty,"TS_{0}")},
            {new AssetName("Procedural","Procedural Content Generation","PCG_",string.Empty,"PCG_{0}")}
        };

        private readonly Dictionary<string, string> ForamtsTypes = new Dictionary<string, string>
        {
            {"otf", "Font"},
            {"ttf", "Font"},
            {"woff", "Font"},
            {"mp3","File Media Source"},
            {"wav","Media Sound Wave"},
            {"abc","Static Mesh,Geometry Cache,Skeletal Mesh,Skeleton,Animation Sequence"},
            {"fbx","Static Mesh,Material,Skeletal Mesh,Skeleton,Physics Asset,Rig,Animation Sequence"},
            {"obj","Static Mesh,Material,Skeletal Mesh,Skeleton,Physics Asset,Rig,Animation Sequence"
                    +"Texture (Height),Texture (Light Map),Texture (Mask),Texture (Metallic),Texture (Normal),Texture (Packed),Texture (Roughness),Texture (Specular)"
                    +"Texture,Texture (Alpha/Opacity),Texture (Ambient Occlusion),Texture (Base Color),Texture (Displacement),Texture (Emissive),Texture (Flow Map)"},
            {"hdr","Texture Cube"},
            {"jpg","Texture (Height),Texture (Light Map),Texture (Mask),Texture (Metallic),Texture (Normal),Texture (Packed),Texture (Roughness),Texture (Specular)"
                    +"Texture,Texture (Alpha/Opacity),Texture (Ambient Occlusion),Texture (Base Color),Texture (Displacement),Texture (Emissive),Texture (Flow Map)"},
            {"png","Texture (Height),Texture (Light Map),Texture (Mask),Texture (Metallic),Texture (Normal),Texture (Packed),Texture (Roughness),Texture (Specular)"
                    +"Texture,Texture (Alpha/Opacity),Texture (Ambient Occlusion),Texture (Base Color),Texture (Displacement),Texture (Emissive),Texture (Flow Map)"},
            {"psd","Texture (Height),Texture (Light Map),Texture (Mask),Texture (Metallic),Texture (Normal),Texture (Packed),Texture (Roughness),Texture (Specular)"
                    +"Texture,Texture (Alpha/Opacity),Texture (Ambient Occlusion),Texture (Base Color),Texture (Displacement),Texture (Emissive),Texture (Flow Map)"},
            {"tga","Texture (Height),Texture (Light Map),Texture (Mask),Texture (Metallic),Texture (Normal),Texture (Packed),Texture (Roughness),Texture (Specular)"
                    +"Texture,Texture (Alpha/Opacity),Texture (Ambient Occlusion),Texture (Base Color),Texture (Displacement),Texture (Emissive),Texture (Flow Map)"},
            {"mtl","Material,Texture (Height),Texture (Light Map),Texture (Mask),Texture (Metallic),Texture (Normal),Texture (Packed),Texture (Roughness),Texture (Specular)"
                    +"Texture,Texture (Alpha/Opacity),Texture (Ambient Occlusion),Texture (Base Color),Texture (Displacement),Texture (Emissive),Texture (Flow Map)"}
        };

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private TextBox SearchBox;
        private Label label3;
        private TextBox VerText;
        private Label ExceptionLabel;
        private TextBox ExBox;
        private Panel ExPanel;
        public Label NameField;
        private Button button2;
        private Label label2;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox ClassBox;
        private Label label5;
        private Label label6;
        private ComboBox VariationBox;
        private ComboBox VariantBox;
        private Label label7;
    }
}
