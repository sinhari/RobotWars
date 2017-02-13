using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.XPath;
using RobotWars.Business.Model;

namespace RobotWars
{
    public partial class OutputForm : Form
    {
       public OutputForm(int x, int y, Coordinates coord1, Coordinates coord2)
        {
            InitializeComponent();
            this.Height = 400;
            this.Width = 400;
           // DrawGraph(x,y, coord1, coord2);
            textBoxRobot1.Text = coord1.Xaxis + " " +coord1.Yaxis +" "+ coord1.Orientation;
            textBoxRobot2.Text = coord2.Xaxis +" " + coord2.Yaxis +" " + coord2.Orientation;
        }

        public OutputForm()
        {
            InitializeComponent();
        }

        
        //Wanted to show the position of both the robots on graph,However unable to plot coordinates like 0,1 and 1,1 differently.
        //Hence commenting out this section
        //It can be done but will need more time.
        #region DrawGraph
        //private void DrawGraph(int rowCount, int columnCount, Coordinates robot1Coordinates,Coordinates robot2Coordinates)
        //{

        //    //Clear out the existing controls, we are generating a new table layout
        //    tableLayoutPanel1.Controls.Clear();

        //    //Clear out the existing row and column styles
        //    tableLayoutPanel1.ColumnStyles.Clear();
        //    tableLayoutPanel1.RowStyles.Clear();

        //    //Now we will generate the table, setting up the row and column counts first
        //    tableLayoutPanel1.ColumnCount = columnCount;
        //    tableLayoutPanel1.RowCount = rowCount;

        //    for (int x = 0; x < columnCount; x++)
        //    {
        //        //First add a column
        //        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

        //        for (int y = 0; y < rowCount; y++)
        //        {
        //            //Next, add a row. 
        //            if (x == 0)
        //            {
        //                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        //            }

        //            TextBox objTextBox = new TextBox();
        //            objTextBox.Enabled = false;
        //            objTextBox.AutoSize = true;

        //            //Finally, add the control to the correct location in the table
        //            tableLayoutPanel1.Controls.Add(objTextBox, x, y);
        //        }
        //    }

        //    this.tableLayoutPanel1.GetControlFromPosition(robot1Coordinates.Xaxis-1, robot1Coordinates.Yaxis-1).BackColor = Color.Lime;
        //    this.tableLayoutPanel1.GetControlFromPosition(robot1Coordinates.Xaxis-1, robot1Coordinates.Yaxis-1).Text = robot1Coordinates.Orientation;


        //    this.tableLayoutPanel1.GetControlFromPosition(robot2Coordinates.Xaxis-1, robot2Coordinates.Yaxis-1).BackColor =
        //        Color.DarkOrange;//   255, 128, 0;
        //    this.tableLayoutPanel1.GetControlFromPosition(robot2Coordinates.Xaxis-1, robot2Coordinates.Yaxis-1).Text =
        //        robot2Coordinates.Orientation;
        //}

#endregion
    }

}

