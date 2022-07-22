using System;
using System.Linq;
using UnityEngine;

public class UnityHomeWork5 : MonoBehaviour
{
    // Поиск суммы четных чисел диапазона
    public void SumEvenNumbersInRange()
    {
        int _result = 0;
        int[] _array = Enumerable.Range(7, 14).ToArray();
        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] % 2 == 0)
            {
                _result += _array[i];
            }
        }
        Debug.Log($"Сумма четных чисел в диапозоне от 7 до 21 = {_result}");
    }
    // Поиск суммы четных чисел в массиве
    public void SumEvenNumbersInArray()
    {
        int[] _array = { 81, 22, 13, 54, 10, 34, 15, 26, 68, 71 };
        int _result = 0;

        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] % 2 == 0)
            {
                _result += _array[i];
            }
        }
        Debug.Log($"Сумма четных чисел в заданном массиве = {_result}");
    }
    // Поиск индекса указанных чисел рабочий вариант
    public void OnFirstOccurrence()
    {
        int[] _array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int _result34 = Array.IndexOf(_array, 34);
        int _result55 = Array.IndexOf(_array, 55);
        Debug.Log($"Индекс элемента 34 = {_result34}");
        Debug.Log($"Элемент массива 55 не найден = {_result55}");
    }

    // Поиск индекса указнных чисел если надо посложнее
    //    public void OnFirstOccerenceVer2()
    //    {
    //        int[] _array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
    //        int _result34 = FirstOccurrence(_array, 34);
    //        int _result55 = SecondOccurrence(_array, 55);
    //        Debug.Log($"Индекс числа 34 = {_result34}\n \tИндекс числа 55 = {_result55}");
    //    }

    //    private int FirstOccurrence(int[] array, int value)
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            if (array[i] == value)
    //            {
    //                return i;
    //            }
    //        }
    //        return -1;
    //    }
    //    private int SecondOccurrence(int[] array, int value)
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            if (array[i] == value)
    //            {
    //                return i;
    //            }
    //        }
    //        return -1;
    //    }
}
