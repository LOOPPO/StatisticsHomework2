namespace CSVandUnivariat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                CSVDataGridView.Rows.Clear();
                CSVDataGridView.Columns.Clear();
                FilePathTextBox.Text = OpenFileDialog.FileName;
                var strings = File.ReadAllLines(FilePathTextBox.Text);
                bool headerSet = false;

                if (!HasHeaderCheckBox.Checked)
                {
                    for (int i = 0; i < strings.Length; i++)
                        CSVDataGridView.Columns.Add($"Field{i + 1}", $"Field {i + 1}");
                    headerSet = true;
                }
                
                foreach (var s in strings)
                {
                    var fields = s.Split(string.IsNullOrEmpty(SeparatorTextBox.Text) ? "," : SeparatorTextBox.Text);

                    if (!headerSet)
                    {   
                        foreach (var field in fields)
                            CSVDataGridView.Columns.Add(field, field);
                        headerSet = true;
                    }
                    else
                        CSVDataGridView.Rows.Add(fields);                    
                }
            }

        }

        private void CSVDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Dictionary<string, int> valuePairs = new Dictionary<string, int>();

            UnivariatDataGridView.Rows.Clear();
            UnivariatLabel.Text = CSVDataGridView.Columns[e.ColumnIndex].HeaderText;
            
            for (int i = 0; i < CSVDataGridView.Rows.Count; i++)
            {
                var value = (string)CSVDataGridView[e.ColumnIndex, i].Value;
                if (!valuePairs.ContainsKey(value))
                    valuePairs.Add(value, 1);
                else
                    valuePairs[value]++;
            }

            foreach (var pair in valuePairs)
                UnivariatDataGridView.Rows.Add(pair.Key, $"{pair.Value} / {CSVDataGridView.Rows.Count} ({(double)pair.Value / CSVDataGridView.Rows.Count * 100:N2}%)");
        }
    }
}