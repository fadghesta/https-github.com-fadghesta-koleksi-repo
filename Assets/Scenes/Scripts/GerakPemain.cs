using UnityEngine;

public class GerakPemain : MonoBehaviour
{
    [SerializeField] private float kecepatan = 5f;

    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal"); // Kiri-Kanan
        float inputVertikal = Input.GetAxis("Vertical");     // Depan-Belakang

        Vector3 arah = new Vector3(inputHorizontal, 0f, inputVertikal).normalized;
        transform.Translate(arah * kecepatan * Time.deltaTime, Space.World);
    }
}