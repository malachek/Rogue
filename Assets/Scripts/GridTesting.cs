using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTesting : MonoBehaviour
{
    [SerializeField] int x;
    [SerializeField] int y;
    [SerializeField] float cellSize;
    private void Start()
    {
        Grid grid = new Grid(x, y, cellSize);
    }
}
