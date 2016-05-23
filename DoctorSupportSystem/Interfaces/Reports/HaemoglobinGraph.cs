﻿using DoctorSupportSystem.Models.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorSupportSystem.Interfaces.Reports
{
    public partial class HaemoglobinGraph : Form
    {

        private List<HaemoglobinTest> testList = null;
        public HaemoglobinGraph(List<HaemoglobinTest> testList)
        {
            this.testList = testList;
            InitializeComponent();
            setGraphs();
        }

        private void setGraphs()
        {
            foreach (HaemoglobinTest test in testList)
            {
               
                this.urineGraphs.Series["Haemoglobin "].Points.AddXY(test.Date.getDate(), test.Results);              

            }
        }
    }
}