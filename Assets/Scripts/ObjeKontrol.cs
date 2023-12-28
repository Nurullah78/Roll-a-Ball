using UnityEngine;

public class ObjeKontrol : MonoBehaviour
{
    private Vector3 _vector;
    
    private void Start()
    {
        _vector = new Vector3(15, 30 ,45);
    }

    private void Update()
    {
        transform.Rotate(_vector*0.02f);
    }
}
