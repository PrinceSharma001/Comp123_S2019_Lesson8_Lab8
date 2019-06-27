using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8_Lab08
{
    public partial class Lab8Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        public Lab8Form()
        {
            InitializeComponent();

        }
         /// <summary>
         /// Event Handler for Lab08Form Load Event
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// This is the Event Handler for SubmitButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextbox.Text;
            UserAge = float.Parse(AgeTextbox.Text);
            OutputLabel.Text = NameTextbox.Text + " " + AgeTextbox.Text;
            ClearForm();

        }

        private void ClearForm()
        {
            NameTextbox.Clear();
            AgeTextbox.Clear();
            SubmitButton.Enabled = false;
        }

        private void AgeTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextbox.Text);
                SubmitButton.Enabled = true;
            }
            catch 
            {
                SubmitButton.Enabled = false;
            }
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextbox.Text.Length > 2) ? true : false;
        }
    }
}
