using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] string word;
    [SerializeField] Text wordField;
    [SerializeField] InputField inputField;
    [SerializeField] string letters = "";
    [SerializeField] int attempts;
    [SerializeField] Text attemptsText;
    [SerializeField] Button checkButton;
    // Start is called before the first frame update
    void Start()
    {
        //attemptsText.text = attempts.ToString();
        ShowWord();
    }

    private void ShowWord()
    {
        string output = "";
        foreach (char ch in word)
        {
            if (letters.Contains(ch.ToString())) output += ch;
            else output += "*";
        }
        wordField.text = output;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) CheckLetter();
    }

    public void CheckLetter()
    {
        string letter = inputField.text;
        inputField.text = "";
        inputField.ActivateInputField();
        letters += letter;

        ShowWord();

        if(!word.Contains(letter)) LoseAttempt();
        if (wordField.text.Equals(word)) FinishGame("Победа");
        else if (attempts <= 0) FinishGame("Поражение");
    }

    void LoseAttempt()
    {
        attempts--;
        attemptsText.text = attempts.ToString();
    }

    void FinishGame(string text)
    {
        wordField.text = text;
        inputField.interactable = false;
        checkButton.interactable = false;
    }
}
