using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using GraphX.Controls;
using QuickGraph;

namespace Lab1
{
    public partial class GraphVisualizer : Form
    {
        public GraphVisualizer(Calculation calc)
        {
            InitializeComponent();
            this.calc = calc;
        }

        Calculation calc;

        private void GraphVisualizer_Load(object sender, EventArgs e)
        {
            wpfHost.Child = GenerateWpfVisuals();
            _zoomctrl.ZoomToFill();
        }

        private ZoomControl _zoomctrl;
        private GraphArea _gArea;

        private UIElement GenerateWpfVisuals()
        {
            _zoomctrl = new ZoomControl();
            ZoomControl.SetViewFinderVisibility(_zoomctrl, Visibility.Visible);
            /* ENABLES WINFORMS HOSTING MODE --- >*/
            var logic = new GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>();
            _gArea = new GraphArea() { EnableWinFormsHostingMode = true, LogicCore = logic };
            logic.Graph = GenerateGraph();
            logic.DefaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.LinLog;
            logic.DefaultLayoutAlgorithmParams = logic.AlgorithmFactory.CreateLayoutParameters(LayoutAlgorithmTypeEnum.LinLog);
            //((LinLogLayoutParameters)logic.DefaultLayoutAlgorithmParams). = 100;
            logic.DefaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
            logic.DefaultOverlapRemovalAlgorithmParams = logic.AlgorithmFactory.CreateOverlapRemovalParameters(OverlapRemovalAlgorithmTypeEnum.FSA);
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 50;
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 50;
            logic.DefaultEdgeRoutingAlgorithm = EdgeRoutingAlgorithmTypeEnum.None;
            logic.AsyncAlgorithmCompute = false;
            _zoomctrl.Content = _gArea;
            _gArea.RelayoutFinished += gArea_RelayoutFinished;


            var myResourceDictionary = new ResourceDictionary { Source = new Uri("Templates\\template.xaml", UriKind.Relative) };
            _zoomctrl.Resources.MergedDictionaries.Add(myResourceDictionary);

            return _zoomctrl;
        }

        void gArea_RelayoutFinished(object sender, EventArgs e)
        {
            _zoomctrl.ZoomToFill();
        }

        private Graph GenerateGraph()
        {
           
            var dataGraph = new Graph();

            HashSet<string> tempSet = new HashSet<string>();
            
            foreach(HashSet<string> i in calc.setElAfterV)//Формування вершин
            {
                foreach (string j in i)
                {
                    tempSet.Add(j);
                }
            }

            foreach(string st in tempSet)
            {
                var dataVertex = new DataVertex(st);
                dataGraph.AddVertex(dataVertex);
            }

            var list = dataGraph.Vertices.ToList();

            for (int i = 0; i < calc.setElAfterV.Count; i++)//Утворення зв'язків
            {
                for (int j = 0; j < calc.setElAfterV[i].Count-1; j++)
                {
                    var dataVertex1 = new DataVertex(calc.setElAfterV[i].ElementAt(j));
                    
                    var dataVertex2 = new DataVertex(calc.setElAfterV[i].ElementAt(j+1));

                    var vlist = dataGraph.Vertices.ToList();

                    var dataEdge = new DataEdge(vlist.Find(x => x.Text == dataVertex1.Text), vlist.Find(x => x.Text == dataVertex2.Text)) 
                    { Text = string.Format("{0} -> {1}", vlist.Find(x => x.Text == dataVertex1.Text), vlist.Find(x => x.Text == dataVertex2.Text)) };

                    dataGraph.AddEdge(dataEdge);
                }
            }
            
            return dataGraph;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            _gArea.GenerateGraph(true);
            _gArea.SetVerticesDrag(true, true);
            _zoomctrl.ZoomToFill();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            _gArea.RelayoutGraph();
        }
    }
}
