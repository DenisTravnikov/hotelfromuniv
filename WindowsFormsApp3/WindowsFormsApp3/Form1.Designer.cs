namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.VIEW_OK = new System.Windows.Forms.Button();
            this.VIEW_AV = new System.Windows.Forms.Button();
            this.CheckLn = new System.Windows.Forms.Button();
            this.CheckOut = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.occupiedRoomsListBox = new System.Windows.Forms.ListBox();
            this.availableRoomsListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.occupied = new System.Windows.Forms.TabPage();
            this.available = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VIEW_OK
            // 
            this.VIEW_OK.Location = new System.Drawing.Point(155, 321);
            this.VIEW_OK.Name = "VIEW_OK";
            this.VIEW_OK.Size = new System.Drawing.Size(92, 31);
            this.VIEW_OK.TabIndex = 0;
            this.VIEW_OK.Text = "VIEW_OK";
            this.VIEW_OK.UseVisualStyleBackColor = true;
            this.VIEW_OK.Click += new System.EventHandler(this.VIEW_OK_Click);
            // 
            // VIEW_AV
            // 
            this.VIEW_AV.Location = new System.Drawing.Point(295, 321);
            this.VIEW_AV.Name = "VIEW_AV";
            this.VIEW_AV.Size = new System.Drawing.Size(85, 31);
            this.VIEW_AV.TabIndex = 1;
            this.VIEW_AV.Text = "VIEW_AV";
            this.VIEW_AV.UseVisualStyleBackColor = true;
            this.VIEW_AV.Click += new System.EventHandler(this.VIEW_AV_Click);
            // 
            // CheckLn
            // 
            this.CheckLn.Location = new System.Drawing.Point(430, 321);
            this.CheckLn.Name = "CheckLn";
            this.CheckLn.Size = new System.Drawing.Size(88, 31);
            this.CheckLn.TabIndex = 4;
            this.CheckLn.Text = "CheckLn";
            this.CheckLn.UseVisualStyleBackColor = true;
            this.CheckLn.Click += new System.EventHandler(this.CheckLn_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.Location = new System.Drawing.Point(610, 321);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(89, 31);
            this.CheckOut.TabIndex = 5;
            this.CheckOut.Text = "CheckOut";
            this.CheckOut.UseVisualStyleBackColor = true;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.ItemHeight = 16;
            this.roomsListBox.Location = new System.Drawing.Point(78, 164);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(218, 84);
            this.roomsListBox.TabIndex = 6;
            // 
            // occupiedRoomsListBox
            // 
            this.occupiedRoomsListBox.FormattingEnabled = true;
            this.occupiedRoomsListBox.ItemHeight = 16;
            this.occupiedRoomsListBox.Location = new System.Drawing.Point(315, 164);
            this.occupiedRoomsListBox.Name = "occupiedRoomsListBox";
            this.occupiedRoomsListBox.Size = new System.Drawing.Size(227, 84);
            this.occupiedRoomsListBox.TabIndex = 7;
            this.occupiedRoomsListBox.SelectedIndexChanged += new System.EventHandler(this.occupiedRoomsListBox_SelectedIndexChanged);
            // 
            // availableRoomsListBox
            // 
            this.availableRoomsListBox.FormattingEnabled = true;
            this.availableRoomsListBox.ItemHeight = 16;
            this.availableRoomsListBox.Location = new System.Drawing.Point(564, 164);
            this.availableRoomsListBox.Name = "availableRoomsListBox";
            this.availableRoomsListBox.Size = new System.Drawing.Size(203, 84);
            this.availableRoomsListBox.TabIndex = 8;
            this.availableRoomsListBox.SelectedIndexChanged += new System.EventHandler(this.availableRoomsListBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 22);
            this.textBox1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.occupied);
            this.tabControl1.Controls.Add(this.available);
            this.tabControl1.Location = new System.Drawing.Point(78, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 10;
            // 
            // occupied
            // 
            this.occupied.Location = new System.Drawing.Point(4, 25);
            this.occupied.Name = "occupied";
            this.occupied.Padding = new System.Windows.Forms.Padding(3);
            this.occupied.Size = new System.Drawing.Size(192, 71);
            this.occupied.TabIndex = 0;
            this.occupied.Text = "occupiedRoomsTabPage";
            this.occupied.UseVisualStyleBackColor = true;
            // 
            // available
            // 
            this.available.Location = new System.Drawing.Point(4, 25);
            this.available.Name = "available";
            this.available.Padding = new System.Windows.Forms.Padding(3);
            this.available.Size = new System.Drawing.Size(192, 71);
            this.available.TabIndex = 1;
            this.available.Text = "availableRoomsTabPage";
            this.available.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.availableRoomsListBox);
            this.Controls.Add(this.occupiedRoomsListBox);
            this.Controls.Add(this.roomsListBox);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.CheckLn);
            this.Controls.Add(this.VIEW_AV);
            this.Controls.Add(this.VIEW_OK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VIEW_OK;
        private System.Windows.Forms.Button VIEW_AV;
        private System.Windows.Forms.Button CheckLn;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.ListBox occupiedRoomsListBox;
        private System.Windows.Forms.ListBox availableRoomsListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage occupied;
        private System.Windows.Forms.TabPage available;
    }
}

