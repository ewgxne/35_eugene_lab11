using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public Calculator _calculator;
	public string _value;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnMouseDown()
	{
		_calculator.SetInputValue (_value);
	}
}
