class Activity {
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    public Activity(string name, string description) {
        _activityName = name;
        _activityDescription = description;
    }

    public string GetActivityName() {
        return _activityName;
    }

    public string GetActivityDescription() {
        return _activityDescription;
    }

    public int GetActivityDuration() {
        return _activityDuration;
    }

    public string DisplayStartingMessage() {
        return "";
    }

    public string DisplayEndingMessage() {
        return "";
        
    }

    public void PauseShowSpinner() {
        
    }

    public void RunActivity() {
        
    }
}