using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string FristName { get; set; }
        public string SureName { get; set; }
        public string Phone { get; set; }
        public string NIF { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime DOB { get; set; }
    }
}
