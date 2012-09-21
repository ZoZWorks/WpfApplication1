using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.ComponentModel;
using System.Data;

//using System.Speech.Recognition;
using System.IO;

namespace GlassTest
{
    /// <summary>
    /// Interaction logic for Voice2Text.xaml
    /// </summary>
    public partial class Voice2Text : Window
    {

        //private string filePath = "words1.txt";
        //private SpeechRecognizer speechReco;
        //private List<string> grammerList;
        //Paragraph para = new Paragraph();
        private FlowDocument mcFlowDoc = new FlowDocument();
        public Voice2Text()
        {
            InitializeComponent();
        }
       // WebCam webcam;
        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
			this.Opacity=100;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //webcam.Start(); speechReco = new SpeechRecognizer();
            //grammerList = new List<string>();

            //string line;

            //if (File.Exists(filePath))
            //{
            //    StreamReader file = null;
            //    try
            //    {
            //        file = new StreamReader(filePath);
            //        while ((line = file.ReadLine()) != null)
            //        {
            //            grammerList.Add(line);
            //        }
            //    }
            //    finally
            //    {
            //        if (file != null)
            //            file.Close();
            //    }
            //}
            //Choices myChoices = new Choices(grammerList.ToArray());
            //GrammarBuilder builder = new GrammarBuilder(myChoices);
            //Grammar gram = new Grammar(builder);
            //speechReco.LoadGrammar(gram);
            //speechReco.Enabled = true;
            //speechReco.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechReco_SpeechRecognized);

        }
        //void speechReco_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
            
        //    para.Inlines.Add(new Run(e.Result.Text+" "));
        //    mcFlowDoc.Blocks.Add(para);
        //    richTextBox1.Document = mcFlowDoc;
            
        //}

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        //    webcam = new WebCam();
        //    webcam.InitializeWebCam(ref imageVoi);
        //    this.Left = (System.Windows.SystemParameters.PrimaryScreenWidth / 2) - 355;
        //    this.Top = (System.Windows.SystemParameters.PrimaryScreenHeight / 2) - 255;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        //    webcam.Stop();
        }
    }
}
