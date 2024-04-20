using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "bbb324c1c6bdad4a2389feb8764cfd1a")]
public class Device : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public int Select
    {
        get
        {
            return (int)Refs.GetVariable("Select").Value.Value;
        }
        set
        {
            Refs.GetVariable("Select").SetValue(value);
        }
    }
    public IUAVariable SelectVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Select");
        }
    }
    public int Status
    {
        get
        {
            return (int)Refs.GetVariable("Status").Value.Value;
        }
        set
        {
            Refs.GetVariable("Status").SetValue(value);
        }
    }
    public IUAVariable StatusVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Status");
        }
    }
    public int Fault
    {
        get
        {
            return (int)Refs.GetVariable("Fault").Value.Value;
        }
        set
        {
            Refs.GetVariable("Fault").SetValue(value);
        }
    }
    public IUAVariable FaultVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Fault");
        }
    }
    public int Base
    {
        get
        {
            return (int)Refs.GetVariable("Base").Value.Value;
        }
        set
        {
            Refs.GetVariable("Base").SetValue(value);
        }
    }
    public IUAVariable BaseVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Base");
        }
    }
    public int TimeOn
    {
        get
        {
            return (int)Refs.GetVariable("TimeOn").Value.Value;
        }
        set
        {
            Refs.GetVariable("TimeOn").SetValue(value);
        }
    }
    public IUAVariable TimeOnVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TimeOn");
        }
    }
    public int TimerOff
    {
        get
        {
            return (int)Refs.GetVariable("TimerOff").Value.Value;
        }
        set
        {
            Refs.GetVariable("TimerOff").SetValue(value);
        }
    }
    public IUAVariable TimerOffVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TimerOff");
        }
    }
    public string Symbol
    {
        get
        {
            return (string)Refs.GetVariable("Symbol").Value.Value;
        }
        set
        {
            Refs.GetVariable("Symbol").SetValue(value);
        }
    }
    public IUAVariable SymbolVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Symbol");
        }
    }
    public string DeviceGroup
    {
        get
        {
            return (string)Refs.GetVariable("DeviceGroup").Value.Value;
        }
        set
        {
            Refs.GetVariable("DeviceGroup").SetValue(value);
        }
    }
    public IUAVariable DeviceGroupVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("DeviceGroup");
        }
    }
    public string StationName
    {
        get
        {
            return (string)Refs.GetVariable("StationName").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationName").SetValue(value);
        }
    }
    public IUAVariable StationNameVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationName");
        }
    }
    public string Name
    {
        get
        {
            return (string)Refs.GetVariable("Name").Value.Value;
        }
        set
        {
            Refs.GetVariable("Name").SetValue(value);
        }
    }
    public IUAVariable NameVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Name");
        }
    }
    public int StationNo
    {
        get
        {
            return (int)Refs.GetVariable("StationNo").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationNo").SetValue(value);
        }
    }
    public IUAVariable StationNoVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationNo");
        }
    }
    public string Position
    {
        get
        {
            return (string)Refs.GetVariable("Position").Value.Value;
        }
        set
        {
            Refs.GetVariable("Position").SetValue(value);
        }
    }
    public IUAVariable PositionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Position");
        }
    }
#endregion
}
