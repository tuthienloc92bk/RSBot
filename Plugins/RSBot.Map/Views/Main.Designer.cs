﻿using System;

namespace RSBot.Map.Views
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.mapCanvas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboViewType = new System.Windows.Forms.ComboBox();
            this.trmInterval = new System.Windows.Forms.Timer(this.components);
            this.labelSectorInfo = new System.Windows.Forms.Label();
            this.lvMonster = new RSBot.Theme.Controls.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonZoomIn = new RSBot.Theme.Material.Button();
            this.buttonZoomReset = new RSBot.Theme.Material.Button();
            this.buttonZoomOut = new RSBot.Theme.Material.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(55, 339);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(13, 13);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "0";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(157, 339);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(13, 13);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "0";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(33, 61);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(72, 13);
            this.lblRegion.TabIndex = 7;
            this.lblRegion.Text = "Not in game";
            // 
            // mapCanvas
            // 
            this.mapCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mapCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mapCanvas.Location = new System.Drawing.Point(35, 80);
            this.mapCanvas.Name = "mapCanvas";
            this.mapCanvas.Size = new System.Drawing.Size(256, 256);
            this.mapCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mapCanvas.TabIndex = 0;
            this.mapCanvas.TabStop = false;
            this.mapCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.mapCanvas_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Show:";
            // 
            // comboViewType
            // 
            this.comboViewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboViewType.Items.AddRange(new object[] {
            "Monsters",
            "Players",
            "Party",
            "NPCs",
            "COS",
            "Portals",
            "All"});
            this.comboViewType.Location = new System.Drawing.Point(392, 17);
            this.comboViewType.Name = "comboViewType";
            this.comboViewType.Size = new System.Drawing.Size(180, 21);
            this.comboViewType.TabIndex = 10;
            // 
            // trmInterval
            // 
            this.trmInterval.Enabled = true;
            this.trmInterval.Tick += new System.EventHandler(this.trmInterval_Tick);
            // 
            // labelSectorInfo
            // 
            this.labelSectorInfo.AutoSize = true;
            this.labelSectorInfo.BackColor = System.Drawing.Color.White;
            this.labelSectorInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSectorInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectorInfo.Location = new System.Drawing.Point(240, 60);
            this.labelSectorInfo.Name = "labelSectorInfo";
            this.labelSectorInfo.Size = new System.Drawing.Size(50, 15);
            this.labelSectorInfo.TabIndex = 14;
            this.labelSectorInfo.Text = "000x000";
            // 
            // lvMonster
            // 
            this.lvMonster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colType,
            this.colLevel,
            this.colPosition});
            this.lvMonster.FullRowSelect = true;
            this.lvMonster.HideSelection = false;
            this.lvMonster.Location = new System.Drawing.Point(347, 46);
            this.lvMonster.Name = "lvMonster";
            this.lvMonster.Size = new System.Drawing.Size(388, 394);
            this.lvMonster.TabIndex = 8;
            this.lvMonster.UseCompatibleStateImageBehavior = false;
            this.lvMonster.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 146;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 64;
            // 
            // colLevel
            // 
            this.colLevel.Text = "Level";
            this.colLevel.Width = 42;
            // 
            // colPosition
            // 
            this.colPosition.Text = "Position";
            this.colPosition.Width = 125;
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Depth = 0;
            this.buttonZoomIn.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonZoomIn.Icon = null;
            this.buttonZoomIn.Location = new System.Drawing.Point(295, 80);
            this.buttonZoomIn.MouseState = RSBot.Theme.IMatMouseState.HOVER;
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Primary = true;
            this.buttonZoomIn.Raised = true;
            this.buttonZoomIn.SingleColor = System.Drawing.Color.RosyBrown;
            this.buttonZoomIn.Size = new System.Drawing.Size(24, 24);
            this.buttonZoomIn.TabIndex = 16;
            this.buttonZoomIn.Text = "5";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomReset
            // 
            this.buttonZoomReset.Depth = 0;
            this.buttonZoomReset.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonZoomReset.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonZoomReset.Icon = null;
            this.buttonZoomReset.Location = new System.Drawing.Point(295, 110);
            this.buttonZoomReset.MouseState = RSBot.Theme.IMatMouseState.HOVER;
            this.buttonZoomReset.Name = "buttonZoomReset";
            this.buttonZoomReset.Primary = true;
            this.buttonZoomReset.Raised = true;
            this.buttonZoomReset.SingleColor = System.Drawing.Color.Empty;
            this.buttonZoomReset.Size = new System.Drawing.Size(24, 24);
            this.buttonZoomReset.TabIndex = 16;
            this.buttonZoomReset.Text = "n";
            this.buttonZoomReset.UseVisualStyleBackColor = true;
            this.buttonZoomReset.Click += new System.EventHandler(this.buttonZoomReset_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Depth = 0;
            this.buttonZoomOut.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonZoomOut.Icon = null;
            this.buttonZoomOut.Location = new System.Drawing.Point(295, 140);
            this.buttonZoomOut.MouseState = RSBot.Theme.IMatMouseState.HOVER;
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Primary = true;
            this.buttonZoomOut.Raised = true;
            this.buttonZoomOut.SingleColor = System.Drawing.Color.Silver;
            this.buttonZoomOut.Size = new System.Drawing.Size(24, 24);
            this.buttonZoomOut.TabIndex = 16;
            this.buttonZoomOut.Text = "6";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.buttonZoomOut);
            this.Controls.Add(this.buttonZoomReset);
            this.Controls.Add(this.buttonZoomIn);
            this.Controls.Add(this.labelSectorInfo);
            this.Controls.Add(this.comboViewType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvMonster);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapCanvas);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(750, 458);
            ((System.ComponentModel.ISupportInitialize)(this.mapCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblRegion;
        private Theme.Controls.ListView lvMonster;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboViewType;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.Timer trmInterval;
        private System.Windows.Forms.Label labelSectorInfo;
        private Theme.Material.Button buttonZoomIn;
        private Theme.Material.Button buttonZoomReset;
        private Theme.Material.Button buttonZoomOut;
    }
}
