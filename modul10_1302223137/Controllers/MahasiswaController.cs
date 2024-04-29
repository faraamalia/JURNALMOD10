using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223137.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        { 
            new Mahasiswa ("Farah Amalia Putri", "1302223137",new List<string>{"KPL","PBO","BD"}, 2022),
            new Mahasiswa ("Faris Azhar Dwiputra", "1302223123", new List<string>{"KPL","PBO","BD"}, 2022),
            new Mahasiswa ("Wildan Syukri Ni'am", "1302220005", new List<string>{"KPL","PBO","BD"}, 2022),
            new Mahasiswa ("Muhammad Bintang Al-Fath", "1302223099", new List<string>{"KPL","PBO","BD"}, 2022),
            new Mahasiswa ("Arga Adolf Lumunon", "1302223038", new List<string>{"KPL","PBO","BD"}, 2022),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        //GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }

        //POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswaList.Add(value);
        }
    }

}

