using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateDistanceMatrix
{
    public partial class GenerateDistanceMatrix : System.Windows.Forms.Form
    {
        float[,] distanceMatrix;

        public GenerateDistanceMatrix()
        {
            InitializeComponent();
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            DataGridNodes.Rows.Clear();
            string filename = inputDataTxt.Text;
            string[] text = File.ReadAllLines(filename, Encoding.UTF8);
            int nnode = 0;
            foreach(string row in text)
            {
                if(nnode != 0)
                {
                    string[] data = row.Split(new string[] { "," }, StringSplitOptions.None);
                    DataGridNodes.Rows.Add(data[0], data[1], data[2]);
                }
                nnode++;
            }

            totalNodeTxt.Text = (nnode-1).ToString();
        }

        private void GrabDataBtn_Click(object sender, EventArgs e)
        {

            grabProgress.Visible = true;
            int percent = 0;
            float[,] distanceMatrix;
            int nnodes = int.Parse(totalNodeTxt.Text);
            distanceMatrix = new float[nnodes, nnodes];
            string[] latlang = new string[nnodes];
            string apikey = Interaction.InputBox("Please input new API Key", "Update Key", "", -1, -1);

            string origins = "";
            string destinations = "";

            for (int i = 0; i < nnodes; i++)
            {
                latlang[i] = DataGridNodes.Rows[i].Cells[1].Value.ToString() + "," + DataGridNodes.Rows[i].Cells[2].Value.ToString();
            }

            List<string> fromToList = new List<string>();
            for (int i = 0; i < nnodes; i++)
            {
                for (int j = 0; j < nnodes; j++)
                {
                    fromToList.Add(i + "-" + j);
                }
            }

            int k = 1;
            int last = 0;
            List<int> ori = new List<int>();
            List<int> dest = new List<int>();

            for (int i = last; i < fromToList.Count; i++)
            {
                string[] ft = fromToList[i].Split(new string[] { "-" }, StringSplitOptions.None);
                int from = int.Parse(ft[0]);
                int to = int.Parse(ft[1]);

                if (!ori.Contains(from))
                {
                    if (ori.Count > 0) origins += "|";
                    origins += latlang[from];
                    ori.Add(from);
                }


                if (!dest.Contains(to))
                {
                    if (dest.Count > 0) destinations += "|";
                    destinations += latlang[to];
                    dest.Add(to);
                }

                if (k % 25 == 0 || i == fromToList.Count() - 1)
                {
                    percent = int.Parse(Math.Ceiling((double)i / (double)fromToList.Count() * 100).ToString());
                    grabProgress.Value = percent;
                    string outputTextTest = "";
                    //GRAB FROM GOOGLE API
                    string url = "https://maps.googleapis.com/maps/api/distancematrix/json?origins=" + origins + "&destinations=" + destinations + "&key="+ apikey;
                    WebRequest request = WebRequest.Create(url);
                    request.ContentType = "application/json; charset=utf-8";
                    WebResponse ws = request.GetResponse();
                    string outputResult = "";
                    using (var sr = new StreamReader(ws.GetResponseStream()))
                    {
                        outputTextTest = sr.ReadToEnd();
                    }

                    JObject test = JObject.Parse(outputTextTest);

                    outputResult = outputTextTest;

                    outputTextTest = test.GetValue("status").ToString();
                    if (outputTextTest != "OK")
                    {
                        do
                        {
                            apikey = Interaction.InputBox("Please input new API Key", "Update Key", "", -1, -1);
                        } while (apikey == "");
                        ori.Clear();
                        dest.Clear();
                        origins = "";
                        destinations = "";
                        i = last-1;
                    }
                    else
                    {
                        ori.Clear();
                        dest.Clear();
                        origins = "";
                        destinations = "";
                        string filename2 = "./" + last + "-" + (i+1) + ".txt";
                        System.IO.File.WriteAllText(filename2, outputResult);
                        last = i + 1;
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                k++;
            }
            grabProgress.Visible = false;
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            grabProgress.Visible = true;
            int percent = 0;
            int nnodes = int.Parse(totalNodeTxt.Text);
            distanceMatrix = new float[nnodes, nnodes];
            string[] latlang = new string[nnodes];

            string origins = "";
            string destinations = "";

            for (int i = 0; i < nnodes; i++)
            {
                latlang[i] = DataGridNodes.Rows[i].Cells[1].Value.ToString() + "," + DataGridNodes.Rows[i].Cells[2].Value.ToString();
            }

            List<string> fromToList = new List<string>();
            for (int i = 0; i < nnodes; i++)
            {
                for (int j = 0; j < nnodes; j++)
                {
                    fromToList.Add(i + "-" + j);
                }
            }

            int k = 1;
            int last = 0;
            List<int> ori = new List<int>();
            List<int> dest = new List<int>();
            string outputText = "";
            for (int i = last; i < fromToList.Count; i++)
            {
                string[] ft = fromToList[i].Split(new string[] { "-" }, StringSplitOptions.None);
                int from = int.Parse(ft[0]);
                int to = int.Parse(ft[1]);

                if (!ori.Contains(from))
                {
                    if (ori.Count > 0) origins += "|";
                    origins += latlang[from];
                    ori.Add(from);
                }


                if (!dest.Contains(to))
                {
                    if (dest.Count > 0) destinations += "|";
                    destinations += latlang[to];
                    dest.Add(to);
                }

                if (k % 25 == 0 || i == fromToList.Count() - 1)
                {
                    percent = int.Parse(Math.Ceiling((double)i / (double)fromToList.Count() * 100).ToString());
                    grabProgress.Value = percent;
                    string filename2 = "./" + last + "-" + (i + 1) + ".txt";
                    string text2 = File.ReadAllText(filename2, Encoding.UTF8);
                    JObject response = JObject.Parse(text2);
                    int f = 0;
                    foreach (var token in response["rows"])
                    {
                        int t = 0;
                        foreach (var token2 in token["elements"])
                        {
                            if (token2["status"].ToString() == "OK")
                            {
                                outputText += ori[f] + "|" + dest[t] + "|" + token2["distance"]["value"] + "\n";
                                distanceMatrix[ori[f], dest[t]] = float.Parse(token2["distance"]["value"].ToString());
                            }
                            else
                            { 
                                outputText += ori[f] + "|" + dest[t] + "|" + -1 + "\n";
                                distanceMatrix[ori[f], dest[t]] = -1;
                            }

                            t++;
                        }
                        f++;
                    }

                    ori.Clear();
                    dest.Clear();
                    origins = "";
                    destinations = "";
                    last = i + 1;
                }
                k++;
            }

            outputText = "";
            for (int i = 0;i<nnodes;i++)
            {
                for (int j = 0; j < nnodes; j++)
                {
                    outputText += distanceMatrix[i,j] + "\t";
                }
                outputText +=  "\n";
            }

            outputDistanceTxt.Text = outputText;
            grabProgress.Visible = false;
            TabPages.SelectedIndex = 1;
        }

        private void GenerateSubsetBtn_Click(object sender, EventArgs e)
        {
            if(distanceMatrix != null)
            { 
                grabSubsetProgress.Visible = true;
                int percent = 0;
                int nnodes = int.Parse(totalNodeSubsetTxt.Text);

                string outputText = "";
                int total = nnodes * nnodes;
                int count = 0;
                int from, to;
                for (int i = 0; i < nnodes; i++)
                {
                    from = int.Parse(DataGridNodesSubset.Rows[i].Cells[0].Value.ToString());
                    for (int j = 0; j < nnodes; j++)
                    {
                        to = int.Parse(DataGridNodesSubset.Rows[j].Cells[0].Value.ToString());
                        outputText += distanceMatrix[from, to] + "\t";
                        count++;
                    }
                    outputText += "\n";
                    percent = int.Parse(Math.Ceiling((double)count / (double)total * 100).ToString());
                    grabSubsetProgress.Value = percent;

                }

                outputDistanceSubsetTxt.Text = outputText;
                grabSubsetProgress.Visible = false;
                tabControl2.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Please generate initial data first");
            }
        }

        private void inputSubsetBtn_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 0;
            outputDistanceSubsetTxt.Text = "";
            DataGridNodesSubset.Rows.Clear();
            string filename = inputDataSubsetTxt.Text;
            string[] text = File.ReadAllLines(filename, Encoding.UTF8);
            int nnode = 0;
            foreach (string row in text)
            {
                if (nnode != 0)
                {
                    string[] data = row.Split(new string[] { "," }, StringSplitOptions.None);
                    DataGridNodesSubset.Rows.Add(data[0], "", "");
                }
                nnode++;
            }

            totalNodeSubsetTxt.Text = (nnode - 1).ToString();
        }
    }
}
