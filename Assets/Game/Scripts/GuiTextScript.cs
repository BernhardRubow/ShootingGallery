using UnityEngine;
using System.Collections;

public class GuiTextScript : MonoBehaviour {

    public GUIStyle GameStyle;

	private int m_Remaining;
	private int m_Fallen;
    private int m_Remaining_Balls;

    // Use this for initialization
    void Start() {
        m_Remaining_Balls = 9;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnGUI() {

        DrawOutline(
			new Rect(20, 20, 50, 25), 
			"Cans: " + m_Fallen.ToString("00"), 
			GameStyle, 
			Color.red, 
			Color.yellow);

        DrawOutline(
			new Rect(Screen.width -310, 20, 50, 25), 
			"Reamining: " + m_Remaining.ToString("00")  , GameStyle, 
			Color.red, 
			Color.yellow);

        DrawOutline(
            new Rect(20,Screen.height - 80, 50, 25),
            "Balls: " + m_Remaining_Balls.ToString("00"), GameStyle,
            Color.red,
            Color.yellow
            );

        DrawOutline(
            new Rect(Screen.width - 310, Screen.height - 80, 50, 25),
            "Total Cans: " + GameManagerScript.TotalNumberCans.ToString("00"), GameStyle,
            Color.red,
            Color.yellow);
    }

    public void SetCans(int fallen, int remaining){
		m_Fallen = fallen;
		m_Remaining = remaining;
	}

    public void DecrementBalls() {

        m_Remaining_Balls -= 1;

        if (m_Remaining_Balls == 0)
            GameManagerScript.GameState = "End";

    }

    //draw text of style color, with a specified outline color
    public static void DrawOutline(Rect position, string text, GUIStyle style, Color outColor) {

        var backupStyle = style;

        var oldColor = style.normal.textColor;

        style.normal.textColor = outColor;

        position.x -= 2;

        GUI.Label(position, text, style);

        position.x += 4;

        GUI.Label(position, text, style);

        position.x -= 2;

        position.y -= 2;

        GUI.Label(position, text, style);

        position.y += 4;

        GUI.Label(position, text, style);

        position.y -=2;

        style.normal.textColor = oldColor;

        GUI.Label(position, text, style);

        style = backupStyle;

    }


    //draw text of a specified color, with a specified outline color
    public static void DrawOutline(Rect position, string text, GUIStyle style, Color outColor, Color inColor) {

        var backupStyle = style;

        style.normal.textColor = outColor;

        position.x -= 2;

        GUI.Label(position, text, style);

        position.x += 4;

        GUI.Label(position, text, style);

        position.x -= 2;

        position.y -= 2;

        GUI.Label(position, text, style);

        position.y += 4;

        GUI.Label(position, text, style);

        position.y -= 2;

        style.normal.textColor = inColor;

        GUI.Label(position, text, style);

        style = backupStyle;

    }
}
