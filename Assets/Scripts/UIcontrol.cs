using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    public Image image;
    public GameObject game;
    public Button btn;
    private bool s = false;
    void Start()
    {
        // btn.transform.GetComponent<Text>().text = "Start";

        btn.onClick.AddListener(TaskOnClick);
    }

    void Update() {
        if(s)image.enabled = false;
    }
    void TaskOnClick(){
        s = true;
        menu.SetActive(false);
        game.SetActive(true);
	}
}
