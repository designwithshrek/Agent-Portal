namespace AgentPortal.Models
{
    public class Orders
    {

        public Orders(long orderID, string FirstName, string LastName, string MDN, string LifelineStatus, string ACPStatus)
        {
            this.orderID = orderID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MDN = MDN;
            this.LifelineStatus = LifelineStatus;
            this.ACPStatus = ACPStatus;
        }
        public long orderID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MDN { get; set; }
        public string LifelineStatus { get; set; }
        public string ACPStatus { get; set; }
    }
}