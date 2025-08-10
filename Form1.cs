// Double-click a [Design] file element to create an event below

namespace WinformsDemo_i2winforms
{
    public partial class userInfoForm : Form {
        private bool isInputLengthValid(string input) {
            return input.Length >= 2;
        }

        private void clearForm() {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        // -- EVENTS --

        public userInfoForm() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;    // opens form center screen
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            string firstName = firstNameTextBox.Text;

            // display submitted data
            if (isInputLengthValid(firstName) && genderOptionMan.Checked == true) {
                MessageBox.Show($"Successfully submitted data!\nFirst Name: {firstName}\nLast Name: {lastNameTextBox.Text}\nDOB: {DOBDateTime.Text}\nGender: Man");
                clearForm();
            }
            else if (isInputLengthValid(firstName) && genderOptionWoman.Checked == true) {
                MessageBox.Show($"Successfully submitted data!\nFirst Name: {firstName}\nLast Name: {lastNameTextBox.Text}\nDOB: {DOBDateTime.Text}\nGender: Woman");
                clearForm();
            }
            else if (isInputLengthValid(firstName) && genderOptionOther.Checked == true) {
                MessageBox.Show($"Successfully submitted data!\nFirst Name: {firstName}\nLast Name: {lastNameTextBox.Text}\nDOB: {DOBDateTime.Text}\nGender: Other");
                clearForm();
            }
            else {
                MessageBox.Show($"First name must be at least 2 characters long.");
            }
        }
    }
}