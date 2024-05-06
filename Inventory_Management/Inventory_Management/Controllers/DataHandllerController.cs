using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using System.Text.Json;

namespace Inventory_Management.Controllers
{
    public class DataItem
    {
        public string? Name { get; set; }
        public string? Id { get; set; }
    }

    public class DataObject
    {
        public DataItem[]? Data { get; set; }
    }
    public class DataObject_Post
    {
        public List<DataItem>? Data { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class DataHandllerController : Controller
    {
        private readonly ILogger<DataHandllerController> _logger;

        public DataHandllerController(ILogger<DataHandllerController> logger)
        {
            _logger = logger;
        }

        string filePath = @"C:\Projects_Github\Inventory_Management\Inventory_Management\Data\Data.json";

        [HttpGet]
        [Route("GetData")]

        public ActionResult<DataObject> GetData()
        {


            try
            {
                // Read the JSON file content
                string jsonString = System.IO.File.ReadAllText(filePath);

                // Deserialize the JSON content into a DataObject
                DataObject? dataObject = JsonSerializer.Deserialize<DataObject>(jsonString);

                // Return the DataObject as a response
                return Ok(dataObject);
            }
            catch (FileNotFoundException)
            {
                return NotFound("File not found.");
            }
            catch (JsonException)
            {
                return BadRequest("Invalid JSON format.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }


        [HttpPost]
        [Route("AddNewOnes")]
        public IActionResult AddData([FromBody] DataItem newData)
        {
            try
            {
                // Read existing JSON content from the file
                string jsonString = System.IO.File.ReadAllText(filePath);

                // Deserialize JSON content into a list of DataItems
                //DataObject dataObject = JsonSerializer.Deserialize<DataObject>(jsonString);
                DataObject_Post? dataObject = JsonSerializer.Deserialize<DataObject_Post>(jsonString);

                // Add the new DataItem to the list

                dataObject.Data.Add(newData);

                // Serialize the updated list back to JSON format
                string updatedJsonString = JsonSerializer.Serialize(dataObject);

                // Write the updated JSON content back to the file
                System.IO.File.WriteAllText(filePath, updatedJsonString);

                return Ok("Data added successfully.");
            }
            catch (FileNotFoundException)
            {
                return NotFound("File not found.");
            }
            catch (JsonException)
            {
                return BadRequest("Invalid JSON format.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }


        }
    }

}