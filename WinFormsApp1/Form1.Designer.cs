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
        public string Priority { get; set; }

        public AssetName(string assetType, string prefix, string suffix, string example)
        {                                   
            AssetType = assetType;
            Prefix = prefix;
            Suffix = suffix;
            Example = example;
        }

        public AssetName(string domain, string assetType, string prefix, string suffix, string example, int priority = 101, string exception = "")
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            ExceptionLabel = new Label();
            textBox4 = new TextBox();
            panel2 = new Panel();
            NameField = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(429, 70);
            comboBox1.MaxDropDownItems = 12;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(12, 70);
            textBox2.MaxLength = 32;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F);
            label3.Location = new Point(12, 403);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 6;
            label3.Text = "Version:";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(93, 403);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 23);
            textBox3.TabIndex = 7;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // ExceptionLabel
            // 
            ExceptionLabel.AutoSize = true;
            ExceptionLabel.Font = new Font("Segoe UI Black", 12F);
            ExceptionLabel.Location = new Point(2, 3);
            ExceptionLabel.Margin = new Padding(0);
            ExceptionLabel.Name = "ExceptionLabel";
            ExceptionLabel.RightToLeft = RightToLeft.No;
            ExceptionLabel.Size = new Size(123, 21);
            ExceptionLabel.TabIndex = 8;
            ExceptionLabel.Text = "Exception Box";
            ExceptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 27);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(ExceptionLabel);
            panel2.Location = new Point(282, 397);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 60);
            panel2.TabIndex = 10;
            // 
            // NameField
            // 
            NameField.AutoSize = true;
            NameField.Location = new Point(12, 492);
            NameField.Name = "NameField";
            NameField.Size = new Size(39, 15);
            NameField.TabIndex = 11;
            NameField.Text = "Name";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(624, 601);
            Controls.Add(NameField);
            Controls.Add(panel2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "Form";
            Text = "Name Corrector";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;

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
            {new AssetName("Animation","Skeleton","SKEL_",string.Empty,"SKEL_{0}")},
            {new AssetName("Misc","Animated Vector Field","VFA_",string.Empty,"VFA_{0}")},
            {new AssetName("Misc","Blink Media Player","BMP_",string.Empty,"BMP_{0}")},
            {new AssetName("Misc","Camera Anim","CA_",string.Empty,"CA_{0}")},
            {new AssetName("Misc","Color Curve","Curve_","_Color","Curve_{0}_Color")},
            {new AssetName("Misc","Curve Atlas","Curve_","_Atlas","Curve_{0}_Atlas")},
            {new AssetName("Misc","Curve Table","Curve_","_Table","Curve_{0}_Table")},
            {new AssetName("Misc","Data Asset","DA_",string.Empty,"DA_{1}_{0}",100,"sub-class type: Weapon")},
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
            {new AssetName("Audio","Sound Class","SCL_",string.Empty,"SCL_{0}", 100, "Move to SoundClasses folder")},
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
            {new AssetName("Texture","Texture (Packed)","T_","_{1}","T_{0}_{1}",100,"Color Order: ARMH")},
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

        private readonly Dictionary<string, List<AssetName>> Domains
            = new Dictionary<string, List<AssetName>>
            {
                {"AI", new List<AssetName>
                    {
                        {new AssetName("AI Controller","AIC_",string.Empty,"AIC_{0}")},
                        {new AssetName("Behavior Tree","BT_",string.Empty,"BT_{0}")},
                        {new AssetName("Blackboard","BB_",string.Empty,"BB_{0}")},
                        {new AssetName("Decorator","BTD_",string.Empty,"BTD_{0}")},
                        {new AssetName("Environment Query","EQS_",string.Empty,"EQS_{0}")},
                        {new AssetName("Environment Query Context","EQS_","_Context","EQS_{0}_Context")},
                        {new AssetName("Service","BTS_",string.Empty,"BTS_{0}")},
                        {new AssetName("Task","BTT_",string.Empty,"BTT_{0}")}
                    }
                },
                {"Gameplay", new List<AssetName>
                    {
                        {new AssetName("Ability Set","AS_",string.Empty,"AS_{0}")},
                        {new AssetName("Game Phase Abilities","Phase_",string.Empty,"Phase_{0}")},
                        {new AssetName("Gameplay Abilities","GA_",string.Empty,"GA_{0}")},
                        {new AssetName("Gameplay Cue Notifies","GCN_",string.Empty,"GCN_{0}")},
                        {new AssetName("Gameplay Effects","GE_",string.Empty,"GE_{0}")},
                        {new AssetName("Latent Gameplay Cue Notifies","GCNL_",string.Empty,"GCNL_{0}")}
                    }
                },
                {"Animation", new List<AssetName>
                    {
                        {new AssetName("Aim Offset","AO_",string.Empty,"AO_{0}")},
                        {new AssetName("Aim Offset 1D","AO_",string.Empty,"AO_{0}")},
                        {new AssetName("Animation Blueprint","ABP_",string.Empty,"ABP_{0}")},
                        {new AssetName("Animation Composite","AC_",string.Empty,"AC_{0}")},
                        {new AssetName("Animation Montage","AM_",string.Empty,"AM_{0}")},
                        {new AssetName("Animation Notify","AN_",string.Empty,"AN_{0}")},
                        {new AssetName("Animation Sequence","AS_",string.Empty,"AS_{0}")},
                        {new AssetName("Blend Space","BS_",string.Empty,"BS_{0}")},
                        {new AssetName("Blend Space 1D","BS_",string.Empty,"BS_{0}")},
                        {new AssetName("Level Sequence","LS_",string.Empty,"LS_{0}")},
                        {new AssetName("Morph Target","MT_",string.Empty,"MT_{0}")},
                        {new AssetName("Paper Flipbook","PFB_",string.Empty,"PFB_{0}")},
                        {new AssetName("Rig","Rig_",string.Empty,"Rig_{0}")},
                        {new AssetName("Skeletal Mesh","SK_",string.Empty,"SK_{0}")},
                        {new AssetName("Skeleton","SKEL_",string.Empty,"SKEL_{0}")}
                    }
                },
                {"Misc", new List<AssetName>
                    {
                        {new AssetName("Animated Vector Field","VFA_",string.Empty,"VFA_{0}")},
                        {new AssetName("Blink Media Player","BMP_",string.Empty,"BMP_{0}")},
                        {new AssetName("Camera Anim","CA_",string.Empty,"CA_{0}")},
                        {new AssetName("Color Curve","Curve_","_Color","Curve_{0}_Color")},
                        {new AssetName("Curve Atlas","Curve_","_Atlas","Curve_{0}_Atlas")},
                        {new AssetName("Curve Table","Curve_","_Table","Curve_{0}_Table")},
                        {new AssetName("Misc","Data Asset","DA_",string.Empty,"DA_{1}_{0}",100,"sub-class type: Weapon")},
                        {new AssetName("Data Registry","DR_",string.Empty,"DR_{0}")},
                        {new AssetName("Data Table","DT_",string.Empty,"DT_{0}")},
                        {new AssetName("File Media Source","FMS_",string.Empty,"FMS_{0}")},
                        {new AssetName("Float Curve","Curve_","_Float","Curve_{0}_Float")},
                        {new AssetName("Foliage Type","FT_",string.Empty,"FT_{0}")},
                        {new AssetName("Force Feedback Effect","FFE_",string.Empty,"FFE_{0}")},
                        {new AssetName("Landscape Grass Type","LG_",string.Empty,"LG_{0}")},
                        {new AssetName("Landscape Layer","LL_",string.Empty,"LL_{0}")},
                        {new AssetName("Level","L_",string.Empty,"L_{0}")},
                        {new AssetName("Level (World Partition)","L_","_WP","L_{0}_WP")},
                        {new AssetName("Level Instance","LI_",string.Empty,"LI_{0}")},
                        {new AssetName("Media Player","MP_",string.Empty,"MP_{0}")},
                        {new AssetName("Object Library","OL_",string.Empty,"OL_{0}")},
                        {new AssetName("Redirector","RE_",string.Empty,"RE_{0}")},
                        {new AssetName("Static Mesh","SM_",string.Empty,"SM_{0}")},
                        {new AssetName("Static Vector Field","VF_",string.Empty,"VF_{0}")},
                        {new AssetName("Touch Interface Setup","TI_",string.Empty,"TI_{0}")},
                        {new AssetName("Vector Curve","Curve_","_Vector","Curve_{0}_Vector")}
                    }
                },
                {"Plugin", new List<AssetName>
                    {
                        {new AssetName("Asset Placement Palette","APP_",string.Empty,"APP_{0}")},
                        {new AssetName("Substance Graph Instance","SGI_",string.Empty,"SGI_{0}")},
                        {new AssetName("Substance Instance Factor","SIF_",string.Empty,"SIF_{0}")}
                    }
                },
                {"Audio", new List<AssetName>
                    {
                        {new AssetName("Attenuation",string.Empty,"_ATT","{0}_ATT")},
                        {new AssetName("Dialogue Voice","DV_",string.Empty,"DV_{0}")},
                        {new AssetName("Dialogue Wave","DW_",string.Empty,"DW_{0}")},
                        {new AssetName("Media Sound Wave","MSW_",string.Empty,"MSW_{0}")},
                        {new AssetName("Reverb Effect","Reverb_",string.Empty,"Reverb_{0}")},
                        {new AssetName("Sound Attenuation","ATT_",string.Empty,"ATT_{0}")},
                        {new AssetName("Sound Class","SCL_",string.Empty,"SoundClasses/SCL_{0}")},
                        {new AssetName("Sound Concurrency","SCL_","_CO","SCL_{0}_CO")},
                        {new AssetName("Sound Cue","A_","_Cue","A_{0}_Cue")},
                        {new AssetName("Sound Mix","Mix_",string.Empty,"Mix_{0}")},
                        {new AssetName("Sound Wave","A_",string.Empty,"A_{0}")},
                        {new AssetName("Soundscape Color","SC_",string.Empty,"SC_{0}")},
                        {new AssetName("Soundscape Palette","SP_",string.Empty,"SP_{0}")}
                    }
                },
                {"Blueprint", new List<AssetName>
                    {
                        {new AssetName("Blueprint","BP_",string.Empty,"BP_{0}")},
                        {new AssetName("Blueprint Actor Component","BP_","_AC","BP_{0}_AC")},
                        {new AssetName("Blueprint Scene Component","BP_","_SC","BP_{0}_SC")},
                        {new AssetName("Blueprint Function Library","BPFL_",string.Empty,"BPFL_{0}")},
                        {new AssetName("Blueprint Interface","BPI_",string.Empty,"BPI_{0}")},
                        {new AssetName("Blueprint Macro Library","BPML_",string.Empty,"BPML_{0}")},
                        {new AssetName("Enumerator","E",string.Empty,"E{0}")},
                        {new AssetName("Structure","S",string.Empty,"S{0}")},
                        {new AssetName("Tutorial Blueprint","TBP_",string.Empty,"TBP_{0}")}
                    }
                },
                {"Texture", new List<AssetName>
                    {
                        {new AssetName("Cube Render Target","RTC_",string.Empty,"RTC_{0}")},
                        {new AssetName("Media Texture","MT_",string.Empty,"MT_{0}")},
                        {new AssetName("Render Target","RT_",string.Empty,"RT_{0}")},
                        {new AssetName("Texture","T_",string.Empty,"T_{0}")},
                        {new AssetName("Texture (Alpha/Opacity)","T_","_A","T_{0}_A")},
                        {new AssetName("Texture (Ambient Occlusion)","T_","_AO","T_{0}_AO")},
                        {new AssetName("Texture (Base Color)","T_","_BC","T_{0}_BC")},
                        {new AssetName("Texture (Displacement)","T_","_D","T_{0}_D")},
                        {new AssetName("Texture (Emissive)","T_","_E","T_{0}_E")},
                        {new AssetName("Texture (Flow Map)","T_","_F","T_{0}_F")},
                        {new AssetName("Texture (Height)","T_","_H","T_{0}_H")},
                        {new AssetName("Texture (Light Map)","T_","_L","T_{0}_L")},
                        {new AssetName("Texture (Mask)","T_","_Mask","T_{0}_Mask")},
                        {new AssetName("Texture (Metallic)","T_","_M","T_{0}_M")},
                        {new AssetName("Texture (Normal)","T_","_N","T_{0}_N")},
                        {new AssetName("Texture", "Texture (Packed)","T_","_{1}","T_{0}_{1}", 100, "Color Order: ARMH")},
                        {new AssetName("Texture (Roughness)","T_","_R","T_{0}_R")},
                        {new AssetName("Texture (Specular)","T_","_S","T_{0}_S")},
                        {new AssetName("Texture Cube","TC_",string.Empty,"TC_{0}")},
                        {new AssetName("Texture Light Profile","TLP_",string.Empty,"TLP_{0}")}
                    }
                },
                {"Datasmith", new List<AssetName>
                    {
                        {new AssetName("Dataprep Asset","DPA_",string.Empty,"DPA_{0}")}
                    }
                },
                {"Physics", new List<AssetName>
                    {
                        {new AssetName("Destructable Mesh","DM_",string.Empty,"DM_{0}")},
                        {new AssetName("Physical Material","PM_",string.Empty,"PM_{0}")},
                        {new AssetName("Physics Asset","PHYS_",string.Empty,"PHYS_{0}")}
                    }
                },
                {"UI", new List<AssetName>
                    {
                        {new AssetName("Editor Utility Widget Blueprint","EUW_",string.Empty,"EUW_{0}")},
                        {new AssetName("Font","Font_",string.Empty,"Font_{0}")},
                        {new AssetName("Slate Brush","SB_",string.Empty,"SB_{0}")},
                        {new AssetName("Slate Widget Style","SWS_",string.Empty,"SWS_{0}")},
                        {new AssetName("Widget Blueprint","W_",string.Empty,"W_{0}")}
                    }
                },
                {"Enhanced Input", new List<AssetName>
                    {
                        {new AssetName("Input Action","IA_",string.Empty,"IA_{0}")},
                        {new AssetName("Input Mapping Context","IMC_",string.Empty,"IMC_{0}")}
                    }
                },
                {"Material", new List<AssetName>
                    {
                        {new AssetName("Material","M_",string.Empty,"M_{0}")},
                        {new AssetName("Material (Decal)","M_","_Decal","M_{0}_Decal")},
                        {new AssetName("Material (Light Function)","M_","_LF","M_{0}_LF")},
                        {new AssetName("Material (Post Process)","M_","_PP","M_{0}_PP")},
                        {new AssetName("Material (User Interface)","M_","_UI","M_{0}_UI")},
                        {new AssetName("Material (Volume)","M_","_Vol","M_{0}_Vol")},
                        {new AssetName("Material Function","MF_",string.Empty,"MF_{0}")},
                        {new AssetName("Material Instance","MI_",string.Empty,"MI_{0}")},
                        {new AssetName("Material Instance (Decal)","MI_","_Decal","MI_{0}_Decal")},
                        {new AssetName("Material Instance (Light Function)","MI_","_LF","MI_{0}_LF")},
                        {new AssetName("Material Instance (Post Process)","MI_","_PP","MI_{0}_PP")},
                        {new AssetName("Material Instance (User Interface)","MI_","_UI","MI_{0}_UI")},
                        {new AssetName("Material Instance (Volume)","MI_","_Vol","MI_{0}_Vol")},
                        {new AssetName("Material Parameter Collection","MPC_",string.Empty,"MPC_{0}")},
                        {new AssetName("Subsurface Profile","SP_",string.Empty,"SP_{0}")}
                    }
                },
                {"Niagara", new List<AssetName>
                    {
                        {new AssetName("Niagara Dynamic Input Script","NDIS_",string.Empty,"NDIS_{0}")},
                        {new AssetName("Niagara Effect Type","NET_",string.Empty,"NET_{0}")},
                        {new AssetName("Niagara Emitter","NE_",string.Empty,"NE_{0}")},
                        {new AssetName("Niagara Function Script","NFS_",string.Empty,"NFS_{0}")},
                        {new AssetName("Niagara Module Script","NMS_",string.Empty,"NMS_{0}")},
                        {new AssetName("Niagara Parameter Collection","NPC_",string.Empty,"NPC_{0}")},
                        {new AssetName("Niagara Parameter Collection Instance","NPCI_",string.Empty,"NPCI_{0}")},
                        {new AssetName("Niagara System","NS_",string.Empty,"NS_{0}")}
                    }
                },
                {"Paper2D", new List<AssetName>
                    {
                        {new AssetName("Paper Flipbook","PFB_",string.Empty,"PFB_{0}")},
                        {new AssetName("Sprite","SPR_",string.Empty,"SPR_{0}")},
                        {new AssetName("Sprite Atlas Group","SPRG_",string.Empty,"SPRG_{0}")},
                        {new AssetName("Tile Map","TM_",string.Empty,"TM_{0}")},
                        {new AssetName("Tile Set","TS_",string.Empty,"TS_{0}")}
                    }
                },
                {"Procedural", new List<AssetName>
                    {
                        {new AssetName("Procedural Content Generation","PCG_",string.Empty,"PCG_{0}")}
                    }
                }
            };
        private Panel panel1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label ExceptionLabel;
        private TextBox textBox4;
        private Panel panel2;
        private Label NameField;
    }
}
