namespace StreamingPlatform
{
    public class Program()
    {
        public static void Main()
        {
            Video video1 = new("video cime", 123);
            Console.WriteLine(video1.Length);
        }
    }
}