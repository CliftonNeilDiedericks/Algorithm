namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
            int i, j,n;
            n = numbers.Length;
            int leftsum, rightsum;

         
            for (i = 0; i < n; ++i)
            {
                leftsum = 0;
                rightsum = 0;

                //sum left(preceeding)
                for (j = 0; j < i; j++)
                {
                    leftsum += numbers[j];
                }

                //sum right(proceeding)
                for (j = i + 1; j < n; j++)
                {
                    rightsum += numbers[j];
                }

                if (leftsum == rightsum)
                    return i;
            }

            //if no equivalence is found
            return -1;
        }
    }
}
