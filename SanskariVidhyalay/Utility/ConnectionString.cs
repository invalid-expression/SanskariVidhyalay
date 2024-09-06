namespace SanskariVidhyalay.Utility
{
    public class ConnectionString
    {
        private static string cName = "Data Source=DESKTOP-50K995S\\SQLEXPRESS;Initial Catalog=SanskariVidhyalay;Integrated Security=True;Encrypt=True;Trust Server Certificate=True; Initial Catalog=SanskariVidhyalay";
        public static string CName
        {
            get => cName;
        }
    }
}
