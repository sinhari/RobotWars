using RobotWars.Business.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Configuration;
using System.Windows.Forms;
using RobotWars.Business;

namespace RobotWars
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            this.Height = 680;
            this.Width = 470;
            this.cmbBoxRobot1.SelectedIndex = 0;
            this.cmbBoxRobot2.SelectedIndex = 0;
        }

       private void textBoxLengthofArena_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxLengthofArena.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Please Check!!");
                txtBoxLengthofArena.Text = txtBoxLengthofArena.Text.Remove(txtBoxLengthofArena.Text.Length - 1);
            }
        }

        private void textBoxBreadthofArena_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxBreadthofArena.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Please Check!!");
                txtBoxBreadthofArena.Text = txtBoxBreadthofArena.Text.Remove(txtBoxBreadthofArena.Text.Length - 1);
            }
        }

        private void txtXaxisRobot1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtXaxisRobot1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Please Check!!");
                txtXaxisRobot1.Text = txtXaxisRobot1.Text.Remove(txtXaxisRobot1.Text.Length - 1);
            }
        }

        private void txtYaxisRobot1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtYaxisRobot1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Please Check!!");
                txtYaxisRobot1.Text = txtYaxisRobot1.Text.Remove(txtYaxisRobot1.Text.Length - 1);
            }
        }

        private void txtXaxisRobot2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtXaxisRobot2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Please Check!!");
                txtXaxisRobot2.Text = txtXaxisRobot2.Text.Remove(txtXaxisRobot2.Text.Length - 1);
            }
        }

        private void txtYaxisRobot2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtYaxisRobot2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.","Please Check!!");
                txtYaxisRobot2.Text = txtYaxisRobot2.Text.Remove(txtYaxisRobot2.Text.Length - 1);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool controlsAreValid = false;
            controlsAreValid=ValidateControls();
            if (controlsAreValid)
            {
                //get the value of grid
                var arenalength = Int32.Parse(txtBoxLengthofArena.Text);
                var arenawidth = Int32.Parse(txtBoxBreadthofArena.Text);

                EnableDisableRobot2Controls(false);

                //get the value of robot 1 (x, y, orientation)
                var x1 = Int32.Parse(txtXaxisRobot1.Text);
                var y1 = Int32.Parse(txtYaxisRobot1.Text);
                var direction1 = cmbBoxRobot1.SelectedItem.ToString();
                var strmovements = txtMovesRobot1.Text;
                List<string> movements1 = strmovements.Select(r1 => r1.ToString()).ToList();

                //call controller
                Coordinates robot1Coordinates = Controller.RobotController(x1, y1, direction1, movements1);

                //get the value of robot 2(x, y, orientation)
                var x2 = Int32.Parse(txtXaxisRobot2.Text);
                var y2 = Int32.Parse(txtYaxisRobot2.Text);
                var direction2 = cmbBoxRobot2.SelectedItem.ToString();
                var strmovements2 = txtMovesRobot2.Text;
                List<string> movements2 = strmovements2.Select(r1 => r1.ToString()).ToList();

                //call controller
                Coordinates robot2Coordinates = Controller.RobotController(x2, y2, direction2, movements2);

                OutputForm outputForm = new OutputForm(arenalength, arenawidth, robot1Coordinates, robot2Coordinates);
                outputForm.Show();
            }

        }

        private bool ValidateControls()
        {
            //As of now I am only doing the minimum validation, As this is a form with user input I
            //would want to add more checks going further.This code can also be further refactored.
            string msg = "";
            if (String.IsNullOrEmpty(txtBoxLengthofArena.Text))
            {
                msg = msg +"Arena length cannot be empty" +"\n";
            }
            if (String.IsNullOrEmpty(txtBoxBreadthofArena.Text))
            {
                msg = msg + "Arena breadth cannot be empty" + "\n";
            }
            if (String.IsNullOrEmpty(txtXaxisRobot1.Text))
            {
                msg = msg + "X-Coord for Robot1 cannot be empty" + "\n";
            }
            if (String.IsNullOrEmpty(txtMovesRobot1.Text))
            {
                msg = msg + "Moves for Robot1 cannot be empty" + "\n";
            }
            if (String.IsNullOrEmpty(txtXaxisRobot2.Text))
            {
                msg = msg + "X-Coord for Robot2 cannot be empty" + "\n";
            }
            if (String.IsNullOrEmpty(txtXaxisRobot2.Text))
            {
                msg = msg + "Y-Coord for Robot2 cannot be empty" + "\n";
            }
            if (String.IsNullOrEmpty(txtMovesRobot2.Text))
            {
                msg = msg + "Moves for Robot2 cannot be empty" + "\n";
            }
            
            if (String.IsNullOrEmpty(msg))
            {
                return true;
            }
            else
            {
                MessageBox.Show(msg);
                return false;
            }
        }

        private void txtMovesRobot1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMovesRobot1.Text, "[^LRM]"))
            {
                MessageBox.Show("Please enter either L,R or M.", "Please Check!!");
                txtMovesRobot1.Text = txtMovesRobot1.Text.Remove(txtMovesRobot1.Text.Length - 1);
            }
        }

        private void txtMovesRobot1_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMovesRobot1.Text, "[^LRM]"))
            {
                MessageBox.Show("Please enter either L,R or M.", "Please Check!!");
                txtMovesRobot1.Text = txtMovesRobot1.Text.Remove(txtMovesRobot1.Text.Length - 1);
            }
        }

        private void txtMovesRobot2_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMovesRobot2.Text, "[^LRM]"))
            {
                MessageBox.Show("Please enter either L,R or M.", "Please Check!!");
                txtMovesRobot2.Text = txtMovesRobot2.Text.Remove(txtMovesRobot2.Text.Length - 1);
            }
        }

        private void txtMovesRobot2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMovesRobot2.Text, "[^LRM]"))
            {
                MessageBox.Show("Please enter either L,R or M.", "Please Check!!");
                txtMovesRobot2.Text = txtMovesRobot2.Text.Remove(txtMovesRobot2.Text.Length - 1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            EnableDisableRobot2Controls(true);
            btnSubmit.Enabled = true;
            EnableDisableRobot1Controls(false);

         }

        private void EnableDisableRobot1Controls(bool value)
        {
            txtXaxisRobot1.Enabled = value;
            txtYaxisRobot1.Enabled = value;
            txtMovesRobot1.Enabled = value;
            cmbBoxRobot1.Enabled = value;
        }

        private void EnableDisableRobot2Controls(bool value)
        {
            txtXaxisRobot2.Enabled = value;
            txtYaxisRobot2.Enabled = value;
            txtMovesRobot2.Enabled = value;
            cmbBoxRobot2.Enabled = value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            EnableDisableRobot1Controls(true);
            EnableDisableRobot2Controls(false);
        }
    }
}
