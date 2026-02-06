using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 30)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < -10 )
        {
            Destroy(gameObject);
        }
    }
}
