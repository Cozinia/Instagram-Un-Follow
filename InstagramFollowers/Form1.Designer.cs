﻿namespace InstagramUnfollow
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
            this.openFileDialogFollowers = new System.Windows.Forms.OpenFileDialog();
            this.labelFollowers = new System.Windows.Forms.Label();
            this.labelFollowings = new System.Windows.Forms.Label();
            this.buttonUploadFollowers = new System.Windows.Forms.Button();
            this.buttonUploadFollowings = new System.Windows.Forms.Button();
            this.labelPathToFollowers = new System.Windows.Forms.Label();
            this.labelPathToFollowings = new System.Windows.Forms.Label();
            this.labelPeopleToUnfollow = new System.Windows.Forms.Label();
            this.labelSelectedFileFollowers = new System.Windows.Forms.Label();
            this.labelSelectedFollowers = new System.Windows.Forms.Label();
            this.buttonUnfollowPeople = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFollowers = new System.Windows.Forms.GroupBox();
            this.groupBoxFollowings = new System.Windows.Forms.GroupBox();
            this.groupBoxUnfollow = new System.Windows.Forms.GroupBox();
            this.dataGridViewPeopleToUnfollow = new System.Windows.Forms.DataGridView();
            this.groupBoxFollowers.SuspendLayout();
            this.groupBoxFollowings.SuspendLayout();
            this.groupBoxUnfollow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleToUnfollow)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogFollowers
            // 
            this.openFileDialogFollowers.DefaultExt = "json";
            this.openFileDialogFollowers.FileName = "openFileDialogFollowers";
            // 
            // labelFollowers
            // 
            this.labelFollowers.AutoSize = true;
            this.labelFollowers.Location = new System.Drawing.Point(6, 18);
            this.labelFollowers.Name = "labelFollowers";
            this.labelFollowers.Size = new System.Drawing.Size(111, 16);
            this.labelFollowers.TabIndex = 0;
            this.labelFollowers.Text = "Upload followers:";
            // 
            // labelFollowings
            // 
            this.labelFollowings.AutoSize = true;
            this.labelFollowings.Location = new System.Drawing.Point(6, 28);
            this.labelFollowings.Name = "labelFollowings";
            this.labelFollowings.Size = new System.Drawing.Size(117, 16);
            this.labelFollowings.TabIndex = 1;
            this.labelFollowings.Text = "Upload followings:";
            // 
            // buttonUploadFollowers
            // 
            this.buttonUploadFollowers.Location = new System.Drawing.Point(278, 11);
            this.buttonUploadFollowers.Name = "buttonUploadFollowers";
            this.buttonUploadFollowers.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadFollowers.TabIndex = 2;
            this.buttonUploadFollowers.Text = "Browse";
            this.buttonUploadFollowers.UseVisualStyleBackColor = true;
            this.buttonUploadFollowers.Click += new System.EventHandler(this.buttonUploadFollowers_Click);
            // 
            // buttonUploadFollowings
            // 
            this.buttonUploadFollowings.Location = new System.Drawing.Point(278, 25);
            this.buttonUploadFollowings.Name = "buttonUploadFollowings";
            this.buttonUploadFollowings.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadFollowings.TabIndex = 3;
            this.buttonUploadFollowings.Text = "Browse";
            this.buttonUploadFollowings.UseVisualStyleBackColor = true;
            this.buttonUploadFollowings.Click += new System.EventHandler(this.buttonUploadFollowings_Click);
            // 
            // labelPathToFollowers
            // 
            this.labelPathToFollowers.AutoSize = true;
            this.labelPathToFollowers.Location = new System.Drawing.Point(96, 56);
            this.labelPathToFollowers.Name = "labelPathToFollowers";
            this.labelPathToFollowers.Size = new System.Drawing.Size(0, 16);
            this.labelPathToFollowers.TabIndex = 4;
            // 
            // labelPathToFollowings
            // 
            this.labelPathToFollowings.AutoSize = true;
            this.labelPathToFollowings.Location = new System.Drawing.Point(96, 64);
            this.labelPathToFollowings.Name = "labelPathToFollowings";
            this.labelPathToFollowings.Size = new System.Drawing.Size(0, 16);
            this.labelPathToFollowings.TabIndex = 5;
            // 
            // labelPeopleToUnfollow
            // 
            this.labelPeopleToUnfollow.AutoSize = true;
            this.labelPeopleToUnfollow.Location = new System.Drawing.Point(6, 83);
            this.labelPeopleToUnfollow.Name = "labelPeopleToUnfollow";
            this.labelPeopleToUnfollow.Size = new System.Drawing.Size(128, 16);
            this.labelPeopleToUnfollow.TabIndex = 7;
            this.labelPeopleToUnfollow.Text = "People To Unfollow:";
            // 
            // labelSelectedFileFollowers
            // 
            this.labelSelectedFileFollowers.AutoSize = true;
            this.labelSelectedFileFollowers.Location = new System.Drawing.Point(6, 56);
            this.labelSelectedFileFollowers.Name = "labelSelectedFileFollowers";
            this.labelSelectedFileFollowers.Size = new System.Drawing.Size(84, 16);
            this.labelSelectedFileFollowers.TabIndex = 8;
            this.labelSelectedFileFollowers.Text = "Selected file:";
            // 
            // labelSelectedFollowers
            // 
            this.labelSelectedFollowers.AutoSize = true;
            this.labelSelectedFollowers.Location = new System.Drawing.Point(6, 64);
            this.labelSelectedFollowers.Name = "labelSelectedFollowers";
            this.labelSelectedFollowers.Size = new System.Drawing.Size(84, 16);
            this.labelSelectedFollowers.TabIndex = 9;
            this.labelSelectedFollowers.Text = "Selected file:";
            // 
            // buttonUnfollowPeople
            // 
            this.buttonUnfollowPeople.Location = new System.Drawing.Point(278, 39);
            this.buttonUnfollowPeople.Name = "buttonUnfollowPeople";
            this.buttonUnfollowPeople.Size = new System.Drawing.Size(75, 23);
            this.buttonUnfollowPeople.TabIndex = 10;
            this.buttonUnfollowPeople.Text = "Find";
            this.buttonUnfollowPeople.UseVisualStyleBackColor = true;
            this.buttonUnfollowPeople.Click += new System.EventHandler(this.buttonUnfollowPeople_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Find people who don\'t follow you back:";
            // 
            // groupBoxFollowers
            // 
            this.groupBoxFollowers.Controls.Add(this.labelFollowers);
            this.groupBoxFollowers.Controls.Add(this.buttonUploadFollowers);
            this.groupBoxFollowers.Controls.Add(this.labelSelectedFileFollowers);
            this.groupBoxFollowers.Controls.Add(this.labelPathToFollowers);
            this.groupBoxFollowers.Location = new System.Drawing.Point(12, 7);
            this.groupBoxFollowers.Name = "groupBoxFollowers";
            this.groupBoxFollowers.Size = new System.Drawing.Size(976, 83);
            this.groupBoxFollowers.TabIndex = 12;
            this.groupBoxFollowers.TabStop = false;
            this.groupBoxFollowers.Text = "People who you follow";
            // 
            // groupBoxFollowings
            // 
            this.groupBoxFollowings.Controls.Add(this.labelFollowings);
            this.groupBoxFollowings.Controls.Add(this.buttonUploadFollowings);
            this.groupBoxFollowings.Controls.Add(this.labelPathToFollowings);
            this.groupBoxFollowings.Controls.Add(this.labelSelectedFollowers);
            this.groupBoxFollowings.Location = new System.Drawing.Point(12, 96);
            this.groupBoxFollowings.Name = "groupBoxFollowings";
            this.groupBoxFollowings.Size = new System.Drawing.Size(976, 100);
            this.groupBoxFollowings.TabIndex = 13;
            this.groupBoxFollowings.TabStop = false;
            this.groupBoxFollowings.Text = "People who follow you";
            // 
            // groupBoxUnfollow
            // 
            this.groupBoxUnfollow.Controls.Add(this.dataGridViewPeopleToUnfollow);
            this.groupBoxUnfollow.Controls.Add(this.labelPeopleToUnfollow);
            this.groupBoxUnfollow.Controls.Add(this.buttonUnfollowPeople);
            this.groupBoxUnfollow.Controls.Add(this.label1);
            this.groupBoxUnfollow.Location = new System.Drawing.Point(12, 202);
            this.groupBoxUnfollow.Name = "groupBoxUnfollow";
            this.groupBoxUnfollow.Size = new System.Drawing.Size(976, 355);
            this.groupBoxUnfollow.TabIndex = 14;
            this.groupBoxUnfollow.TabStop = false;
            this.groupBoxUnfollow.Text = "People who don\'t follow you back";
            // 
            // dataGridViewPeopleToUnfollow
            // 
            this.dataGridViewPeopleToUnfollow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeopleToUnfollow.Location = new System.Drawing.Point(9, 120);
            this.dataGridViewPeopleToUnfollow.Name = "dataGridViewPeopleToUnfollow";
            this.dataGridViewPeopleToUnfollow.RowHeadersWidth = 51;
            this.dataGridViewPeopleToUnfollow.RowTemplate.Height = 24;
            this.dataGridViewPeopleToUnfollow.Size = new System.Drawing.Size(881, 217);
            this.dataGridViewPeopleToUnfollow.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 581);
            this.Controls.Add(this.groupBoxUnfollow);
            this.Controls.Add(this.groupBoxFollowings);
            this.Controls.Add(this.groupBoxFollowers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Instagram (Un)Follow";
            this.groupBoxFollowers.ResumeLayout(false);
            this.groupBoxFollowers.PerformLayout();
            this.groupBoxFollowings.ResumeLayout(false);
            this.groupBoxFollowings.PerformLayout();
            this.groupBoxUnfollow.ResumeLayout(false);
            this.groupBoxUnfollow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeopleToUnfollow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogFollowers;
        private System.Windows.Forms.Label labelFollowers;
        private System.Windows.Forms.Label labelFollowings;
        private System.Windows.Forms.Button buttonUploadFollowers;
        private System.Windows.Forms.Button buttonUploadFollowings;
        private System.Windows.Forms.Label labelPathToFollowers;
        private System.Windows.Forms.Label labelPathToFollowings;
        private System.Windows.Forms.Label labelPeopleToUnfollow;
        private System.Windows.Forms.Label labelSelectedFileFollowers;
        private System.Windows.Forms.Label labelSelectedFollowers;
        private System.Windows.Forms.Button buttonUnfollowPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxFollowers;
        private System.Windows.Forms.GroupBox groupBoxFollowings;
        private System.Windows.Forms.GroupBox groupBoxUnfollow;
        private System.Windows.Forms.DataGridView dataGridViewPeopleToUnfollow;
    }
}
