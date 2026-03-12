using UnityEngine;

public class BelajarDasar : MonoBehaviour
{
    // Dipanggil 1x saat tombol Play ditekan
    void Start()
    {
        Debug.Log("Game Dimulai!");
    }

    // Dipanggil terus-menerus setiap frame (sangat cepat)
    void Update()
    {
        // Hati-hati: Jangan taruh logika berat di sini
        // Debug.Log("Saya dipanggil setiap saat"); 
    }
}