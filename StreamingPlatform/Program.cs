namespace StreamingPlatform
{
    public class Program()
    {
        public static void Main()
        {
            Video video1 = new("video cime", 123);
            Console.WriteLine(video1.Length);
            Movie movie1 = new(video1);
            Console.WriteLine(movie1.GetLength());

            Video resz1 = new("elsoresz", 10);
            Video resz2 = new("masodikresz", 11);
            List<Video> reszek = new List<Video>();
            reszek.Add(resz1);
            reszek.Add(resz2);
            Series series1 = new("sorozat cime 1", new Video("sorozat elso resz", 40));
            Series series2 = new("Sorozat cime 2", reszek);
            Console.WriteLine(series1.GetTitle());
            Console.WriteLine(series1.GetLength());
            Console.WriteLine(series2.GetTitle());
            Console.WriteLine(series2.GetLength());

            StreamingPlatform streamingPlatform = new();
            streamingPlatform.AddContent(movie1);
            streamingPlatform.AddContent(series1);
            Console.WriteLine(streamingPlatform.GetLeghosszabbTatalom().GetTitle());
        }
    }
}