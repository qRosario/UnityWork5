using System;
using System.Linq;
using UnityEngine;

public class UnityHomeWork5 : MonoBehaviour
{
    // ����� ����� ������ ����� ���������
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
        Debug.Log($"����� ������ ����� � ��������� �� 7 �� 21 = {_result}");
    }
    // ����� ����� ������ ����� � �������
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
        Debug.Log($"����� ������ ����� � �������� ������� = {_result}");
    }
    // ����� ������� ��������� ����� ������� �������
    public void OnFirstOccurrence()
    {
        int[] _array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int _result34 = Array.IndexOf(_array, 34);
        int _result55 = Array.IndexOf(_array, 55);
        Debug.Log($"������ �������� 34 = {_result34}");
        Debug.Log($"������� ������� 55 �� ������ = {_result55}");
    }

    // ����� ������� �������� ����� ���� ���� ���������
    //    public void OnFirstOccerenceVer2()
    //    {
    //        int[] _array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
    //        int _result34 = FirstOccurrence(_array, 34);
    //        int _result55 = SecondOccurrence(_array, 55);
    //        Debug.Log($"������ ����� 34 = {_result34}\n \t������ ����� 55 = {_result55}");
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
