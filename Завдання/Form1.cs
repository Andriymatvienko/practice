namespace Завдання
{
    public partial class FrmClasses : Form
    {
        
        public FrmClasses()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile("D:\\olimp.jpg");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CountryMedals new_country;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            CountryMedals new_country;
            if (CountryBox1.Text == "" | CountryBox1.Text == "Russia")
            {
                
                MessageBox.Show("Введіть країну");
                return;
            }

           
            if (MedalBox2.Text != "") // если строка медали не пустая работает это
            {
                if (PeopleBox3.Text != "") //если строка люди не пустая работает это
                {
                    new_country = new CountryMedals(CountryBox1.Text,
                    Convert.ToInt32(MedalBox2.Text), Convert.ToInt32(PeopleBox3.Text)); // выводятся страны медали и люди
                }
                else
                {
                    new_country = new CountryMedals(CountryBox1.Text, Convert.ToInt32(MedalBox2.Text), // если строка людей пустая выводим это
                    0);
                }
            }
            else
            {
                if (PeopleBox3.Text != "")
                {
                    new_country = new CountryMedals(CountryBox1.Text,0, Convert.ToInt32(PeopleBox3.Text));
                }
                else
                {
                    new_country = new CountryMedals(CountryBox1.Text, 0, 0);
                }
            }
                ResultBox.Text += new_country.GetInformation();
        }
        
                    private void PeopleBox3_TextChanged(object sender, EventArgs e)
        {
            CountryMedals new_country;
        }

        private void CountryBox1_TextChanged(object sender, EventArgs e)
        {
            CountryMedals new_country;
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmClasses_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void FrmClasses_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }
    }
}