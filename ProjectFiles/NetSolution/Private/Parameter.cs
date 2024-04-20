using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "db018bbe96bb0c7fcf0dc9c537e8ce48")]
public class Parameter : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
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
    public string Function
    {
        get
        {
            return (string)Refs.GetVariable("Function").Value.Value;
        }
        set
        {
            Refs.GetVariable("Function").SetValue(value);
        }
    }
    public IUAVariable FunctionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Function");
        }
    }
    public string Unit
    {
        get
        {
            return (string)Refs.GetVariable("Unit").Value.Value;
        }
        set
        {
            Refs.GetVariable("Unit").SetValue(value);
        }
    }
    public IUAVariable UnitVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Unit");
        }
    }
    public float Act
    {
        get
        {
            return (float)Refs.GetVariable("Act").Value.Value;
        }
        set
        {
            Refs.GetVariable("Act").SetValue(value);
        }
    }
    public IUAVariable ActVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Act");
        }
    }
    public float Set
    {
        get
        {
            return (float)Refs.GetVariable("Set").Value.Value;
        }
        set
        {
            Refs.GetVariable("Set").SetValue(value);
        }
    }
    public IUAVariable SetVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Set");
        }
    }
#endregion
}
