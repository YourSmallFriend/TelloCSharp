using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace DataBaseLibrary1
{
    public class DataBaseHelper
    {
        //maak de conectie met de database
        string connectionString = "Server=localhost;Database=sakila;user=root;";

        //dit is een helper class die de database connectie regelt
        public void SaveVliegpad()
        {
            //creeer een nieuw vliegpad en sla deze op in de database
        }

    }
}
