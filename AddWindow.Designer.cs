﻿namespace AVTTLoaderStandalone
{
    partial class AddWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPartName = new System.Windows.Forms.Label();
            this.textBoxNewPart = new System.Windows.Forms.TextBox();
            this.comboBoxNodes = new System.Windows.Forms.ComboBox();
            this.buttonAddConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Controls.Add(this.labelNode, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPartName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNewPart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxNodes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddConfirm, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 172);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelNode
            // 
            this.labelNode.AutoSize = true;
            this.labelNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelNode.Location = new System.Drawing.Point(3, 80);
            this.labelNode.Name = "labelNode";
            this.labelNode.Size = new System.Drawing.Size(75, 20);
            this.labelNode.TabIndex = 3;
            this.labelNode.Text = "Tech Node:  ";
            this.labelNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add part to node";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPartName
            // 
            this.labelPartName.AutoSize = true;
            this.labelPartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPartName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPartName.Location = new System.Drawing.Point(3, 20);
            this.labelPartName.Name = "labelPartName";
            this.labelPartName.Size = new System.Drawing.Size(75, 40);
            this.labelPartName.TabIndex = 1;
            this.labelPartName.Text = "Part name: ";
            this.labelPartName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNewPart
            // 
            this.textBoxNewPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewPart.Location = new System.Drawing.Point(84, 30);
            this.textBoxNewPart.Name = "textBoxNewPart";
            this.textBoxNewPart.Size = new System.Drawing.Size(183, 20);
            this.textBoxNewPart.TabIndex = 2;
            // 
            // comboBoxNodes
            // 
            this.comboBoxNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxNodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNodes.FormattingEnabled = true;
            this.comboBoxNodes.Location = new System.Drawing.Point(84, 83);
            this.comboBoxNodes.Name = "comboBoxNodes";
            this.comboBoxNodes.Size = new System.Drawing.Size(183, 21);
            this.comboBoxNodes.TabIndex = 4;
            // 
            // buttonAddConfirm
            // 
            this.buttonAddConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonAddConfirm, 3);
            this.buttonAddConfirm.Location = new System.Drawing.Point(104, 140);
            this.buttonAddConfirm.Name = "buttonAddConfirm";
            this.buttonAddConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddConfirm.TabIndex = 5;
            this.buttonAddConfirm.Text = "Add part";
            this.buttonAddConfirm.UseVisualStyleBackColor = true;
            this.buttonAddConfirm.Click += new System.EventHandler(this.ButtonAddConfirmClick);
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddWindowFormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPartName;
        private System.Windows.Forms.TextBox textBoxNewPart;
        private System.Windows.Forms.Label labelNode;
        private System.Windows.Forms.ComboBox comboBoxNodes;
        private System.Windows.Forms.Button buttonAddConfirm;
    }
}