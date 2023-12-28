using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public GameObject top;
    public Vector3 aradakiFark;

    private void Start()
    {
        aradakiFark = transform.position - top.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = top.transform.position + aradakiFark;
    }
}
