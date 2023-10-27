using System;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    [SerializeField] private Simulation _simulation;
    private void Awake()
    {
        OnRectTransformDimensionsChange();
    }
    private void OnRectTransformDimensionsChange()
    {
        _simulation.Init();
    }
}
