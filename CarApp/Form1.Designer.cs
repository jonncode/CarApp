namespace CarApp
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
            this.lbRegNr = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.tBRegNr = new System.Windows.Forms.TextBox();
            this.tBModel = new System.Windows.Forms.TextBox();
            this.tBBrand = new System.Windows.Forms.TextBox();
            this.tBYear = new System.Windows.Forms.TextBox();
            this.cBForSale = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.LVCars = new System.Windows.Forms.ListView();
            this.regnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.forSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRegNr
            // 
            this.lbRegNr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRegNr.AutoSize = true;
            this.lbRegNr.Location = new System.Drawing.Point(6, 16);
            this.lbRegNr.Name = "lbRegNr";
            this.lbRegNr.Size = new System.Drawing.Size(44, 13);
            this.lbRegNr.TabIndex = 0;
            this.lbRegNr.Text = "Reg Nr.";
            // 
            // lbYear
            // 
            this.lbYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(236, 16);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(17, 13);
            this.lbYear.TabIndex = 1;
            this.lbYear.Text = "År";
            // 
            // lbModel
            // 
            this.lbModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(118, 58);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 2;
            this.lbModel.Text = "Model";
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(118, 16);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(37, 13);
            this.lb.TabIndex = 3;
            this.lb.Text = "Märke";
            // 
            // tBRegNr
            // 
            this.tBRegNr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tBRegNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBRegNr.ForeColor = System.Drawing.Color.White;
            this.tBRegNr.Location = new System.Drawing.Point(6, 32);
            this.tBRegNr.Name = "tBRegNr";
            this.tBRegNr.Size = new System.Drawing.Size(100, 20);
            this.tBRegNr.TabIndex = 0;
            // 
            // tBModel
            // 
            this.tBModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBModel.ForeColor = System.Drawing.Color.White;
            this.tBModel.Location = new System.Drawing.Point(121, 74);
            this.tBModel.Name = "tBModel";
            this.tBModel.Size = new System.Drawing.Size(100, 20);
            this.tBModel.TabIndex = 3;
            // 
            // tBBrand
            // 
            this.tBBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBBrand.ForeColor = System.Drawing.Color.White;
            this.tBBrand.Location = new System.Drawing.Point(121, 32);
            this.tBBrand.Name = "tBBrand";
            this.tBBrand.Size = new System.Drawing.Size(100, 20);
            this.tBBrand.TabIndex = 2;
            // 
            // tBYear
            // 
            this.tBYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBYear.ForeColor = System.Drawing.Color.White;
            this.tBYear.Location = new System.Drawing.Point(239, 32);
            this.tBYear.Name = "tBYear";
            this.tBYear.Size = new System.Drawing.Size(100, 20);
            this.tBYear.TabIndex = 4;
            // 
            // cBForSale
            // 
            this.cBForSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBForSale.AutoSize = true;
            this.cBForSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBForSale.ForeColor = System.Drawing.Color.White;
            this.cBForSale.Location = new System.Drawing.Point(239, 74);
            this.cBForSale.Name = "cBForSale";
            this.cBForSale.Padding = new System.Windows.Forms.Padding(3);
            this.cBForSale.Size = new System.Drawing.Size(69, 23);
            this.cBForSale.TabIndex = 5;
            this.cBForSale.Text = "Till Salu";
            this.cBForSale.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(133, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Lägg Till";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lbRegNr);
            this.groupBox1.Controls.Add(this.cBForSale);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tBRegNr);
            this.groupBox1.Controls.Add(this.lbYear);
            this.groupBox1.Controls.Add(this.tBModel);
            this.groupBox1.Controls.Add(this.tBBrand);
            this.groupBox1.Controls.Add(this.tBYear);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.lbModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 142);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lägg Till Bil";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(6, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Sök i registret";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LVCars
            // 
            this.LVCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LVCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regnr,
            this.brand,
            this.model,
            this.year,
            this.forSale});
            this.LVCars.ForeColor = System.Drawing.Color.White;
            this.LVCars.FullRowSelect = true;
            this.LVCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LVCars.HideSelection = false;
            this.LVCars.Location = new System.Drawing.Point(12, 149);
            this.LVCars.Name = "LVCars";
            this.LVCars.Size = new System.Drawing.Size(352, 283);
            this.LVCars.TabIndex = 12;
            this.LVCars.UseCompatibleStateImageBehavior = false;
            this.LVCars.View = System.Windows.Forms.View.Details;
            this.LVCars.SelectedIndexChanged += new System.EventHandler(this.lVCars_SelectedIndexChanged);
            // 
            // regnr
            // 
            this.regnr.Text = "Reg NR";
            // 
            // brand
            // 
            this.brand.Text = "Märke";
            // 
            // forSale
            // 
            this.forSale.Text = "Till Salu";
            this.forSale.Width = 70;
            // 
            // year
            // 
            this.year.DisplayIndex = 2;
            this.year.Text = "År";
            // 
            // model
            // 
            this.model.DisplayIndex = 3;
            this.model.Text = "Model";
            this.model.Width = 98;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(12, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Rensa bort all data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(229, 438);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Ta bort markerad";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(378, 470);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.LVCars);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRegNr;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox tBRegNr;
        private System.Windows.Forms.TextBox tBModel;
        private System.Windows.Forms.TextBox tBBrand;
        private System.Windows.Forms.TextBox tBYear;
        private System.Windows.Forms.CheckBox cBForSale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView LVCars;
        private System.Windows.Forms.ColumnHeader regnr;
        private System.Windows.Forms.ColumnHeader brand;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader forSale;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
    }
}

