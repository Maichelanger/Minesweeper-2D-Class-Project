using TMPro;
using UnityEngine;

public class Cell : MonoBehaviour
{
    private TMP_Text cellText;
    private int x, y;
    private bool isBomb;
    private bool isClicked;

    private void Start()
    {
        cellText = GetComponentInChildren<TMP_Text>();
    }

    #region "Setters and Getters"

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }
    public bool IsBomb
    {
        get { return isBomb; }
        set { isBomb = value; }
    }

    #endregion

    private void SetText(string text)
    {
        cellText.text = text;
    }

    public void OnMouseDown()
    {
        if (!Generator.Instance.IsWinner && isClicked)
        {
            return;
        }

        if (isBomb)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            Generator.Instance.SetIsWinner(false);
            Generator.Instance.EndGame();
            Debug.Log("You are loser.");
        }
        else
        {
            isClicked = true;
            SetText(Generator.Instance.CalculateBombsAround(x, y).ToString());
            Generator.Instance.CheckWinner();
        }
    }
}
