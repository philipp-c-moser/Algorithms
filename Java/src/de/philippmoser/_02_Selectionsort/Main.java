package de.philippmoser._02_Selectionsort;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main
{

    public static void main(String args[])
    {
        System.out.println("02 Selectionsort");

        List<Integer> sortingList = new ArrayList<>(Arrays.asList(50, 12, 72, 48, 12, 84, 3, 13, 35));

        System.out.println(selectionSort(sortingList));

    }


    private static List<Integer> selectionSort(List<Integer> list)
    {
        List<Integer> finalList = new ArrayList<>(list.size());

        int listSize = list.size();

        for(int i = 0; i < listSize; i++)
        {
            int smallest = findSmallestFrom(list);

            finalList.add(list.get(smallest));

            list.remove(smallest);
        }

        return finalList;
    }


    private static int findSmallestFrom(List<Integer> list)
    {
        int valueOfSmallest = list.get(0);
        int indexOfSmallest = 0;

        for(int i = 0; i < list.size(); i++)
        {
            if(list.get(i) < valueOfSmallest)
            {
                valueOfSmallest = list.get(i);
                indexOfSmallest = i;
            }
        }

        return indexOfSmallest;
    }

}