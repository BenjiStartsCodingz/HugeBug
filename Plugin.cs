using UnityEngine;
using GorillaNetworking;
using GorillaLocomotion;
using PlayFab;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;
using UnityEngine.UI;
using PlayFab.ClientModels;
using Photon.Pun;
using Photon.Realtime;
using PlayFab.Internal;
using Steamworks;
using MelonLoader;
using System.Numerics;

namespace HugeBug
{

    public class HugeBug_1 : MonoBehaviour
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


