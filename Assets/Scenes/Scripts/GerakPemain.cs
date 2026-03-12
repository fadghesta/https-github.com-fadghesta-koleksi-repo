using UnityEngine;

public class GerakPemain : MonoBehaviour
{
    public float kecepatan = 5f;

    void Update()
    {
        // Mengambil input dari keyboard (A, D, W, S)
        float inputHorizontal = Input.GetAxis("Horizontal"); // Kiri-Kanan
        float inputVertikal = Input.GetAxis("Vertical");     // Depan-Belakang

        // Menghitung arah gerak
        Vector3 arah = new Vector3(inputHorizontal, 0, inputVertikal);

        // Menggerakkan objek
        transform.Translate(arah * kecepatan * Time.deltaTime);
    }
}