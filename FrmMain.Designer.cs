namespace Maple_Scroll_Probability_Calculator
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel = new System.Windows.Forms.Panel();
            this.stat100 = new System.Windows.Forms.NumericUpDown();
            this.stat70 = new System.Windows.Forms.NumericUpDown();
            this.stat60 = new System.Windows.Forms.NumericUpDown();
            this.stat30 = new System.Windows.Forms.NumericUpDown();
            this.stat10 = new System.Windows.Forms.NumericUpDown();
            this.lblStat = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl70 = new System.Windows.Forms.Label();
            this.lbl60 = new System.Windows.Forms.Label();
            this.lbl30 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.cmb100 = new System.Windows.Forms.ComboBox();
            this.cmb70 = new System.Windows.Forms.ComboBox();
            this.cmb60 = new System.Windows.Forms.ComboBox();
            this.cmb30 = new System.Windows.Forms.ComboBox();
            this.cmb10 = new System.Windows.Forms.ComboBox();
            this.lblSlots = new System.Windows.Forms.Label();
            this.cmbSlots = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tblOutputTable = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stat100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOutputTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.stat100);
            this.panel.Controls.Add(this.stat70);
            this.panel.Controls.Add(this.stat60);
            this.panel.Controls.Add(this.stat30);
            this.panel.Controls.Add(this.stat10);
            this.panel.Controls.Add(this.lblStat);
            this.panel.Controls.Add(this.lbl100);
            this.panel.Controls.Add(this.lbl70);
            this.panel.Controls.Add(this.lbl60);
            this.panel.Controls.Add(this.lbl30);
            this.panel.Controls.Add(this.lbl10);
            this.panel.Controls.Add(this.cmb100);
            this.panel.Controls.Add(this.cmb70);
            this.panel.Controls.Add(this.cmb60);
            this.panel.Controls.Add(this.cmb30);
            this.panel.Controls.Add(this.cmb10);
            this.panel.Controls.Add(this.lblSlots);
            this.panel.Controls.Add(this.cmbSlots);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(379, 181);
            this.panel.TabIndex = 0;
            // 
            // stat100
            // 
            this.stat100.Location = new System.Drawing.Point(186, 151);
            this.stat100.Name = "stat100";
            this.stat100.Size = new System.Drawing.Size(183, 20);
            this.stat100.TabIndex = 18;
            // 
            // stat70
            // 
            this.stat70.Location = new System.Drawing.Point(186, 124);
            this.stat70.Name = "stat70";
            this.stat70.Size = new System.Drawing.Size(183, 20);
            this.stat70.TabIndex = 17;
            // 
            // stat60
            // 
            this.stat60.Location = new System.Drawing.Point(186, 97);
            this.stat60.Name = "stat60";
            this.stat60.Size = new System.Drawing.Size(183, 20);
            this.stat60.TabIndex = 16;
            // 
            // stat30
            // 
            this.stat30.Location = new System.Drawing.Point(186, 70);
            this.stat30.Name = "stat30";
            this.stat30.Size = new System.Drawing.Size(183, 20);
            this.stat30.TabIndex = 15;
            // 
            // stat10
            // 
            this.stat10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stat10.Location = new System.Drawing.Point(186, 43);
            this.stat10.Name = "stat10";
            this.stat10.Size = new System.Drawing.Size(183, 20);
            this.stat10.TabIndex = 14;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(183, 18);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(186, 13);
            this.lblStat.TabIndex = 13;
            this.lblStat.Text = "Increase to desired stat upon success";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Location = new System.Drawing.Point(17, 153);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(95, 13);
            this.lbl100.TabIndex = 11;
            this.lbl100.Text = "100% Scrolls Used";
            // 
            // lbl70
            // 
            this.lbl70.AutoSize = true;
            this.lbl70.Location = new System.Drawing.Point(17, 126);
            this.lbl70.Name = "lbl70";
            this.lbl70.Size = new System.Drawing.Size(89, 13);
            this.lbl70.TabIndex = 10;
            this.lbl70.Text = "70% Scrolls Used";
            // 
            // lbl60
            // 
            this.lbl60.AutoSize = true;
            this.lbl60.Location = new System.Drawing.Point(17, 99);
            this.lbl60.Name = "lbl60";
            this.lbl60.Size = new System.Drawing.Size(89, 13);
            this.lbl60.TabIndex = 9;
            this.lbl60.Text = "60% Scrolls Used";
            // 
            // lbl30
            // 
            this.lbl30.AutoSize = true;
            this.lbl30.Location = new System.Drawing.Point(17, 72);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new System.Drawing.Size(89, 13);
            this.lbl30.TabIndex = 8;
            this.lbl30.Text = "30% Scrolls Used";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(17, 45);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(89, 13);
            this.lbl10.TabIndex = 7;
            this.lbl10.Text = "10% Scrolls Used";
            // 
            // cmb100
            // 
            this.cmb100.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb100.FormattingEnabled = true;
            this.cmb100.Location = new System.Drawing.Point(113, 150);
            this.cmb100.Name = "cmb100";
            this.cmb100.Size = new System.Drawing.Size(48, 21);
            this.cmb100.TabIndex = 6;
            this.cmb100.SelectedIndexChanged += new System.EventHandler(this.cmb100_SelectedIndexChanged);
            // 
            // cmb70
            // 
            this.cmb70.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb70.FormattingEnabled = true;
            this.cmb70.Location = new System.Drawing.Point(113, 123);
            this.cmb70.Name = "cmb70";
            this.cmb70.Size = new System.Drawing.Size(48, 21);
            this.cmb70.TabIndex = 5;
            this.cmb70.SelectedIndexChanged += new System.EventHandler(this.cmb70_SelectedIndexChanged);
            // 
            // cmb60
            // 
            this.cmb60.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb60.FormattingEnabled = true;
            this.cmb60.Location = new System.Drawing.Point(113, 96);
            this.cmb60.Name = "cmb60";
            this.cmb60.Size = new System.Drawing.Size(48, 21);
            this.cmb60.TabIndex = 4;
            this.cmb60.SelectedIndexChanged += new System.EventHandler(this.cmb60_SelectedIndexChanged);
            // 
            // cmb30
            // 
            this.cmb30.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb30.FormattingEnabled = true;
            this.cmb30.Location = new System.Drawing.Point(113, 69);
            this.cmb30.Name = "cmb30";
            this.cmb30.Size = new System.Drawing.Size(48, 21);
            this.cmb30.TabIndex = 3;
            this.cmb30.SelectedIndexChanged += new System.EventHandler(this.cmb30_SelectedIndexChanged);
            // 
            // cmb10
            // 
            this.cmb10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb10.FormattingEnabled = true;
            this.cmb10.Location = new System.Drawing.Point(113, 42);
            this.cmb10.Name = "cmb10";
            this.cmb10.Size = new System.Drawing.Size(48, 21);
            this.cmb10.TabIndex = 2;
            this.cmb10.SelectedIndexChanged += new System.EventHandler(this.cmb10_SelectedIndexChanged);
            // 
            // lblSlots
            // 
            this.lblSlots.AutoSize = true;
            this.lblSlots.Location = new System.Drawing.Point(17, 18);
            this.lblSlots.Name = "lblSlots";
            this.lblSlots.Size = new System.Drawing.Size(67, 13);
            this.lblSlots.TabIndex = 1;
            this.lblSlots.Text = "Slots on item";
            // 
            // cmbSlots
            // 
            this.cmbSlots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSlots.FormattingEnabled = true;
            this.cmbSlots.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbSlots.Location = new System.Drawing.Point(113, 15);
            this.cmbSlots.MaxDropDownItems = 11;
            this.cmbSlots.Name = "cmbSlots";
            this.cmbSlots.Size = new System.Drawing.Size(48, 21);
            this.cmbSlots.TabIndex = 0;
            this.cmbSlots.SelectedIndexChanged += new System.EventHandler(this.cmbSlots_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(278, 219);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(113, 32);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Calculate!";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tblOutputTable
            // 
            this.tblOutputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOutputTable.Location = new System.Drawing.Point(12, 219);
            this.tblOutputTable.Name = "tblOutputTable";
            this.tblOutputTable.Size = new System.Drawing.Size(260, 219);
            this.tblOutputTable.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.tblOutputTable);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnCalc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 489);
            this.MinimumSize = new System.Drawing.Size(413, 489);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahotbanana\'s Scroll Probability Calc v1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stat100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOutputTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblSlots;
        private System.Windows.Forms.ComboBox cmbSlots;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl70;
        private System.Windows.Forms.Label lbl60;
        private System.Windows.Forms.Label lbl30;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.ComboBox cmb100;
        private System.Windows.Forms.ComboBox cmb70;
        private System.Windows.Forms.ComboBox cmb60;
        private System.Windows.Forms.ComboBox cmb30;
        private System.Windows.Forms.ComboBox cmb10;
        private System.Windows.Forms.NumericUpDown stat100;
        private System.Windows.Forms.NumericUpDown stat70;
        private System.Windows.Forms.NumericUpDown stat60;
        private System.Windows.Forms.NumericUpDown stat30;
        private System.Windows.Forms.NumericUpDown stat10;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.DataGridView tblOutputTable;
    }
}

