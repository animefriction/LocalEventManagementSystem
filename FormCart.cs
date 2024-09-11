using System;
using System.Windows.Forms;

namespace LocalEventManagementSystem
{
    public partial class FormCart : Form
    {
        private ListBox lstEvents;
        private NumericUpDown numTickets;
        private Button btnAddToCart;
        private Label lblTotalPrice;

        public FormCart()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Label for Events
            Label lblEvents = new Label();
            lblEvents.Text = "Available Events:";
            lblEvents.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(lblEvents);

            // ListBox for showing events
            lstEvents = new ListBox();
            lstEvents.Location = new System.Drawing.Point(20, 50);
            lstEvents.Size = new System.Drawing.Size(250, 100);
            this.Controls.Add(lstEvents);

            // Label for selecting number of tickets
            Label lblTickets = new Label();
            lblTickets.Text = "Number of Tickets:";
            lblTickets.Location = new System.Drawing.Point(20, 160);
            this.Controls.Add(lblTickets);

            // NumericUpDown for selecting ticket count
            numTickets = new NumericUpDown();
            numTickets.Location = new System.Drawing.Point(150, 160);
            numTickets.Minimum = 1;  // Minimum of 1 ticket
            numTickets.Maximum = 100; // Maximum of 100 tickets
            this.Controls.Add(numTickets);

            // Button for adding tickets to cart
            btnAddToCart = new Button();
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.Location = new System.Drawing.Point(20, 200);
            btnAddToCart.Click += new EventHandler(btnAddToCart_Click);
            this.Controls.Add(btnAddToCart);

            // Label to display total price
            lblTotalPrice = new Label();
            lblTotalPrice.Text = "Total Price: $0";
            lblTotalPrice.Location = new System.Drawing.Point(20, 240);
            this.Controls.Add(lblTotalPrice);

            // Load the events into the ListBox
            LoadEvents();
        }

        private void LoadEvents()
        {
            // Add all events from Form1's eventList to the ListBox
            foreach (var evnt in Form1.eventList)
            {
                lstEvents.Items.Add(evnt.EventName + " - " + evnt.EventDate.ToString("d"));
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Make sure an event is selected
            if (lstEvents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an event.");
                return;
            }

            // Get the selected event and number of tickets
            int selectedEventIndex = lstEvents.SelectedIndex;
            Event selectedEvent = Form1.eventList[selectedEventIndex];
            int ticketCount = (int)numTickets.Value;

            // Calculate the total price
            decimal totalPrice = selectedEvent.TicketPrice * ticketCount;
            lblTotalPrice.Text = "Total Price: $" + totalPrice.ToString("F2");

            // Show confirmation
            MessageBox.Show("Added to cart: " + selectedEvent.EventName + " - " + ticketCount + " tickets");
        }


    }
}
