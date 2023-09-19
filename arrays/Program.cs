using System;
public static class JaggedArrayExtensions
{
    public static void AddValue(this int[][] jaggedArray, int index, int value)
    {
        if (index >= 0 && index < jaggedArray.Length)
        {
            int[] row = jaggedArray[index];
            int newRowLength = (row != null) ? row.Length + 1 : 1;
            int[] newRow = new int[newRowLength];

            if (row != null)
            {
                Array.Copy(row, newRow, row.Length);
            }

            newRow[newRowLength - 1] = value;
            jaggedArray[index] = newRow;
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
    }
}


public static class JaggedArrayExtensions2
{
    public static int[][] AddValue(this int[][] jaggedArray, int value)
    {
        int[][] newArray = new int[jaggedArray.Length + 1][];
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            newArray[i] = jaggedArray[i];
        }

        newArray[jaggedArray.Length] = new int[] { value };
        return newArray;
    }
}


