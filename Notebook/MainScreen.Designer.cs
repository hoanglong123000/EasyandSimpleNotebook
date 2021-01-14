
namespace Notebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Notebooklst = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lựaChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.titlebox = new System.Windows.Forms.TextBox();
            this.toolStripAddbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Upbtn = new System.Windows.Forms.ToolStripButton();
            this.Deletetoolstripbtn = new System.Windows.Forms.ToolStripButton();
            this.Findbtn = new System.Windows.Forms.ToolStripButton();
            this.mởCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátCtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripSaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.Notebooklst)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notebooklst
            // 
            this.Notebooklst.AllowUserToAddRows = false;
            this.Notebooklst.AllowUserToDeleteRows = false;
            this.Notebooklst.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Notebooklst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Notebooklst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.title,
            this.username,
            this.date});
            this.Notebooklst.GridColor = System.Drawing.SystemColors.Control;
            this.Notebooklst.Location = new System.Drawing.Point(25, 115);
            this.Notebooklst.Margin = new System.Windows.Forms.Padding(5);
            this.Notebooklst.Name = "Notebooklst";
            this.Notebooklst.ReadOnly = true;
            this.Notebooklst.RowHeadersWidth = 51;
            this.Notebooklst.RowTemplate.Height = 24;
            this.Notebooklst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Notebooklst.Size = new System.Drawing.Size(1444, 549);
            this.Notebooklst.TabIndex = 10;
            this.Notebooklst.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Notebooklst_CellClick);
            this.Notebooklst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Notebooklst_CellContentClick);
            // 
            // No
            // 
            this.No.HeaderText = "Trang";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "Tiêu đề";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 400;
            // 
            // username
            // 
            this.username.HeaderText = "Nội dung";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 400;
            // 
            // date
            // 
            this.date.HeaderText = "Ngày tháng";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 400;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lựaChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1483, 40);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lựaChọnToolStripMenuItem
            // 
            this.lựaChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởCtrlOToolStripMenuItem,
            this.lToolStripSaveItem,
            this.thoátCtrlEToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.lựaChọnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lựaChọnToolStripMenuItem.Name = "lựaChọnToolStripMenuItem";
            this.lựaChọnToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.lựaChọnToolStripMenuItem.Text = "Lựa Chọn";
            this.lựaChọnToolStripMenuItem.ToolTipText = "Lựa chọn để lưu mở trang sổ mới";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripAddbtn,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.Upbtn,
            this.Deletetoolstripbtn,
            this.toolStripSeparator4,
            this.Findbtn,
            this.toolStripSeparator5,
            this.Savebtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1483, 37);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(347, 80);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(100, 34);
            this.titlebox.TabIndex = 15;
            this.titlebox.Visible = false;
            this.titlebox.TextChanged += new System.EventHandler(this.pagebox_TextChanged);
            // 
            // toolStripAddbtn
            // 
            this.toolStripAddbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAddbtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripAddbtn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddbtn.Image")));
            this.toolStripAddbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddbtn.Name = "toolStripAddbtn";
            this.toolStripAddbtn.Size = new System.Drawing.Size(34, 34);
            this.toolStripAddbtn.ToolTipText = "Thêm Trang Mới";
            this.toolStripAddbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Notebook.Properties.Resources._17637375381582779183_128;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton1.Text = "Mở file";
            this.toolStripButton1.ToolTipText = "Mở file";
            // 
            // Upbtn
            // 
            this.Upbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Upbtn.Image = ((System.Drawing.Image)(resources.GetObject("Upbtn.Image")));
            this.Upbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Upbtn.Name = "Upbtn";
            this.Upbtn.Size = new System.Drawing.Size(34, 34);
            this.Upbtn.ToolTipText = "Chỉnh Sửa Trang ";
            this.Upbtn.Click += new System.EventHandler(this.Upbtn_Click);
            // 
            // Deletetoolstripbtn
            // 
            this.Deletetoolstripbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Deletetoolstripbtn.Image = ((System.Drawing.Image)(resources.GetObject("Deletetoolstripbtn.Image")));
            this.Deletetoolstripbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Deletetoolstripbtn.Name = "Deletetoolstripbtn";
            this.Deletetoolstripbtn.Size = new System.Drawing.Size(34, 34);
            this.Deletetoolstripbtn.ToolTipText = "Xóa Trang";
            this.Deletetoolstripbtn.Click += new System.EventHandler(this.Deletetoolstripbtn_Click);
            // 
            // Findbtn
            // 
            this.Findbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Findbtn.Image = ((System.Drawing.Image)(resources.GetObject("Findbtn.Image")));
            this.Findbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(34, 34);
            this.Findbtn.Text = "toolStripButton3";
            this.Findbtn.ToolTipText = "Tìm Trang ";
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // mởCtrlOToolStripMenuItem
            // 
            this.mởCtrlOToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mởCtrlOToolStripMenuItem.BackgroundImage")));
            this.mởCtrlOToolStripMenuItem.Image = global::Notebook.Properties.Resources._17637375381582779183_128;
            this.mởCtrlOToolStripMenuItem.Name = "mởCtrlOToolStripMenuItem";
            this.mởCtrlOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mởCtrlOToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.mởCtrlOToolStripMenuItem.Text = "Mở ";
            this.mởCtrlOToolStripMenuItem.ToolTipText = "Tìm trên máy vi tính của bạn và mở trang dạng txt";
            this.mởCtrlOToolStripMenuItem.Click += new System.EventHandler(this.mởCtrlOToolStripMenuItem_Click);
            // 
            // thoátCtrlEToolStripMenuItem
            // 
            this.thoátCtrlEToolStripMenuItem.Image = global::Notebook.Properties.Resources._11600322591535351491_128;
            this.thoátCtrlEToolStripMenuItem.Name = "thoátCtrlEToolStripMenuItem";
            this.thoátCtrlEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.thoátCtrlEToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.thoátCtrlEToolStripMenuItem.Text = "Thoát";
            this.thoátCtrlEToolStripMenuItem.ToolTipText = "Thoát khỏi phần mềm và đăng xuất";
            this.thoátCtrlEToolStripMenuItem.Click += new System.EventHandler(this.thoátCtrlEToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::Notebook.Properties.Resources._11746585021530177262_128;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.ToolTipText = "Quay về màn hình đăng nhập";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // lToolStripSaveItem
            // 
            this.lToolStripSaveItem.Image = global::Notebook.Properties.Resources._129510;
            this.lToolStripSaveItem.Name = "lToolStripSaveItem";
            this.lToolStripSaveItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lToolStripSaveItem.Size = new System.Drawing.Size(257, 32);
            this.lToolStripSaveItem.Text = "Lưu";
            this.lToolStripSaveItem.ToolTipText = "Lưu định dạng file";
            this.lToolStripSaveItem.Click += new System.EventHandler(this.lToolStripSaveItem_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Savebtn.Image = global::Notebook.Properties.Resources._129510;
            this.Savebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(34, 34);
            this.Savebtn.Text = "Lưu";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 702);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Notebooklst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sổ tay";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notebooklst)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Notebooklst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lựaChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátCtrlEToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAddbtn;
        private System.Windows.Forms.ToolStripButton Upbtn;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Deletetoolstripbtn;
        private System.Windows.Forms.ToolStripButton Findbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem lToolStripSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Savebtn;
    }
}