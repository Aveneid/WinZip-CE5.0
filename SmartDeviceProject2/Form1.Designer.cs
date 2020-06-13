namespace SmartDeviceProject2
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.parent = new System.Windows.Forms.ToolBarButton();
            this.addfolder = new System.Windows.Forms.ToolBarButton();
            this.delete = new System.Windows.Forms.ToolBarButton();
            this.refresh = new System.Windows.Forms.ToolBarButton();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Path";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader3);
            this.listView1.Columns.Add(this.columnHeader4);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 294);
            this.listView1.TabIndex = 0;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 60;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 60;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 272);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.Add(this.parent);
            this.toolBar1.Buttons.Add(this.addfolder);
            this.toolBar1.Buttons.Add(this.refresh);
            this.toolBar1.Buttons.Add(this.delete);
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            this.imageList1.Images.Clear();
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource5"))));
            // 
            // parent
            // 
            this.parent.ImageIndex = 1;
            this.parent.ToolTipText = "Parent folder";
            // 
            // addfolder
            // 
            this.addfolder.ImageIndex = 0;
            this.addfolder.ToolTipText = "Create folder";
            // 
            // delete
            // 
            this.delete.ImageIndex = 3;
            this.delete.ToolTipText = "Delete selected";
            // 
            // refresh
            // 
            this.refresh.ImageIndex = 2;
            this.refresh.ToolTipText = "Refresh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.listView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "WinZip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton parent;
        private System.Windows.Forms.ToolBarButton addfolder;
        private System.Windows.Forms.ToolBarButton refresh;
        private System.Windows.Forms.ToolBarButton delete;


    }
}

