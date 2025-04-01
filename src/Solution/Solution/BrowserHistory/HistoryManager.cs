using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.BrowserHistory
{
    public class HistoryManager
    {
        private List<string> history = new List<string>();
        private int currentIndex = -1;

        public void KunjungiHalaman(string halaman)
        {
            if (currentIndex < history.Count - 1)
            {
                history.RemoveRange(currentIndex + 1, history.Count - currentIndex - 1);
            }

            history.Add(halaman);
            currentIndex++;
            Console.WriteLine($"Mengunjungi halaman: {halaman}");
        }
        public string LihatHalamanSaatIni()
        {
            if (currentIndex >= 0 && currentIndex < history.Count)
            {
                return history[currentIndex];
            }
            return "Tidak ada halaman.";
        }
        public string Kembali()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                return history[currentIndex];
            }
            return "Tidak ada halaman sebelumnya.";
        }
        public void TampilkanHistory()
        {
            foreach (var page in history)
            {
                Console.WriteLine(page);
            }
        }
    }
}
