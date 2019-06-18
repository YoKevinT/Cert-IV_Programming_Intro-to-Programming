[System.Serializable]
public class Quest
{
    // State of Quest
    public QuestState state = QuestState.New;
    // Name
    public string name;
    // Description
    public string description;
    // Experience Reward
    public int experienceReward;
    // Gold Reward
    public int goldReward;

    // Goal
    public QuestGoal goal;
    //Complete
    public void Complete()
    {
        state = QuestState.Completed;
    }
}
public enum QuestState
{
    New,
    Accepted,
    Failed,
    Completed,
    Claimed
}