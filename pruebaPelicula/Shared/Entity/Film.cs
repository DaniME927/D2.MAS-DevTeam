using System;
namespace pruebaPelicula.Shared.Entity
{
    public class Film
    {
        public Film(int filmID, string filmName, string filmLanguage, string filmDuration, string filmCast, string filmCategory, DateTime releaseDate, string uRLFilmImage, string filmDescription, string uRLFilmTrailer, int filmRate) 
        {
            this.FilmID = filmID;
            this.FilmName = filmName;
            this.FilmLanguage = filmLanguage;
            this.FilmDuration = filmDuration;
            this.FilmCast = filmCast;
            this.FilmCategory = filmCategory;
            this.ReleaseDate = releaseDate;
            this.URLFilmImage = uRLFilmImage;
            this.FilmDescription = filmDescription;
            this.URLFilmTrailer = uRLFilmTrailer;
            this.FilmRate = filmRate;
        }

        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public string FilmLanguage { get; set; }
        public string FilmDuration { get; set; }
        public string FilmCast { get; set; }
        public string FilmCategory { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string URLFilmImage { get; set; }
        public string FilmDescription { get; set; }
        public string URLFilmTrailer { get; set; }
        public int FilmRate { get; set; }
    }
}