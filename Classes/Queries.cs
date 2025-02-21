using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Classes
{
    public class Queries
    {
        public static string EditCustomerQuery = "UPDATE CustomerTable SET FullName = @FullName WHERE CustomerID = @CustomerID";

        public static string UpdateRentalTable = "UPDATE RentalTable SET PenaltyFee = (DATEDIFF(DAY, DueDate, GETDATE()) * 5), Status = 'Overdue' WHERE ReturnDate IS NULL AND DueDate < GETDATE()";

        public static string GetMemberID = "SELECT CustomerID FROM CustomerTable WHERE FullName = @FullName";

        public static string DeleteVideo = "DELETE FROM VideoTable WHERE VideoID = @VideoID";

        public static string LoadClosedTransactions = "SELECT * FROM RentalTable WHERE Status = 'Closed'";

        public static string LoadOngoingRent = "SELECT * FROM RentalTable WHERE Status = 'On Rent'";

        public static string InsertToCustomerTable = "INSERT INTO CustomerTable (FullName) VALUES (@FullName)";

        public static string EditVideo = "UPDATE VideoTable SET Title = @Title, Category = @Category, Price = @Price, Copies = @Copies WHERE VideoID = @VideoID";

        public static string AddNewVideo = "INSERT INTO VideoTable (Title, Category, Price) VALUES (@Title, @Category, @Price)";
    }
}
