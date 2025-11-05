namespace phonebook
{
    partial class phonebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phonebook));
            this.namelabel = new System.Windows.Forms.Label();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addresslablel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.numberlabel = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.infodataGridView = new System.Windows.Forms.DataGridView();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.laodbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.namelabel.Location = new System.Drawing.Point(19, 13);
            this.namelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(50, 21);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            // 
            // addresstextBox
            // 
            this.addresstextBox.BackColor = System.Drawing.Color.LightYellow;
            this.addresstextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.addresstextBox.Location = new System.Drawing.Point(91, 96);
            this.addresstextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addresstextBox.Multiline = true;
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(385, 25);
            this.addresstextBox.TabIndex = 1;
            this.addresstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(482, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addresslablel
            // 
            this.addresslablel.AutoSize = true;
            this.addresslablel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.addresslablel.Location = new System.Drawing.Point(16, 96);
            this.addresslablel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addresslablel.Name = "addresslablel";
            this.addresslablel.Size = new System.Drawing.Size(68, 21);
            this.addresslablel.TabIndex = 3;
            this.addresslablel.Text = "Address";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.emaillabel.Location = new System.Drawing.Point(22, 71);
            this.emaillabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(47, 21);
            this.emaillabel.TabIndex = 4;
            this.emaillabel.Text = "Email";
            this.emaillabel.Click += new System.EventHandler(this.emaillabel_Click);
            // 
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.numberlabel.Location = new System.Drawing.Point(16, 42);
            this.numberlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(66, 21);
            this.numberlabel.TabIndex = 5;
            this.numberlabel.Text = "Number";
            // 
            // emailtextBox
            // 
            this.emailtextBox.BackColor = System.Drawing.Color.LightYellow;
            this.emailtextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.emailtextBox.Location = new System.Drawing.Point(92, 67);
            this.emailtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailtextBox.Multiline = true;
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(385, 25);
            this.emailtextBox.TabIndex = 6;
            this.emailtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numbertextBox
            // 
            this.numbertextBox.BackColor = System.Drawing.Color.LightYellow;
            this.numbertextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.numbertextBox.Location = new System.Drawing.Point(91, 38);
            this.numbertextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numbertextBox.Multiline = true;
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(385, 25);
            this.numbertextBox.TabIndex = 7;
            this.numbertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numbertextBox.TextChanged += new System.EventHandler(this.numbertextBox_TextChanged);
            // 
            // nametextBox
            // 
            this.nametextBox.BackColor = System.Drawing.Color.LightYellow;
            this.nametextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.nametextBox.Location = new System.Drawing.Point(92, 9);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(385, 25);
            this.nametextBox.TabIndex = 8;
            this.nametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.PeachPuff;
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.deletebutton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.deletebutton.Location = new System.Drawing.Point(482, 87);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(70, 34);
            this.deletebutton.TabIndex = 9;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // infodataGridView
            // 
            this.infodataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infodataGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.infodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infodataGridView.Location = new System.Drawing.Point(11, 168);
            this.infodataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infodataGridView.Name = "infodataGridView";
            this.infodataGridView.RowHeadersWidth = 51;
            this.infodataGridView.RowTemplate.Height = 24;
            this.infodataGridView.Size = new System.Drawing.Size(615, 383);
            this.infodataGridView.TabIndex = 12;
            this.infodataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infodataGridView_CellDoubleClick);
            // 
            // searchtextBox
            // 
            this.searchtextBox.BackColor = System.Drawing.Color.LightYellow;
            this.searchtextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.searchtextBox.Location = new System.Drawing.Point(11, 132);
            this.searchtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchtextBox.Multiline = true;
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(465, 25);
            this.searchtextBox.TabIndex = 14;
            this.searchtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.searchbutton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.Location = new System.Drawing.Point(480, 132);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(146, 25);
            this.searchbutton.TabIndex = 15;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // laodbutton
            // 
            this.laodbutton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.laodbutton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laodbutton.Location = new System.Drawing.Point(556, 87);
            this.laodbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.laodbutton.Name = "laodbutton";
            this.laodbutton.Size = new System.Drawing.Size(70, 34);
            this.laodbutton.TabIndex = 16;
            this.laodbutton.Text = "Contacts";
            this.laodbutton.UseVisualStyleBackColor = false;
            this.laodbutton.Click += new System.EventHandler(this.laodbutton_Click);
            // 
            // phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 561);
            this.Controls.Add(this.laodbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.infodataGridView);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.numbertextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.numberlabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.addresslablel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.namelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "phonebook";
            this.Text = "phonebook";
            this.Load += new System.EventHandler(this.phonebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label addresslablel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DataGridView infodataGridView;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button laodbutton;
    }
}

