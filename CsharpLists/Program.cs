namespace CsharpLists
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a list to store integer scores
            List<int> playerScores = new List<int>();

            // Adding elements to the list
            playerScores.Add(10);
            playerScores.Add(20);
            playerScores.Add(30);
            playerScores.Add(40);
            playerScores.Add(50);

            // Displaying the elements in the list

            Console.WriteLine("Player scores:");
            foreach (int score in playerScores)
            {
                Console.WriteLine(score);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////


            List<int> playerScores1 = new List<int> { 10, 20, 30, 40, 50 };

            // Accessing and modifiying an element in the List

            playerScores1[2] = 35; // Modifiying the score of the third player

            // Displaying the updated list  of scores

            Console.WriteLine("Updated player scores: ");
            for (int i = 0; i < playerScores1.Count; i++)
            {
                Console.WriteLine("Player: " + (i + 1) + " score: " + playerScores1[i]);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            List<int> playerScores2 = new List<int> { 10, 20, 30, 40, 50 };

            // Inserting an element at a specific position
            playerScores2.Insert(2, 25);

            // Removing elements from the list 
            playerScores2.Remove(40); // Removes the first occurence of 40
            playerScores2.RemoveAt(0); // Removes the element at index 0

            // Displaying the list after modifications

            Console.WriteLine("Player scores after insertions and removals");
            foreach (int score in playerScores2)
            {
                Console.WriteLine(score);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            List<int> playerScores3 = new List<int> { 50, 30, 20, 40, 10 };

            // Checking if the list contains a specific score
            bool containsThirty = playerScores3.Contains(30);
            Console.WriteLine("List contains 30: " + containsThirty);

            // Finding the index of a specific score
            int indexOfForty = playerScores3.IndexOf(40);
            Console.WriteLine("Index of 40: " + indexOfForty);

            // Sorting the List

            playerScores3.Sort();
            Console.WriteLine("Sorted player scores:");

            foreach (int score in playerScores3)
            {
                Console.WriteLine(score);
            }

            // Reversing th list 
            playerScores3.Reverse();
            Console.WriteLine("Reversed player Scores:");
            foreach (int score in playerScores3)
            {
                Console.Write(score);
            }

            // Last one Clearing the list

            playerScores3.Clear();
            Console.WriteLine("\nNumber of player scores after clearing: " + playerScores3.Count);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            List<int> highScores = new List<int> { 300, 250, 200, 150, 100 };

            // Adding a new score

            highScores.Add(275);

            // Sorting the list in descending order

            highScores.Sort();
            highScores.Reverse();

            // Displaying the top 5 scores

            Console.WriteLine("Top 5 high scores:");
            for (int i = 0; i < Math.Min(5, highScores.Count); i++)
            {
                Console.WriteLine(highScores[i]);

            }

            // Removing a specific score
            highScores.Remove(150);
            Console.WriteLine("High scores after removal: \n");
            foreach (int score in highScores)
            {
                Console.Write(score);
            }

        }

    }

}