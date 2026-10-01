using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float minSpeed = 50f;
    public float maxSpeed = 100f;

    public float minScale = 1.0f;
    public float maxScale = 3.5f;

    void Start()
    {
        float randomSize = Random.Range(minScale, maxScale);
        transform.localScale = new Vector3(randomSize, randomSize, 1f);
    }



}