using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Generator : MonoBehaviour
{
    public GameObject food;
    public void Generate()
    {
        var x = Random.Range(-8.5f, 8.5f);
        var y = Random.Range(-5.5f, 5.5f);
        Instantiate(food, new Vector3(x, y, 0), Quaternion.identity);
    }

    private void Start()
    {
        // Generate();
    }
}
