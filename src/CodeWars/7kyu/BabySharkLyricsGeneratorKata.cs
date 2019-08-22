namespace CodeWars._7kyu
{
    public class BabySharkLyricsGeneratorKata
    {
        public static string BabySharkLyrics()
        {
            string G = "Grand", S = " shark", D = " doo", s = "";
            var x = new[] {"Baby" + S, "Mommy" + S, "Daddy" + S, G + "ma" + S, G + "pa" + S, "Let's go hunt"};
            for (var i = 0; i < 6; i++)
            {
                for (var j = 0; j < 3; j++)
                    s += x[i] + "," + D + D + D + D + D + D + "\n";
                s += x[i] + "!\n";
            }
            return s + "Run away,…\n";
        }
    }
}


//string G = "Grand", S = " shark", D = " doo", s = "";
//foreach(var _ in new[]{"Baby"+S,"Mommy"+S,"Daddy"+S,G+"ma"+S,G+"pa"+S,"Let's go hunt"}) {
//var b = _ + "," + D + D + D + D + D + D + "\n";
//s+=b+b+b+_+"!\n";
//}
//return s+"Run away,…\n";