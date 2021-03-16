using System;


namespace CpDatabaseAccess
{
    class MovieEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Slogan { get; set; }

        public string Link { get; set; }

        public int StudioId { get; set; }

        public int CertificationId { get; set; }
    }
}
