using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject cell;
    [SerializeField] private GameObject endGameCanvas;
    [SerializeField] private TextMeshProUGUI endGameText;
    [SerializeField] private int easyWidth, easyHeight;
    [SerializeField] private int easyBombsNumber;
    [SerializeField] private int mediumWidth, mediumHeight;
    [SerializeField] private int mediumBombsNumber;
    [SerializeField] private int hardWidth, hardHeight;
    [SerializeField] private int hardBombsNumber;

    public void StartEasy()
    {
        Generator generator = gameObject.AddComponent<Generator>();
        generator.SetGenerator(easyWidth, easyHeight, easyBombsNumber, endGameCanvas, endGameText, cell);
    }

    public void StartMedium()
    {
        Generator generator = gameObject.AddComponent<Generator>();
        generator.SetGenerator(mediumWidth, mediumHeight, mediumBombsNumber, endGameCanvas, endGameText, cell);
    }

    public void StartHard()
    {
        Generator generator = gameObject.AddComponent<Generator>();
        generator.SetGenerator(hardWidth, hardHeight, hardBombsNumber, endGameCanvas, endGameText, cell);
    }
}
