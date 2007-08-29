namespace SSASUtils.ObjectProcessor
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbCube = new System.Windows.Forms.ComboBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetDimensions = new System.Windows.Forms.Button();
            this.clbDimensions = new System.Windows.Forms.CheckedListBox();
            this.btnProcessDimensions = new System.Windows.Forms.Button();
            this.clbPartitions = new System.Windows.Forms.CheckedListBox();
            this.btnGetPartitions = new System.Windows.Forms.Button();
            this.txtPartitionNameFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcessPartitions = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbCube);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDatabase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Info";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(224, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbCube
            // 
            this.cbCube.FormattingEnabled = true;
            this.cbCube.Location = new System.Drawing.Point(530, 15);
            this.cbCube.Name = "cbCube";
            this.cbCube.Size = new System.Drawing.Size(121, 21);
            this.cbCube.TabIndex = 5;
            this.cbCube.SelectedIndexChanged += new System.EventHandler(this.cbCube_SelectedIndexChanged);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(84, 16);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(134, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(362, 15);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(121, 21);
            this.cbDatabase.TabIndex = 4;
            this.cbDatabase.SelectedIndexChanged += new System.EventHandler(this.cbDatabase_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cube:";
            // 
            // btnGetDimensions
            // 
            this.btnGetDimensions.Location = new System.Drawing.Point(21, 56);
            this.btnGetDimensions.Name = "btnGetDimensions";
            this.btnGetDimensions.Size = new System.Drawing.Size(134, 23);
            this.btnGetDimensions.TabIndex = 1;
            this.btnGetDimensions.Text = "Get Dimensions";
            this.btnGetDimensions.UseVisualStyleBackColor = true;
            this.btnGetDimensions.Click += new System.EventHandler(this.btnGetDimensions_Click);
            // 
            // clbDimensions
            // 
            this.clbDimensions.CheckOnClick = true;
            this.clbDimensions.FormattingEnabled = true;
            this.clbDimensions.Location = new System.Drawing.Point(21, 96);
            this.clbDimensions.Name = "clbDimensions";
            this.clbDimensions.Size = new System.Drawing.Size(277, 514);
            this.clbDimensions.TabIndex = 2;
            // 
            // btnProcessDimensions
            // 
            this.btnProcessDimensions.Location = new System.Drawing.Point(161, 56);
            this.btnProcessDimensions.Name = "btnProcessDimensions";
            this.btnProcessDimensions.Size = new System.Drawing.Size(137, 23);
            this.btnProcessDimensions.TabIndex = 3;
            this.btnProcessDimensions.Text = "Process Dimensions";
            this.btnProcessDimensions.UseVisualStyleBackColor = true;
            this.btnProcessDimensions.Click += new System.EventHandler(this.btnProcessDimensions_Click);
            // 
            // clbPartitions
            // 
            this.clbPartitions.CheckOnClick = true;
            this.clbPartitions.FormattingEnabled = true;
            this.clbPartitions.Location = new System.Drawing.Point(324, 126);
            this.clbPartitions.Name = "clbPartitions";
            this.clbPartitions.Size = new System.Drawing.Size(502, 484);
            this.clbPartitions.TabIndex = 4;
            // 
            // btnGetPartitions
            // 
            this.btnGetPartitions.Location = new System.Drawing.Point(324, 56);
            this.btnGetPartitions.Name = "btnGetPartitions";
            this.btnGetPartitions.Size = new System.Drawing.Size(133, 23);
            this.btnGetPartitions.TabIndex = 5;
            this.btnGetPartitions.Text = "Get Partitions";
            this.btnGetPartitions.UseVisualStyleBackColor = true;
            this.btnGetPartitions.Click += new System.EventHandler(this.btnGetPartitions_Click);
            // 
            // txtPartitionNameFilter
            // 
            this.txtPartitionNameFilter.Location = new System.Drawing.Point(359, 93);
            this.txtPartitionNameFilter.Name = "txtPartitionNameFilter";
            this.txtPartitionNameFilter.Size = new System.Drawing.Size(237, 20);
            this.txtPartitionNameFilter.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filter:";
            // 
            // btnProcessPartitions
            // 
            this.btnProcessPartitions.Location = new System.Drawing.Point(463, 56);
            this.btnProcessPartitions.Name = "btnProcessPartitions";
            this.btnProcessPartitions.Size = new System.Drawing.Size(133, 23);
            this.btnProcessPartitions.TabIndex = 8;
            this.btnProcessPartitions.Text = "Process Partitions";
            this.btnProcessPartitions.UseVisualStyleBackColor = true;
            this.btnProcessPartitions.Click += new System.EventHandler(this.btnProcessPartitions_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 623);
            this.Controls.Add(this.btnProcessPartitions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPartitionNameFilter);
            this.Controls.Add(this.btnGetPartitions);
            this.Controls.Add(this.clbPartitions);
            this.Controls.Add(this.btnProcessDimensions);
            this.Controls.Add(this.clbDimensions);
            this.Controls.Add(this.btnGetDimensions);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "SSAS Utils - Object Processor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbCube;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Button btnGetDimensions;
        private System.Windows.Forms.CheckedListBox clbDimensions;
        private System.Windows.Forms.Button btnProcessDimensions;
        private System.Windows.Forms.CheckedListBox clbPartitions;
        private System.Windows.Forms.Button btnGetPartitions;
        private System.Windows.Forms.TextBox txtPartitionNameFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcessPartitions;
    }
}