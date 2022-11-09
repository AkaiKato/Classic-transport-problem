using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace КТЗ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int m;
        int n;
        int[] ai, bj, uj, vi;
        int[,] transportData;
        int minCordM, minCordN, maxDeltM, maxDeltN;
        int numberOfBasedDots = 0;
        List<int> coordsM = new List<int>();
        List<int> coordsN = new List<int>();

        private void readyDimensionButton_Click(object sender, EventArgs e)
        {
            if (getDimension())
            {
                dimensionVisibleFalse();
                datagridVisibleTrue();

                createDataGrid(beginDataDataGrid, 48);
                createDataGrid(workingSpaceDataGrid, 57);
                createDataGridUjVi(planAndPotencialDataGrid, 48);
            }
        }

        private void readyBeginDataButton_Click(object sender, EventArgs e)
        {
            if (getAiAndBj() && getTransportData())
            {
                fillTheBeginDataDataGrid();
                beginDataVisibleFalse();
                nopButton.Visible = true;
            }
        }

        private void nopButton_Click(object sender, EventArgs e)
        {
            minVolumeTransportingVisibleFalse();
            minTransportVisionTrue();
            nopButton.Enabled = false;
            volumeTransportingEnableFalse();
        }

        private void minTransportButton_Click(object sender, EventArgs e)
        {
            int number;
            if(int.TryParse(minTransportTextBox.Text, out number) && minTransportFind() == number)
            {
                volumeTransportingButton.Enabled = true;
                volumeTransportingButton.Visible = true;
                workingSpaceDataGrid.Rows[minCordM].Cells[minCordN].Style.BackColor = Color.Red;
                minTransportVisionFalse();
            }
            else
                MessageBox.Show("Проверьте правильность введеных данных!", "Ошибка!");
        }

        private void volumeTransportingButton_Click(object sender, EventArgs e)
        {
            minTransportVisionFalse();
            minVolumeTransportingVisibleTrue();
            volumeTransportingEnableFalse();
        }

        private void minVolumeTransportingButton_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(minVolumeTrasnportingTextBox.Text, out number))
            {
                if (bj[minCordN - 2] > ai[minCordM - 2] && ai[minCordM - 2] == number)
                {
                    bj[minCordN - 2] = bj[minCordN - 2] - ai[minCordM - 2];
                    planAndPotencialDataGrid.Rows[minCordM].Cells[minCordN].Value = ai[minCordM - 2];
                    ai[minCordM - 2] = -1;
                    clearRow();
                    if (bj[minCordN - 2] != -1)
                        workingSpaceDataGrid.Rows[m + 2].Cells[minCordN].Value = bj[minCordN - 2];
                }
                else if (bj[minCordN - 2] <= ai[minCordM - 2] && bj[minCordN - 2] == number)
                {
                    ai[minCordM - 2] = ai[minCordM - 2] - bj[minCordN - 2];
                    planAndPotencialDataGrid.Rows[minCordM].Cells[minCordN].Value = bj[minCordN - 2];
                    bj[minCordN - 2] = -1;
                    clearColumn();
                    if (ai[minCordM - 2] != -1)
                        workingSpaceDataGrid.Rows[minCordM].Cells[n + 2].Value = ai[minCordM - 2];
                }
                else
                {
                    MessageBox.Show("Проверьте данные!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность введеных данных!", "Ошибка!");
                return;
            }

            workingSpaceDataGrid.Rows[minCordM].Cells[minCordN].Style.BackColor = Color.White;
            numberOfBasedDots++;
            
            if(numberOfBasedDots != (n + m) - 1)
            {
                nopButton.Enabled = true;
            }
            else
            {
                for (int i = 2; i < m + 2; i++)
                    for (int j = 2; j < n + 2; j++)
                        workingSpaceDataGrid.Rows[i].Cells[j].Value = transportData[i - 2, j - 2];
                for (int i = 2; i < n + 2; i++)
                    workingSpaceDataGrid.Rows[m + 2].Cells[i].Value = "";
                for (int i = 2; i < m + 2; i++)
                    workingSpaceDataGrid.Rows[i].Cells[n + 2].Value = "";

                potentialButton.Enabled = true;
                potentialButton.Visible = true;
            }

            minVolumeTransportingVisibleFalse();
            
        }

        private void potentialButton_Click(object sender, EventArgs e)
        {
            potentialReadyVisibleTrue();
            potentialButton.Enabled = false;
            workingSpaceDataGrid.Rows[0].Cells[1].Value = "Vi";
            workingSpaceDataGrid.Rows[1].Cells[0].Value = "Uj";
        }

        private void potentailReadyButton_Click(object sender, EventArgs e)
        {
            int[] ujStd, viStd;
            uj = new int[m];
            vi = new int[n];
            ujStd = new int[m];
            viStd = new int[n];
            potentialFind();
            for (int i = 2; i < n + 2; i++)
            {
                if (!(workingSpaceDataGrid.Rows[0].Cells[i].Value != null) || !int.TryParse(workingSpaceDataGrid.Rows[0].Cells[i].Value.ToString(), out viStd[i - 2]))
                {
                    MessageBox.Show("Провверьте правильность вводимых данных!", "Ошибка!");
                    return;
                }
            }
            for (int i = 2; i < m + 2; i++)
            {
                if(!(workingSpaceDataGrid.Rows[i].Cells[0].Value != null) || !int.TryParse(workingSpaceDataGrid.Rows[i].Cells[0].Value.ToString(), out ujStd[i - 2]))
                {
                    MessageBox.Show("Провверьте правильность вводимых данных!", "Ошибка!");
                    return;
                }
            }
            Enumerable.SequenceEqual(uj, ujStd);
            if(!Enumerable.SequenceEqual(uj, ujStd) || !Enumerable.SequenceEqual(vi, viStd))
            {
                MessageBox.Show("Провверьте правильность вводимых данных!", "Ошибка!");
                return;
            }
            for (int i = 2; i < n + 2; i++)
                planAndPotencialDataGrid.Rows[0].Cells[i].Value = vi[i - 2];
            for (int i = 2; i < m + 2 ; i++)
                planAndPotencialDataGrid.Rows[i].Cells[0].Value = uj[i - 2];
      
            potentialReadyVisibleFalse();
            checkOptimalButton.Visible = true;
            workingSpaceLabel.Text = "Значение дельт";
            findDelt();   
        }

        private void checkOptimalButton_Click(object sender, EventArgs e)
        {
            planOptimalVisibleTrue();
            checkOptimalButton.Enabled = false;
        }

        private void planOptimalYesButton_Click(object sender, EventArgs e)
        {
            if (checkDelt())
            {
                MessageBox.Show("Данный план оптимален!", "Всё!");
                planOptimalVisibleFalse();
            }
            else
                MessageBox.Show("Проверьте еще раз!", "Ошибка!");
        }

        private void planOptimalNoButton_Click(object sender, EventArgs e)
        {
            if (!checkDelt())
            {
                defineFirstCageOfCycleButton.Visible = true;
                planOptimalVisibleFalse();
            }
            else
                MessageBox.Show("Проверьте еще раз!", "Ошибка!");
        }

        private void defineFirstCageOfCycleButton_Click(object sender, EventArgs e)
        {
            defineFirstCageOfCycleButton.Enabled = false;
            cageFindedVisibleTrue();
        }

        private void cageFindedButton_Click(object sender, EventArgs e)
        {
            if(int.Parse(workingSpaceDataGrid.CurrentCell.Value.ToString()) == findMaxDel())
            {
                cageFindedVisibleFalse();
                nextCageVisibleTrue();
            }
            else
                MessageBox.Show("Проверьте еще раз!", "Ошибка!");
        }

        private void nextCageButton_Click(object sender, EventArgs e)
        {
            var g = workingSpaceDataGrid.SelectedCells;
            int beginM = maxDeltM;
            int beginN = maxDeltN;
            int k = 0;
            coordsM.Clear();
            coordsN.Clear();
            findCycleRow(beginM, beginN);
            string str1 = "", str2 = "";

            for (int i = 0; i < coordsM.Count; i++)
                str1 += coordsM.ElementAt(i).ToString()+","+coordsN.ElementAt(i).ToString()+"/";
            for (int i = 0; i < g.Count; i++)
                str2 += g[i].RowIndex.ToString() + "," + g[i].ColumnIndex.ToString()+"/";

            string[] strArr1 = str1.Split('/');
            string[] strArr2 = str2.Split('/');

            for (int i = 0; i < strArr1.Length; i++)
            {
                for (int j = 0; j < strArr2.Length; j++)
                {
                    if (strArr1[i] == strArr2[j])
                        k++;
                }
            }

            if (k == strArr1.Length && strArr1.Length == strArr2.Length)
            {
                for (int i = 0; i < coordsM.Count; i++)
                {
                    if (i % 2 == 0)
                        workingSpaceDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Style.BackColor = Color.Green;
                    else
                        workingSpaceDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Style.BackColor = Color.Red;
                    nexCageVisibleFalse();
                    enterTettaValueVisibleTrue();
                }

            }
            else
                MessageBox.Show("Проверьте еще раз!", "Ошибка!");
        }

        private void enterTettaValueButton_Click(object sender, EventArgs e)
        {
            int minTetta = 999999;
            for (int i = 0; i < coordsM.Count; i++)
            {
                if (planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value != null)
                {
                    if (i % 2 != 0 && int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString()) < minTetta)
                        minTetta = int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString());
                }
            }

            int nb;
            if (int.TryParse(enterTettaValueTextBox.Text, out nb) && nb == minTetta)
            {
                goToTheBestPlan.Visible = true;

                for (int i = 0; i < coordsM.Count; i++)
                {
                    if (planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value != null && minTetta == int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString()) && i % 2 != 0)
                        planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value = null;
                    else
                    {
                        if (planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value == null)
                            planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value = minTetta;
                        else if (i % 2 == 0)
                            planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value = minTetta + int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString());
                        else
                            planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value = int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString()) - minTetta;
                    }
                }
                enterTettaValueVisibleFalse();
            }
            else
                MessageBox.Show("Проверьте еще раз!", "Ошибка!");
        }

        private void goToTheBestPlan_Click(object sender, EventArgs e)
        {
            goToTheBestPlan.Enabled = false;
            
            for (int i = 2; i < m + 2; i++)
            {
                for (int j = 2; j < n + 2; j++)
                {
                    workingSpaceDataGrid.Rows[i].Cells[j].Value = transportData[i - 2, j - 2];
                }
            }

            for (int i = 0; i < coordsM.Count; i++)
            {
                if (i % 2 == 0)
                    workingSpaceDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Style.BackColor = Color.White;
                else
                    workingSpaceDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Style.BackColor = Color.White;
            }

            while (true)
            {
                potentialFind();
                findDelt();
                if(checkDelt())
                    break;
                findMaxDel();
                int beginM = maxDeltM;
                int beginN = maxDeltN;
                coordsM.Clear();
                coordsN.Clear();
                findCycleRow(beginM, beginN);
                int minTetta = 999999;

                for (int i = 0; i < coordsM.Count; i++)
                {
                    if(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value != null)
                    {
                        if (i % 2 != 0 && int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString()) < minTetta)
                            minTetta = int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString());
                    }
                }

                for (int i = 0; i < coordsM.Count; i++)
                {
                    if (planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value != null && minTetta == int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString()) && i % 2 != 0)
                        planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value = null;
                    else
                    {
                        if (planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value == null)
                            planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value = minTetta;
                        else if (i % 2 == 0)
                            planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value = minTetta + int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString());
                        else
                            planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value = int.Parse(planAndPotencialDataGrid.Rows[coordsM.ElementAt(i)].Cells[coordsN.ElementAt(i)].Value.ToString()) - minTetta;
                    }
                }
            }
            
            endLabel.Visible = true;
            endSecondlabel.Visible = true;

        }

        private bool findCycleRow(int M, int N)
        {
            for (int i = N+1; i < n + 2; i++)
            {
                if (M == maxDeltM && i == maxDeltN)
                {
                    coordsM.Add(M);
                    coordsN.Add(i);
                    return true;
                }
                if (planAndPotencialDataGrid.Rows[M].Cells[i].Value != null)
                {
                    if (findCycleColumn(M, i))
                    {
                        coordsM.Add(M);
                        coordsN.Add(i);
                        return true;
                    }
                }
            }
            for (int i = N-1; i > 1; i--)
            {
                if (M == maxDeltM && i == maxDeltN)
                {
                    coordsM.Add(M);
                    coordsN.Add(i);
                    return true;
                }
                if (planAndPotencialDataGrid.Rows[M].Cells[i].Value != null)
                {
                    if (findCycleColumn(M, i))
                    {
                        coordsM.Add(M);
                        coordsN.Add(i);
                        return true;
                    }
                }
            }
            return false;
        }

        private bool findCycleColumn(int M, int N)
        {
            for (int i = M+1; i < m + 2; i++)
            {
                if (i == maxDeltM && N == maxDeltN)
                {
                    coordsM.Add(i);
                    coordsN.Add(N);
                    return true;
                }
                if (planAndPotencialDataGrid.Rows[i].Cells[N].Value != null)
                {
                    if(findCycleRow(i, N))
                    {
                        coordsM.Add(i);
                        coordsN.Add(N);
                        return true;
                    }
                }
            }
            for (int i = M-1; i > 1; i--)
            {
                if (i == maxDeltM && N == maxDeltN)
                {
                    coordsM.Add(i);
                    coordsN.Add(N);
                    return true;
                }
                if (planAndPotencialDataGrid.Rows[i].Cells[N].Value != null)
                {
                    if (findCycleRow(i, N))
                    {
                        coordsM.Add(i);
                        coordsN.Add(N);
                        return true;
                    }
                }
            }
            return false;
        }

        private int findMaxDel()
        {
            int max = 0;
            for (int i = 2; i < m + 2; i++)
            {
                for (int j = 2; j < n + 2; j++)
                {
                    if (int.Parse(workingSpaceDataGrid.Rows[i].Cells[j].Value.ToString()) > max)
                    {
                        max = int.Parse(workingSpaceDataGrid.Rows[i].Cells[j].Value.ToString());
                        maxDeltM = i;
                        maxDeltN = j;
                    }
                }
            }
            return max;
        }

        private bool checkDelt()
        {
            for (int i = 2; i < m + 2; i++)
            {
                for (int j = 2; j < n + 2; j++)
                {
                    if(int.Parse(workingSpaceDataGrid.Rows[i].Cells[j].Value.ToString()) > 0)
                        return false;
                }
            }
            return true;
        }

        //---------------------------------------------------------------------------
        private void findDelt()
        {
            for (int i = 2; i < m + 2; i++)
                for (int j = 2; j < n + 2; j++)
                    workingSpaceDataGrid.Rows[i].Cells[j].Value = vi[j - 2] - uj[i - 2] - int.Parse(beginDataDataGrid.Rows[i].Cells[j].Value.ToString());
        }

        private void potentialFind()
        {
            clearMass(uj, m);
            clearMass(vi, n);
            uj[0] = 0;
            potentialRowFind(0, uj[0]);
        }

        private void potentialRowFind(int number, int ujNumb) 
        {
            for (int i = 2; i < n + 2; i++)
            {
                if(planAndPotencialDataGrid.Rows[number + 2].Cells[i].Value != null && vi[i - 2] == -999999999)
                {
                    vi[i - 2] = ujNumb + transportData[number,i - 2];
                    potentialColumnFind(i - 2, vi[i - 2]);
                }
            }
        }

        private void potentialColumnFind(int number, int viNumb) 
        {
            for (int i = 2; i < m + 2; i++)
            {
                if (planAndPotencialDataGrid.Rows[i].Cells[number + 2].Value != null && uj[i - 2] == -999999999)
                {
                    uj[i - 2] = viNumb - transportData[i - 2, number];
                    potentialRowFind(i - 2, uj[i - 2]);
                }
            }
        }

        //-----------------------------------------------------------------------------
        private void clearMass(int[] mass, int number)
        {
            for (int i = 0; i < number; i++)
                mass[i] = -999999999;
        }

        private void clearRow()
        {
            for (int i = 2; i < n + 3; i++)
            {
                workingSpaceDataGrid.Rows[minCordM].Cells[i].Value = "";
            }
        }

        private void clearColumn()
        {
            for (int i = 2; i < m + 3; i++)
            {
                workingSpaceDataGrid.Rows[i].Cells[minCordN].Value = "";
            }
        }

        private int minTransportFind()
        {
            int min = 9999999;
            for (int i = 2; i < m + 2; i++)
            {
                for (int j = 2; j < n + 2; j++)
                {
                    var p = workingSpaceDataGrid.Rows[i].Cells[j].Value.ToString();
                    if (p != "")
                    {
                        if(min > int.Parse(p))
                        {
                            min = int.Parse(p);
                            minCordM = i;
                            minCordN = j;
                        }
                    }
                }
            }
            return min;
        }

        private bool getAiAndBj()
        {
            bj = new int[n];
            ai = new int[m];
            //bj
            for (int i = 2; i < n + 2; i++)
            {
                if (workingSpaceDataGrid.Rows[m + 2].Cells[i].Value == null || !int.TryParse(workingSpaceDataGrid.Rows[m + 2].Cells[i].Value.ToString(), out bj[i - 2]))
                {
                    MessageBox.Show("Проверьте правильность введеных данных!", "Ошибка!");
                    return false;
                }
            }
            //ai
            for (int i = 2; i < m + 2; i++)
            {
                if (workingSpaceDataGrid.Rows[i].Cells[n + 2].Value == null || !int.TryParse(workingSpaceDataGrid.Rows[i].Cells[n + 2].Value.ToString(), out ai[i - 2]))
                {
                    MessageBox.Show("Проверьте правильность введеных данных!", "Ошибка!");
                    return false;
                }
            }
            if(ai.Sum() == bj.Sum())
                return true;
            MessageBox.Show("Проверьте правильность введеных данных!", "Ошибка!");
            return false;
        }

        private bool getTransportData()
        {
            transportData = new int[m, n];
            for (int i = 2; i < m + 2; i++)
            {
                for (int j = 2; j < n + 2; j++)
                {
                    if (workingSpaceDataGrid.Rows[i].Cells[j].Value == null || !int.TryParse(workingSpaceDataGrid.Rows[i].Cells[j].Value.ToString(), out transportData[i - 2, j - 2]))
                    {
                        MessageBox.Show("Проверьте правильность введеных данных!", "Ошибка!");
                        return false;
                    }
                }
            }
            return true;
        }

        private void fillTheBeginDataDataGrid()
        {
            for (int i = 2; i < m + 2; i++)
            {
                for (int j = 2; j < n + 2; j++)
                {
                    beginDataDataGrid.Rows[i].Cells[j].Value = transportData[i - 2, j - 2];
                }
            }
            for (int i = 2; i < n + 2; i++)
                beginDataDataGrid.Rows[m + 2].Cells[i].Value = bj[i - 2];
            for (int i = 2; i < m + 2; i++)
                beginDataDataGrid.Rows[i].Cells[n + 2].Value = ai[i - 2];
        }

        private bool getDimension()
        {
            int.TryParse(getIDimensionTextBox.Text, out m);
            int.TryParse(getJDimensionTextBox.Text, out n);
            if(m > 0 && n > 0)
                return true;
            MessageBox.Show("Провверьте правильность вводимых данных!", "Ошибка!");
            return false;
        }

        private void createDataGrid(DataGridView dataGridView, int width)
        {
            for (int i = 0; i < n + 3; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = "colimn" + i.ToString();
                column.Width = width;
                dataGridView.Columns.Add(column);
            }
            dataGridView.ColumnHeadersVisible = false;
            for (int i = 0; i < m + 3; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int j = 0; j < n + 3; j++)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (i == 0)
                        cell.Value = "";
                    else if (i == 1)
                    {
                        if (j >= 2 && j < (n + 2))
                            cell.Value = j - 1;
                        else if (j == (n + 2))
                            cell.Value = "ai";
                        else
                            cell.Value = "";
                    }
                    else
                    {
                        if (j == 1 && i < (m + 2))
                            cell.Value = i - 1;
                        else if (j == 1 && i == (m + 2))
                            cell.Value = "bj";
                    }
                    row.Cells.Add(cell);
                }
                dataGridView.Rows.Add(row);
            }
            dataGridView.RowHeadersVisible = false;
        }

        private void createDataGridUjVi(DataGridView dataGridView, int width)
        {
            for (int i = 0; i < n + 2; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = "colimn" + i.ToString();
                column.Width = width;
                dataGridView.Columns.Add(column);
            }
            dataGridView.ColumnHeadersVisible = false;
            for (int i = 0; i < m + 2; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int j = 0; j < n + 2; j++)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (i == 0)
                    {
                        if (j == 1)
                            cell.Value = "Vi";
                        else
                            cell.Value = "";
                    }
                    else if (i == 1)
                    {
                        if (j >= 2 && j < (n + 2))
                            cell.Value = j - 1;
                        else if (j == 0)
                            cell.Value = "Uj";
                        else
                            cell.Value = "";
                    }
                    else
                    {
                        if (j == 1 && i < (m + 2))
                            cell.Value = i - 1;
                    }
                    row.Cells.Add(cell);
                }
                dataGridView.Rows.Add(row);
            }
            dataGridView.RowHeadersVisible = false;
        }

        private void dimensionVisibleFalse()
        {
            getIDimensionTextBox.Visible = false;
            getJDimensionTextBox.Visible = false;
            dimensionLabel.Visible = false;
            readyDimensionButton.Visible = false;
        }

        private void datagridVisibleTrue()
        {
            workingSpaceLabel.Visible = true;
            workingSpaceDataGrid.Visible = true;
            beginDataLabel.Visible = true;
            beginDataDataGrid.Visible = true;
            planAndPotencialLabel.Visible = true;
            planAndPotencialDataGrid.Visible = true;
            enterBeginDataLabel.Visible = true;
            readyBeginDataButton.Visible = true;
        }

        private void beginDataVisibleFalse()
        {
            enterBeginDataLabel.Visible = false;
            readyBeginDataButton.Visible = false;
        }

        private void minTransportVisionTrue()
        {
            minTransportButton.Visible = true;
            minTransportLabel.Visible = true;
            minTransportTextBox.Visible = true;
        }

        private void minTransportVisionFalse()
        {
            minTransportButton.Visible = false;
            minTransportLabel.Visible = false;
            minTransportTextBox.Visible = false;
        }

        private void volumeTransportingEnableFalse()
        {
            volumeTransportingButton.Enabled = false;
        }

        private void minVolumeTransportingVisibleTrue()
        {
            minVolumeTransportingButton.Visible = true;
            minVolumeTransportingLabel.Visible = true;
            minVolumeTrasnportingTextBox.Visible = true;
        }

        private void minVolumeTransportingVisibleFalse()
        {
            minVolumeTransportingButton.Visible = false;
            minVolumeTransportingLabel.Visible = false;
            minVolumeTrasnportingTextBox.Visible = false;
        }

        private void potentialReadyVisibleTrue()
        {
            potentailReadyButton.Visible = true;
            potentialReadyLabel.Visible = true;
        }

        private void potentialReadyVisibleFalse()
        {
            potentailReadyButton.Visible = false;
            potentialReadyLabel.Visible = false;
        }

        private void planOptimalVisibleTrue()
        {
            planOptimalLabel.Visible = true;
            planOptimalYesButton.Visible = true;
            planOptimalNoButton.Visible = true;
        }

        private void planOptimalVisibleFalse()
        {
            planOptimalLabel.Visible = false;
            planOptimalYesButton.Visible = false;
            planOptimalNoButton.Visible = false;
        }

        private void cageFindedVisibleTrue()
        {
            cageFindedLabel.Visible = true;
            cageFindedButton.Visible = true;
        }

        private void nexCageVisibleFalse()
        {
            nextCageButton.Visible = false;
            nextCageLabel.Visible = false;
        }

        private void nextCageVisibleTrue()
        {
            nextCageButton.Visible = true;
            nextCageLabel.Visible = true;
        }

        private void cageFindedVisibleFalse()
        {
            cageFindedLabel.Visible = false;
            cageFindedButton.Visible = false;
        }

        private void enterTettaValueVisibleFalse()
        {
            enterTettaValueButton.Visible = false;
            enterTettaValueLabel.Visible = false;
            enterTettaValueTextBox.Visible = false;
        }

        private void enterTettaValueVisibleTrue()
        {
            enterTettaValueButton.Visible = true;
            enterTettaValueLabel.Visible = true;
            enterTettaValueTextBox.Visible = true;
        }
    }
}
