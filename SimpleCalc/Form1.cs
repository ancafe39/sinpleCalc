namespace SimpleCalc
{
    public partial class �ȒP�v�Z�v���O���� : Form
    {
        public �ȒP�v�Z�v���O����()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // �ϐ��̐錾
            int valueLeft;
            // �ϐ��̐錾
            int valueRight;
            // �ϐ��̐錾
            int valueAnswer;

            // �l�̎�荞��
            valueLeft = InputCheck(input1TextBox.Text, out valueLeft);
            valueRight = InputCheck(input2TextBox.Text, out valueRight);


            // ��荞�񂾒l�̌v�Z��
            valueAnswer = valueLeft + valueRight;

            // �v�Z���ʂ��o��
            answerTextBox.Text = valueAnswer.ToString();
        }

        private int InputCheck(string textValue, out int value)
        {
            if (int.TryParse(textValue, out value))
            {
                value = int.Parse(textValue);
            }
            else
            {
                value = 0;
            }

            return value;
        }
    }
}