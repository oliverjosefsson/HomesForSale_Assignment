
namespace HomesForSale
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
            this.cdCountry = new System.Windows.Forms.ComboBox();
            this.cdLegalForm = new System.Windows.Forms.ComboBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.rdCommercial = new System.Windows.Forms.RadioButton();
            this.rbResidental = new System.Windows.Forms.RadioButton();
            this.lblLegalForm = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lvProperties = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cResCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLegalform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zipcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCitySearch = new System.Windows.Forms.TextBox();
            this.tbTypeSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdCountry
            // 
            this.cdCountry.FormattingEnabled = true;
            this.cdCountry.Location = new System.Drawing.Point(123, 63);
            this.cdCountry.Name = "cdCountry";
            this.cdCountry.Size = new System.Drawing.Size(102, 21);
            this.cdCountry.TabIndex = 0;
            this.cdCountry.Text = "Country";
            // 
            // cdLegalForm
            // 
            this.cdLegalForm.FormattingEnabled = true;
            this.cdLegalForm.Location = new System.Drawing.Point(123, 94);
            this.cdLegalForm.Name = "cdLegalForm";
            this.cdLegalForm.Size = new System.Drawing.Size(102, 21);
            this.cdLegalForm.TabIndex = 1;
            this.cdLegalForm.Text = "Legal Form";
            // 
            // tbCity
            // 
            this.tbCity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCity.Location = new System.Drawing.Point(28, 162);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(197, 20);
            this.tbCity.TabIndex = 2;
            this.tbCity.Text = "City";
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(28, 188);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(197, 20);
            this.tbZipCode.TabIndex = 3;
            this.tbZipCode.Text = "Zip Code";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(28, 214);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(197, 20);
            this.tbStreet.TabIndex = 4;
            this.tbStreet.Text = "Street";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.rdCommercial);
            this.panel1.Controls.Add(this.rbResidental);
            this.panel1.Controls.Add(this.lblLegalForm);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.tbStreet);
            this.panel1.Controls.Add(this.tbZipCode);
            this.panel1.Controls.Add(this.cdCountry);
            this.panel1.Controls.Add(this.tbCity);
            this.panel1.Controls.Add(this.cdLegalForm);
            this.panel1.Location = new System.Drawing.Point(2, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 257);
            this.panel1.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(25, 125);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(67, 13);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Select Type:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(123, 122);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(102, 21);
            this.cbType.TabIndex = 9;
            // 
            // rdCommercial
            // 
            this.rdCommercial.AutoSize = true;
            this.rdCommercial.Location = new System.Drawing.Point(123, 29);
            this.rdCommercial.Name = "rdCommercial";
            this.rdCommercial.Size = new System.Drawing.Size(79, 17);
            this.rdCommercial.TabIndex = 8;
            this.rdCommercial.Text = "Commercial";
            this.rdCommercial.UseVisualStyleBackColor = true;
            this.rdCommercial.CheckedChanged += new System.EventHandler(this.rdCommercial_CheckedChanged);
            // 
            // rbResidental
            // 
            this.rbResidental.AutoSize = true;
            this.rbResidental.Location = new System.Drawing.Point(28, 29);
            this.rbResidental.Name = "rbResidental";
            this.rbResidental.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbResidental.Size = new System.Drawing.Size(75, 17);
            this.rbResidental.TabIndex = 7;
            this.rbResidental.Text = "Residental";
            this.rbResidental.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbResidental.UseVisualStyleBackColor = true;
            this.rbResidental.CheckedChanged += new System.EventHandler(this.rbResidental_CheckedChanged);
            // 
            // lblLegalForm
            // 
            this.lblLegalForm.AutoSize = true;
            this.lblLegalForm.Location = new System.Drawing.Point(25, 97);
            this.lblLegalForm.Name = "lblLegalForm";
            this.lblLegalForm.Size = new System.Drawing.Size(92, 13);
            this.lblLegalForm.TabIndex = 6;
            this.lblLegalForm.Text = "Select Legal form:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(25, 66);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(79, 13);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "Select Country:";
            // 
            // lvProperties
            // 
            this.lvProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cResCom,
            this.cType,
            this.cLegalform,
            this.cCountry,
            this.City,
            this.Zipcode,
            this.cStreet});
            this.lvProperties.FullRowSelect = true;
            this.lvProperties.Location = new System.Drawing.Point(244, 12);
            this.lvProperties.Name = "lvProperties";
            this.lvProperties.Size = new System.Drawing.Size(658, 277);
            this.lvProperties.TabIndex = 6;
            this.lvProperties.UseCompatibleStateImageBehavior = false;
            this.lvProperties.View = System.Windows.Forms.View.Details;
            this.lvProperties.SelectedIndexChanged += new System.EventHandler(this.lvProperties_SelectedIndexChanged);
            // 
            // cID
            // 
            this.cID.Text = "ID";
            this.cID.Width = 25;
            // 
            // cResCom
            // 
            this.cResCom.Text = "Res/Com";
            this.cResCom.Width = 77;
            // 
            // cType
            // 
            this.cType.Text = "Type";
            this.cType.Width = 59;
            // 
            // cLegalform
            // 
            this.cLegalform.Text = "LegalForm";
            this.cLegalform.Width = 80;
            // 
            // cCountry
            // 
            this.cCountry.Text = "Country";
            this.cCountry.Width = 102;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 91;
            // 
            // Zipcode
            // 
            this.Zipcode.Text = "Zip Code";
            this.Zipcode.Width = 63;
            // 
            // cStreet
            // 
            this.cStreet.Text = "Street";
            this.cStreet.Width = 157;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(2, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Property";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(2, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete property";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(2, 380);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(160, 46);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Change property";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Objects: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "Open ...";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveAs.Text = "Save as ...";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(244, 295);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.Text = "show info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(155, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 34);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search object";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = " To search for an object, \r\nadd City and Type below";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "City :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Type:";
            // 
            // tbCitySearch
            // 
            this.tbCitySearch.Location = new System.Drawing.Point(49, 60);
            this.tbCitySearch.Name = "tbCitySearch";
            this.tbCitySearch.Size = new System.Drawing.Size(100, 20);
            this.tbCitySearch.TabIndex = 18;
            // 
            // tbTypeSearch
            // 
            this.tbTypeSearch.Location = new System.Drawing.Point(49, 90);
            this.tbTypeSearch.Name = "tbTypeSearch";
            this.tbTypeSearch.Size = new System.Drawing.Size(100, 20);
            this.tbTypeSearch.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCitySearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbTypeSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(648, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 175);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvProperties);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cdCountry;
        private System.Windows.Forms.ComboBox cdLegalForm;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLegalForm;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.RadioButton rdCommercial;
        private System.Windows.Forms.RadioButton rbResidental;
        private System.Windows.Forms.ListView lvProperties;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cType;
        private System.Windows.Forms.ColumnHeader cLegalform;
        private System.Windows.Forms.ColumnHeader cCountry;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Zipcode;
        private System.Windows.Forms.ColumnHeader cStreet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ColumnHeader cResCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCitySearch;
        private System.Windows.Forms.TextBox tbTypeSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

