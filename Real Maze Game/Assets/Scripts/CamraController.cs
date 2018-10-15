using UnityEngine;

public class CamraController : MonoBehaviour
{

    public GameObject You;
    public Vector3 offset;

    public void Start()
    {
        offset = transform.position - You.transform.position;
    }

    public void LateUpdate()
    {
        transform.position = You.transform.position + offset;
    }
}
