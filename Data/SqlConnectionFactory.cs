using Microsoft.Data.SqlClient;

namespace ECommerceAPI.Data;

public class SqlConnectionFactory(IConfiguration configuration)
{
  private readonly IConfiguration _configuration = configuration;

  public SqlConnection CreateConnection() => new(_configuration.GetConnectionString("DefaultConnection"));
}
