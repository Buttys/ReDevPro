namespace ReDevPro
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.CustomizeTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.YGOProOptionsControl = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.YGOProSkin = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.AboutTxt = new System.Windows.Forms.Label();
            this.MenuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.QuickDuelBtn = new System.Windows.Forms.Button();
            this.DeckEditBtn = new System.Windows.Forms.Button();
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.AiBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServerSelectTxt = new System.Windows.Forms.Label();
            this.ServerSelect = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.CustomizeTab.SuspendLayout();
            this.OptionsTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.MenuLayout.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.MainTabControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MenuLayout, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.CustomizeTab);
            this.MainTabControl.Controls.Add(this.OptionsTab);
            this.MainTabControl.Controls.Add(this.AboutTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(3, 3);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(912, 437);
            this.MainTabControl.TabIndex = 0;
            // 
            // CustomizeTab
            // 
            this.CustomizeTab.Controls.Add(this.label1);
            this.CustomizeTab.Location = new System.Drawing.Point(4, 22);
            this.CustomizeTab.Name = "CustomizeTab";
            this.CustomizeTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomizeTab.Size = new System.Drawing.Size(904, 411);
            this.CustomizeTab.TabIndex = 2;
            this.CustomizeTab.Text = "Customize";
            this.CustomizeTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 405);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buttys was here. Try again later!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionsTab
            // 
            this.OptionsTab.Controls.Add(this.tableLayoutPanel2);
            this.OptionsTab.Location = new System.Drawing.Point(4, 22);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTab.Size = new System.Drawing.Size(904, 411);
            this.OptionsTab.TabIndex = 3;
            this.OptionsTab.Text = "Options";
            this.OptionsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(898, 405);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(701, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YGOPro Options";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.YGOProOptionsControl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(188, 289);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // YGOProOptionsControl
            // 
            this.YGOProOptionsControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YGOProOptionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YGOProOptionsControl.FormattingEnabled = true;
            this.YGOProOptionsControl.Location = new System.Drawing.Point(3, 3);
            this.YGOProOptionsControl.Name = "YGOProOptionsControl";
            this.YGOProOptionsControl.Size = new System.Drawing.Size(182, 229);
            this.YGOProOptionsControl.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.YGOProSkin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 48);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Skin:";
            // 
            // YGOProSkin
            // 
            this.YGOProSkin.FormattingEnabled = true;
            this.YGOProSkin.Location = new System.Drawing.Point(40, 16);
            this.YGOProSkin.Name = "YGOProSkin";
            this.YGOProSkin.Size = new System.Drawing.Size(139, 21);
            this.YGOProSkin.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Launcher Options";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(686, 380);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buttys was here. Try again later!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.AboutTxt);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(904, 411);
            this.AboutTab.TabIndex = 1;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // AboutTxt
            // 
            this.AboutTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutTxt.Location = new System.Drawing.Point(3, 3);
            this.AboutTxt.Name = "AboutTxt";
            this.AboutTxt.Size = new System.Drawing.Size(898, 405);
            this.AboutTxt.TabIndex = 0;
            this.AboutTxt.Text = "Buttys was here. Try again later!";
            this.AboutTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuLayout
            // 
            this.MenuLayout.ColumnCount = 2;
            this.MenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 586F));
            this.MenuLayout.Controls.Add(this.MenuPanel, 1, 0);
            this.MenuLayout.Controls.Add(this.panel1, 0, 0);
            this.MenuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuLayout.Location = new System.Drawing.Point(3, 446);
            this.MenuLayout.Name = "MenuLayout";
            this.MenuLayout.RowCount = 1;
            this.MenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuLayout.Size = new System.Drawing.Size(912, 34);
            this.MenuLayout.TabIndex = 1;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.Controls.Add(this.QuickDuelBtn);
            this.MenuPanel.Controls.Add(this.DeckEditBtn);
            this.MenuPanel.Controls.Add(this.ReplayBtn);
            this.MenuPanel.Controls.Add(this.AiBtn);
            this.MenuPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.MenuPanel.Location = new System.Drawing.Point(329, 3);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(580, 28);
            this.MenuPanel.TabIndex = 0;
            // 
            // QuickDuelBtn
            // 
            this.QuickDuelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuickDuelBtn.Location = new System.Drawing.Point(502, 3);
            this.QuickDuelBtn.Name = "QuickDuelBtn";
            this.QuickDuelBtn.Size = new System.Drawing.Size(75, 23);
            this.QuickDuelBtn.TabIndex = 0;
            this.QuickDuelBtn.Text = "Duel!";
            this.QuickDuelBtn.UseVisualStyleBackColor = true;
            // 
            // DeckEditBtn
            // 
            this.DeckEditBtn.Location = new System.Drawing.Point(421, 3);
            this.DeckEditBtn.Name = "DeckEditBtn";
            this.DeckEditBtn.Size = new System.Drawing.Size(75, 23);
            this.DeckEditBtn.TabIndex = 2;
            this.DeckEditBtn.Text = "Deck Edit";
            this.DeckEditBtn.UseVisualStyleBackColor = true;
            this.DeckEditBtn.Click += new System.EventHandler(this.DeckEditBtn_Click);
            // 
            // ReplayBtn
            // 
            this.ReplayBtn.Location = new System.Drawing.Point(340, 3);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.Size = new System.Drawing.Size(75, 23);
            this.ReplayBtn.TabIndex = 3;
            this.ReplayBtn.Text = "Replays";
            this.ReplayBtn.UseVisualStyleBackColor = true;
            this.ReplayBtn.Click += new System.EventHandler(this.ReplayBtn_Click);
            // 
            // AiBtn
            // 
            this.AiBtn.Location = new System.Drawing.Point(259, 3);
            this.AiBtn.Name = "AiBtn";
            this.AiBtn.Size = new System.Drawing.Size(75, 23);
            this.AiBtn.TabIndex = 5;
            this.AiBtn.Text = "AI";
            this.AiBtn.UseVisualStyleBackColor = true;
            this.AiBtn.Click += new System.EventHandler(this.AiBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ServerSelectTxt);
            this.panel1.Controls.Add(this.ServerSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 28);
            this.panel1.TabIndex = 1;
            // 
            // ServerSelectTxt
            // 
            this.ServerSelectTxt.AutoSize = true;
            this.ServerSelectTxt.Location = new System.Drawing.Point(6, 8);
            this.ServerSelectTxt.Name = "ServerSelectTxt";
            this.ServerSelectTxt.Size = new System.Drawing.Size(74, 13);
            this.ServerSelectTxt.TabIndex = 1;
            this.ServerSelectTxt.Text = "Server Select:";
            // 
            // ServerSelect
            // 
            this.ServerSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerSelect.FormattingEnabled = true;
            this.ServerSelect.Location = new System.Drawing.Point(86, 4);
            this.ServerSelect.Name = "ServerSelect";
            this.ServerSelect.Size = new System.Drawing.Size(121, 21);
            this.ServerSelect.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Re:DevPro - Beta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.CustomizeTab.ResumeLayout(false);
            this.OptionsTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.AboutTab.ResumeLayout(false);
            this.MenuLayout.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TableLayoutPanel MenuLayout;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel;
        private System.Windows.Forms.Button QuickDuelBtn;
        private System.Windows.Forms.Button DeckEditBtn;
        private System.Windows.Forms.Button ReplayBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ServerSelectTxt;
        private System.Windows.Forms.ComboBox ServerSelect;
        private System.Windows.Forms.Button AiBtn;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.Label AboutTxt;
        private System.Windows.Forms.TabPage CustomizeTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage OptionsTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckedListBox YGOProOptionsControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox YGOProSkin;
        private System.Windows.Forms.Label label3;
    }
}

