namespace ClientLibrary
{
    public struct Record
    {
        public int ClientID; 
        public int Year; 
        public int Month; 
        public int Duration;

        public Record(int clientID, int year, int month, int duration) : this() 
        { 
            ClientID = clientID;   
            Year = year;    
            Month = month;
            Duration = duration;
        }
    }
}