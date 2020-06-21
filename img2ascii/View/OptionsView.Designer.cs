namespace img2ascii.View
{
    partial class OptionsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comPictureBox = new System.Windows.Forms.PictureBox();
            this.pnlMasterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNavigationButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lblOutputWidth = new System.Windows.Forms.Label();
            this.pnlOutputSize = new System.Windows.Forms.TableLayoutPanel();
            this.scrOutputSize = new System.Windows.Forms.HScrollBar();
            this.lblOutputSizeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comPictureBox)).BeginInit();
            this.pnlMasterLayout.SuspendLayout();
            this.pnlNavigationButtons.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlOutputSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // comPictureBox
            // 
            this.comPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comPictureBox.Location = new System.Drawing.Point(0, 0);
            this.comPictureBox.Name = "comPictureBox";
            this.comPictureBox.Size = new System.Drawing.Size(391, 288);
            this.comPictureBox.TabIndex = 0;
            this.comPictureBox.TabStop = false;
            // 
            // pnlMasterLayout
            // 
            this.pnlMasterLayout.ColumnCount = 3;
            this.pnlMasterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMasterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.pnlMasterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMasterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMasterLayout.Controls.Add(this.pnlNavigationButtons, 1, 2);
            this.pnlMasterLayout.Controls.Add(this.pnlOptions, 1, 1);
            this.pnlMasterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMasterLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlMasterLayout.Name = "pnlMasterLayout";
            this.pnlMasterLayout.RowCount = 4;
            this.pnlMasterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMasterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.pnlMasterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.pnlMasterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMasterLayout.Size = new System.Drawing.Size(391, 288);
            this.pnlMasterLayout.TabIndex = 1;
            // 
            // pnlNavigationButtons
            // 
            this.pnlNavigationButtons.ColumnCount = 3;
            this.pnlNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.pnlNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlNavigationButtons.Controls.Add(this.btnNext, 1, 1);
            this.pnlNavigationButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavigationButtons.Location = new System.Drawing.Point(70, 214);
            this.pnlNavigationButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavigationButtons.Name = "pnlNavigationButtons";
            this.pnlNavigationButtons.RowCount = 3;
            this.pnlNavigationButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlNavigationButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlNavigationButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlNavigationButtons.Size = new System.Drawing.Size(250, 45);
            this.pnlNavigationButtons.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(87, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Generate";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.OnGenerateClick);
            // 
            // pnlOptions
            // 
            this.pnlOptions.ColumnCount = 3;
            this.pnlOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.pnlOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOptions.Controls.Add(this.lblOutputWidth, 0, 0);
            this.pnlOptions.Controls.Add(this.pnlOutputSize, 2, 0);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(70, 29);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.RowCount = 2;
            this.pnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOptions.Size = new System.Drawing.Size(250, 185);
            this.pnlOptions.TabIndex = 1;
            // 
            // lblOutputWidth
            // 
            this.lblOutputWidth.AutoSize = true;
            this.lblOutputWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutputWidth.Location = new System.Drawing.Point(0, 0);
            this.lblOutputWidth.Margin = new System.Windows.Forms.Padding(0);
            this.lblOutputWidth.Name = "lblOutputWidth";
            this.lblOutputWidth.Size = new System.Drawing.Size(90, 40);
            this.lblOutputWidth.TabIndex = 0;
            this.lblOutputWidth.Text = "OutputSize";
            this.lblOutputWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlOutputSize
            // 
            this.pnlOutputSize.ColumnCount = 1;
            this.pnlOutputSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlOutputSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlOutputSize.Controls.Add(this.scrOutputSize, 0, 1);
            this.pnlOutputSize.Controls.Add(this.lblOutputSizeValue, 0, 0);
            this.pnlOutputSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputSize.Location = new System.Drawing.Point(95, 0);
            this.pnlOutputSize.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOutputSize.Name = "pnlOutputSize";
            this.pnlOutputSize.RowCount = 2;
            this.pnlOutputSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlOutputSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlOutputSize.Size = new System.Drawing.Size(155, 40);
            this.pnlOutputSize.TabIndex = 1;
            // 
            // scrOutputSize
            // 
            this.scrOutputSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrOutputSize.Location = new System.Drawing.Point(0, 20);
            this.scrOutputSize.Maximum = 64;
            this.scrOutputSize.Minimum = 8;
            this.scrOutputSize.Name = "scrOutputSize";
            this.scrOutputSize.Size = new System.Drawing.Size(155, 20);
            this.scrOutputSize.TabIndex = 0;
            this.scrOutputSize.Value = 8;
            this.scrOutputSize.ValueChanged += new System.EventHandler(this.OutputSizeChanged);
            // 
            // lblOutputSizeValue
            // 
            this.lblOutputSizeValue.AutoSize = true;
            this.lblOutputSizeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutputSizeValue.Location = new System.Drawing.Point(0, 0);
            this.lblOutputSizeValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblOutputSizeValue.Name = "lblOutputSizeValue";
            this.lblOutputSizeValue.Size = new System.Drawing.Size(155, 20);
            this.lblOutputSizeValue.TabIndex = 1;
            this.lblOutputSizeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMasterLayout);
            this.Controls.Add(this.comPictureBox);
            this.Name = "OptionsView";
            this.Size = new System.Drawing.Size(391, 288);
            ((System.ComponentModel.ISupportInitialize)(this.comPictureBox)).EndInit();
            this.pnlMasterLayout.ResumeLayout(false);
            this.pnlNavigationButtons.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlOutputSize.ResumeLayout(false);
            this.pnlOutputSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox comPictureBox;
        private System.Windows.Forms.TableLayoutPanel pnlMasterLayout;
        private System.Windows.Forms.TableLayoutPanel pnlNavigationButtons;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TableLayoutPanel pnlOptions;
        private System.Windows.Forms.Label lblOutputWidth;
        private System.Windows.Forms.TableLayoutPanel pnlOutputSize;
        private System.Windows.Forms.HScrollBar scrOutputSize;
        private System.Windows.Forms.Label lblOutputSizeValue;
    }
}
