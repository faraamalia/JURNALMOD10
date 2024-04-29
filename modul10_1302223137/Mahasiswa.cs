namespace modul10_1302223137.Controllers
{

    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa(string Nama, string Nim, List<string> Course, int Year)
        {
            this.Nama = Nama;
            this.Nim = Nim;
            this.Course = Course;   
            this.Year = Year;
        }
    }
}