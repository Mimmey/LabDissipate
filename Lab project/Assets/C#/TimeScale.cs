using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScale : MonoBehaviour
{
    // Start is called before the first frame update
    Button click;
    bool istimescaled = false;
    public Text text;
    void Start()
    {
        click = gameObject.GetComponent<Button>();
        click.onClick.AddListener(WasClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WasClicked()
    {
        if (!istimescaled)
        {
            Time.timeScale = 0.1f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            text.text = "Скорость - 10%";
            istimescaled = true;
        }
        else
        {
            Time.timeScale = 1;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            text.text = "Скорость - 100%";
            istimescaled = false;
        }
    }
}
