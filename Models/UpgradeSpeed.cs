using System.Data.SqlClient;

namespace VehcileUpgrades.Models
{
    public class UpgradeSpeed : IUpgradeSpeed
    {
        SqlConnection conn = new SqlConnection("Data Source=KABELOKWENAITE;Initial Catalog=Vehicles;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        public void VehicleUpgradeSpeed(string vehicleSpeed)
        {
            try
            {
                string sql = "UPDATE vehicleinfo SET VehicleSpeed = @vSpeed WHERE (SELECT * FROM usersinfo INNER JOIN vehicleinfo on usersinfo.VehicleID = vehicleinfo.VehicleID)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
