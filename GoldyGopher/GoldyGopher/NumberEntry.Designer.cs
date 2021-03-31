
namespace GoldyGopher
{
    partial class NumberEntry
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
            this.components = new System.ComponentModel.Container();
            this.numStartValue = new System.Windows.Forms.NumericUpDown();
            this.numEndValue = new System.Windows.Forms.NumericUpDown();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblStartValue = new System.Windows.Forms.Label();
            this.lblEndValue = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProviderEndingValue = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEndingValue)).BeginInit();
            this.SuspendLayout();
            // 
            // numStartValue
            // 
            this.numStartValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStartValue.Location = new System.Drawing.Point(101, 56);
            this.numStartValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numStartValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numStartValue.Name = "numStartValue";
            this.numStartValue.Size = new System.Drawing.Size(323, 23);
            this.numStartValue.TabIndex = 0;
            // 
            // numEndValue
            // 
            this.numEndValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numEndValue.Location = new System.Drawing.Point(101, 85);
            this.numEndValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numEndValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numEndValue.Name = "numEndValue";
            this.numEndValue.Size = new System.Drawing.Size(323, 23);
            this.numEndValue.TabIndex = 1;
            this.numEndValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numEndValue.Validating += new System.ComponentModel.CancelEventHandler(this.numEndValue_Validating);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(421, 25);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Please input your number range";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStartValue
            // 
            this.lblStartValue.AutoSize = true;
            this.lblStartValue.Location = new System.Drawing.Point(13, 58);
            this.lblStartValue.Name = "lblStartValue";
            this.lblStartValue.Size = new System.Drawing.Size(82, 15);
            this.lblStartValue.TabIndex = 3;
            this.lblStartValue.Text = "Starting Value:";
            // 
            // lblEndValue
            // 
            this.lblEndValue.AutoSize = true;
            this.lblEndValue.Location = new System.Drawing.Point(13, 87);
            this.lblEndValue.Name = "lblEndValue";
            this.lblEndValue.Size = new System.Drawing.Size(78, 15);
            this.lblEndValue.TabIndex = 4;
            this.lblEndValue.Text = "Ending Value:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(349, 114);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 228);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 1);
            this.panel1.TabIndex = 7;
            // 
            // errorProviderEndingValue
            // 
            this.errorProviderEndingValue.ContainerControl = this;
            // 
            // NumberEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEndValue);
            this.Controls.Add(this.lblStartValue);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.numEndValue);
            this.Controls.Add(this.numStartValue);
            this.Name = "NumberEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Display";
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEndingValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStartValue;
        private System.Windows.Forms.NumericUpDown numEndValue;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblStartValue;
        private System.Windows.Forms.Label lblEndValue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProviderEndingValue;
    }
}

