using UnityEngine;

public class Conflictvermijden : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Transform child in transform)
        {
            Instantiate(child, transform);
        }
        Instantiate(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // doe een conflict
}
