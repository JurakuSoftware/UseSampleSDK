namespace UseSampleSDK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                SampleSDK.LogWriter.Info("WinFormsから呼び出し（Info）");
                SampleSDK.LogWriter.Error("WinFormsから呼び出し（Error）");

                MessageBox.Show("書き込みが完了しました", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"書き込みに失敗しました。エラー内容：{ex}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}