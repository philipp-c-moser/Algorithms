package de.philippmoser._01_BinarySearch;

public class Main
{

    public static void main(String args[])
    {

        System.out.println("01 Binary Search");

        int[] searchList = { 4, 2, 6, 9, 1, 7, 5, 3 };

    }


    private static Integer binarySearch(int[] list, int item)
    {

        int lowest = 0;
        int highest = list.length -1;

        while(lowest <= highest)
        {
            int middle = (lowest + highest) / 2;
            int guess = list[middle];

            if(guess == item)
            {
                return middle;
            }

            if(guess > item)
            {
                highest = middle -1;
            }
            else
            {
                lowest = middle + 1;
            }
        }

        return null;
    }

}
