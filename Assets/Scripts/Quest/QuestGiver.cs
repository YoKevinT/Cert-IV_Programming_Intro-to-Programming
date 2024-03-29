﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class QuestUI
{
    public PlayerQuest player;
    public GameObject questWindow;

    public Text nameText;
    public Text descriptionText;
    public Text experienceText;
    public Text goldText;

}

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public QuestUI uI;

    public void OpenQuestWindow()
    {
        uI.questWindow.SetActive(true);

        uI.nameText.text = quest.name;
        uI.descriptionText.text = quest.description;
        uI.experienceText.text = quest.experienceReward.ToString();
        uI.goldText.text = quest.goldReward.ToString();
    }
    public void AcceptQuest()
    {
        uI.questWindow.SetActive(false);
        if (quest.state == QuestState.New)
        {
            quest.state = QuestState.Accepted;
            uI.player.quests.Add(quest);
        }
    }
}