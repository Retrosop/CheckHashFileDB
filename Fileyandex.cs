using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowHashFileNew
{
    public class Fileyandex
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string fileyandex { get; set; }
        [Required]
        public string sizeyandex { get; set; }

        [Required]
        public string mime_typeyandex { get; set; }

        [Required]
        public int idymail { get; set; }

        [Required]
        public string pathyandex { get; set; }

        [Required]
        public string md5yandex { get; set; }

        [Required]
        public string sha256yandex { get; set; }

        [Required]
        public string nameyandex { get; set; }

        [Required]
        public int iditem { get; set; }

        [Required]
        public string contentrf { get; set; }

        [Required]
        public string content_error { get; set; }

    }
    public class Meteostation
    {
        [Key]
        public int Idmeteostation { get; set; }
        [Required]
        public int station { get; set; } //Index VMO meteostation
        [Required]
        public string name { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string alt { get; set; }
        public bool active { get; set; }
        public int admin_code { get; set; }

    }

}
