﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zuby.ADGV;

namespace ADGV_MemoryLeakageTest
{
    public partial class Form1 : Form
    {
        Random r;
        DataTable dt_Test;
        private int column_count;
        private int row_count;
       
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private async void btn_StartTest_Click(object sender, EventArgs e)
        {
            column_count = Convert.ToInt32(nud_Columns.Value);
            row_count = Convert.ToInt32(nud_DataRows.Value);
            var maxCount = Convert.ToInt32(nud_MaxTestCount.Value);
            btn_StartTest.Enabled = false;
            btn_StartTest2.Enabled = false;
            progressBar_TestCount.Value = 0;
            progressBar_TestCount.Step = 1;
            progressBar_TestCount.Maximum = maxCount;
            var test_task = Task.Run(() => TestLoop(maxCount, adgv_test, true));
            await Task.WhenAll(test_task);
            btn_StartTest.Enabled = true;
            btn_StartTest2.Enabled = true;

        }

        /// <summary>
        /// This flow is to test don't set DatSource = null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_StartTest2_Click(object sender, EventArgs e)
        {            
            column_count = Convert.ToInt32(nud_Columns.Value);
            row_count = Convert.ToInt32(nud_DataRows.Value);
            var maxCount = Convert.ToInt32(nud_MaxTestCount.Value);
            btn_StartTest.Enabled = false;
            btn_StartTest2.Enabled = false;
            progressBar_TestCount.Value = 0;
            progressBar_TestCount.Step = 1;
            progressBar_TestCount.Maximum = maxCount;
            var test_task = Task.Run(() => TestLoop(maxCount, adgv_test2, false));
            await Task.WhenAll(test_task);
            btn_StartTest.Enabled = true;
            btn_StartTest2.Enabled = true;
        }
        /// <summary>
        /// Create dummy DataTable for memory test
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="columnSize"></param>
        /// <param name="rowSize"></param>
        private void construct_test_dt(ref DataTable dt, int columnSize, int rowSize)
        {
            dt = new DataTable();
            if (columnSize < 1) columnSize = 1;
            if (rowSize < 1) rowSize = 1;
            for (int j = 0; j <= columnSize; j++)
            {
                dt.Columns.Add($@"col_{j}", typeof(string));
            }
            for (int i = 0; i <= rowSize; i++)
            {
                DataRow dr = dt.NewRow();
                foreach (DataColumn dc in dt.Columns)
                {
                    dr[dc.ColumnName] = r.Next(0, 65535);
                }
                dt.Rows.Add(dr);
            }
        }
        private void TestLoop(int maxCount, DataGridView dgv, bool assignNullToDataSource = false)
        {
            for (int i = 1; i <= maxCount; i++)
            {
                Invoke(new MethodInvoker(() =>
                {
                    try
                    {
                        var memory = GC.GetTotalMemory(true);
                        Console.Write($@"TestLoop {i}=>");

                        LB_Info.Text = $@"Testing {i}/{maxCount}/ MemoryUsage : {Math.Round(memory / (1024.0 * 1024.0), 2)} MB";
                        LB_Info.Refresh();
                        if (assignNullToDataSource)
                        {
                            dgv.DataSource = null;
                        }
                        construct_test_dt(ref dt_Test, column_count, row_count);                        

                        BindingSource bs = new BindingSource() { DataSource = dt_Test };
                        dgv.ColumnHeadersVisible = false;//For shorten binding time
                        dgv.DataSource = bs;
                        dgv.Refresh();
                        dgv.ColumnHeadersVisible = true;

                        memory = GC.GetTotalMemory(true);
                        Console.WriteLine($@"MemoryUsage : {Math.Round(memory / (1024.0 * 1024.0), 2)} MB");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }));

                Invoke(new MethodInvoker(() =>
                {
                    progressBar_TestCount.PerformStep();
                }));

            }
            Invoke(new MethodInvoker(() =>
            {
                LB_Info.Text = $@"Test Complete";
            }));

        }       
      
    }
}
