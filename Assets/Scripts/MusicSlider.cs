using UnityEngine;

public class MusicSlider : MonoBehaviour {
    public Canvas myCanvas;
    Vector3 musicVolumePosition;

	void Start ()
    {
        float musicVolume = PlayerPrefs.GetFloat("musicVolume", 100f);
        musicVolumePosition = new Vector3((musicVolume * 3.4f) - 170f, 306, -1);
        transform.position = myCanvas.transform.TransformPoint(musicVolumePosition);

    }
	
	void Update ()
    {
		if (Input.touchCount > 0 && (Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(0).phase == TouchPhase.Moved))
        {
            Vector2 pos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(myCanvas.transform as RectTransform, Input.mousePosition, myCanvas.worldCamera, out pos);
            musicVolumePosition.x = pos.x;
            transform.position = myCanvas.transform.TransformPoint(musicVolumePosition);
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            PlayerPrefs.SetFloat("musicVolume", musicVolumePosition.x / 3.4f - 170f);
        }
	}
}
