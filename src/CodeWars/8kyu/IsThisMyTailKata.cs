namespace CodeWars._8kyu
{
    public class IsThisMyTailKata
    {
        public static bool CorrectTail(string body, string tail)
        {
            var sub = body[body.Length - 1];

            return sub.ToString() == tail;
        }
    }
}