using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZemberekDotNet.Core.IO;
using ZemberekDotNet.Morphology;
using ZemberekDotNet.Morphology.Analysis;

namespace _200601038_odev1_1
{
    public partial class MorphologicalAnalysisForm : Form
    {
        MorphologicalAnalysis morphologicalAnalysis;
        public MorphologicalAnalysisForm(string fileName, string text)
        {
            InitializeComponent();
            this.gbMorphologicalAnalysis.Text = fileName;
            this.morphologicalAnalysis = new MorphologicalAnalysis(text);
        }

        private void MorphologicalAnalysisForm_Load(object sender, EventArgs e)
        {
            this.init();

        }


        private List<string> getUniqueWords(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> uniqueWords = new HashSet<string>(words);
            return new List<string>(uniqueWords);

        }

        private List<string> getUniqueWords(string[] words)
        {
            return new List<string>(new HashSet<string>(words));
        }
        private string[] listToStringArray(List<string> list)
        {
            string[] array = new string[list.Count];
            for (int i = 0; i < list.Count; i += 1)
                array[i] = list[i];
            return array;
        }

        private List<string> getUniqueWords()
        {
            return this.getUniqueWords(this.morphologicalAnalysis.getProcessedAndCorrectedWords());
        }

        private List<List<string>> getWordRoots(List<string> words)
        {
            List<List<string>> wordRoots = new List<List<string>>();
            for (int i = 0; i < words.Count; i += 1)
            {
                string word = words[i];
                WordAnalysis wa = this.morphologicalAnalysis.getTurkisMorphology().Analyze(word);
                wordRoots.Add(new List<string>());

                if (wa.Count() > 0)
                {
                    wordRoots[i].Add(wa.GetAnalysisResults()[0].GetStem());
                    wordRoots[i].Add(wa.GetAnalysisResults()[0].GetMorphemes()[0].Name);
                }
                else
                {
                    wordRoots[i].Add(word);
                    wordRoots[i].Add(word);
                }

            }

            return wordRoots;

        }

        private void setListView()
        {
            this.lvMorphologicalAnalysis.View = View.Details;
            this.addColumns();
        }
        string[] headers = { "Kelime", "Kökler", "Morfem" };
        private void addColumns()
        {
            for (int i = 0; i < this.headers.Length; i += 1)
            {
                this.lvMorphologicalAnalysis.Columns.Add(this.ColumnHeaderGenerator(this.headers[i], this.lvMorphologicalAnalysis.Width / this.headers.Length));
            }
        }
        private ColumnHeader ColumnHeaderGenerator(string name, int width)
        {
            ColumnHeader c = new ColumnHeader();
            c.Text = name;
            c.Width = width;
            return c;
        }

        private void setLabelTexts(int number1, int number2)
        {
            this.lblUniqueWordNumber1.Text = number1.ToString();
            this.lblUniqueWordNumber2.Text = number2.ToString();
        }
        private string[] getStems(List<List<string>> morphemStemList)
        {
            string[] array = new string[morphemStemList.Count];
            for (int i = 0; i < morphemStemList.Count; i++)
                array[i] = morphemStemList[i][0];
            return array;
        }
        private void init()
        {
            List<string> uniqueWords = this.getUniqueWords();
            List<List<string>> wordRoots = this.getWordRoots(uniqueWords);
            this.setListView();
            this.addToListView(uniqueWords, wordRoots);
            this.setLabelTexts(uniqueWords.Count, this.getUniqueWords(this.getStems(wordRoots)).Count);

        }

        private void addToListView(List<string> words, List<List<string>> roots)
        {
            for (int i = 0; i < words.Count; i++)
                this.lvMorphologicalAnalysis.Items.Add(this.getListViewItem(words[i], roots[i][0], roots[i][1]));
        }
        private ListViewItem getListViewItem(string word, string root, string morfem)
        {
            ListViewItem temp = new ListViewItem(word);
            temp.SubItems.Add(root);
            temp.SubItems.Add(morfem);
            return temp;
        }
    }
}
