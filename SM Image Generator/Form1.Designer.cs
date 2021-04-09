namespace SM_Image_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numSampling = new System.Windows.Forms.NumericUpDown();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSampling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(67, 12);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(149, 20);
            this.txtDir.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 3;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 117);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(204, 75);
            this.cmdStart.TabIndex = 4;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sampling";
            // 
            // numSampling
            // 
            this.numSampling.DecimalPlaces = 2;
            this.numSampling.Location = new System.Drawing.Point(67, 64);
            this.numSampling.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numSampling.Name = "numSampling";
            this.numSampling.Size = new System.Drawing.Size(149, 20);
            this.numSampling.TabIndex = 6;
            this.numSampling.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "SCRAP_WOOD_BLOCK",
            "WOOD_BLOCK_1",
            "WOOD_BLOCK_2",
            "WOOD_BLOCK_3",
            "SCRAP_METAL_BLOCK",
            "METAL_BLOCK_2",
            "METAL_BLOCK_3",
            "SCRAP_STONE_BLOCK",
            "CRACKED_STONE_BLOCK",
            "CONCRETE_SLAB_BLOCK",
            "CONCRETE_BLOCK_1",
            "CONCRETE_BLOCK_2",
            "CONCRETE_BLOCK_3",
            "RUSTED_METAL_BLOCK",
            "EXTRUDED_METAL_BLOCK",
            "SOLID_METAL_BLOCK",
            "ALUMINUM_BLOCK",
            "NET_BLOCK",
            "SPACESHIP_FLOOR_BLOCK",
            "PLASTIC_BLOCK",
            "RESTROOM_BLOCK",
            "INSULATION_BLOCK",
            "STRIPED_NET_BLOCK",
            "PLASTER_BLOCK",
            "SQUARE_MESH_BLOCK",
            "ARMORED_GLASS_BLOCK",
            "FRAMEWORK_BLOCK",
            "SAND_BLOCK",
            "WORN_METAL_BLOCK",
            "PAINTED_WALL_BLOCK",
            "PUNCHED_STEEl_BLOCK",
            "BUBBLE_PLASTIC_BLOCK",
            "DIAMOND_PLATE_BLOCK",
            "CARPET_BLOCK"});
            this.cmbMaterial.Location = new System.Drawing.Point(12, 90);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(204, 21);
            this.cmbMaterial.TabIndex = 7;
            this.cmbMaterial.Text = "Scrap Wood Block";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 204);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.numSampling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SM Image";
            ((System.ComponentModel.ISupportInitialize)(this.numSampling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSampling;
        private System.Windows.Forms.ComboBox cmbMaterial;
    }
}

