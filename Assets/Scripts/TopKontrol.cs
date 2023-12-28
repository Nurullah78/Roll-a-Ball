using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public Rigidbody fizik;
    
    public int hiz;
    public int puan;
    public int objeSayisi;

    public Text puanText;
    public Text oyunBittiText;

    private void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vector * hiz);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);

        puan++;
        puanText.text = "Puan: " + puan;

        if (puan == objeSayisi)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
    }
}
