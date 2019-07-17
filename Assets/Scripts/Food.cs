using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Some one stuck into me!");
        var bc = other.gameObject.GetComponent<BodyController>();
        bc.Increase();
        FindObjectOfType<Generator>().Generate();
        Destroy(gameObject);
    }
}
