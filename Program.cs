namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size;
            int[] array;

            bool isValid = true;
            do
            {
                // Reset The value
                isValid = true;

                Console.Write("Enter a size: ");
                isValid = Int32.TryParse(Console.ReadLine(), out size);
                if (!isValid)
                {
                    Console.WriteLine("Size should not be a Character nor a Symbol!");
                    isValid = false;
                }
                else if (size <= 0)
                {
                    Console.WriteLine("Size should bigger than 0");
                    isValid = false;
                }
                else if (size > 20)
                {
                    Console.WriteLine("Size should not exceed 20");
                    isValid = false;
                }
            } while (!isValid);

            // Creating an array to hold the value
            array = new int[size];
            for (int index = 0; index < array.Length; index++)
            {
            askArrayElement:
                Console.Write("Enter element " + (index + 1) + " : ");
                isValid = Int32.TryParse(Console.ReadLine(), out array[index]);
                if (!isValid)
                {
                    Console.WriteLine("Value should not be a Character nor a Symbol!");
                    goto askArrayElement;
                }
            }

            // Print out Every ELement in the Array
            Console.Write("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + "\t");
            }
            Console.WriteLine();

            // Find The Largest Value in the Array
            int max_index = 0;

            // Start From 1 because we have examine at index 0
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] > array[max_index])
                {
                    max_index = index;
                }
            }

            int max_value = array[max_index];
            Console.WriteLine("The largest property value in the list is " + max_value + " ,at position " + max_index);
        }
    }
}