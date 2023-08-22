using FileTask;

string choice = Console.ReadLine().Trim().ToLower();

            object instance;

            switch (choice)
            {
                case "word":
                    instance = new MainPrintFile(new Word());
                    break;
                case "excel":
                    instance = new MainPrintFile(new Excel());
                    break;
                case "pdf":
                    instance = new MainPrintFile(new PDF());
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter Word, Excel, PDF.");
                    continue;
            }

            ((MainPrintFile)instance).Print();
        }
    }
}
