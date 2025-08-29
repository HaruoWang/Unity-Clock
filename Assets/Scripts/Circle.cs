using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Circle : MonoBehaviour
{
    [SerializeField]
    private LineRenderer Line;
    [SerializeField]
    [Range(3, 12)]
    private int Edge = 12;
    [SerializeField]
    private float R = 5f;

    void Start()
    {
        Line.loop = true;
    }

    void Update()
    {
        float angleStep = 2f * Mathf.PI / Edge;
        Line.positionCount = Edge;

        for (int i = 0; i < Edge; i++)
        {
            float X = R * Mathf.Cos(angleStep * i);
            float Y = R * Mathf.Sin(angleStep * i);

            Vector3 linePos = new Vector3(X, Y, 0f);
            Line.SetPosition(i, linePos);
        }
    }
}
