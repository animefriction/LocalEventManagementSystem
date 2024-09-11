using System;
using System.Windows.Forms;

namespace LocalEventManagementSystem
{
    public partial class FormEventCreation : Form
    {
        // Controls
        private TextBox txtEventName;
        private DateTimePicker dtpEventDate;
        private TextBox txtLocation;
        private TextBox txtTicketPrice;
        private Button btnSubmit;

        public FormEventCreation()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Label for Event Name
            Label lblEventName = new Label();
            lblEventName.Text = "Event Name:";
            lblEventName.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(lblEventName);

            // TextBox for Event Name
            txtEventName = new TextBox();
            txtEventName.Location = new System.Drawing.Point(120, 20);
            this.Controls.Add(txtEventName);

            // Label for Event Date
            Label lblEventDate = new Label();
            lblEventDate.Text = "Event Date:";
            lblEventDate.Location = new System.Drawing.Point(20, 60);
            this.Controls.Add(lblEventDate);

            // DateTimePicker for Event Date
            dtpEventDate = new DateTimePicker();
            dtpEventDate.Location = new System.Drawing.Point(120, 60);
            this.Controls.Add(dtpEventDate);

            // Label for Location
            Label lblLocation = new Label();
            lblLocation.Text = "Location:";
            lblLocation.Location = new System.Drawing.Point(20, 100);
            this.Controls.Add(lblLocation);

            // TextBox for Location
            txtLocation = new TextBox();
            txtLocation.Location = new System.Drawing.Point(120, 100);
            this.Controls.Add(txtLocation);

            // Label for Ticket Price
            Label lblTicketPrice = new Label();
            lblTicketPrice.Text = "Ticket Price:";
            lblTicketPrice.Location = new System.Drawing.Point(20, 140);
            this.Controls.Add(lblTicketPrice);

            // TextBox for Ticket Price
            txtTicketPrice = new TextBox();
            txtTicketPrice.Location = new System.Drawing.Point(120, 140);
            this.Controls.Add(txtTicketPrice);

            // Submit Button
            btnSubmit = new Button();
            btnSubmit.Text = "Submit Event";
            btnSubmit.Location = new System.Drawing.Point(120, 180);
            btnSubmit.Click += new EventHandler(btnSubmit_Click);
            this.Controls.Add(btnSubmit);
        }

        // Submit button click event to add event to the list
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            DateTime eventDate = dtpEventDate.Value;
            string location = txtLocation.Text;
            decimal ticketPrice;

            // Validate price input
            if (!decimal.TryParse(txtTicketPrice.Text, out ticketPrice))
            {
                MessageBox.Show("Please enter a valid ticket price.");
                return;
            }

            // Create new event and add it to the list
            Event newEvent = new Event(eventName, eventDate, location, ticketPrice);
            Form1.eventList.Add(newEvent);

            MessageBox.Show("Event created successfully!");

            // Clear the input fields after submission
            txtEventName.Clear();
            txtLocation.Clear();
            txtTicketPrice.Clear();
        }


    }
}
