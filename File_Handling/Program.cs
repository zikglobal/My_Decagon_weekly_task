namespace File_Handling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            
                
                var myFile = new FileStream("C:\\Users\\Decagon Laptop\\Zik.txt", FileMode.OpenOrCreate);
                Console.WriteLine("File was successfully created");

                var write = new StreamWriter(myFile);

            var writer = new StreamWriter(myFile);
            string? n = Console.ReadLine();
            writer.WriteLine(n);

            writer.WriteLine("isaac is a boss");
            writer.WriteLine("isaac is a boss");

            var reader = new StreamReader(myFile);
            Console.WriteLine(reader.ReadToEnd());

            write.Close();
            myFile.Close();




            
        }
    }
}