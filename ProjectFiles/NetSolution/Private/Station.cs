using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "f913487af487cf6e935d5eac068be0cb")]
public class Station : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public int Number
    {
        get
        {
            return (int)Refs.GetVariable("Number").Value.Value;
        }
        set
        {
            Refs.GetVariable("Number").SetValue(value);
        }
    }
    public IUAVariable NumberVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Number");
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
    public int ID
    {
        get
        {
            return (int)Refs.GetVariable("ID").Value.Value;
        }
        set
        {
            Refs.GetVariable("ID").SetValue(value);
        }
    }
    public IUAVariable IDVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ID");
        }
    }
    public int WorkbarNo
    {
        get
        {
            return (int)Refs.GetVariable("WorkbarNo").Value.Value;
        }
        set
        {
            Refs.GetVariable("WorkbarNo").SetValue(value);
        }
    }
    public IUAVariable WorkbarNoVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("WorkbarNo");
        }
    }
    public int DripTime
    {
        get
        {
            return (int)Refs.GetVariable("DripTime").Value.Value;
        }
        set
        {
            Refs.GetVariable("DripTime").SetValue(value);
        }
    }
    public IUAVariable DripTimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("DripTime");
        }
    }
    public int PendulumTime
    {
        get
        {
            return (int)Refs.GetVariable("PendulumTime").Value.Value;
        }
        set
        {
            Refs.GetVariable("PendulumTime").SetValue(value);
        }
    }
    public IUAVariable PendulumTimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("PendulumTime");
        }
    }
    public bool Locked
    {
        get
        {
            return (bool)Refs.GetVariable("Locked").Value.Value;
        }
        set
        {
            Refs.GetVariable("Locked").SetValue(value);
        }
    }
    public IUAVariable LockedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Locked");
        }
    }
    public int Characteristic
    {
        get
        {
            return (int)Refs.GetVariable("Characteristic").Value.Value;
        }
        set
        {
            Refs.GetVariable("Characteristic").SetValue(value);
        }
    }
    public IUAVariable CharacteristicVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Characteristic");
        }
    }
    public int Position
    {
        get
        {
            return (int)Refs.GetVariable("Position").Value.Value;
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
    public bool StationTimesTabVisible
    {
        get
        {
            return (bool)Refs.GetVariable("StationTimesTabVisible").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationTimesTabVisible").SetValue(value);
        }
    }
    public IUAVariable StationTimesTabVisibleVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationTimesTabVisible");
        }
    }
    public bool StationDevicesTabVisible
    {
        get
        {
            return (bool)Refs.GetVariable("StationDevicesTabVisible").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationDevicesTabVisible").SetValue(value);
        }
    }
    public IUAVariable StationDevicesTabVisibleVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationDevicesTabVisible");
        }
    }
    public bool StationAnalogValuesTabVisible
    {
        get
        {
            return (bool)Refs.GetVariable("StationAnalogValuesTabVisible").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationAnalogValuesTabVisible").SetValue(value);
        }
    }
    public IUAVariable StationAnalogValuesTabVisibleVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationAnalogValuesTabVisible");
        }
    }
    public bool StationParametersTabVisible
    {
        get
        {
            return (bool)Refs.GetVariable("StationParametersTabVisible").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationParametersTabVisible").SetValue(value);
        }
    }
    public IUAVariable StationParametersTabVisibleVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationParametersTabVisible");
        }
    }
    public bool StationFaultsTabVisible
    {
        get
        {
            return (bool)Refs.GetVariable("StationFaultsTabVisible").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationFaultsTabVisible").SetValue(value);
        }
    }
    public IUAVariable StationFaultsTabVisibleVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationFaultsTabVisible");
        }
    }
    public string StationPathTime
    {
        get
        {
            return (string)Refs.GetVariable("StationPathTime").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationPathTime").SetValue(value);
        }
    }
    public IUAVariable StationPathTimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationPathTime");
        }
    }
    public string StationPathDevice
    {
        get
        {
            return (string)Refs.GetVariable("StationPathDevice").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationPathDevice").SetValue(value);
        }
    }
    public IUAVariable StationPathDeviceVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationPathDevice");
        }
    }
    public string StationPathAnalog
    {
        get
        {
            return (string)Refs.GetVariable("StationPathAnalog").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationPathAnalog").SetValue(value);
        }
    }
    public IUAVariable StationPathAnalogVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationPathAnalog");
        }
    }
    public string StationPathParameter
    {
        get
        {
            return (string)Refs.GetVariable("StationPathParameter").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationPathParameter").SetValue(value);
        }
    }
    public IUAVariable StationPathParameterVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationPathParameter");
        }
    }
    public string StationPathFault
    {
        get
        {
            return (string)Refs.GetVariable("StationPathFault").Value.Value;
        }
        set
        {
            Refs.GetVariable("StationPathFault").SetValue(value);
        }
    }
    public IUAVariable StationPathFaultVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StationPathFault");
        }
    }
#endregion
}
