using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    Button click;
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
        Time.timeScale = 1;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
        Application.LoadLevel("1");
        
    }
}
