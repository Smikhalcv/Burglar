using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float startTime;
    public int intervalTime;

    /// <summary>
    /// ������������ ������� �������
    /// </summary>
    /// <returns>int ���� ������ 0 ����� 0</returns>
    public int LimitTime()
    {
        if (startTime + intervalTime - Time.time > 0)
        {
            return Convert.ToInt32(Math.Round(startTime + intervalTime - Time.time));
        }
        return 0;
    }
}
