namespace StreamingPlatform
{
    public class Program()
    {
        private static readonly StreamingPlatform Streaming = new StreamingPlatform();
        public static void ReadMovies()
        {
            // A csv fajlokat ai segitsegevel generaltattam
            string[] sorok = File.ReadAllLines("./movies.csv");
            foreach(string sor in sorok)
            {
                string[] data = sor.Split(";");
                Video video = new(data[0], Convert.ToInt32(data[1]));
                Movie movie = new Movie(video);
                Streaming.AddContent(movie);
            }
        }

        public static void ReadSeries()
        {
            string[] sorok = File.ReadAllLines("./series.csv");
            Dictionary<string, List<Video>> sorozatok = [];
            foreach(string sor in sorok)
            {
                string[] data = sor.Split(";");
                string seriesName = data[0];
                Video episode = new(data[1], Convert.ToInt32(data[2]));
                if (!sorozatok.ContainsKey(seriesName))
                {
                    sorozatok[seriesName] = new List<Video>();
                }
                sorozatok[seriesName].Add(episode);
            };
            foreach(var sorozat in sorozatok)
            {
                Series series = new(sorozat.Key, sorozat.Value);
                Streaming.AddContent(series);
            }
        }
        public static void Main()
        {
            // Video video1 = new("video cime", 123);
            // Console.WriteLine(video1.Length);
            // Movie movie1 = new(video1);
            // Console.WriteLine(movie1.GetLength());

            // Video resz1 = new("elsoresz", 10);
            // Video resz2 = new("masodikresz", 11);
            // List<Video> reszek = new List<Video>();
            // reszek.Add(resz1);
            // reszek.Add(resz2);
            // Series series1 = new("sorozat cime 1", new Video("sorozat elso resz", 40));
            // Series series2 = new("Sorozat cime 2", reszek);
            // Console.WriteLine(series1.GetTitle());
            // Console.WriteLine(series1.GetLength());
            // Console.WriteLine(series2.GetTitle());
            // Console.WriteLine(series2.GetLength());

            // StreamingPlatform streamingPlatform = new();
            // streamingPlatform.AddContent(movie1);
            // streamingPlatform.AddContent(series1);
            // Console.WriteLine(streamingPlatform.GetLeghosszabbTatalom().GetTitle());
            ReadMovies();
            ReadSeries();
            foreach(IContent tartalom in Streaming.TartalomLista)
            {
                Console.WriteLine($"{tartalom.GetTitle()} - {tartalom.GetLength()}");
                if (tartalom is Series series)
                {
                    foreach(Video video in series.Videos)
                    {
                        Console.WriteLine($"\t{video.Title} - {video.Length}");
                    }
                    ;
                }
            }
        }
    }
}