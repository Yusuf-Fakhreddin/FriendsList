namespace FriendsList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_newFriend = new System.Windows.Forms.TextBox();
            this.btn_addFriend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addFive = new System.Windows.Forms.Button();
            this.btn_asc = new System.Windows.Forms.Button();
            this.lbl_sort = new System.Windows.Forms.Label();
            this.btn_desc = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(23, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 316);
            this.listBox1.TabIndex = 0;
            // 
            // txt_newFriend
            // 
            this.txt_newFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newFriend.Location = new System.Drawing.Point(310, 24);
            this.txt_newFriend.Name = "txt_newFriend";
            this.txt_newFriend.Size = new System.Drawing.Size(168, 29);
            this.txt_newFriend.TabIndex = 1;
            // 
            // btn_addFriend
            // 
            this.btn_addFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFriend.Location = new System.Drawing.Point(310, 69);
            this.btn_addFriend.Name = "btn_addFriend";
            this.btn_addFriend.Size = new System.Drawing.Size(83, 41);
            this.btn_addFriend.TabIndex = 2;
            this.btn_addFriend.Text = "ADD";
            this.btn_addFriend.UseVisualStyleBackColor = true;
            this.btn_addFriend.Click += new System.EventHandler(this.btn_addFriend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0 Friends";
            // 
            // btn_addFive
            // 
            this.btn_addFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFive.Location = new System.Drawing.Point(310, 116);
            this.btn_addFive.Name = "btn_addFive";
            this.btn_addFive.Size = new System.Drawing.Size(83, 47);
            this.btn_addFive.TabIndex = 4;
            this.btn_addFive.Text = "ADD FIVE";
            this.btn_addFive.UseVisualStyleBackColor = true;
            this.btn_addFive.Click += new System.EventHandler(this.btn_addFive_Click);
            // 
            // btn_asc
            // 
            this.btn_asc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asc.Location = new System.Drawing.Point(310, 283);
            this.btn_asc.Name = "btn_asc";
            this.btn_asc.Size = new System.Drawing.Size(84, 46);
            this.btn_asc.TabIndex = 5;
            this.btn_asc.Text = "A - Z";
            this.btn_asc.UseVisualStyleBackColor = true;
            this.btn_asc.Click += new System.EventHandler(this.btn_asc_Click);
            // 
            // lbl_sort
            // 
            this.lbl_sort.AutoSize = true;
            this.lbl_sort.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sort.Location = new System.Drawing.Point(306, 249);
            this.lbl_sort.Name = "lbl_sort";
            this.lbl_sort.Size = new System.Drawing.Size(43, 22);
            this.lbl_sort.TabIndex = 6;
            this.lbl_sort.Text = "Sort";
            this.lbl_sort.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btn_desc
            // 
            this.btn_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desc.Location = new System.Drawing.Point(407, 283);
            this.btn_desc.Name = "btn_desc";
            this.btn_desc.Size = new System.Drawing.Size(86, 46);
            this.btn_desc.TabIndex = 7;
            this.btn_desc.Text = "Z - A";
            this.btn_desc.UseVisualStyleBackColor = true;
            this.btn_desc.Click += new System.EventHandler(this.btn_desc_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_clear.Location = new System.Drawing.Point(407, 117);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(70, 45);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 365);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_desc);
            this.Controls.Add(this.lbl_sort);
            this.Controls.Add(this.btn_asc);
            this.Controls.Add(this.btn_addFive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addFriend);
            this.Controls.Add(this.txt_newFriend);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "My Friends List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_newFriend;
        private System.Windows.Forms.Button btn_addFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addFive;
        private System.Windows.Forms.Button btn_asc;
        private System.Windows.Forms.Label lbl_sort;
        private System.Windows.Forms.Button btn_desc;
        private System.Windows.Forms.Button btn_clear;
    }
}

