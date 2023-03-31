namespace SimpleCalc
{
    public partial class 簡単計算プログラム : Form
    {
        public 簡単計算プログラム()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // 変数の宣言
            int valueLeft;
            // 変数の宣言
            int valueRight;
            // 変数の宣言
            int valueAnswer;

            // 値の取り込み
            valueLeft = InputCheck(input1TextBox.Text, out valueLeft);
            valueRight = InputCheck(input2TextBox.Text, out valueRight);


            // 取り込んだ値の計算式
            valueAnswer = valueLeft + valueRight;

            // 計算結果を出力
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