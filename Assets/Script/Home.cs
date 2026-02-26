using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    [Header("UI Panels & Objects")]
    public GameObject panelInstruksi;
    public GameObject btnClose;

    // Fungsi untuk tombol Play
    public void PlayGame()
    {
        // Memastikan nama scene sesuai dengan yang ada di folder Scenes Anda
        SceneManager.LoadScene("Gameplay");
    }

    // Fungsi untuk tombol Instruksi
    public void OpenInstruksi()
    {
        panelInstruksi.SetActive(true);
        btnClose.SetActive(true);
    }

    // Fungsi untuk tombol Close
    public void CloseInstruksi()
    {
        panelInstruksi.SetActive(false);
        btnClose.SetActive(false);
    }
}