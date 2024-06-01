using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("How to cook a salmon", "Robert R", 400));
        videos.Add(new Video("Moonlight Sonata","Beethoven's biggest fan", 900));
        videos.Add(new Video("The History of the Wall of China (short version)", "Dr. China", 30));
        videos[0].GenerateComment("Billy", "Gross!");
        videos[0].GenerateComment("Bob","Thank you for the instructions!");
        videos[0].GenerateComment("Mr. Hungry","You are making my mouth water!");
        videos[1].GenerateComment("Wolfgang","So inspiring!");
        videos[1].GenerateComment("Ludwig","Copycat!");
        videos[1].GenerateComment("Sebastian","Simply marvelous!");
        videos[2].GenerateComment("Mr Gu","很好！");
        videos[2].GenerateComment("Mrs. Shen", "对了，谢谢你！");
        videos[2].GenerateComment("Chen Kangdi","So cool!");

        foreach (Video v in videos)
        {
            v.DisplayInformation();
        }
    }
}