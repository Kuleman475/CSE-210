class Activity {
    private string _date;
    private int _minutes;

    // private List<string> _acivityList;
    

    public Activity(int minutes, string date){
        _minutes = minutes;
        date = DateTime.Now.ToString("MM/dd/yyyy");
        _date = date;
    }

    public string GetDate(){
        return _date;
    }
    public int GetMinutes(){
        return _minutes;
    }
    public virtual double GetDistance(){
        return 0;
    } 
    public virtual double GetSpeed(){
        return 0;
    } 
    public virtual double GetPace(){
        return 0;
    }
    public virtual string GetSummary(){
        return "";
    }
    
}