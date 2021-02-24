//using Pvr_UnitySDKAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenShot : MonoBehaviour {

    public GameObject cube;

    public Camera mainCamera;

    public RenderTexture renderTexture;
    //public Eye eyeSide;
    void OnPostRender()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            cube.transform.Rotate(0, 0, 360 * Time.deltaTime);
            //SaveImages.SaveImage(Pvr_UnitySDKManager.SDK.eyeTextures[Pvr_UnitySDKManager.SDK.currEyeTextureIdx + (int)eyeSide * 3]);
            SaveImages.SaveImage(renderTexture);
        }

    }

}
