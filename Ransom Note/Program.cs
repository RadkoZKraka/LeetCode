using System.Linq;

namespace Ransom_Note
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var magList = magazine.ToList();
            var noteList = ransomNote.ToList();
            foreach (var c in noteList)
            {
                if (!magList.Contains(c)) return false;
                magList.Remove(c);
            }

            return true;
        }
    }
}