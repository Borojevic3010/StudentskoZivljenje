using System;

namespace StudentskoZivljenje.Models
{
	public class Student
    { 	
        public int studentID {  get; set; }
        public string ime { get; set; }
        public string priimek { get; set; }
        public DateTime dob { get; set; }
		public string naslov { get; set; }
		public string telefon { get; set; }
        public IFormFile File { get; set; }
        public string FilePath { get; set; }

        public string ocena { get; set; }

        public StipendijaViewModel stipendijaViewModel;
		public HobiViewModel hobiViewModel;
        public VpisTecajViewModel vpisTecajViewModel;
        public DomViewModel domViewModel;
        public RegistracijaViewModel registracijaViewModel;
	}
}
