using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Text HPText;
    public Slider HPSlider;

    // Start is called before the first frame update
    void Start()
    {
        HPText.text = "100";
        HPSlider.maxValue = 500;
        HPSlider.minValue = 0;
        HPSlider.value = 500;
    }

    // Update is called once per frame
    void Update()
    {
        Transform Player = GetComponent<Transform>();
        Player.position += new Vector3(0.1f, 0, 0);
        HPSlider.value -= 10;
        HPText.text = HPSlider.value.ToString();
    }
}
