using API_QLBN.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_QLBN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Benhnhan : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public Benhnhan(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET: api/<benhnhan>
        [HttpGet]
        public IActionResult Get()
        {
            string? connectionString = _configuration.GetConnectionString("MSSQL");
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            List<BENHNHAN> listBN = new List<BENHNHAN>();
                try
                {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from BENHNHAN";
                SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        BENHNHAN b = new BENHNHAN();
                        b.Id = (Guid)reader["id"];
                        b.Name = (string)reader["name"];
                        b.Address = (string)reader["address"];
                        b.Phone = (string)reader["phone"];
                        b.Gender = (string)reader["gender"];
                        b.Ppdt = (string)reader["ppdt"];
                        b.Time = (DateTime)reader["time"];
                        listBN.Add(b);
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            return Ok(listBN);
        }

        // POST api/<benhnhan>
        [HttpPost]
        public IActionResult Post([FromBody] BENHNHAN value)
        {
            string? connectionString = _configuration.GetConnectionString("MSSQL");
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "DECLARE @InsertedIds TABLE (InsertedId uniqueidentifier);" +
                    "INSERT INTO BENHNHAN (name, address, phone, gender, time, ppdt) " +
                    "OUTPUT INSERTED.id INTO @InsertedIds " +
                    "VALUES (@NAME, @ADDRESS, @PHONE, @GENDER, @TIME, @PPDT); " +
                    "SELECT InsertedId FROM @InsertedIds;";
                cmd.Parameters.AddWithValue("@NAME", value.Name);
                cmd.Parameters.AddWithValue("@ADDRESS", value.Address);
                cmd.Parameters.AddWithValue("@PHONE", value.Phone);
                cmd.Parameters.AddWithValue("@GENDER", value.Gender);
                cmd.Parameters.AddWithValue("@TIME", value.Time);
                cmd.Parameters.AddWithValue("@PPDT", value.Ppdt);
                Guid insertedId = (Guid)cmd.ExecuteScalar();
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(insertedId);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // PUT api/<benhnhan>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] BENHNHAN value)
        {
            string? connectionString = _configuration.GetConnectionString("MSSQL");
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE BENHNHAN SET name=@NAME, address=@ADDRESS, phone=@PHONE, gender=@GENDER, time=@TIME, ppdt=@PPDT WHERE id = @ID";
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NAME", value.Name);
                cmd.Parameters.AddWithValue("@ADDRESS", value.Address);
                cmd.Parameters.AddWithValue("@PHONE", value.Phone);
                cmd.Parameters.AddWithValue("@GENDER", value.Gender);
                cmd.Parameters.AddWithValue("@TIME", value.Time);
                cmd.Parameters.AddWithValue("@PPDT", value.Ppdt);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Ok();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // DELETE api/<benhnhan>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            string? connectionString = _configuration.GetConnectionString("MSSQL");
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM BENHNHAN WHERE id=@ID";
                cmd.Parameters.AddWithValue("@ID", id);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Ok();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
