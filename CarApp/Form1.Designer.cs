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
            this.lVCars = new System.Windows.Forms.ListView();
            this.regnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.forSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRegNr
            // 
            this.lbRegNr.AutoSize = true;
            this.lbRegNr.Location = new System.Drawing.Point(6, 16);
            this.lbRegNr.Name = "lbRegNr";
            this.lbRegNr.Size = new System.Drawing.Size(44, 13);
            this.lbRegNr.TabIndex = 0;
            this.lbRegNr.Text = "Reg Nr.";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(118, 16);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(17, 13);
            this.lbYear.TabIndex = 1;
            this.lbYear.Text = "År";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(118, 55);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 2;
            this.lbModel.Text = "Model";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(6, 55);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(37, 13);
            this.lb.TabIndex = 3;
            this.lb.Text = "Märke";
            // 
            // tBRegNr
            // 
            this.tBRegNr.Location = new System.Drawing.Point(6, 32);
            this.tBRegNr.Name = "tBRegNr";
            this.tBRegNr.Size = new System.Drawing.Size(100, 20);
            this.tBRegNr.TabIndex = 0;
            // 
            // tBModel
            // 
            this.tBModel.Location = new System.Drawing.Point(121, 71);
            this.tBModel.Name = "tBModel";
            this.tBModel.Size = new System.Drawing.Size(100, 20);
            this.tBModel.TabIndex = 4;
            // 
            // tBBrand
            // 
            this.tBBrand.Location = new System.Drawing.Point(6, 71);
            this.tBBrand.Name = "tBBrand";
            this.tBBrand.Size = new System.Drawing.Size(100, 20);
            this.tBBrand.TabIndex = 2;
            // 
            // tBYear
            // 
            this.tBYear.Location = new System.Drawing.Point(121, 32);
            this.tBYear.Name = "tBYear";
            this.tBYear.Size = new System.Drawing.Size(100, 20);
            this.tBYear.TabIndex = 2;
            // 
            // cBForSale
            // 
            this.cBForSale.AutoSize = true;
            this.cBForSale.Location = new System.Drawing.Point(227, 32);
            this.cBForSale.Name = "cBForSale";
            this.cBForSale.Size = new System.Drawing.Size(63, 17);
            this.cBForSale.TabIndex = 5;
            this.cBForSale.Text = "Till Salu";
            this.cBForSale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(227, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Lägg Till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(339, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lägg Till Bil";
            // 
            // lVCars
            // 
            this.lVCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regnr,
            this.brand,
            this.forSale,
            this.year,
            this.model});
            this.lVCars.HideSelection = false;
            this.lVCars.Location = new System.Drawing.Point(12, 118);
            this.lVCars.Name = "lVCars";
            this.lVCars.Size = new System.Drawing.Size(339, 247);
            this.lVCars.TabIndex = 12;
            this.lVCars.UseCompatibleStateImageBehavior = false;
            this.lVCars.View = System.Windows.Forms.View.Details;
            this.lVCars.SelectedIndexChanged += new System.EventHandler(this.lVCars_SelectedIndexChanged);
            // 
            // regnr
            // 
            this.regnr.Text = "Reg NR";
            // 
            // brand
            // 
            this.brand.Text = "Märke";
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
            // 
            // forSale
            // 
            this.forSale.DisplayIndex = 4;
            this.forSale.Text = "Till Salu";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Rensa bort all data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(216, 382);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Ta bort markerad";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lVCars);
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
        private System.Windows.Forms.ListView lVCars;
        private System.Windows.Forms.ColumnHeader regnr;
        private System.Windows.Forms.ColumnHeader brand;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader forSale;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
    }
}

