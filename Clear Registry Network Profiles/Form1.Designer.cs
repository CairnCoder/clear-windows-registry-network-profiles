
namespace Clear_Registry_Network_Profiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetNetworkProfiles = new System.Windows.Forms.Button();
            this.dgViewNetworkProfiles = new System.Windows.Forms.DataGridView();
            this.ProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveNetworks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewNetworkProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clear registry network profiles";
            // 
            // btnGetNetworkProfiles
            // 
            this.btnGetNetworkProfiles.Location = new System.Drawing.Point(12, 111);
            this.btnGetNetworkProfiles.Name = "btnGetNetworkProfiles";
            this.btnGetNetworkProfiles.Size = new System.Drawing.Size(161, 29);
            this.btnGetNetworkProfiles.TabIndex = 2;
            this.btnGetNetworkProfiles.Text = "Get network profiles";
            this.btnGetNetworkProfiles.UseVisualStyleBackColor = true;
            this.btnGetNetworkProfiles.Click += new System.EventHandler(this.btnGetNetworkProfiles_Click);
            // 
            // dgViewNetworkProfiles
            // 
            this.dgViewNetworkProfiles.AllowUserToAddRows = false;
            this.dgViewNetworkProfiles.AllowUserToDeleteRows = false;
            this.dgViewNetworkProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgViewNetworkProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewNetworkProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileName,
            this.ProfilePath});
            this.dgViewNetworkProfiles.Location = new System.Drawing.Point(12, 146);
            this.dgViewNetworkProfiles.MultiSelect = false;
            this.dgViewNetworkProfiles.Name = "dgViewNetworkProfiles";
            this.dgViewNetworkProfiles.ReadOnly = true;
            this.dgViewNetworkProfiles.RowHeadersVisible = false;
            this.dgViewNetworkProfiles.RowHeadersWidth = 51;
            this.dgViewNetworkProfiles.RowTemplate.Height = 24;
            this.dgViewNetworkProfiles.Size = new System.Drawing.Size(728, 336);
            this.dgViewNetworkProfiles.TabIndex = 4;
            this.dgViewNetworkProfiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewNetworkProfiles_CellClick);
            this.dgViewNetworkProfiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewNetworkProfiles_CellDoubleClick);
            // 
            // ProfileName
            // 
            this.ProfileName.DataPropertyName = "profileName";
            this.ProfileName.HeaderText = "Profile name";
            this.ProfileName.MinimumWidth = 6;
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.ReadOnly = true;
            this.ProfileName.Width = 150;
            // 
            // ProfilePath
            // 
            this.ProfilePath.DataPropertyName = "registoryPath";
            this.ProfilePath.HeaderText = "Profile path";
            this.ProfilePath.MinimumWidth = 6;
            this.ProfilePath.Name = "ProfilePath";
            this.ProfilePath.ReadOnly = true;
            this.ProfilePath.Width = 300;
            // 
            // btnRemoveNetworks
            // 
            this.btnRemoveNetworks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveNetworks.Location = new System.Drawing.Point(592, 111);
            this.btnRemoveNetworks.Name = "btnRemoveNetworks";
            this.btnRemoveNetworks.Size = new System.Drawing.Size(148, 29);
            this.btnRemoveNetworks.TabIndex = 6;
            this.btnRemoveNetworks.Text = "Remove networks";
            this.btnRemoveNetworks.UseVisualStyleBackColor = true;
            this.btnRemoveNetworks.Click += new System.EventHandler(this.btnRemoveNetworks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Click cell to copy to clipboard.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click \'Remove networks\' to remove all notworks containing the word \'Network\'.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveNetworks);
            this.Controls.Add(this.dgViewNetworkProfiles);
            this.Controls.Add(this.btnGetNetworkProfiles);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewNetworkProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetNetworkProfiles;
        private System.Windows.Forms.DataGridView dgViewNetworkProfiles;
        private System.Windows.Forms.Button btnRemoveNetworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

