class RemoteControlCar
{
    private int _mishu = 0;
    private int _dianliang = 100;
    public static RemoteControlCar Buy()=>new RemoteControlCar();
    public string DistanceDisplay()
    {
        if (_mishu >= 2000)
        {
            _mishu = 2000;
            return $"Driven {_mishu} meters";
        }
        else return $"Driven {_mishu} meters";
    }
    public string BatteryDisplay()
    {
        if(_dianliang <= 0) return "Battery empty";
        else return $"Battery at {_dianliang}%";
    }
    public void Drive()
    {
        _mishu += 20;
        _dianliang -= 1;
    }
}
