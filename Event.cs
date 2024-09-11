using System;

public class Event
{
    public string EventName { get; set; }
    public DateTime EventDate { get; set; }
    public string Location { get; set; }
    public decimal TicketPrice { get; set; }

    public Event(string eventName, DateTime eventDate, string location, decimal ticketPrice)
    {
        EventName = eventName;
        EventDate = eventDate;
        Location = location;
        TicketPrice = ticketPrice;
    }
}
