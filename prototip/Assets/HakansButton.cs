using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HakansButton : MonoBehaviour
{
    public Button hButton;        // Buton
    public TMP_Text buttonText;   // Buton üzerindeki yazý
    public TMP_Text mesajText;    // Ekranda çýkacak yazý

    void Start()
    {
        // Butona týklayýnca HakanMesajGoster fonksiyonu çalýþsýn
        hButton.onClick.AddListener(HakanMesajGoster);
    }

    void HakanMesajGoster()
    {
        mesajText.text = "Hakan bacýn yanýmda zaaaxd";
    }
}
