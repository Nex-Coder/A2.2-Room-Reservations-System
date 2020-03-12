﻿namespace RoomManagementSystem
{
    partial class rmsForm
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.roomView = new System.Windows.Forms.ListView();
            this.roomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomClose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClearFoundFilter = new System.Windows.Forms.Button();
            this.lblIn = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.txtBoxFind = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.lblRoomViewer = new System.Windows.Forms.Label();
            this.lblTimeFormatC = new System.Windows.Forms.Label();
            this.lblTimeFormatO = new System.Windows.Forms.Label();
            this.txtBoxCloseHour = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.checkBoxAvaliable = new System.Windows.Forms.CheckBox();
            this.lblCloseHour = new System.Windows.Forms.Label();
            this.lblOpenHour = new System.Windows.Forms.Label();
            this.txtBoxOpenHour = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxRoomID = new System.Windows.Forms.TextBox();
            this.rtxtBoxDesc = new System.Windows.Forms.RichTextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblRoomEditor = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(3, 330);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 27);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomView
            // 
            this.roomView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.roomView.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.roomView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomID,
            this.roomName,
            this.roomDesc,
            this.roomOpen,
            this.roomClose,
            this.roomStatus});
            this.roomView.HideSelection = false;
            this.roomView.HoverSelection = true;
            this.roomView.Location = new System.Drawing.Point(3, 41);
            this.roomView.MultiSelect = false;
            this.roomView.Name = "roomView";
            this.roomView.Size = new System.Drawing.Size(715, 281);
            this.roomView.TabIndex = 2;
            this.roomView.UseCompatibleStateImageBehavior = false;
            this.roomView.View = System.Windows.Forms.View.Details;
            // 
            // roomID
            // 
            this.roomID.Text = "Room ID";
            this.roomID.Width = 85;
            // 
            // roomName
            // 
            this.roomName.Text = "Name";
            this.roomName.Width = 120;
            // 
            // roomDesc
            // 
            this.roomDesc.Text = "Description";
            this.roomDesc.Width = 200;
            // 
            // roomOpen
            // 
            this.roomOpen.Text = "Opening Hour";
            this.roomOpen.Width = 112;
            // 
            // roomClose
            // 
            this.roomClose.Text = "Closing Hour";
            this.roomClose.Width = 112;
            // 
            // roomStatus
            // 
            this.roomStatus.Text = "Avaliable";
            this.roomStatus.Width = 80;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClearFoundFilter);
            this.splitContainer1.Panel1.Controls.Add(this.lblIn);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblFind);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxFind);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFind);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFilter);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSelect);
            this.splitContainer1.Panel1.Controls.Add(this.lblRoomViewer);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.roomView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblTimeFormatC);
            this.splitContainer1.Panel2.Controls.Add(this.lblTimeFormatO);
            this.splitContainer1.Panel2.Controls.Add(this.txtBoxCloseHour);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNew);
            this.splitContainer1.Panel2.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEdit);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxAvaliable);
            this.splitContainer1.Panel2.Controls.Add(this.lblCloseHour);
            this.splitContainer1.Panel2.Controls.Add(this.lblOpenHour);
            this.splitContainer1.Panel2.Controls.Add(this.txtBoxOpenHour);
            this.splitContainer1.Panel2.Controls.Add(this.lblDesc);
            this.splitContainer1.Panel2.Controls.Add(this.lblRoomID);
            this.splitContainer1.Panel2.Controls.Add(this.lblName);
            this.splitContainer1.Panel2.Controls.Add(this.txtBoxRoomID);
            this.splitContainer1.Panel2.Controls.Add(this.rtxtBoxDesc);
            this.splitContainer1.Panel2.Controls.Add(this.txtBoxName);
            this.splitContainer1.Panel2.Controls.Add(this.lblRoomEditor);
            this.splitContainer1.Size = new System.Drawing.Size(885, 587);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnClearFoundFilter
            // 
            this.btnClearFoundFilter.Location = new System.Drawing.Point(721, 316);
            this.btnClearFoundFilter.Name = "btnClearFoundFilter";
            this.btnClearFoundFilter.Size = new System.Drawing.Size(164, 27);
            this.btnClearFoundFilter.TabIndex = 12;
            this.btnClearFoundFilter.Text = "Clear Found / Filter";
            this.btnClearFoundFilter.UseVisualStyleBackColor = true;
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(717, 112);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(176, 20);
            this.lblIn.TabIndex = 11;
            this.lblIn.Text = "Find In (One) / Filter:";
            this.lblIn.Click += new System.EventHandler(this.lblIn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Room ID",
            "Name",
            "Description",
            "Openning Hour",
            "Closing Hour",
            "Avaliable"});
            this.checkedListBox1.Location = new System.Drawing.Point(721, 135);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(164, 130);
            this.checkedListBox1.TabIndex = 10;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(724, 60);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(49, 20);
            this.lblFind.TabIndex = 9;
            this.lblFind.Text = "Find:";
            // 
            // txtBoxFind
            // 
            this.txtBoxFind.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxFind.Location = new System.Drawing.Point(718, 83);
            this.txtBoxFind.Name = "txtBoxFind";
            this.txtBoxFind.Size = new System.Drawing.Size(167, 26);
            this.txtBoxFind.TabIndex = 7;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(721, 283);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(80, 27);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(807, 283);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(78, 27);
            this.buttonFilter.TabIndex = 5;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(117, 330);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(142, 29);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Edit Selection";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // lblRoomViewer
            // 
            this.lblRoomViewer.AutoSize = true;
            this.lblRoomViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomViewer.Location = new System.Drawing.Point(293, 5);
            this.lblRoomViewer.Name = "lblRoomViewer";
            this.lblRoomViewer.Size = new System.Drawing.Size(325, 33);
            this.lblRoomViewer.TabIndex = 3;
            this.lblRoomViewer.Text = "Room Viewer/Selector";
            // 
            // lblTimeFormatC
            // 
            this.lblTimeFormatC.AutoSize = true;
            this.lblTimeFormatC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimeFormatC.Location = new System.Drawing.Point(589, 108);
            this.lblTimeFormatC.Name = "lblTimeFormatC";
            this.lblTimeFormatC.Size = new System.Drawing.Size(96, 17);
            this.lblTimeFormatC.TabIndex = 26;
            this.lblTimeFormatC.Text = "hh : mm : ss";
            // 
            // lblTimeFormatO
            // 
            this.lblTimeFormatO.AutoSize = true;
            this.lblTimeFormatO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimeFormatO.Location = new System.Drawing.Point(589, 63);
            this.lblTimeFormatO.Name = "lblTimeFormatO";
            this.lblTimeFormatO.Size = new System.Drawing.Size(96, 17);
            this.lblTimeFormatO.TabIndex = 25;
            this.lblTimeFormatO.Text = "hh : mm : ss";
            // 
            // txtBoxCloseHour
            // 
            this.txtBoxCloseHour.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxCloseHour.Location = new System.Drawing.Point(588, 128);
            this.txtBoxCloseHour.MaxLength = 8;
            this.txtBoxCloseHour.Name = "txtBoxCloseHour";
            this.txtBoxCloseHour.Size = new System.Drawing.Size(102, 26);
            this.txtBoxCloseHour.TabIndex = 22;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(702, 152);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(180, 28);
            this.buttonNew.TabIndex = 19;
            this.buttonNew.Text = "Submit New ";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(3, 186);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(82, 30);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(702, 186);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(99, 29);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Submit Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(807, 186);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 29);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxAvaliable
            // 
            this.checkBoxAvaliable.AutoSize = true;
            this.checkBoxAvaliable.Location = new System.Drawing.Point(691, 108);
            this.checkBoxAvaliable.Name = "checkBoxAvaliable";
            this.checkBoxAvaliable.Size = new System.Drawing.Size(191, 24);
            this.checkBoxAvaliable.TabIndex = 15;
            this.checkBoxAvaliable.Text = "Avaliable for bookings?";
            this.checkBoxAvaliable.UseVisualStyleBackColor = true;
            // 
            // lblCloseHour
            // 
            this.lblCloseHour.AutoSize = true;
            this.lblCloseHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseHour.Location = new System.Drawing.Point(465, 134);
            this.lblCloseHour.Name = "lblCloseHour";
            this.lblCloseHour.Size = new System.Drawing.Size(117, 20);
            this.lblCloseHour.TabIndex = 14;
            this.lblCloseHour.Text = "Closing Hour:";
            // 
            // lblOpenHour
            // 
            this.lblOpenHour.AutoSize = true;
            this.lblOpenHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenHour.Location = new System.Drawing.Point(463, 89);
            this.lblOpenHour.Name = "lblOpenHour";
            this.lblOpenHour.Size = new System.Drawing.Size(125, 20);
            this.lblOpenHour.TabIndex = 12;
            this.lblOpenHour.Text = "Opening Hour:";
            // 
            // txtBoxOpenHour
            // 
            this.txtBoxOpenHour.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxOpenHour.Location = new System.Drawing.Point(588, 83);
            this.txtBoxOpenHour.MaxLength = 8;
            this.txtBoxOpenHour.Name = "txtBoxOpenHour";
            this.txtBoxOpenHour.Size = new System.Drawing.Size(102, 26);
            this.txtBoxOpenHour.TabIndex = 11;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(3, 75);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(105, 20);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Description:";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.Location = new System.Drawing.Point(26, 42);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(85, 20);
            this.lblRoomID.TabIndex = 9;
            this.lblRoomID.Text = "Room ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(224, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // txtBoxRoomID
            // 
            this.txtBoxRoomID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxRoomID.Location = new System.Drawing.Point(112, 38);
            this.txtBoxRoomID.Name = "txtBoxRoomID";
            this.txtBoxRoomID.ReadOnly = true;
            this.txtBoxRoomID.Size = new System.Drawing.Size(106, 26);
            this.txtBoxRoomID.TabIndex = 7;
            // 
            // rtxtBoxDesc
            // 
            this.rtxtBoxDesc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtxtBoxDesc.Location = new System.Drawing.Point(112, 70);
            this.rtxtBoxDesc.Name = "rtxtBoxDesc";
            this.rtxtBoxDesc.Size = new System.Drawing.Size(345, 118);
            this.rtxtBoxDesc.TabIndex = 6;
            this.rtxtBoxDesc.Text = "";
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxName.Location = new System.Drawing.Point(290, 39);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(167, 26);
            this.txtBoxName.TabIndex = 5;
            // 
            // lblRoomEditor
            // 
            this.lblRoomEditor.AutoSize = true;
            this.lblRoomEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomEditor.Location = new System.Drawing.Point(365, 3);
            this.lblRoomEditor.Name = "lblRoomEditor";
            this.lblRoomEditor.Size = new System.Drawing.Size(188, 33);
            this.lblRoomEditor.TabIndex = 4;
            this.lblRoomEditor.Text = "Room Editor";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.navigateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(903, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reloadWindowToolStripMenuItem
            // 
            this.reloadWindowToolStripMenuItem.Name = "reloadWindowToolStripMenuItem";
            this.reloadWindowToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reloadWindowToolStripMenuItem.Text = "Reload Window";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.bookingsToolStripMenuItem});
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.navigateToolStripMenuItem.Text = "Navigate";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationGuideToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informationGuideToolStripMenuItem
            // 
            this.informationGuideToolStripMenuItem.Name = "informationGuideToolStripMenuItem";
            this.informationGuideToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.informationGuideToolStripMenuItem.Text = "Information / Guide";
            // 
            // rmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(903, 615);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "rmsForm";
            this.Text = "Room Management System";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListView roomView;
        private System.Windows.Forms.ColumnHeader roomID;
        private System.Windows.Forms.ColumnHeader roomName;
        private System.Windows.Forms.ColumnHeader roomDesc;
        private System.Windows.Forms.ColumnHeader roomOpen;
        private System.Windows.Forms.ColumnHeader roomClose;
        private System.Windows.Forms.ColumnHeader roomStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblRoomViewer;
        private System.Windows.Forms.Label lblRoomEditor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxRoomID;
        private System.Windows.Forms.RichTextBox rtxtBoxDesc;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblCloseHour;
        private System.Windows.Forms.Label lblOpenHour;
        private System.Windows.Forms.TextBox txtBoxOpenHour;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.CheckBox checkBoxAvaliable;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationGuideToolStripMenuItem;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtBoxFind;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblTimeFormatO;
        private System.Windows.Forms.TextBox txtBoxCloseHour;
        private System.Windows.Forms.Label lblTimeFormatC;
        private System.Windows.Forms.Button btnClearFoundFilter;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
