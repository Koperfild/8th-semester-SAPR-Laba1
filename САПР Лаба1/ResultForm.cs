﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPR_Laba1
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            //this.algo = algo;
            FillText();
            WriteCriterionValue();
        }
        public void FillText()
        {
            
            for (int i=0;i<AlgorithmScheme.pages.Count;i++)
            {
                richTextBox1.Text += "Страница " + i.ToString() + "\n";
                for (int j=0;j< AlgorithmScheme.pages[i].graphSymbols.Count;j++)
                {
                    richTextBox1.Text += "Из узла " + AlgorithmScheme.pages[i].graphSymbols[j].ID.ToString() + "\n        выходят   ";
                    for (int k=0; k < AlgorithmScheme.pages[i].graphSymbols[j].outgoingNodes.Count;k++)
                    {
                        richTextBox1.Text += AlgorithmScheme.pages[i].graphSymbols[j].outgoingNodes[k].ID.ToString() + "  ";
                    }
                    richTextBox1.Text += "\n        входят   ";
                    for (int k=0;k< AlgorithmScheme.pages[i].graphSymbols[j].incomingNodes.Count;k++)
                    {
                        richTextBox1.Text += AlgorithmScheme.pages[i].graphSymbols[j].incomingNodes[k].ID.ToString() + " ";
                    }
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += "Kcv = " + AlgorithmScheme.pages[i].graphSymbols[j].Kcv;
                    richTextBox1.Text += "\n";
                }
            }
        }
        public void WriteCriterionValue()
        {
            richTextBox1.Text += "\nКритерий результата = " + AlgorithmScheme.Criterion().ToString();
        }
    }
}
