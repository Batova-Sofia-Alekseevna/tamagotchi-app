namespace TamagotchiApp
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RulesForm_Load(object sender, EventArgs e)
        {
            textBox.Text += "1. Лодка вмещает максимум двух человек.\r\n\r\n";

            textBox.Text += "2. Управлять лодкой могут только:\r\n";
            textBox.Text += "   • Полицейский\r\n";
            textBox.Text += "   • Отец\r\n";
            textBox.Text += "   • Мать\r\n\r\n";

            textBox.Text += "3. Преступника нельзя оставлять\r\n";
            textBox.Text += "   с другими персонажами\r\n";
            textBox.Text += "   без полицейского.\r\n\r\n";

            textBox.Text += "4. Отца нельзя оставлять\r\n";
            textBox.Text += "   с дочерьми без матери.\r\n\r\n";

            textBox.Text += "5. Мать нельзя оставлять\r\n";
            textBox.Text += "   с сыновьями без отца.\r\n\r\n";

            textBox.Text += "6. Победа засчитывается,\r\n";
            textBox.Text += "   когда все персонажи\r\n";
            textBox.Text += "   окажутся на правом берегу.";

            textBox.TabStop = false;

        }
    }
}
