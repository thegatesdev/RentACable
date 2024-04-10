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
            System.Windows.Forms.Panel contentGroup;
            System.Windows.Forms.TabPage tabLend;
            System.Windows.Forms.TabPage tabItems;
            System.Windows.Forms.TabPage tabLabels;
            System.Windows.Forms.TabPage tabFile;
            this.navGroup = new System.Windows.Forms.Panel();
            this.navLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lendButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.labelsButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.contentTabs = new System.Windows.Forms.TabControl();
            mainLayout = new System.Windows.Forms.TableLayoutPanel();
            contentGroup = new System.Windows.Forms.Panel();
            tabLend = new System.Windows.Forms.TabPage();
            tabItems = new System.Windows.Forms.TabPage();
            tabLabels = new System.Windows.Forms.TabPage();
            tabFile = new System.Windows.Forms.TabPage();
            mainLayout.SuspendLayout();
            this.navGroup.SuspendLayout();
            this.navLayout.SuspendLayout();
            contentGroup.SuspendLayout();
            this.contentTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            mainLayout.Controls.Add(this.navGroup, 0, 0);
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
            this.navGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.navGroup.Controls.Add(this.navLayout);
            this.navGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navGroup.Location = new System.Drawing.Point(0, 0);
            this.navGroup.Margin = new System.Windows.Forms.Padding(0);
            this.navGroup.Name = "navGroup";
            this.navGroup.Size = new System.Drawing.Size(171, 624);
            this.navGroup.TabIndex = 1;
            // 
            // navLayout
            // 
            this.navLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.navLayout.ColumnCount = 1;
            this.navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navLayout.Controls.Add(this.lendButton, 0, 0);
            this.navLayout.Controls.Add(this.itemsButton, 0, 1);
            this.navLayout.Controls.Add(this.labelsButton, 0, 2);
            this.navLayout.Controls.Add(this.fileButton, 0, 3);
            this.navLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.navLayout.Location = new System.Drawing.Point(0, 0);
            this.navLayout.Margin = new System.Windows.Forms.Padding(0);
            this.navLayout.Name = "navLayout";
            this.navLayout.RowCount = 4;
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.navLayout.Size = new System.Drawing.Size(171, 127);
            this.navLayout.TabIndex = 0;
            // 
            // lendButton
            // 
            this.lendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lendButton.FlatAppearance.BorderSize = 0;
            this.lendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendButton.Location = new System.Drawing.Point(0, 0);
            this.lendButton.Margin = new System.Windows.Forms.Padding(0);
            this.lendButton.Name = "lendButton";
            this.lendButton.Size = new System.Drawing.Size(171, 32);
            this.lendButton.TabIndex = 0;
            this.lendButton.Text = "Geleend";
            this.lendButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lendButton.UseVisualStyleBackColor = true;
            this.lendButton.Click += new System.EventHandler(this.LendButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsButton.FlatAppearance.BorderSize = 0;
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Location = new System.Drawing.Point(0, 32);
            this.itemsButton.Margin = new System.Windows.Forms.Padding(0);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(171, 32);
            this.itemsButton.TabIndex = 1;
            this.itemsButton.Text = "Items";
            this.itemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.ItemsButton_Click);
            // 
            // labelsButton
            // 
            this.labelsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelsButton.FlatAppearance.BorderSize = 0;
            this.labelsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelsButton.Location = new System.Drawing.Point(0, 64);
            this.labelsButton.Margin = new System.Windows.Forms.Padding(0);
            this.labelsButton.Name = "labelsButton";
            this.labelsButton.Size = new System.Drawing.Size(171, 32);
            this.labelsButton.TabIndex = 2;
            this.labelsButton.Text = "Labels";
            this.labelsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelsButton.UseVisualStyleBackColor = true;
            this.labelsButton.Click += new System.EventHandler(this.LabelsButton_Click);
            // 
            // fileButton
            // 
            this.fileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileButton.FlatAppearance.BorderSize = 0;
            this.fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton.Location = new System.Drawing.Point(0, 96);
            this.fileButton.Margin = new System.Windows.Forms.Padding(0);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(171, 35);
            this.fileButton.TabIndex = 3;
            this.fileButton.Text = "Bestand";
            this.fileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // contentGroup
            // 
            contentGroup.Controls.Add(this.contentTabs);
            contentGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            contentGroup.Location = new System.Drawing.Point(171, 0);
            contentGroup.Margin = new System.Windows.Forms.Padding(0);
            contentGroup.Name = "contentGroup";
            contentGroup.Size = new System.Drawing.Size(513, 624);
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
            this.contentTabs.Size = new System.Drawing.Size(513, 624);
            this.contentTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.contentTabs.TabIndex = 0;
            // 
            // tabLend
            // 
            tabLend.Location = new System.Drawing.Point(4, 5);
            tabLend.Margin = new System.Windows.Forms.Padding(0);
            tabLend.Name = "tabLend";
            tabLend.Padding = new System.Windows.Forms.Padding(3);
            tabLend.Size = new System.Drawing.Size(505, 615);
            tabLend.TabIndex = 0;
            tabLend.Text = "tabPage1";
            tabLend.UseVisualStyleBackColor = true;
            // 
            // tabItems
            // 
            tabItems.Location = new System.Drawing.Point(4, 5);
            tabItems.Margin = new System.Windows.Forms.Padding(0);
            tabItems.Name = "tabItems";
            tabItems.Padding = new System.Windows.Forms.Padding(3);
            tabItems.Size = new System.Drawing.Size(505, 615);
            tabItems.TabIndex = 1;
            tabItems.Text = "tabPage2";
            tabItems.UseVisualStyleBackColor = true;
            // 
            // tabLabels
            // 
            tabLabels.Location = new System.Drawing.Point(4, 5);
            tabLabels.Margin = new System.Windows.Forms.Padding(0);
            tabLabels.Name = "tabLabels";
            tabLabels.Size = new System.Drawing.Size(505, 615);
            tabLabels.TabIndex = 2;
            tabLabels.Text = "tabLabels";
            tabLabels.UseVisualStyleBackColor = true;
            // 
            // tabFile
            // 
            tabFile.Location = new System.Drawing.Point(4, 5);
            tabFile.Margin = new System.Windows.Forms.Padding(0);
            tabFile.Name = "tabFile";
            tabFile.Size = new System.Drawing.Size(505, 615);
            tabFile.TabIndex = 3;
            tabFile.Text = "tabPage1";
            tabFile.UseVisualStyleBackColor = true;
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
            this.navGroup.ResumeLayout(false);
            this.navLayout.ResumeLayout(false);
            contentGroup.ResumeLayout(false);
            this.contentTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel navLayout;
        private System.Windows.Forms.Button lendButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button labelsButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Panel navGroup;
        private System.Windows.Forms.TabControl contentTabs;
    }
}