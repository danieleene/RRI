using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;

public class FacebookLogout : MonoBehaviour
{
    public void FbLogout()
    {
        FB.LogOut();
    }
}
