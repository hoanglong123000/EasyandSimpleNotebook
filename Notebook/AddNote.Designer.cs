
namespace Notebook
{
    partial class AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            this.returnaddscrnbtn = new System.Windows.Forms.Button();
            this.Addnotebtn = new System.Windows.Forms.Button();
            this.descripbox = new System.Windows.Forms.RichTextBox();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnaddscrnbtn
            // 
            this.returnaddscrnbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnaddscrnbtn.Location = new System.Drawing.Point(12, 606);
            this.returnaddscrnbtn.Name = "returnaddscrnbtn";
            this.returnaddscrnbtn.Size = new System.Drawing.Size(148, 46);
            this.returnaddscrnbtn.TabIndex = 4;
            this.returnaddscrnbtn.Text = "Quay lại";
            this.returnaddscrnbtn.UseVisualStyleBackColor = true;
            this.returnaddscrnbtn.Click += new System.EventHandler(this.returnaddscrnbtn_Click);
            // 
            // Addnotebtn
            // 
            this.Addnotebtn.Enabled = false;
            this.Addnotebtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addnotebtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Addnotebtn.Location = new System.Drawing.Point(881, 606);
            this.Addnotebtn.Name = "Addnotebtn";
            this.Addnotebtn.Size = new System.Drawing.Size(140, 46);
            this.Addnotebtn.TabIndex = 10;
            this.Addnotebtn.Text = "Thêm";
            this.Addnotebtn.UseVisualStyleBackColor = true;
            this.Addnotebtn.Click += new System.EventHandler(this.Addnotebtn_Click);
            // 
            // descripbox
            // 
            this.descripbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripbox.Location = new System.Drawing.Point(22, 192);
            this.descripbox.Name = "descripbox";
            this.descripbox.Size = new System.Drawing.Size(1009, 391);
            this.descripbox.TabIndex = 11;
            this.descripbox.Text = "";
            this.descripbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // titlebox
            // 
            this.titlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebox.Location = new System.Drawing.Point(12, 126);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(941, 38);
            this.titlebox.TabIndex = 12;
            this.titlebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datebox
            // 
            this.datebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebox.Location = new System.Drawing.Point(675, 70);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(130, 30);
            this.datebox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tiêu đề:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày và tháng:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripSeparator5,
            this.toolStripComboBox1,
            this.toolStripSeparator4,
            this.toolStripComboBox2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 37);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 37);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "8",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "28",
            "32",
            "36",
            "48",
            "56",
            "72"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 37);
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 678);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.descripbox);
            this.Controls.Add(this.Addnotebtn);
            this.Controls.Add(this.returnaddscrnbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNote";
            this.Load += new System.EventHandler(this.AddNote_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnaddscrnbtn;
        private System.Windows.Forms.Button Addnotebtn;
        private System.Windows.Forms.RichTextBox descripbox;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}