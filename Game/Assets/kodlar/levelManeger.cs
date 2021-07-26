using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelManeger : MonoBehaviour
{
    public List<Button> buttons;
    public bool delete;
    // Start is called before the first frame update
    void Start()
    {
        
        int saveIndex = PlayerPrefs.GetInt("SaveIndex");

        if (delete)
        {
            PlayerPrefs.DeleteAll();
        }
        for(int i = 0; i < buttons.Count; i++)
        {
            if (i <= saveIndex)
            {
                buttons[i].interactable = true;
            }
            else
            {
                buttons[i].interactable = false;
            }
        }
    }

    public void LevelSelect()
    {
        int level = int.Parse(EventSystem.current.currentSelectedGameObject.name);
        SceneManager.LoadScene(level);
    }
}
