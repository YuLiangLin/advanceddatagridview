﻿namespace ADGV_MemoryLeakageTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.adgv_test = new Zuby.ADGV.AdvancedDataGridView();
            this.btn_StartTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_Columns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_DataRows = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_MaxTestCount = new System.Windows.Forms.NumericUpDown();
            this.progressBar_TestCount = new System.Windows.Forms.ProgressBar();
            this.LB_Info = new System.Windows.Forms.Label();
            this.btn_StartTest2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.adgv_test2 = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.adgv_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DataRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxTestCount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgv_test2)).BeginInit();
            this.SuspendLayout();
            // 
            // adgv_test
            // 
            this.adgv_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgv_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adgv_test.FilterAndSortEnabled = true;
            this.adgv_test.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv_test.Location = new System.Drawing.Point(3, 3);
            this.adgv_test.Name = "adgv_test";
            this.adgv_test.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgv_test.Size = new System.Drawing.Size(438, 281);
            this.adgv_test.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv_test.TabIndex = 0;
            // 
            // btn_StartTest
            // 
            this.btn_StartTest.Location = new System.Drawing.Point(12, 12);
            this.btn_StartTest.Name = "btn_StartTest";
            this.btn_StartTest.Size = new System.Drawing.Size(220, 64);
            this.btn_StartTest.TabIndex = 1;
            this.btn_StartTest.Text = "Test 1\r\n(Set DataSource = null)";
            this.btn_StartTest.UseVisualStyleBackColor = true;
            this.btn_StartTest.Click += new System.EventHandler(this.btn_StartTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(458, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data Columns :";
            // 
            // nud_Columns
            // 
            this.nud_Columns.Location = new System.Drawing.Point(577, 14);
            this.nud_Columns.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Columns.Name = "nud_Columns";
            this.nud_Columns.Size = new System.Drawing.Size(87, 29);
            this.nud_Columns.TabIndex = 9;
            this.nud_Columns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Columns.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(668, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data Rows :";
            // 
            // nud_DataRows
            // 
            this.nud_DataRows.Location = new System.Drawing.Point(763, 14);
            this.nud_DataRows.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_DataRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_DataRows.Name = "nud_DataRows";
            this.nud_DataRows.Size = new System.Drawing.Size(87, 29);
            this.nud_DataRows.TabIndex = 7;
            this.nud_DataRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_DataRows.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(489, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Test Loop :";
            // 
            // nud_MaxTestCount
            // 
            this.nud_MaxTestCount.Location = new System.Drawing.Point(577, 49);
            this.nud_MaxTestCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_MaxTestCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_MaxTestCount.Name = "nud_MaxTestCount";
            this.nud_MaxTestCount.Size = new System.Drawing.Size(87, 29);
            this.nud_MaxTestCount.TabIndex = 11;
            this.nud_MaxTestCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_MaxTestCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // progressBar_TestCount
            // 
            this.progressBar_TestCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_TestCount.Location = new System.Drawing.Point(3, 424);
            this.progressBar_TestCount.Name = "progressBar_TestCount";
            this.progressBar_TestCount.Size = new System.Drawing.Size(888, 14);
            this.progressBar_TestCount.TabIndex = 13;
            // 
            // LB_Info
            // 
            this.LB_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.LB_Info.Location = new System.Drawing.Point(3, 82);
            this.LB_Info.Name = "LB_Info";
            this.LB_Info.Size = new System.Drawing.Size(888, 46);
            this.LB_Info.TabIndex = 14;
            this.LB_Info.Text = "Info";
            this.LB_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_StartTest2
            // 
            this.btn_StartTest2.Location = new System.Drawing.Point(233, 12);
            this.btn_StartTest2.Name = "btn_StartTest2";
            this.btn_StartTest2.Size = new System.Drawing.Size(220, 64);
            this.btn_StartTest2.TabIndex = 15;
            this.btn_StartTest2.Text = "Test 2\r\n(Don\'t set DataSource = null)\r\n";
            this.btn_StartTest2.UseVisualStyleBackColor = true;
            this.btn_StartTest2.Click += new System.EventHandler(this.btn_StartTest2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.adgv_test2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.adgv_test, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 287);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // adgv_test2
            // 
            this.adgv_test2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgv_test2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adgv_test2.FilterAndSortEnabled = true;
            this.adgv_test2.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv_test2.Location = new System.Drawing.Point(447, 3);
            this.adgv_test2.Name = "adgv_test2";
            this.adgv_test2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgv_test2.Size = new System.Drawing.Size(438, 281);
            this.adgv_test2.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv_test2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_StartTest2);
            this.Controls.Add(this.LB_Info);
            this.Controls.Add(this.progressBar_TestCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_MaxTestCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_Columns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_DataRows);
            this.Controls.Add(this.btn_StartTest);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.adgv_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DataRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxTestCount)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adgv_test2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView adgv_test;
        private System.Windows.Forms.Button btn_StartTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_Columns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_DataRows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_MaxTestCount;
        private System.Windows.Forms.ProgressBar progressBar_TestCount;
        private System.Windows.Forms.Label LB_Info;
        private System.Windows.Forms.Button btn_StartTest2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Zuby.ADGV.AdvancedDataGridView adgv_test2;
    }
}

