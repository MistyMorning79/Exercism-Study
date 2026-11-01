class RemoteControlCar
{
    public int _speed;
    public int _batteryDrain;
    public int _mishu = 0;
    public int _dianliang = 100;
    public RemoteControlCar(int speed , int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return _dianliang < _batteryDrain;
    }
    
    public int DistanceDriven()
    {
        return _mishu;
    }

    public void Drive()
    {
        if(_dianliang >= _batteryDrain)
        {
            _mishu += _speed;
            _dianliang -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    private int _distance;
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        double d = (double)this._distance / (double)car._speed;
        double d1 = d*(double)car._batteryDrain;
        if(d1 > car._dianliang) return false;
        else return true;
    }
}
