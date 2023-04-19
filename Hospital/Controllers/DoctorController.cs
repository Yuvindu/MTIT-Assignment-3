using Microsoft.AspNetCore.Mvc;
using Doctor.Services;
using Doctor.DoctorInfo;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Doctor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService ?? throw new ArgumentNullException(nameof(doctorService));
        }


        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns>return the list of students</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_doctorService.GetDoctors());
        }

        /// <summary>
        /// Get student by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the student with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _doctorService.GetDoctor(id) != null ? Ok(_doctorService.GetDoctor(id)) : NoContent();
        }

        /// <summary>
        /// Add students
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns>Return the added student</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Doctor doctor)
        {
            return Ok(_doctorService.AddDoctor(doctor));
        }

        /// <summary>
        /// Update the student
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns>Return the updated student</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Doctor doctor)
        {
            return Ok(_doctorService.UpdateDoctor(doctor));
        }

        /// <summary>
        /// Delete the student with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _doctorService.DeleteDoctor(id);

            return result.HasValue & result == true ? Ok($"doctor with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the doctor with ID:{id}.");
        }
    }
}
