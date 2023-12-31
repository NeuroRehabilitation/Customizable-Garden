using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;

//Script used to control the keyboard that is used to enter the username and set the log even for the user login
public class KeyboardScript : MonoBehaviour
{
    public GameObject inputField;
    public GameObject stateController;
    public GameObject canvas;

    public void tapLetter(string Letter)
    {
        inputField.GetComponent<TMP_InputField>().text = inputField.GetComponent<TMP_InputField>().text + Letter;
    }

    public void deleteLetter()
    {
        string currentText = inputField.GetComponent<TMP_InputField>().text;
        if (currentText.Length > 0) {
            inputField.GetComponent<TMP_InputField>().text = currentText.Substring(0, currentText.Length - 1);
        }

    }


    void Update()
    {
        
    }
}
