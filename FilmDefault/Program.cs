using System;

namespace FilmDefault
{
    internal class Program
    {
        private enum GenreVanDeFilm
        {
            None, Drama, Comedy, Action, Horror, Thriller, Crime, Adventure,
            ScienceFiction, Western, Romance, Fantasy, Musical, Historical, Documentary, Family,
            Spy, Melodrama, Animation, Erotic, Education
        };

        private static void FilmRuntime(string filmnaam, int minuten = 90, GenreVanDeFilm genre = GenreVanDeFilm.Action)
        {
            Console.WriteLine($"{filmnaam} ({minuten}minuten, {genre})");
        }

        private static void Main(string[] args)
        {
            FilmRuntime("The Matrix", 136, genre: GenreVanDeFilm.ScienceFiction);
            FilmRuntime("The Matrix", minuten: 120);
            FilmRuntime("The Matrix");
        }
    }
}