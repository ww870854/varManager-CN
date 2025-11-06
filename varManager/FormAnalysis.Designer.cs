namespace varManager
{
    partial class FormAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnalysis));
            this.label1 = new System.Windows.Forms.Label();
            this.labelSceneName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddAsSubscene = new System.Windows.Forms.Button();
            this.buttonAddToScene = new System.Windows.Forms.Button();
            this.buttonLoadScene = new System.Windows.Forms.Button();
            this.triStateTreeViewAtoms = new nsThreeStateTreeview.TriStateTreeView();
            this.labelMessage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxBreast = new System.Windows.Forms.CheckBox();
            this.checkBoxSkin = new System.Windows.Forms.CheckBox();
            this.checkBoxGlute = new System.Windows.Forms.CheckBox();
            this.checkBoxClothing = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreGender = new System.Windows.Forms.CheckBox();
            this.checkBoxHair = new System.Windows.Forms.CheckBox();
            this.buttonLoadLook = new System.Windows.Forms.Button();
            this.buttonLoadPlugin = new System.Windows.Forms.Button();
            this.buttonLoadAnimation = new System.Windows.Forms.Button();
            this.buttonLoadPose = new System.Windows.Forms.Button();
            this.checkBoxMorphs = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPerson = new System.Windows.Forms.ListBox();
            this.listBoxAtom = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "场景名称";
            // 
            // labelSceneName
            // 
            this.labelSceneName.Location = new System.Drawing.Point(102, 15);
            this.labelSceneName.Name = "labelSceneName";
            this.labelSceneName.Size = new System.Drawing.Size(421, 52);
            this.labelSceneName.TabIndex = 7;
            this.labelSceneName.Text = "label2";
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(386, 489);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(118, 35);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "取消";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 412);
            this.tabControl1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.tabControl1, "List of Atoms in current scene");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAddAsSubscene);
            this.tabPage2.Controls.Add(this.buttonAddToScene);
            this.tabPage2.Controls.Add(this.buttonLoadScene);
            this.tabPage2.Controls.Add(this.triStateTreeViewAtoms);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "原子列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddAsSubscene
            // 
            this.buttonAddAsSubscene.Location = new System.Drawing.Point(340, 264);
            this.buttonAddAsSubscene.Name = "buttonAddAsSubscene";
            this.buttonAddAsSubscene.Size = new System.Drawing.Size(118, 50);
            this.buttonAddAsSubscene.TabIndex = 1;
            this.buttonAddAsSubscene.Text = "添加为子场景";
            this.toolTip1.SetToolTip(this.buttonAddAsSubscene, "Selected atoms aggregate into subscene and add to running scene");
            this.buttonAddAsSubscene.UseVisualStyleBackColor = true;
            this.buttonAddAsSubscene.Click += new System.EventHandler(this.buttonAddAsSubscene_Click);
            // 
            // buttonAddToScene
            // 
            this.buttonAddToScene.Location = new System.Drawing.Point(340, 182);
            this.buttonAddToScene.Name = "buttonAddToScene";
            this.buttonAddToScene.Size = new System.Drawing.Size(118, 50);
            this.buttonAddToScene.TabIndex = 1;
            this.buttonAddToScene.Text = "添加到场景中";
            this.toolTip1.SetToolTip(this.buttonAddToScene, "Selected atoms add to running scene");
            this.buttonAddToScene.UseVisualStyleBackColor = true;
            this.buttonAddToScene.Click += new System.EventHandler(this.buttonAddToScene_Click);
            // 
            // buttonLoadScene
            // 
            this.buttonLoadScene.Location = new System.Drawing.Point(340, 100);
            this.buttonLoadScene.Name = "buttonLoadScene";
            this.buttonLoadScene.Size = new System.Drawing.Size(118, 50);
            this.buttonLoadScene.TabIndex = 1;
            this.buttonLoadScene.Text = "加载场景";
            this.toolTip1.SetToolTip(this.buttonLoadScene, "Selected atoms loaded as a new scene");
            this.buttonLoadScene.UseVisualStyleBackColor = true;
            this.buttonLoadScene.Click += new System.EventHandler(this.buttonLoadScene_Click);
            // 
            // triStateTreeViewAtoms
            // 
            this.triStateTreeViewAtoms.Location = new System.Drawing.Point(6, 6);
            this.triStateTreeViewAtoms.Name = "triStateTreeViewAtoms";
            this.triStateTreeViewAtoms.Size = new System.Drawing.Size(293, 370);
            this.triStateTreeViewAtoms.TabIndex = 0;
            this.triStateTreeViewAtoms.TriStateStyleProperty = nsThreeStateTreeview.TriStateTreeView.TriStateStyles.Standard;
            this.triStateTreeViewAtoms.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.triStateTreeViewAtoms_AfterCheck);
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelMessage.Location = new System.Drawing.Point(16, 481);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(364, 55);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "labelMessage";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessage.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxBreast
            // 
            this.checkBoxBreast.AutoSize = true;
            this.checkBoxBreast.Checked = global::varManager.Properties.Settings.Default.presetBreast;
            this.checkBoxBreast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBreast.Location = new System.Drawing.Point(362, 52);
            this.checkBoxBreast.Name = "checkBoxBreast";
            this.checkBoxBreast.Size = new System.Drawing.Size(74, 18);
            this.checkBoxBreast.TabIndex = 8;
            this.checkBoxBreast.Text = "乳房物理";
            this.toolTip1.SetToolTip(this.checkBoxBreast, "Breast Physics Preset");
            this.checkBoxBreast.UseVisualStyleBackColor = true;
            // 
            // checkBoxSkin
            // 
            this.checkBoxSkin.AutoSize = true;
            this.checkBoxSkin.Checked = global::varManager.Properties.Settings.Default.presetSkin;
            this.checkBoxSkin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSkin.Location = new System.Drawing.Point(362, 10);
            this.checkBoxSkin.Name = "checkBoxSkin";
            this.checkBoxSkin.Size = new System.Drawing.Size(50, 18);
            this.checkBoxSkin.TabIndex = 8;
            this.checkBoxSkin.Text = "皮肤";
            this.toolTip1.SetToolTip(this.checkBoxSkin, "Skin Preset");
            this.checkBoxSkin.UseVisualStyleBackColor = true;
            // 
            // checkBoxGlute
            // 
            this.checkBoxGlute.AutoSize = true;
            this.checkBoxGlute.Checked = global::varManager.Properties.Settings.Default.presetGlute;
            this.checkBoxGlute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGlute.Location = new System.Drawing.Point(361, 94);
            this.checkBoxGlute.Name = "checkBoxGlute";
            this.checkBoxGlute.Size = new System.Drawing.Size(74, 18);
            this.checkBoxGlute.TabIndex = 8;
            this.checkBoxGlute.Text = "臀肌物理";
            this.toolTip1.SetToolTip(this.checkBoxGlute, "Glute Physics Preset");
            this.checkBoxGlute.UseVisualStyleBackColor = true;
            // 
            // checkBoxClothing
            // 
            this.checkBoxClothing.AutoSize = true;
            this.checkBoxClothing.Checked = global::varManager.Properties.Settings.Default.presetClothing;
            this.checkBoxClothing.Location = new System.Drawing.Point(254, 94);
            this.checkBoxClothing.Name = "checkBoxClothing";
            this.checkBoxClothing.Size = new System.Drawing.Size(50, 18);
            this.checkBoxClothing.TabIndex = 8;
            this.checkBoxClothing.Text = "服装";
            this.toolTip1.SetToolTip(this.checkBoxClothing, "Clothing Preset");
            this.checkBoxClothing.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreGender
            // 
            this.checkBoxIgnoreGender.AutoSize = true;
            this.checkBoxIgnoreGender.Location = new System.Drawing.Point(371, 176);
            this.checkBoxIgnoreGender.Name = "checkBoxIgnoreGender";
            this.checkBoxIgnoreGender.Size = new System.Drawing.Size(74, 18);
            this.checkBoxIgnoreGender.TabIndex = 8;
            this.checkBoxIgnoreGender.Text = "忽略性别";
            this.checkBoxIgnoreGender.UseVisualStyleBackColor = true;
            // 
            // checkBoxHair
            // 
            this.checkBoxHair.AutoSize = true;
            this.checkBoxHair.Checked = global::varManager.Properties.Settings.Default.presetHair;
            this.checkBoxHair.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHair.Location = new System.Drawing.Point(254, 52);
            this.checkBoxHair.Name = "checkBoxHair";
            this.checkBoxHair.Size = new System.Drawing.Size(50, 18);
            this.checkBoxHair.TabIndex = 8;
            this.checkBoxHair.Text = "发型";
            this.toolTip1.SetToolTip(this.checkBoxHair, "HairStyle Preset");
            this.checkBoxHair.UseVisualStyleBackColor = true;
            // 
            // buttonLoadLook
            // 
            this.buttonLoadLook.Enabled = false;
            this.buttonLoadLook.Location = new System.Drawing.Point(371, 204);
            this.buttonLoadLook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadLook.Name = "buttonLoadLook";
            this.buttonLoadLook.Size = new System.Drawing.Size(118, 35);
            this.buttonLoadLook.TabIndex = 4;
            this.buttonLoadLook.Text = "加载外观";
            this.toolTip1.SetToolTip(this.buttonLoadLook, "Load presets for person in running scene ");
            this.buttonLoadLook.UseVisualStyleBackColor = true;
            this.buttonLoadLook.Click += new System.EventHandler(this.buttonLoadLook_Click);
            // 
            // buttonLoadPlugin
            // 
            this.buttonLoadPlugin.Enabled = false;
            this.buttonLoadPlugin.Location = new System.Drawing.Point(370, 332);
            this.buttonLoadPlugin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadPlugin.Name = "buttonLoadPlugin";
            this.buttonLoadPlugin.Size = new System.Drawing.Size(118, 35);
            this.buttonLoadPlugin.TabIndex = 4;
            this.buttonLoadPlugin.Text = "加载插件";
            this.toolTip1.SetToolTip(this.buttonLoadPlugin, "Load plugin preset for person in running scene ");
            this.buttonLoadPlugin.UseVisualStyleBackColor = true;
            this.buttonLoadPlugin.Click += new System.EventHandler(this.buttonLoadPlugin_Click);
            // 
            // buttonLoadAnimation
            // 
            this.buttonLoadAnimation.Enabled = false;
            this.buttonLoadAnimation.Location = new System.Drawing.Point(371, 290);
            this.buttonLoadAnimation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadAnimation.Name = "buttonLoadAnimation";
            this.buttonLoadAnimation.Size = new System.Drawing.Size(118, 35);
            this.buttonLoadAnimation.TabIndex = 4;
            this.buttonLoadAnimation.Text = "加载动画";
            this.toolTip1.SetToolTip(this.buttonLoadAnimation, "Load animtion for person in running scene ");
            this.buttonLoadAnimation.UseVisualStyleBackColor = true;
            this.buttonLoadAnimation.Click += new System.EventHandler(this.buttonLoadAnimation_Click);
            // 
            // buttonLoadPose
            // 
            this.buttonLoadPose.Location = new System.Drawing.Point(371, 247);
            this.buttonLoadPose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadPose.Name = "buttonLoadPose";
            this.buttonLoadPose.Size = new System.Drawing.Size(118, 35);
            this.buttonLoadPose.TabIndex = 4;
            this.buttonLoadPose.Text = "加载姿势";
            this.toolTip1.SetToolTip(this.buttonLoadPose, "Load pose for person in running scene ");
            this.buttonLoadPose.UseVisualStyleBackColor = true;
            this.buttonLoadPose.Click += new System.EventHandler(this.buttonLoadPose_Click);
            // 
            // checkBoxMorphs
            // 
            this.checkBoxMorphs.AutoSize = true;
            this.checkBoxMorphs.Checked = global::varManager.Properties.Settings.Default.presetMorphs;
            this.checkBoxMorphs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMorphs.Location = new System.Drawing.Point(254, 10);
            this.checkBoxMorphs.Name = "checkBoxMorphs";
            this.checkBoxMorphs.Size = new System.Drawing.Size(50, 18);
            this.checkBoxMorphs.TabIndex = 8;
            this.checkBoxMorphs.Text = "变形";
            this.toolTip1.SetToolTip(this.checkBoxMorphs, "Morph Preset");
            this.checkBoxMorphs.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(240, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 203);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // listBoxPerson
            // 
            this.listBoxPerson.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPerson.FormattingEnabled = true;
            this.listBoxPerson.ItemHeight = 23;
            this.listBoxPerson.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.listBoxPerson.Location = new System.Drawing.Point(6, 24);
            this.listBoxPerson.Name = "listBoxPerson";
            this.listBoxPerson.Size = new System.Drawing.Size(112, 156);
            this.listBoxPerson.TabIndex = 9;
            this.toolTip1.SetToolTip(this.listBoxPerson, "Person order in running scene");
            // 
            // listBoxAtom
            // 
            this.listBoxAtom.FormattingEnabled = true;
            this.listBoxAtom.ItemHeight = 14;
            this.listBoxAtom.Location = new System.Drawing.Point(6, 6);
            this.listBoxAtom.Name = "listBoxAtom";
            this.listBoxAtom.Size = new System.Drawing.Size(226, 354);
            this.listBoxAtom.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listBoxAtom, "List of Persons in current scene");
            this.listBoxAtom.SelectedIndexChanged += new System.EventHandler(this.listBoxAtom_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxAtom);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.checkBoxMorphs);
            this.tabPage1.Controls.Add(this.buttonLoadPose);
            this.tabPage1.Controls.Add(this.buttonLoadAnimation);
            this.tabPage1.Controls.Add(this.buttonLoadPlugin);
            this.tabPage1.Controls.Add(this.buttonLoadLook);
            this.tabPage1.Controls.Add(this.checkBoxHair);
            this.tabPage1.Controls.Add(this.checkBoxIgnoreGender);
            this.tabPage1.Controls.Add(this.checkBoxClothing);
            this.tabPage1.Controls.Add(this.checkBoxGlute);
            this.tabPage1.Controls.Add(this.checkBoxSkin);
            this.tabPage1.Controls.Add(this.checkBoxBreast);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "人物列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormAnalysis
            // 
            this.AcceptButton = this.buttonLoadLook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(541, 534);
            this.ControlBox = false;
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelSceneName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Analysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAnalysis_FormClosed);
            this.Load += new System.EventHandler(this.FormAnalysis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSceneName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private nsThreeStateTreeview.TriStateTreeView triStateTreeViewAtoms;
        private System.Windows.Forms.Button buttonLoadScene;
        private System.Windows.Forms.Button buttonAddToScene;
        private System.Windows.Forms.Button buttonAddAsSubscene;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxAtom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMorphs;
        private System.Windows.Forms.Button buttonLoadPose;
        private System.Windows.Forms.Button buttonLoadAnimation;
        private System.Windows.Forms.Button buttonLoadPlugin;
        private System.Windows.Forms.Button buttonLoadLook;
        private System.Windows.Forms.CheckBox checkBoxHair;
        private System.Windows.Forms.CheckBox checkBoxIgnoreGender;
        private System.Windows.Forms.CheckBox checkBoxClothing;
        private System.Windows.Forms.CheckBox checkBoxGlute;
        private System.Windows.Forms.CheckBox checkBoxSkin;
        private System.Windows.Forms.CheckBox checkBoxBreast;
        private System.Windows.Forms.ListBox listBoxPerson;
    }
}