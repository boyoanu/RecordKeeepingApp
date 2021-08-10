using RecordKeepingApp.Library;
using System;

namespace RecordKeepingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // A college lecturer needs to keep track of class attendance. 
            // Each record contains a matric number along with a true (present) or false(absent) value.

            // Create an attendance register that meets the lecturer's data storage needs
            IRecordKeeper<string, bool> attendanceRegister = new RecordKeeper<string, bool>();

            // Populate the attendance register
            attendanceRegister.AcceptItem("UNILAG/1001", true);
            attendanceRegister.AcceptItem("UNILAG/1002", true);
            attendanceRegister.AcceptItem("UNILAG/1003", false);
            attendanceRegister.AcceptItem("UNILAG/1004", true);

            // A receptionist needs to maintain a register of visitors to the organization. 
            // Each record contains a timestamp (arrival time) along with the visitor’s name. 

            // Create a visitors register that meets the receptionist's data storage needs
            IRecordKeeper<DateTime, string> visitorRegister = new RecordKeeper<DateTime, string>();

            // Populate the attendance register
            visitorRegister.AcceptItem(DateTime.Now, "Mr. Tunde Bello");
            visitorRegister.AcceptItem(DateTime.Now, "Mr. Phil Newman");
            visitorRegister.AcceptItem(DateTime.Now, "Mr. Boyowa Odometa");


            // A mobile phone dealer needs to keep an inventory of phones in stock. 
            // Each record contains a unique serial number and the phone itself.   

            // Create an inventory that meets the mobile phone dealer's data storage needs
            IRecordKeeper<string, MobilePhone> inventory = new RecordKeeper<string, MobilePhone>();

            // Populate the inventory
            inventory.AcceptItem("MP10028299", new MobilePhone());
            inventory.AcceptItem("MP10028347", new MobilePhone());
            inventory.AcceptItem("MP10028210", new MobilePhone());
        }
    }
}
