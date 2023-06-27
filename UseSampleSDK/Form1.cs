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

                SampleSDK.LogWriter.Info("WinForms����Ăяo���iInfo�j");
                SampleSDK.LogWriter.Error("WinForms����Ăяo���iError�j");

                MessageBox.Show("�������݂��������܂���", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�������݂Ɏ��s���܂����B�G���[���e�F{ex}", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}