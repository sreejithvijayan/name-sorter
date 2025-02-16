
namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Validate input arguments
            if (args.Length != 1)
            {
                Console.WriteLine("Argument missing. Please use as : name-sorter <file-path>");
                return;
            }

            string inputFilePath = args[0];
            string outputFilePath = "sorted-names-list.txt";

            try
            {
                // Read names from input file
                if (!File.Exists(inputFilePath))
                {
                    Console.WriteLine($"Error: File '{inputFilePath}' not found.");
                    return;
                }
                var unsortedListFile = File.ReadAllText(inputFilePath);
                var unsortedList = unsortedListFile.Split("\n").ToList(); // Split the names by new line
                var sortedList = NameSorterService.SortNames(unsortedList);  // Sort names
                foreach (var name in sortedList)
                {
                    Console.WriteLine(name);
                }
                // Write (or overwrite) sorted names to the output file.
                File.WriteAllLines(outputFilePath, sortedList);
                Console.WriteLine($"\nNames have been sorted and saved to '{outputFilePath}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
