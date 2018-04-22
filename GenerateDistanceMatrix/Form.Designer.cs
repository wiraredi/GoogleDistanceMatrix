namespace GenerateDistanceMatrix
{
    partial class GenerateDistanceMatrix
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
            this.TabPages = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.grabProgress = new System.Windows.Forms.ProgressBar();
            this.DataGridNodes = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.outputDistanceTxt = new System.Windows.Forms.RichTextBox();
            this.inputDataTxt = new System.Windows.Forms.TextBox();
            this.inputBtn = new System.Windows.Forms.Button();
            this.totalNodeTxt = new System.Windows.Forms.TextBox();
            this.GrabDataBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DataGridNodesSubset = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.outputDistanceSubsetTxt = new System.Windows.Forms.RichTextBox();
            this.inputDataSubsetTxt = new System.Windows.Forms.TextBox();
            this.GenerateSubsetBtn = new System.Windows.Forms.Button();
            this.totalNodeSubsetTxt = new System.Windows.Forms.TextBox();
            this.grabSubsetProgress = new System.Windows.Forms.ProgressBar();
            this.inputSubsetBtn = new System.Windows.Forms.Button();
            this.TabPages.SuspendLayout();
            this.Page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodes)).BeginInit();
            this.Page2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodesSubset)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPages
            // 
            this.TabPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPages.Controls.Add(this.Page1);
            this.TabPages.Controls.Add(this.Page2);
            this.TabPages.Location = new System.Drawing.Point(0, 74);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedIndex = 0;
            this.TabPages.Size = new System.Drawing.Size(764, 434);
            this.TabPages.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.grabProgress);
            this.Page1.Controls.Add(this.DataGridNodes);
            this.Page1.Location = new System.Drawing.Point(4, 29);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(756, 401);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Nodes";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // grabProgress
            // 
            this.grabProgress.Location = new System.Drawing.Point(216, 185);
            this.grabProgress.Name = "grabProgress";
            this.grabProgress.Size = new System.Drawing.Size(323, 31);
            this.grabProgress.TabIndex = 1;
            this.grabProgress.Visible = false;
            // 
            // DataGridNodes
            // 
            this.DataGridNodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridNodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Lat,
            this.Lng});
            this.DataGridNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridNodes.Location = new System.Drawing.Point(3, 3);
            this.DataGridNodes.Name = "DataGridNodes";
            this.DataGridNodes.RowTemplate.Height = 28;
            this.DataGridNodes.Size = new System.Drawing.Size(750, 395);
            this.DataGridNodes.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // Lat
            // 
            this.Lat.HeaderText = "Lat";
            this.Lat.Name = "Lat";
            // 
            // Lng
            // 
            this.Lng.HeaderText = "Lng";
            this.Lng.Name = "Lng";
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.outputDistanceTxt);
            this.Page2.Location = new System.Drawing.Point(4, 29);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(756, 401);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Matrix";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // outputDistanceTxt
            // 
            this.outputDistanceTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputDistanceTxt.Location = new System.Drawing.Point(3, 3);
            this.outputDistanceTxt.Name = "outputDistanceTxt";
            this.outputDistanceTxt.Size = new System.Drawing.Size(750, 395);
            this.outputDistanceTxt.TabIndex = 0;
            this.outputDistanceTxt.Text = "";
            // 
            // inputDataTxt
            // 
            this.inputDataTxt.Location = new System.Drawing.Point(8, 6);
            this.inputDataTxt.Name = "inputDataTxt";
            this.inputDataTxt.Size = new System.Drawing.Size(256, 26);
            this.inputDataTxt.TabIndex = 1;
            this.inputDataTxt.Text = "data.csv";
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(484, 6);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(102, 34);
            this.inputBtn.TabIndex = 2;
            this.inputBtn.Text = "input";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // totalNodeTxt
            // 
            this.totalNodeTxt.Location = new System.Drawing.Point(8, 38);
            this.totalNodeTxt.Name = "totalNodeTxt";
            this.totalNodeTxt.Size = new System.Drawing.Size(256, 26);
            this.totalNodeTxt.TabIndex = 3;
            // 
            // GrabDataBtn
            // 
            this.GrabDataBtn.Location = new System.Drawing.Point(592, 6);
            this.GrabDataBtn.Name = "GrabDataBtn";
            this.GrabDataBtn.Size = new System.Drawing.Size(102, 34);
            this.GrabDataBtn.TabIndex = 4;
            this.GrabDataBtn.Text = "Grab Data";
            this.GrabDataBtn.UseVisualStyleBackColor = true;
            this.GrabDataBtn.Click += new System.EventHandler(this.GrabDataBtn_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(592, 46);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(102, 34);
            this.GenerateBtn.TabIndex = 5;
            this.GenerateBtn.Text = "Generate Matrix";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 544);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputDataTxt);
            this.tabPage1.Controls.Add(this.GenerateBtn);
            this.tabPage1.Controls.Add(this.TabPages);
            this.tabPage1.Controls.Add(this.GrabDataBtn);
            this.tabPage1.Controls.Add(this.inputBtn);
            this.tabPage1.Controls.Add(this.totalNodeTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Initial Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.inputSubsetBtn);
            this.tabPage2.Controls.Add(this.inputDataSubsetTxt);
            this.tabPage2.Controls.Add(this.GenerateSubsetBtn);
            this.tabPage2.Controls.Add(this.totalNodeSubsetTxt);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subset";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 67);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(778, 441);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grabSubsetProgress);
            this.tabPage3.Controls.Add(this.DataGridNodesSubset);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(770, 408);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Nodes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DataGridNodesSubset
            // 
            this.DataGridNodesSubset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridNodesSubset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridNodesSubset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DataGridNodesSubset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridNodesSubset.Location = new System.Drawing.Point(3, 3);
            this.DataGridNodesSubset.Name = "DataGridNodesSubset";
            this.DataGridNodesSubset.RowTemplate.Height = 28;
            this.DataGridNodesSubset.Size = new System.Drawing.Size(764, 402);
            this.DataGridNodesSubset.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Lat";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Lng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.outputDistanceSubsetTxt);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(770, 408);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Matrix";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // outputDistanceSubsetTxt
            // 
            this.outputDistanceSubsetTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputDistanceSubsetTxt.Location = new System.Drawing.Point(3, 3);
            this.outputDistanceSubsetTxt.Name = "outputDistanceSubsetTxt";
            this.outputDistanceSubsetTxt.Size = new System.Drawing.Size(764, 402);
            this.outputDistanceSubsetTxt.TabIndex = 0;
            this.outputDistanceSubsetTxt.Text = "";
            // 
            // inputDataSubsetTxt
            // 
            this.inputDataSubsetTxt.Location = new System.Drawing.Point(7, 6);
            this.inputDataSubsetTxt.Name = "inputDataSubsetTxt";
            this.inputDataSubsetTxt.Size = new System.Drawing.Size(256, 26);
            this.inputDataSubsetTxt.TabIndex = 6;
            this.inputDataSubsetTxt.Text = "S8.txt";
            // 
            // GenerateSubsetBtn
            // 
            this.GenerateSubsetBtn.Location = new System.Drawing.Point(660, 27);
            this.GenerateSubsetBtn.Name = "GenerateSubsetBtn";
            this.GenerateSubsetBtn.Size = new System.Drawing.Size(102, 34);
            this.GenerateSubsetBtn.TabIndex = 8;
            this.GenerateSubsetBtn.Text = "Generate Matrix";
            this.GenerateSubsetBtn.UseVisualStyleBackColor = true;
            this.GenerateSubsetBtn.Click += new System.EventHandler(this.GenerateSubsetBtn_Click);
            // 
            // totalNodeSubsetTxt
            // 
            this.totalNodeSubsetTxt.Location = new System.Drawing.Point(7, 38);
            this.totalNodeSubsetTxt.Name = "totalNodeSubsetTxt";
            this.totalNodeSubsetTxt.Size = new System.Drawing.Size(256, 26);
            this.totalNodeSubsetTxt.TabIndex = 7;
            // 
            // grabSubsetProgress
            // 
            this.grabSubsetProgress.Location = new System.Drawing.Point(206, 198);
            this.grabSubsetProgress.Name = "grabSubsetProgress";
            this.grabSubsetProgress.Size = new System.Drawing.Size(323, 31);
            this.grabSubsetProgress.TabIndex = 2;
            this.grabSubsetProgress.Visible = false;
            // 
            // inputSubsetBtn
            // 
            this.inputSubsetBtn.Location = new System.Drawing.Point(552, 27);
            this.inputSubsetBtn.Name = "inputSubsetBtn";
            this.inputSubsetBtn.Size = new System.Drawing.Size(102, 34);
            this.inputSubsetBtn.TabIndex = 9;
            this.inputSubsetBtn.Text = "input";
            this.inputSubsetBtn.UseVisualStyleBackColor = true;
            this.inputSubsetBtn.Click += new System.EventHandler(this.inputSubsetBtn_Click);
            // 
            // GenerateDistanceMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.tabControl1);
            this.Name = "GenerateDistanceMatrix";
            this.Text = "Generate Distance Matrix";
            this.TabPages.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodes)).EndInit();
            this.Page2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodesSubset)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPages;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.TextBox inputDataTxt;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.DataGridView DataGridNodes;
        private System.Windows.Forms.TextBox totalNodeTxt;
        private System.Windows.Forms.Button GrabDataBtn;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.RichTextBox outputDistanceTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lng;
        private System.Windows.Forms.ProgressBar grabProgress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox inputDataSubsetTxt;
        private System.Windows.Forms.Button GenerateSubsetBtn;
        private System.Windows.Forms.TextBox totalNodeSubsetTxt;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DataGridNodesSubset;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox outputDistanceSubsetTxt;
        private System.Windows.Forms.ProgressBar grabSubsetProgress;
        private System.Windows.Forms.Button inputSubsetBtn;
    }
}

