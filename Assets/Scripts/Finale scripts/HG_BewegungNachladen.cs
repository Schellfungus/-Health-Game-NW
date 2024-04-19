using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HG_BewegungNachladen : MonoBehaviour
{

    private Animator npcAnimator;

    [SerializeField] Vector3 woSollIchHin;
    [SerializeField] Quaternion drehung;
    private bool debug = false;

    // Update is called once per frame
    void Update()
    {
        if (debug == false && QuestLog.GetQuestState("MainQuest") != QuestState.Unassigned)
        {
            bewegeDich();
        }
    }

    private void bewegeDich()
    {
        transform.position = woSollIchHin;
        transform.rotation = drehung;
        debug = true;
    }
}
