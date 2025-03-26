using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Classes
{
    public class Queries
    {
        public static string EditCustomerQuery { get; } = "UPDATE CustomerTable SET CustomerName = @CustomerName, ContactInfo = @ContactInfo WHERE CustomerID = @CustomerID";
        public static string UpdateRentalTable { get; } = "UPDATE RentalTable SET Status = 'Overdue' WHERE ReturnDate IS NULL AND CONVERT(DATE, DueDate) < CONVERT(DATE, GETDATE());";
        public static string UpdatePenaltyFee { get; } = "UPDATE RentalTable SET PenaltyFee = (DATEDIFF(DAY, DueDate, GETDATE()) * 5) WHERE Status = 'Overdue'";    
        public static string GetMemberID { get; } = "SELECT CustomerID FROM CustomerTable WHERE CustomerName = @CustomerName";
        public static string DeleteVideo { get; } = "DELETE FROM VideoTable WHERE VideoID = @VideoID";
        public static string InsertToCustomerTable { get; } = "INSERT INTO CustomerTable (CustomerName, ContactInfo) VALUES (@CustomerName, @ContactInfo)";
        public static string EditVideo { get; } = "UPDATE VideoTable SET Title = @Title, Category = @Category, Price = @Price, Copies = @Copies, Rating = @Rating WHERE VideoID = @VideoID";
        public static string AddNewVideo { get; } = "INSERT INTO VideoTable (Title, Category, Price, Copies) VALUES (@Title, @Category, @Price, @Copies)";
    }
}