using System.Collections;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    //DLG = Dialogue
    public bool showDlg;
    public string[] dlgText;
    //scr = Screen
    public Vector2 scr;
    public int index,optionsIndex;
    void Start()
    {

    }

    //Code version of Canvas
    //OnGUI runs along side Update
    void OnGUI()
    {
       if(showDlg)
        {
            if (scr.x != Screen.width / 16 || scr.y != Screen.height / 9)
            {
                scr.x = Screen.width / 16;
                scr.y = Screen.height / 9;
            }
            //GUI Element of Type Box
            //new Rectangular Position and Size
            //Pos X, Pos Y, Size X, Size Y
            //Content of Box
            GUI.Box(new Rect(0, 6 * scr.y, Screen.width, 3 * scr.y), dlgText[index]);
            //Have a Box that touches the Left edge and goes to the Right Edge
            //And starts 2/3rd down the screen and is 1/3rd in size
            //Finishing at the bottom of the screen
            if (!(index + 1 >= dlgText.Length-1 || index == optionsIndex))
            //Alternative 1: index+1 >= dlgText.Length)
            //Alternative 2: index < dlgText.Length)
            {
                if (GUI.Button(new Rect(15 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Next"))
                {
                    index++;
                }
            }

            else if (index == optionsIndex)
            {
                if (GUI.Button(new Rect(13 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Accept"))
                {
                    index++;
                }
                if (GUI.Button(new Rect(14 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Decline"))
                {
                    index = dlgText.Length - 1;
                }
            }

            else
            {
                if (GUI.Button(new Rect(15 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Bye"))
                {
                    index = 0;
                    showDlg = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                }
            }
        }
    }
}