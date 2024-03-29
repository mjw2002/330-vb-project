﻿namespace VB_330
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
            this.rightItem = new System.Windows.Forms.Button();
            this.leftItem = new System.Windows.Forms.Button();
            this.positionLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.galleryBox = new System.Windows.Forms.PictureBox();
            this.imageImport = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.galleryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rightItem
            // 
            this.rightItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightItem.Location = new System.Drawing.Point(408, 680);
            this.rightItem.Name = "rightItem";
            this.rightItem.Size = new System.Drawing.Size(75, 23);
            this.rightItem.TabIndex = 0;
            this.rightItem.Text = "->";
            this.rightItem.UseVisualStyleBackColor = true;
            // 
            // leftItem
            // 
            this.leftItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftItem.Location = new System.Drawing.Point(218, 680);
            this.leftItem.Name = "leftItem";
            this.leftItem.Size = new System.Drawing.Size(75, 23);
            this.leftItem.TabIndex = 1;
            this.leftItem.Text = "<-";
            this.leftItem.UseVisualStyleBackColor = true;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(340, 683);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(24, 15);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "0/0";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(33, 680);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(590, 680);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_click);
            // 
            // galleryBox
            // 
            this.galleryBox.Location = new System.Drawing.Point(0, 12);
            this.galleryBox.Name = "galleryBox";
            this.galleryBox.Size = new System.Drawing.Size(697, 652);
            this.galleryBox.TabIndex = 5;
            this.galleryBox.TabStop = false;
            // 
            // imageImport
            // 
            this.imageImport.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 733);
            this.ControlBox = false;
            this.Controls.Add(this.galleryBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.leftItem);
            this.Controls.Add(this.rightItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Photo Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.galleryBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rightItem;
        private System.Windows.Forms.Button leftItem;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox galleryBox;
        private System.Windows.Forms.FolderBrowserDialog imageImport;
    }
}

