using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        var mv = other.gameObject.GetComponent<Movement>();
        if (mv == null) return;
        mv.SpeedUp();
        FindObjectOfType<Generator>().Generate();
        Destroy(gameObject);
    }
}