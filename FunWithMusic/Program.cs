using System;
namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Classical,
            Jazz,
            Pop,
            Metal,
            Reggae
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            //public void setArtist(string artist)
            //{
            //    Artist = artist;
            //}
            //public void setAlbum(string album)
            //{
            //    Album= album;
            //}
            public void setLength(string length)
            {
                Length = length;
            }
            //public void setGenre(Genre genre)
            //{
            //    Genre = genre;
            //}
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What album is it on?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the song length?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What genre of music?");
            Console.WriteLine("C - Classical\nJ - Jazz\nP - Pop\nM - Metal\nR - Reggae");
            Genre tempGenre = Genre.Classical;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'C':
                    tempGenre = Genre.Classical;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'R':
                    tempGenre = Genre.Reggae;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music newMusic = music;
            Console.WriteLine("What is the name of another song on the same album?");
            newMusic.setTitle(Console.ReadLine());
            Console.WriteLine("What is the length of the song?");
            newMusic.setLength(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Song #1:");
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine();
            Console.WriteLine("Song #2:");
            Console.WriteLine($"{newMusic.Display()}");
        }
    }
}