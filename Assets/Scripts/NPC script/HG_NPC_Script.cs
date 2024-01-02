using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class HG_NPC_Script : MonoBehaviour
{

    [SerializeField] Vector3 woSollIchHin;
    private bool debug = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (debug == false &&  QuestLog.GetQuestState("MainQuest") != QuestState.Unassigned)
        {
            bewegeDich();
        }
    }

    private void bewegeDich()
    {
        transform.position = woSollIchHin;
        debug = true;
    }
}
