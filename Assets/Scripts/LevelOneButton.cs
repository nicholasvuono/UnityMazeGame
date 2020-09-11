using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelOneButton : MonoBehaviour {

    public Button level1;

    void Start()
    {
        Button b = level1.GetComponent<Button>();
        b.onClick.AddListener(WhichLevel);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }

    void WhichLevel()
    {
        SceneManager.LoadScene(3);
    }
}
