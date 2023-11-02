using System.Text.RegularExpressions;
using ZemberekDotNet;
using ZemberekDotNet.Morphology;
using ZemberekDotNet.Morphology.Analysis;
using ZemberekDotNet.Normalization;

namespace _200601038_odev1_1
{
    public partial class TextScannerForm : Form
    {
        private TxtFile txtFile;
        public TextScannerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtFile = new TxtFile(null, null);
        }

        private void btnMorpAnalysis_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.txtFile.path))
            {
                MessageBox.Show("Geçerli dosya yolu bulunamadý.");
                return;
            }
            MessageBox.Show("Bu iþlem biraz zaman alabilir.");
            this.lblTextProcessing.Visible = true;
            MorphologicalAnalysisForm maForm = new MorphologicalAnalysisForm(this.txtFile.name, this.txtFile.getContent().ToLower());
            this.lblTextProcessing.Visible = false;
            maForm.ShowDialog();
            
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Metin dosyasý seçiniz.";
            openFileDialog.Filter = "Metin Belgesi | *.txt";
            openFileDialog.ShowDialog();

            if (openFileDialog.CheckFileExists)
            {

                lblFile.Text = openFileDialog.SafeFileName;
                lblFile.Visible = true;

                this.txtFile.name = openFileDialog.SafeFileName;
                this.txtFile.path = openFileDialog.FileName;
            }
            else
            {
                lblFile.Visible = false;
                this.txtFile.name = null;
                this.txtFile.path = null;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == null | txtSearch.Text == "")
            {
                MessageBox.Show("Boþ giriþ aramasý yaptýnýz.");
                return;
            }
            if (!File.Exists(this.txtFile.path))
            {
                MessageBox.Show("Önce bir dosya seçin.");
                return;
            }

            Regex regex = new Regex(txtSearch.Text);

            MatchCollection matched = regex.Matches(this.txtFile.getContent());

            string[] results = new string[matched.Count];

            int counter = 0;

            foreach (Match match in matched)
                if (match.Success)
                    results[counter++] = match.Value;


            this.openRegexResultForm(this.txtFile.name, this.txtSearch.Text, results);
        }

        private void openRegexResultForm(string fileName, string pattern, string[] matcheds)
        {
            // Example Regex \b[Oo]\w{0,4}[Rr]\b
            RegexResultForm rrForm = new RegexResultForm(fileName, pattern, matcheds);

            rrForm.ShowDialog();
        }
    }
}