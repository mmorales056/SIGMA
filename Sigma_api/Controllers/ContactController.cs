using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Sigma_api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigma_api.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly string connectionStrig = "server=178.128.146.252;user id=admin_sigmauser;password=pfaDKIJyPF;port=3306;database=admin_sigmatest;";

        [HttpPost]
        public IActionResult AddContact(Contacts contact)
        {
            int result = 0;
            using (var connection = new MySqlConnection(connectionStrig))
            {
                var sql = "insert into contacts (name,email,state,city)" + " values (@name,@email,@state,@city)";
                result = connection.Execute(sql, contact);
            }

            return Ok(result);

        }
    }

    }
