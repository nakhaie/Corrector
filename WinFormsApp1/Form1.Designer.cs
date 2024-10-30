
namespace WinFormsApp1
{
    public class AssetName
    {
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

        public AssetName(string assetType, string prefix, string suffix, string example, string exception)
        {
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
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 5;
            button1.Location = new Point(432, 36);
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
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(12, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 29);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(574, 521);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "Form";
            Text = "Name Corrector";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;

        private readonly Dictionary<string, List<AssetName>> Domains
            = new Dictionary<string, List<AssetName>>
            {
                {"AI", new List<AssetName>
                    {
                        {new AssetName("AI Controller","AIC_","N/A","AIC_Example")},
                        {new AssetName("Behavior Tree","BT_","N/A","BT_Example")},
                        {new AssetName("Blackboard","BB_","N/A","BB_Example")},
                        {new AssetName("Decorator","BTD_","N/A","BTD_Example")},
                        {new AssetName("Environment Query","EQS_","N/A","EQS_Example")},
                        {new AssetName("Environment Query Context","EQS_","_Context","EQS_Example_Context")},
                        {new AssetName("Service","BTS_","N/A","BTS_Example")},
                        {new AssetName("Task","BTT_","N/A","BTT_Example")}
                    }
                },
                {"Gameplay", new List<AssetName>
                    {
                        {new AssetName("Ability Set","AS_","N/A","AS_Example")},
                        {new AssetName("Game Phase Abilities","Phase_","N/A","Phase_Example")},
                        {new AssetName("Gameplay Abilities","GA_","N/A","GA_Example")},
                        {new AssetName("Gameplay Cue Notifies","GCN_","N/A","GCN_Example")},
                        {new AssetName("Gameplay Effects","GE_","N/A","GE_Example")},
                        {new AssetName("Latent Gameplay Cue Notifies","GCNL_","N/A","GCNL_Example")}
                    }
                },
                {"Animation", new List<AssetName>
                    {
                        {new AssetName("Aim Offset","AO_","N/A","AO_Example")},
                        {new AssetName("Aim Offset 1D","AO_","N/A","AO_Example")},
                        {new AssetName("Animation Blueprint","ABP_","N/A","ABP_Example")},
                        {new AssetName("Animation Composite","AC_","N/A","AC_Example")},
                        {new AssetName("Animation Montage","AM_","N/A","AM_Example")},
                        {new AssetName("Animation Notify","AN_","N/A","AN_Example")},
                        {new AssetName("Animation Sequence","AS_","N/A","AS_Example")},
                        {new AssetName("Blend Space","BS_","N/A","BS_Example")},
                        {new AssetName("Blend Space 1D","BS_","N/A","BS_Example")},
                        {new AssetName("Level Sequence","LS_","N/A","LS_Example")},
                        {new AssetName("Morph Target","MT_","N/A","MT_Example")},
                        {new AssetName("Paper Flipbook","PFB_","N/A","PFB_Example")},
                        {new AssetName("Rig","Rig_","N/A","Rig_Example")},
                        {new AssetName("Skeletal Mesh","SK_","N/A","SK_Example")},
                        {new AssetName("Skeleton","SKEL_","N/A","SKEL_Example")}
                    }
                },
                {"Misc", new List<AssetName>
                    {
                        {new AssetName("Animated Vector Field","VFA_","N/A","VFA_Example")},
                        {new AssetName("Blink Media Player","BMP_","N/A","BMP_Example")},
                        {new AssetName("Camera Anim","CA_","N/A","CA_Example")},
                        {new AssetName("Color Curve","Curve_","_Color","Curve_Example_Color")},
                        {new AssetName("Curve Atlas","Curve_","_Atlas","Curve_Example_Atlas")},
                        {new AssetName("Curve Table","Curve_","_Table","Curve_Example_Table")},
                        {new AssetName("Data Asset","DA_{sub-class type}_","N/A","DA_{Weapon}_Example")},
                        {new AssetName("Data Registry","DR_","N/A","DR_Example")},
                        {new AssetName("Data Table","DT_","N/A","DT_Example")},
                        {new AssetName("File Media Source","FMS_","N/A","FMS_Example")},
                        {new AssetName("Float Curve","Curve_","_Float","Curve_Example_Float")},
                        {new AssetName("Foliage Type","FT_","N/A","FT_Example")},
                        {new AssetName("Force Feedback Effect","FFE_","N/A","FFE_Example")},
                        {new AssetName("Landscape Grass Type","LG_","N/A","LG_Example")},
                        {new AssetName("Landscape Layer","LL_","N/A","LL_Example")},
                        {new AssetName("Level","L_","N/A","L_Example")},
                        {new AssetName("Level (World Partition)","L_","_WP","L_Example_WP")},
                        {new AssetName("Level Instance","LI_","N/A","LI_Example")},
                        {new AssetName("Media Player","MP_","N/A","MP_Example")},
                        {new AssetName("Object Library","OL_","N/A","OL_Example")},
                        {new AssetName("Redirector","RE_","N/A","RE_Example")},
                        {new AssetName("Static Mesh","SM_","N/A","SM_Example")},
                        {new AssetName("Static Vector Field","VF_","N/A","VF_Example")},
                        {new AssetName("Touch Interface Setup","TI_","N/A","TI_Example")},
                        {new AssetName("Vector Curve","Curve_","_Vector","Curve_Example_Vector")}
                    }
                },
                {"Plugin", new List<AssetName>
                    {
                        {new AssetName("Asset Placement Palette","APP_","N/A","APP_Example")},
                        {new AssetName("Substance Graph Instance","SGI_","N/A","SGI_Example")},
                        {new AssetName("Substance Instance Factor","SIF_","N/A","SIF_Example")}
                    }
                },
                {"Audio", new List<AssetName>
                    {
                        {new AssetName("Attenuation","N/A","_ATT","Example_ATT")},
                        {new AssetName("Dialogue Voice","DV_","N/A","DV_Example")},
                        {new AssetName("Dialogue Wave","DW_","N/A","DW_Example")},
                        {new AssetName("Media Sound Wave","MSW_","N/A","MSW_Example")},
                        {new AssetName("Reverb Effect","Reverb_","N/A","Reverb_Example")},
                        {new AssetName("Sound Attenuation","ATT_","N/A","ATT_Example")},
                        {new AssetName("Sound Class","SCL_","N/A","SoundClasses/SCL_Example")},
                        {new AssetName("Sound Concurrency","SCL_","_CO","SCL_Example_CO")},
                        {new AssetName("Sound Cue","A_","_Cue","A_Example_Cue")},
                        {new AssetName("Sound Mix","Mix_","N/A","Mix_Example")},
                        {new AssetName("Sound Wave","A_","N/A","A_Example")},
                        {new AssetName("Soundscape Color","SC_","N/A","SC_Example")},
                        {new AssetName("Soundscape Palette","SP_","N/A","SP_Example")}
                    }
                },
                {"Blueprint", new List<AssetName>
                    {
                        {new AssetName("Blueprint","BP_","N/A","BP_Example")},
                        {new AssetName("Blueprint Actor Component","BP_","_AC","BP_Example_AC")},
                        {new AssetName("Blueprint Scene Component","BP_","_SC","BP_Example_SC")},
                        {new AssetName("Blueprint Function Library","BPFL_","N/A","BPFL_Example")},
                        {new AssetName("Blueprint Interface","BPI_","N/A","BPI_Example")},
                        {new AssetName("Blueprint Macro Library","BPML_","N/A","BPML_Example")},
                        {new AssetName("Enumerator","E","N/A","EExample")},
                        {new AssetName("Structure","S","N/A","SExample")},
                        {new AssetName("Tutorial Blueprint","TBP_","N/A","TBP_Example")}
                    }
                },
                {"Texture", new List<AssetName>
                    {
                        {new AssetName("Cube Render Target","RTC_","N/A","RTC_Example")},
                        {new AssetName("Media Texture","MT_","N/A","MT_Example")},
                        {new AssetName("Render Target","RT_","N/A","RT_Example")},
                        {new AssetName("Texture","T_","N/A","T_Example")},
                        {new AssetName("Texture (Alpha/Opacity)","T_","_A","T_Example_A")},
                        {new AssetName("Texture (Ambient Occlusion)","T_","_AO","T_Example_AO")},
                        {new AssetName("Texture (Base Color)","T_","_BC","T_Example_BC")},
                        {new AssetName("Texture (Displacement)","T_","_D","T_Example_D")},
                        {new AssetName("Texture (Emissive)","T_","_E","T_Example_E")},
                        {new AssetName("Texture (Flow Map)","T_","_F","T_Example_F")},
                        {new AssetName("Texture (Height)","T_","_H","T_Example_H")},
                        {new AssetName("Texture (Light Map)","T_","_L","T_Example_L")},
                        {new AssetName("Texture (Mask)","T_","_Mask","T_Example_Mask")},
                        {new AssetName("Texture (Metallic)","T_","_M","T_Example_M")},
                        {new AssetName("Texture (Normal)","T_","_N","T_Example_N")},
                        {new AssetName("Texture (Packed)","T_","_{By Order}","T_Example_{ARMH}")},
                        {new AssetName("Texture (Roughness)","T_","_R","T_Example_R")},
                        {new AssetName("Texture (Specular)","T_","_S","T_Example_S")},
                        {new AssetName("Texture Cube","TC_","N/A","TC_Example")},
                        {new AssetName("Texture Light Profile","TLP_","N/A","TLP_Example")}
                    }
                },
                {"Datasmith", new List<AssetName>
                    {
                        {new AssetName("Dataprep Asset","DPA_","N/A","DPA_Example")}
                    }
                },
                {"Physics", new List<AssetName>
                    {
                        {new AssetName("Destructable Mesh","DM_","N/A","DM_Example")},
                        {new AssetName("Physical Material","PM_","N/A","PM_Example")},
                        {new AssetName("Physics Asset","PHYS_","N/A","PHYS_Example")}
                    }
                },
                {"UI", new List<AssetName>
                    {
                        {new AssetName("Editor Utility Widget Blueprint","EUW_","N/A","EUW_Example")},
                        {new AssetName("Font","Font_","N/A","Font_Example")},
                        {new AssetName("Slate Brush","SB_","N/A","SB_Example")},
                        {new AssetName("Slate Widget Style","SWS_","N/A","SWS_Example")},
                        {new AssetName("Widget Blueprint","W_","N/A","W_Example")}
                    }
                },
                {"Enhanced Input", new List<AssetName>
                    {
                        {new AssetName("Input Action","IA_","N/A","IA_Example")},
                        {new AssetName("Input Mapping Context","IMC_","N/A","IMC_Example")}
                    }
                },
                {"Material", new List<AssetName>
                    {
                        {new AssetName("Material","M_","N/A","M_Example")},
                        {new AssetName("Material (Decal)","M_","_Decal","M_Example_Decal")},
                        {new AssetName("Material (Light Function)","M_","_LF","M_Example_LF")},
                        {new AssetName("Material (Post Process)","M_","_PP","M_Example_PP")},
                        {new AssetName("Material (User Interface)","M_","_UI","M_Example_UI")},
                        {new AssetName("Material (Volume)","M_","_Vol","M_Example_Vol")},
                        {new AssetName("Material Function","MF_","N/A","MF_Example")},
                        {new AssetName("Material Instance","MI_","N/A","MI_Example")},
                        {new AssetName("Material Instance (Decal)","MI_","_Decal","MI_Example_Decal")},
                        {new AssetName("Material Instance (Light Function)","MI_","_LF","MI_Example_LF")},
                        {new AssetName("Material Instance (Post Process)","MI_","_PP","MI_Example_PP")},
                        {new AssetName("Material Instance (User Interface)","MI_","_UI","MI_Example_UI")},
                        {new AssetName("Material Instance (Volume)","MI_","_Vol","MI_Example_Vol")},
                        {new AssetName("Material Parameter Collection","MPC_","N/A","MPC_Example")},
                        {new AssetName("Subsurface Profile","SP_","N/A","SP_Example")}
                    }
                },
                {"Niagara", new List<AssetName>
                    {
                        {new AssetName("Niagara Dynamic Input Script","NDIS_","N/A","NDIS_Example")},
                        {new AssetName("Niagara Effect Type","NET_","N/A","NET_Example")},
                        {new AssetName("Niagara Emitter","NE_","N/A","NE_Example")},
                        {new AssetName("Niagara Function Script","NFS_","N/A","NFS_Example")},
                        {new AssetName("Niagara Module Script","NMS_","N/A","NMS_Example")},
                        {new AssetName("Niagara Parameter Collection","NPC_","N/A","NPC_Example")},
                        {new AssetName("Niagara Parameter Collection Instance","NPCI_","N/A","NPCI_Example")},
                        {new AssetName("Niagara System","NS_","N/A","NS_Example")}
                    }
                },
                {"Paper2D", new List<AssetName>
                    {
                        {new AssetName("Paper Flipbook","PFB_","N/A","PFB_Example")},
                        {new AssetName("Sprite","SPR_","N/A","SPR_Example")},
                        {new AssetName("Sprite Atlas Group","SPRG_","N/A","SPRG_Example")},
                        {new AssetName("Tile Map","TM_","N/A","TM_Example")},
                        {new AssetName("Tile Set","TS_","N/A","TS_Example")}
                    }
                },
                {"Procedural", new List<AssetName>
                    {
                        {new AssetName("Procedural Content Generation","PCG_","N/A","PCG_Example")}
                    }
                }
            };

    }
}
