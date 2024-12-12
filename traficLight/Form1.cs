namespace traficLight
{
    public partial class Form1 : Form
    {
        private int movingObjectX = 50; 
        private int movingObjectY = 100; 
        public Form1()
        {
            InitializeComponent();
            red.Visible = true;
            yellow.Visible = false;
            green.Visible = false;

            // Initialize moving object's properties
            movingObj.BackColor = Color.Blue; // Set the color
            movingObj.Size = new Size(50, 50); // Set the size
            movingObj.Location = new Point(movingObjectX, movingObjectY); // Set the position

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (red.Visible == true)
            {
                red.Visible = false;
                yellow.Visible = false;

                green.Visible = true;
                movingTimer.Enabled = true; // Start moving object

            }
            else if (green.Visible == true)
            {
                red.Visible = false;
                green.Visible = false;

                yellow.Visible = true;
                movingTimer.Enabled = false; // Start moving object


            }
            else if (yellow.Visible == true)
            {
                red.Visible = true;
                yellow.Visible = false;
                green.Visible = false;

                movingTimer.Enabled = false; // Start moving object

            }


        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            movingTimer.Enabled = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            movingTimer.Enabled = false; // Stop moving object


            red.Visible = true;
            yellow.Visible = false;
            green.Visible = false;

            // Reset moving object's position
            movingObjectX = 50;
            movingObj.Location = new Point(movingObjectX, movingObjectY);
        }

        private void movingTimer_Tick(object sender, EventArgs e)
        {
            // Move the object to the right
            movingObjectX += 30;
            if (movingObjectX > this.Width) // Reset position if it goes off-screen
            {
                movingObjectX = -movingObj.Width;
            }
            movingObj.Location = new Point(movingObjectX, movingObjectY);


        }
    }
}
