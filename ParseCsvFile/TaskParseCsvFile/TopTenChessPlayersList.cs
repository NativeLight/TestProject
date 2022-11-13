namespace ParseCsvFile.TaskParseCsvFile { 
    class TopTenChessPlayersList
    {
        static string topTenPlayers;

        public static void Main(string[] args)
        {
            TopTenPlayers();
        }

        private static void TopTenPlayers()
        {
            LogManager.Logger.CreateLogger();
            string[] csvLines =
                File.ReadAllLines(@"D:\CodeProjects\ItechartTestProject\ParseCsvFile\Resources\Top100ChessPlayers.csv");
            
            var firstName = new List<string>();
            var birthYear = new List<double>();
            
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] rowData = csvLines[i].Split(';');
                Double birthYearData = Convert.ToDouble(rowData[6]);
                firstName.Add(rowData[1]);
                birthYear.Add(birthYearData);
            }
           
            for (int i = 0; i <= 10; i++)
            {
                if (birthYear[i] > 1980)
                {
                    topTenPlayers += "[" + firstName[i] + " " + birthYear[i] + "]";
                }
            }
            Serilog.Log.Information(topTenPlayers);
        }
    }
}
