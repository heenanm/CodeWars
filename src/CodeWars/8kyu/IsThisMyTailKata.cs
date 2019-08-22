namespace CodeWars._8kyu
{
    public class IsThisMyTailKata
    {
        public static bool CorrectTail(string body, string tail)
        {
            var sub = body[body.Length - 1];

            if (sub.ToString() == tail)
                return true;
            return false;
        }
    }
}