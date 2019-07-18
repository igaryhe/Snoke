using UnityEngine;
using Random = UnityEngine.Random;

public class Generator : MonoBehaviour
{
    public GameObject[] foods;
    public void Generate()
    {
        var x = Random.Range(-6f, 6f);
        var y = Random.Range(-4f, 4f);
        var random = new System.Random();
        var i = random.Next(2);
        Instantiate(foods[i], new Vector3(x, y, 0), Quaternion.identity);
    }

    private void Start()
    {
        Generate();
    }
}
