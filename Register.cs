namespace Voting
{
    public class Register
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\votingLog.txt";

        public Register(string username)
        {
            if (!File.Exists(path))
                File.Create(path).Close();

            using (StreamWriter sr = new StreamWriter(path, append: true))
            {
                sr.WriteLine("\n{0}", username);
            }

        }
        static public bool Login(string username)
        {
            if (!File.Exists(path))
                File.Create(path).Close();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    if (sr.ReadLine().Contains(username))
                        return true;
                return false;
            }
        }
    }
    class Voting_
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\votingLog1.txt";
        public Voting_(int vote)
        {
            if (!File.Exists(path))
                File.Create(path).Close();
            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                sw.WriteLine("\n{0}", vote);
            }
        }
        public static string getResult()
        {
            double spor = 0, kitap = 0, sinema = 0, teknoloji = 0;
            string res = "";

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    switch (sr.ReadLine().TrimEnd().TrimStart())
                    {
                        case "1": spor++; break;
                        case "2": teknoloji++; break;
                        case "3": sinema++; break;
                        case "4": kitap++; break;

                        default: break;
                    }
                res = String.Format($"\nSonuçlar;" +
                $"\nSpor -> %{spor / (spor + kitap + sinema + teknoloji) * 100}" +
                $"\nTeknoloji -> %{teknoloji / (spor + kitap + sinema + teknoloji) * 100}" +
                $"\nSinema -> %{sinema / (spor + kitap + sinema + teknoloji) * 100}" +
                $"\nKitap -> %{kitap / (spor + kitap + sinema + teknoloji) * 100}");
            }
            return res;
        }
    }
}
