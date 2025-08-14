using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HakansButton : MonoBehaviour
{
    public Button hButton;        // Buton
    public TMP_Text buttonText;   // Buton �zerindeki yaz�
    public TMP_Text mesajText;    // Ekranda ��kacak yaz�

    void Start()
    {
        // Butona t�klay�nca HakanMesajGoster fonksiyonu �al��s�n
        hButton.onClick.AddListener(HakanMesajGoster);
    }

    void HakanMesajGoster()
    {
        mesajText.text = "Hakan bac�n yan�mda zaaaxd";
    }
}
