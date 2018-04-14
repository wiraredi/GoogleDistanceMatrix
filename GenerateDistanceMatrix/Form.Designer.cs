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
            this.DataGridNodes = new System.Windows.Forms.DataGridView();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.outputDistanceTxt = new System.Windows.Forms.RichTextBox();
            this.inputDataTxt = new System.Windows.Forms.TextBox();
            this.inputBtn = new System.Windows.Forms.Button();
            this.totalNodeTxt = new System.Windows.Forms.TextBox();
            this.GrabDataBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grabProgress = new System.Windows.Forms.ProgressBar();
            this.TabPages.SuspendLayout();
            this.Page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodes)).BeginInit();
            this.Page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPages
            // 
            this.TabPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPages.Controls.Add(this.Page1);
            this.TabPages.Controls.Add(this.Page2);
            this.TabPages.Location = new System.Drawing.Point(7, 91);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedIndex = 0;
            this.TabPages.Size = new System.Drawing.Size(768, 450);
            this.TabPages.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.grabProgress);
            this.Page1.Controls.Add(this.DataGridNodes);
            this.Page1.Location = new System.Drawing.Point(4, 29);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(760, 417);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Nodes";
            this.Page1.UseVisualStyleBackColor = true;
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
            this.DataGridNodes.Size = new System.Drawing.Size(754, 411);
            this.DataGridNodes.TabIndex = 0;
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.outputDistanceTxt);
            this.Page2.Location = new System.Drawing.Point(4, 29);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(760, 417);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Matrix";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // outputDistanceTxt
            // 
            this.outputDistanceTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputDistanceTxt.Location = new System.Drawing.Point(3, 3);
            this.outputDistanceTxt.Name = "outputDistanceTxt";
            this.outputDistanceTxt.Size = new System.Drawing.Size(754, 411);
            this.outputDistanceTxt.TabIndex = 0;
            this.outputDistanceTxt.Text = "";
            // 
            // inputDataTxt
            // 
            this.inputDataTxt.Location = new System.Drawing.Point(8, 27);
            this.inputDataTxt.Name = "inputDataTxt";
            this.inputDataTxt.Size = new System.Drawing.Size(256, 26);
            this.inputDataTxt.TabIndex = 1;
            this.inputDataTxt.Text = "data.csv";
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(556, 27);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(102, 34);
            this.inputBtn.TabIndex = 2;
            this.inputBtn.Text = "input";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // totalNodeTxt
            // 
            this.totalNodeTxt.Location = new System.Drawing.Point(8, 59);
            this.totalNodeTxt.Name = "totalNodeTxt";
            this.totalNodeTxt.Size = new System.Drawing.Size(256, 26);
            this.totalNodeTxt.TabIndex = 3;
            // 
            // GrabDataBtn
            // 
            this.GrabDataBtn.Location = new System.Drawing.Point(664, 27);
            this.GrabDataBtn.Name = "GrabDataBtn";
            this.GrabDataBtn.Size = new System.Drawing.Size(102, 34);
            this.GrabDataBtn.TabIndex = 4;
            this.GrabDataBtn.Text = "Grab Data";
            this.GrabDataBtn.UseVisualStyleBackColor = true;
            this.GrabDataBtn.Click += new System.EventHandler(this.GrabDataBtn_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(664, 67);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(102, 34);
            this.GenerateBtn.TabIndex = 5;
            this.GenerateBtn.Text = "Generate Matrix";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
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
            // grabProgress
            // 
            this.grabProgress.Location = new System.Drawing.Point(216, 185);
            this.grabProgress.Name = "grabProgress";
            this.grabProgress.Size = new System.Drawing.Size(323, 31);
            this.grabProgress.TabIndex = 1;
            this.grabProgress.Visible = false;
            // 
            // GenerateDistanceMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.GrabDataBtn);
            this.Controls.Add(this.totalNodeTxt);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.inputDataTxt);
            this.Controls.Add(this.TabPages);
            this.Name = "GenerateDistanceMatrix";
            this.Text = "Generate Distance Matrix";
            this.TabPages.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodes)).EndInit();
            this.Page2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

