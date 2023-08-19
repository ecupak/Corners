using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class TouchInput : MonoBehaviour
{
    public TMP_Text primaryPhaseDisplayText;
    public TMP_Text primaryPositionDisplayText;

    public TMP_Text secondaryPhaseDisplayText;
    public TMP_Text secondaryPositionDisplayText;


    public void onPrimaryInput(InputAction.CallbackContext context)
    {
        //Debug.Log("INPUT: " + context.ReadValue<TouchState>().phase + " @ " + context.ReadValue<TouchState>().position.ToString());

        primaryPhaseDisplayText.text = context.ReadValue<TouchState>().phase.ToString();
        primaryPositionDisplayText.text = context.ReadValue<TouchState>().position.ToString();
    }

    public void onSecondaryInput(InputAction.CallbackContext context)
    {        
        //Debug.Log("POSITION: " + context.ReadValue<Vector2>().ToString());

        secondaryPhaseDisplayText.text = context.ReadValue<TouchState>().phase.ToString();
        secondaryPositionDisplayText.text = context.ReadValue<TouchState>().position.ToString();
    }


    private void Update()
    {
        /*
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
     
            if (theTouch.phase == UnityEngine.TouchPhase.Ended)
            {
                phaseDisplayText.text = theTouch.phase.ToString();
                timeTouchEnded = Time.time;
            }
            else if (Time.time - timeTouchEnded > displayTime)
            {
                phaseDisplayText.text = theTouch.phase.ToString();
                timeTouchEnded = Time.time;
            }
        }
        else if (Time.time - timeTouchEnded > displayTime)
        {
            phaseDisplayText.text = "";
        }
        */
    }
}
