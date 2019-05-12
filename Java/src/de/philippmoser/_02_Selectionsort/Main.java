package de.philippmoser._02_Selectionsort;

import java.util.ArrayList;
import java.util.List;

public class Main
{

    public static void main(String args[])
    {
        System.out.println("02 Selectionsort");

        List<Integer> sortingList = new ArrayList<>();

        sortingList.add(50);
        sortingList.add(12);
        sortingList.add(72);
        sortingList.add(48);
        sortingList.add(12);
        sortingList.add(84);
        sortingList.add(3);
        sortingList.add(13);
        sortingList.add(35);


        System.out.println(selectionSort(sortingList));

    }


    private static List<Integer> selectionSort(List<Integer> list)
    {
        List<Integer> finalList = new ArrayList<>(list.size());

        for(int i = 0; i < list.size(); i++)
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