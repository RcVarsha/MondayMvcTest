using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MondayMvcTest.Models
{
    public class Moviedetail
    {
        public int Id { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string DirectorName { get; set; }
        [Required]
        public string GenreName { get; set; }
        [Required]
        public string ReleaseDate { get; set; }
        public List<Moviedetail> GetMovieDetails()
        {
            return new List<Moviedetail>
         {
         new Moviedetail{Id=1, MovieName="KGF",DirectorName="PrashathNeel",GenreName="Action",ReleaseDate= "14-4-2022"},
         new Moviedetail{Id=2, MovieName="Kantara",DirectorName="Rishab Shetty",GenreName="Thriller",ReleaseDate="30-9-2022"},
         };

       }
    }
}