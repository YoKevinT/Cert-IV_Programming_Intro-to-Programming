[System.Serializable]
public class QuestGoal
{
    // Goal type
    public GoalType goalType;
    // Required Amount
    public int requiredAmount;
    // Current Amount
    public int currentAmount;

    // Is Reached
    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }
    // Enemy Killed
    public void EnemyKilled()
    {
        if (goalType == GoalType.Kill)
        {
            currentAmount++;
        }
    }
    //ObjectCollected
    public void ObjectCollected()
    {
        if (goalType == GoalType.Gather)
        {
            currentAmount++;
        }
    }
}
public enum GoalType
{
    Kill,
    Gather
}