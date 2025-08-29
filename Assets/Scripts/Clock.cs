using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Clock : MonoBehaviour
{
    [SerializeField]
    private GameObject S, M, H;
    private float secondsMultiplier = 1f;
    private int inGameSeconds;

    private int timeAtStart = 0;

    void Update()
    {
        inGameSeconds = Mathf.RoundToInt(Time.time * secondsMultiplier) + timeAtStart;
        S.transform.localRotation = Quaternion.Euler(0, 0, inGameSeconds * -360 / 60);
        int inGameMinutes = Mathf.FloorToInt(inGameSeconds / 60f);
        M.transform.localRotation = Quaternion.Euler(0, 0, inGameMinutes * -360 / 60);
        H.transform.localRotation = Quaternion.Euler(0, 0, inGameSeconds * -360 / 43200);
    }
}