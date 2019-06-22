namespace Basic_Image_Filter
{
    partial class FormBIF
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxR = new System.Windows.Forms.PictureBox();
            this.pictureBoxG = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.pictureBoxRG = new System.Windows.Forms.PictureBox();
            this.pictureBoxRB = new System.Windows.Forms.PictureBox();
            this.pictureBoxGB = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlackWhite = new System.Windows.Forms.PictureBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxR
            // 
            this.pictureBoxR.Location = new System.Drawing.Point(261, 0);
            this.pictureBoxR.Name = "pictureBoxR";
            this.pictureBoxR.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxR.TabIndex = 1;
            this.pictureBoxR.TabStop = false;
            // 
            // pictureBoxG
            // 
            this.pictureBoxG.Location = new System.Drawing.Point(523, 0);
            this.pictureBoxG.Name = "pictureBoxG";
            this.pictureBoxG.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxG.TabIndex = 2;
            this.pictureBoxG.TabStop = false;
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.Location = new System.Drawing.Point(785, 0);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxB.TabIndex = 3;
            this.pictureBoxB.TabStop = false;
            // 
            // pictureBoxRG
            // 
            this.pictureBoxRG.Location = new System.Drawing.Point(785, 262);
            this.pictureBoxRG.Name = "pictureBoxRG";
            this.pictureBoxRG.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxRG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRG.TabIndex = 7;
            this.pictureBoxRG.TabStop = false;
            // 
            // pictureBoxRB
            // 
            this.pictureBoxRB.Location = new System.Drawing.Point(523, 262);
            this.pictureBoxRB.Name = "pictureBoxRB";
            this.pictureBoxRB.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRB.TabIndex = 6;
            this.pictureBoxRB.TabStop = false;
            // 
            // pictureBoxGB
            // 
            this.pictureBoxGB.Location = new System.Drawing.Point(261, 262);
            this.pictureBoxGB.Name = "pictureBoxGB";
            this.pictureBoxGB.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGB.TabIndex = 5;
            this.pictureBoxGB.TabStop = false;
            // 
            // pictureBoxBlackWhite
            // 
            this.pictureBoxBlackWhite.Location = new System.Drawing.Point(-1, 262);
            this.pictureBoxBlackWhite.Name = "pictureBoxBlackWhite";
            this.pictureBoxBlackWhite.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxBlackWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBlackWhite.TabIndex = 4;
            this.pictureBoxBlackWhite.TabStop = false;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(387, 524);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(130, 24);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(-1, 524);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(130, 24);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(523, 524);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 24);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormBIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 548);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.pictureBoxRG);
            this.Controls.Add(this.pictureBoxRB);
            this.Controls.Add(this.pictureBoxGB);
            this.Controls.Add(this.pictureBoxBlackWhite);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.pictureBoxG);
            this.Controls.Add(this.pictureBoxR);
            this.Controls.Add(this.pictureBoxOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBIF";
            this.Text = "Basic Image Filter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackWhite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxR;
        private System.Windows.Forms.PictureBox pictureBoxG;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox pictureBoxRG;
        private System.Windows.Forms.PictureBox pictureBoxRB;
        private System.Windows.Forms.PictureBox pictureBoxGB;
        private System.Windows.Forms.PictureBox pictureBoxBlackWhite;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonSave;
    }
}

