namespace RentACable.Views
{
    partial class HomeForm
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
            System.Windows.Forms.TableLayoutPanel mainLayout;
            System.Windows.Forms.Panel navGroup;
            System.Windows.Forms.Button lendButton;
            System.Windows.Forms.Button itemsButton;
            System.Windows.Forms.Button labelsButton;
            System.Windows.Forms.Button fileButton;
            System.Windows.Forms.Panel contentGroup;
            System.Windows.Forms.TabPage tabLend;
            System.Windows.Forms.TabPage tabItems;
            System.Windows.Forms.TabPage tabLabels;
            System.Windows.Forms.TabPage tabFile;
            System.Windows.Forms.TableLayoutPanel fileContentLayout;
            System.Windows.Forms.Label fileTitleLabel;
            System.Windows.Forms.TableLayoutPanel labelsContentLayout;
            System.Windows.Forms.Label labelsTitleLabel;
            System.Windows.Forms.TableLayoutPanel itemsContentLayout;
            System.Windows.Forms.Label itemsTitle;
            System.Windows.Forms.TableLayoutPanel lendContentLayout;
            System.Windows.Forms.Label lendTitle;
            this.navLayout = new System.Windows.Forms.TableLayoutPanel();
            this.contentTabs = new System.Windows.Forms.TabControl();
            this.labelList = new System.Windows.Forms.ListView();
            this.itemsGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendGrid = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            mainLayout = new System.Windows.Forms.TableLayoutPanel();
            navGroup = new System.Windows.Forms.Panel();
            lendButton = new System.Windows.Forms.Button();
            itemsButton = new System.Windows.Forms.Button();
            labelsButton = new System.Windows.Forms.Button();
            fileButton = new System.Windows.Forms.Button();
            contentGroup = new System.Windows.Forms.Panel();
            tabLend = new System.Windows.Forms.TabPage();
            tabItems = new System.Windows.Forms.TabPage();
            tabLabels = new System.Windows.Forms.TabPage();
            tabFile = new System.Windows.Forms.TabPage();
            fileContentLayout = new System.Windows.Forms.TableLayoutPanel();
            fileTitleLabel = new System.Windows.Forms.Label();
            labelsContentLayout = new System.Windows.Forms.TableLayoutPanel();
            labelsTitleLabel = new System.Windows.Forms.Label();
            itemsContentLayout = new System.Windows.Forms.TableLayoutPanel();
            itemsTitle = new System.Windows.Forms.Label();
            lendContentLayout = new System.Windows.Forms.TableLayoutPanel();
            lendTitle = new System.Windows.Forms.Label();
            mainLayout.SuspendLayout();
            navGroup.SuspendLayout();
            this.navLayout.SuspendLayout();
            contentGroup.SuspendLayout();
            this.contentTabs.SuspendLayout();
            tabLend.SuspendLayout();
            tabItems.SuspendLayout();
            tabLabels.SuspendLayout();
            tabFile.SuspendLayout();
            fileContentLayout.SuspendLayout();
            labelsContentLayout.SuspendLayout();
            itemsContentLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            lendContentLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lendGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            mainLayout.Controls.Add(navGroup, 0, 0);
            mainLayout.Controls.Add(contentGroup, 1, 0);
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.Location = new System.Drawing.Point(0, 0);
            mainLayout.Margin = new System.Windows.Forms.Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            mainLayout.Size = new System.Drawing.Size(684, 361);
            mainLayout.TabIndex = 0;
            // 
            // navGroup
            // 
            navGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            navGroup.Controls.Add(this.navLayout);
            navGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            navGroup.Location = new System.Drawing.Point(0, 0);
            navGroup.Margin = new System.Windows.Forms.Padding(0);
            navGroup.Name = "navGroup";
            navGroup.Size = new System.Drawing.Size(171, 361);
            navGroup.TabIndex = 1;
            // 
            // navLayout
            // 
            this.navLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.navLayout.ColumnCount = 1;
            this.navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navLayout.Controls.Add(lendButton, 0, 0);
            this.navLayout.Controls.Add(itemsButton, 0, 1);
            this.navLayout.Controls.Add(labelsButton, 0, 2);
            this.navLayout.Controls.Add(fileButton, 0, 3);
            this.navLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.navLayout.Location = new System.Drawing.Point(0, 0);
            this.navLayout.Margin = new System.Windows.Forms.Padding(0);
            this.navLayout.Name = "navLayout";
            this.navLayout.RowCount = 4;
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.navLayout.Size = new System.Drawing.Size(171, 127);
            this.navLayout.TabIndex = 0;
            // 
            // lendButton
            // 
            lendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            lendButton.FlatAppearance.BorderSize = 0;
            lendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lendButton.Location = new System.Drawing.Point(0, 0);
            lendButton.Margin = new System.Windows.Forms.Padding(0);
            lendButton.Name = "lendButton";
            lendButton.Size = new System.Drawing.Size(171, 32);
            lendButton.TabIndex = 0;
            lendButton.Text = "Geleend";
            lendButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lendButton.UseVisualStyleBackColor = true;
            // 
            // itemsButton
            // 
            itemsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            itemsButton.FlatAppearance.BorderSize = 0;
            itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            itemsButton.Location = new System.Drawing.Point(0, 32);
            itemsButton.Margin = new System.Windows.Forms.Padding(0);
            itemsButton.Name = "itemsButton";
            itemsButton.Size = new System.Drawing.Size(171, 32);
            itemsButton.TabIndex = 1;
            itemsButton.Text = "Items";
            itemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            itemsButton.UseVisualStyleBackColor = true;
            // 
            // labelsButton
            // 
            labelsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            labelsButton.FlatAppearance.BorderSize = 0;
            labelsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelsButton.Location = new System.Drawing.Point(0, 64);
            labelsButton.Margin = new System.Windows.Forms.Padding(0);
            labelsButton.Name = "labelsButton";
            labelsButton.Size = new System.Drawing.Size(171, 32);
            labelsButton.TabIndex = 2;
            labelsButton.Text = "Labels";
            labelsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelsButton.UseVisualStyleBackColor = true;
            // 
            // fileButton
            // 
            fileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            fileButton.FlatAppearance.BorderSize = 0;
            fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            fileButton.Location = new System.Drawing.Point(0, 96);
            fileButton.Margin = new System.Windows.Forms.Padding(0);
            fileButton.Name = "fileButton";
            fileButton.Size = new System.Drawing.Size(171, 35);
            fileButton.TabIndex = 3;
            fileButton.Text = "Bestand";
            fileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            fileButton.UseVisualStyleBackColor = true;
            // 
            // contentGroup
            // 
            contentGroup.Controls.Add(this.contentTabs);
            contentGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            contentGroup.Location = new System.Drawing.Point(171, 0);
            contentGroup.Margin = new System.Windows.Forms.Padding(0);
            contentGroup.Name = "contentGroup";
            contentGroup.Size = new System.Drawing.Size(513, 361);
            contentGroup.TabIndex = 2;
            // 
            // contentTabs
            // 
            this.contentTabs.Controls.Add(tabLend);
            this.contentTabs.Controls.Add(tabItems);
            this.contentTabs.Controls.Add(tabLabels);
            this.contentTabs.Controls.Add(tabFile);
            this.contentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTabs.ItemSize = new System.Drawing.Size(0, 1);
            this.contentTabs.Location = new System.Drawing.Point(0, 0);
            this.contentTabs.Margin = new System.Windows.Forms.Padding(0);
            this.contentTabs.Name = "contentTabs";
            this.contentTabs.Padding = new System.Drawing.Point(0, 0);
            this.contentTabs.SelectedIndex = 0;
            this.contentTabs.Size = new System.Drawing.Size(513, 361);
            this.contentTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.contentTabs.TabIndex = 0;
            // 
            // tabLend
            // 
            tabLend.Controls.Add(lendContentLayout);
            tabLend.Location = new System.Drawing.Point(4, 5);
            tabLend.Margin = new System.Windows.Forms.Padding(0);
            tabLend.Name = "tabLend";
            tabLend.Padding = new System.Windows.Forms.Padding(3);
            tabLend.Size = new System.Drawing.Size(505, 352);
            tabLend.TabIndex = 0;
            tabLend.Text = "tabPage1";
            tabLend.UseVisualStyleBackColor = true;
            // 
            // tabItems
            // 
            tabItems.Controls.Add(itemsContentLayout);
            tabItems.Location = new System.Drawing.Point(4, 5);
            tabItems.Margin = new System.Windows.Forms.Padding(0);
            tabItems.Name = "tabItems";
            tabItems.Padding = new System.Windows.Forms.Padding(3);
            tabItems.Size = new System.Drawing.Size(505, 352);
            tabItems.TabIndex = 1;
            tabItems.Text = "tabPage2";
            tabItems.UseVisualStyleBackColor = true;
            // 
            // tabLabels
            // 
            tabLabels.Controls.Add(labelsContentLayout);
            tabLabels.Location = new System.Drawing.Point(4, 5);
            tabLabels.Margin = new System.Windows.Forms.Padding(0);
            tabLabels.Name = "tabLabels";
            tabLabels.Size = new System.Drawing.Size(505, 352);
            tabLabels.TabIndex = 2;
            tabLabels.Text = "tabLabels";
            tabLabels.UseVisualStyleBackColor = true;
            // 
            // tabFile
            // 
            tabFile.Controls.Add(fileContentLayout);
            tabFile.Location = new System.Drawing.Point(4, 5);
            tabFile.Margin = new System.Windows.Forms.Padding(0);
            tabFile.Name = "tabFile";
            tabFile.Size = new System.Drawing.Size(505, 352);
            tabFile.TabIndex = 3;
            tabFile.Text = "tabPage1";
            tabFile.UseVisualStyleBackColor = true;
            // 
            // fileContentLayout
            // 
            fileContentLayout.ColumnCount = 1;
            fileContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            fileContentLayout.Controls.Add(fileTitleLabel, 0, 0);
            fileContentLayout.Controls.Add(this.groupBox1, 0, 1);
            fileContentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            fileContentLayout.Location = new System.Drawing.Point(0, 0);
            fileContentLayout.Margin = new System.Windows.Forms.Padding(0);
            fileContentLayout.Name = "fileContentLayout";
            fileContentLayout.RowCount = 2;
            fileContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            fileContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            fileContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            fileContentLayout.Size = new System.Drawing.Size(505, 352);
            fileContentLayout.TabIndex = 0;
            // 
            // fileTitleLabel
            // 
            fileTitleLabel.AutoSize = true;
            fileTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            fileTitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fileTitleLabel.Location = new System.Drawing.Point(3, 0);
            fileTitleLabel.Name = "fileTitleLabel";
            fileTitleLabel.Size = new System.Drawing.Size(499, 22);
            fileTitleLabel.TabIndex = 0;
            fileTitleLabel.Text = "Bestand";
            fileTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelList
            // 
            this.labelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelList.FullRowSelect = true;
            this.labelList.HideSelection = false;
            this.labelList.Location = new System.Drawing.Point(0, 22);
            this.labelList.Margin = new System.Windows.Forms.Padding(0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(505, 330);
            this.labelList.TabIndex = 0;
            this.labelList.UseCompatibleStateImageBehavior = false;
            this.labelList.View = System.Windows.Forms.View.List;
            // 
            // labelsContentLayout
            // 
            labelsContentLayout.ColumnCount = 1;
            labelsContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            labelsContentLayout.Controls.Add(labelsTitleLabel, 0, 0);
            labelsContentLayout.Controls.Add(this.labelList, 0, 1);
            labelsContentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            labelsContentLayout.Location = new System.Drawing.Point(0, 0);
            labelsContentLayout.Margin = new System.Windows.Forms.Padding(0);
            labelsContentLayout.Name = "labelsContentLayout";
            labelsContentLayout.RowCount = 2;
            labelsContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            labelsContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            labelsContentLayout.Size = new System.Drawing.Size(505, 352);
            labelsContentLayout.TabIndex = 2;
            // 
            // labelsTitleLabel
            // 
            labelsTitleLabel.AutoSize = true;
            labelsTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            labelsTitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelsTitleLabel.Location = new System.Drawing.Point(3, 0);
            labelsTitleLabel.Name = "labelsTitleLabel";
            labelsTitleLabel.Size = new System.Drawing.Size(499, 22);
            labelsTitleLabel.TabIndex = 0;
            labelsTitleLabel.Text = "Alle labels";
            labelsTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // itemsContentLayout
            // 
            itemsContentLayout.ColumnCount = 1;
            itemsContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            itemsContentLayout.Controls.Add(itemsTitle, 0, 0);
            itemsContentLayout.Controls.Add(this.itemsGrid, 0, 1);
            itemsContentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            itemsContentLayout.Location = new System.Drawing.Point(3, 3);
            itemsContentLayout.Name = "itemsContentLayout";
            itemsContentLayout.RowCount = 2;
            itemsContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            itemsContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            itemsContentLayout.Size = new System.Drawing.Size(499, 346);
            itemsContentLayout.TabIndex = 1;
            // 
            // itemsTitle
            // 
            itemsTitle.AutoSize = true;
            itemsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            itemsTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemsTitle.Location = new System.Drawing.Point(3, 0);
            itemsTitle.Name = "itemsTitle";
            itemsTitle.Size = new System.Drawing.Size(493, 22);
            itemsTitle.TabIndex = 0;
            itemsTitle.Text = "Items";
            itemsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // itemsGrid
            // 
            this.itemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.itemsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.label});
            this.itemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsGrid.Location = new System.Drawing.Point(0, 22);
            this.itemsGrid.Margin = new System.Windows.Forms.Padding(0);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.RowHeadersWidth = 50;
            this.itemsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemsGrid.ShowCellToolTips = false;
            this.itemsGrid.Size = new System.Drawing.Size(499, 324);
            this.itemsGrid.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Naam";
            this.name.Name = "name";
            // 
            // label
            // 
            this.label.HeaderText = "Label";
            this.label.Name = "label";
            // 
            // lendContentLayout
            // 
            lendContentLayout.ColumnCount = 1;
            lendContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            lendContentLayout.Controls.Add(lendTitle, 0, 0);
            lendContentLayout.Controls.Add(this.lendGrid, 0, 1);
            lendContentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            lendContentLayout.Location = new System.Drawing.Point(3, 3);
            lendContentLayout.Margin = new System.Windows.Forms.Padding(0);
            lendContentLayout.Name = "lendContentLayout";
            lendContentLayout.RowCount = 2;
            lendContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            lendContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            lendContentLayout.Size = new System.Drawing.Size(499, 346);
            lendContentLayout.TabIndex = 1;
            // 
            // lendTitle
            // 
            lendTitle.AutoSize = true;
            lendTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lendTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lendTitle.Location = new System.Drawing.Point(3, 0);
            lendTitle.Name = "lendTitle";
            lendTitle.Size = new System.Drawing.Size(493, 22);
            lendTitle.TabIndex = 0;
            lendTitle.Text = "Geleende Items";
            lendTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lendGrid
            // 
            this.lendGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lendGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.lendGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lendGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.lendGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lendGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.person});
            this.lendGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lendGrid.Location = new System.Drawing.Point(0, 22);
            this.lendGrid.Margin = new System.Windows.Forms.Padding(0);
            this.lendGrid.Name = "lendGrid";
            this.lendGrid.ShowCellToolTips = false;
            this.lendGrid.Size = new System.Drawing.Size(499, 324);
            this.lendGrid.TabIndex = 1;
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // person
            // 
            this.person.HeaderText = "Persoon";
            this.person.Name = "person";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(271, 131);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(122, 131);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(mainLayout);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            mainLayout.ResumeLayout(false);
            navGroup.ResumeLayout(false);
            this.navLayout.ResumeLayout(false);
            contentGroup.ResumeLayout(false);
            this.contentTabs.ResumeLayout(false);
            tabLend.ResumeLayout(false);
            tabItems.ResumeLayout(false);
            tabLabels.ResumeLayout(false);
            tabFile.ResumeLayout(false);
            fileContentLayout.ResumeLayout(false);
            fileContentLayout.PerformLayout();
            labelsContentLayout.ResumeLayout(false);
            labelsContentLayout.PerformLayout();
            itemsContentLayout.ResumeLayout(false);
            itemsContentLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            lendContentLayout.ResumeLayout(false);
            lendContentLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lendGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel navLayout;
        private System.Windows.Forms.TabControl contentTabs;
        private System.Windows.Forms.ListView labelList;
        private System.Windows.Forms.DataGridView itemsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
        private System.Windows.Forms.DataGridView lendGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn person;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}