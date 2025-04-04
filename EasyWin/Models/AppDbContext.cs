using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
namespace EasyWin.Models
{
    public class AppDbContext
    {
        private readonly string connectionString = "Data Source=DELL-T440;Initial Catalog=SanjeevaniTrade;TrustServerCertificate=True;Persist Security Info=True;User ID = sa; password=espl@123;MultipleActiveResultSets=True;";

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DELL-T440;Initial Catalog=SanjeevaniTrade;TrustServerCertificate=True;Persist Security Info=True;User ID = sa; password=espl@123;MultipleActiveResultSets=True;");  // SQLite database file
        //}

        public async Task<IEnumerable<Acms>> AcmAsync()
        {
            List<Acms> acms = new List<Acms>();
            using (SqlConnection con = new SqlConnection("Data Source=DELL-T440;Initial Catalog=SanjeevaniTrade;TrustServerCertificate=True;Persist Security Info=True;User ID = sa; password=espl@123;MultipleActiveResultSets=True;"))
            {
                await con.OpenAsync();
                string query = "SELECT TOP 100 Code,Name,Email,Contact1Mobile,Address FROM Acm with(nolock)";
                return await con.QueryAsync<Acms>(query);
            }            
        }

        public async Task<IEnumerable<Acms>> AcmSearchAsync(string searchTerm)
        {
            List<Acms> acms = new List<Acms>();
            using (SqlConnection con = new SqlConnection("Data Source=DELL-T440;Initial Catalog=SanjeevaniTrade;TrustServerCertificate=True;Persist Security Info=True;User ID = sa; password=espl@123;MultipleActiveResultSets=True;"))
            {
                await con.OpenAsync();
                string query = "SELECT TOP 100 Code,Name,Email,Contact1Mobile,Address FROM Acm with(nolock) WHERE Name LIKE @SearchTerm or code like @Code";
                return await con.QueryAsync<Acms>(query,new { SearchTerm  = "%" + searchTerm + "%" , Code = "%" + searchTerm + "%" });
            }
        }
    }
}
