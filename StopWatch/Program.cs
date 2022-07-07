public class StopWatch
{
    private Boolean _isStart;
    private DateTime _startTime;
    private DateTime _stopTime;
    private TimeSpan _timeSpan;

    public void Start()
    {
        if(_isStart == true)
        {
            throw new InvalidOperationException();
        }

        _startTime = DateTime.Now; 
        _isStart = true;
    }

    public string Stop()
    {
        if(_isStart == false)
        {
            throw new InvalidOperationException();
        }

        _startTime = DateTime.Now;
        _timeSpan = DateTime.Now - _startTime;
        _isStart = false;

        return _timeSpan.Seconds.ToString();
    }
}