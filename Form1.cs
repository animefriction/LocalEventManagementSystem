using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocalEventManagementSystem
{
    public partial class Form1 : Form
    {
        // Static list to hold created events
        public static List<Event> eventList = new List<Event>();

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();  // Initialize the buttons programmatically
        }

        // Programmatically adding buttons
        private void InitializeCustomComponents()
        {
            // Create Event button
            Button btnCreateEvent = new Button();
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.Location = new System.Drawing.Point(100, 50);
            btnCreateEvent.Size = new System.Drawing.Size(200, 40);
            btnCreateEvent.Click += new EventHandler(btnCreateEvent_Click);
            this.Controls.Add(btnCreateEvent);

            // View Cart button
            Button btnViewCart = new Button();
            btnViewCart.Text = "View Cart";
            btnViewCart.Location = new System.Drawing.Point(100, 120);
            btnViewCart.Size = new System.Drawing.Size(200, 40);
            btnViewCart.Click += new EventHandler(btnViewCart_Click);
            this.Controls.Add(btnViewCart);
        }

        // Event handler to open the Event Creation form
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            FormEventCreation eventCreationForm = new FormEventCreation();
            eventCreationForm.ShowDialog();
        }

        // Event handler to open the Cart form
        private void btnViewCart_Click(object sender, EventArgs e)
        {
            FormCart cartForm = new FormCart();
            cartForm.ShowDialog();
        }


    }
}
