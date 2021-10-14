using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementsManager : MonoBehaviour
{
    public Achievement theStartAchievement = new Achievement(11, "The Start");
    public Achievement thePushAchievement = new Achievement(12, "The Push");
    public Achievement adventureAchievement = new Achievement(13, "On a long adventure");
    public Achievement whatGreatVideoAchievement = new Achievement(14, "What a great video");
    public Achievement arduinoAchievement = new Achievement(15, "What is this?");
    public Achievement classAchievement = new Achievement(16, "The Secret Class");
    public Achievement christmassAchievement = new Achievement(17, "Merry Christmas (Every day can be christmas)");
    public Achievement dejaVuAchievement = new Achievement(18, "Deja Vu");
    public Achievement coffeeAchievement = new Achievement(19, "Coffee is the best, served bitter and strong");
    public Achievement kondorianoAchievement = new Achievement(20, "The truth about Kondoriano");

    public void unlockAchievement(Achievement achievement)
    {
        if (achievement.isAchieved == false)
        {
            achievement.isAchieved = true;
            Debug.Log("Achievement unlocked: " + achievement.name);
            LocalStorageSystem.SaveLocalStorage(achievement.id);
            //Show the achievement in the UI
        }
    }
}