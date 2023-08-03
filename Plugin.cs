
using GorillaNetworking;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using Steamworks;
using System.Numerics;

namespace HugeBug
{

    public class Plugin : MonoBehaviour
    {
        void Bug()
            {
            GameObject floatingBug = GameObject.Find("Floating Bug"); // i made this mod dont steal
            Transform bugTransform = floatingBug.GetComponent<Transform>();

            if (bugTransform != null)
            {
                bugTransform.localScale = new UnityEngine.Vector3(15f, 15f, 15f);
            }
        }
        }
    }


