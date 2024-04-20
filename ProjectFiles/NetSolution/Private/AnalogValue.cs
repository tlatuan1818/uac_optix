using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "95a982c7872262cc9f425a4a9e9743e1")]
public class AnalogValue : UAObject
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
    public double Act
    {
        get
        {
            return (double)Refs.GetVariable("Act").Value.Value;
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
    public double Actual_Target
    {
        get
        {
            return (double)Refs.GetVariable("Actual_Target").Value.Value;
        }
        set
        {
            Refs.GetVariable("Actual_Target").SetValue(value);
        }
    }
    public IUAVariable Actual_TargetVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Actual_Target");
        }
    }
    public double Actual_Fitplus
    {
        get
        {
            return (double)Refs.GetVariable("Actual_Fitplus").Value.Value;
        }
        set
        {
            Refs.GetVariable("Actual_Fitplus").SetValue(value);
        }
    }
    public IUAVariable Actual_FitplusVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Actual_Fitplus");
        }
    }
    public double Actual_Fitsubtract
    {
        get
        {
            return (double)Refs.GetVariable("Actual_Fitsubtract").Value.Value;
        }
        set
        {
            Refs.GetVariable("Actual_Fitsubtract").SetValue(value);
        }
    }
    public IUAVariable Actual_FitsubtractVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Actual_Fitsubtract");
        }
    }
    public int TimerOn
    {
        get
        {
            return (int)Refs.GetVariable("TimerOn").Value.Value;
        }
        set
        {
            Refs.GetVariable("TimerOn").SetValue(value);
        }
    }
    public IUAVariable TimerOnVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TimerOn");
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
    public double Operation_Target
    {
        get
        {
            return (double)Refs.GetVariable("Operation_Target").Value.Value;
        }
        set
        {
            Refs.GetVariable("Operation_Target").SetValue(value);
        }
    }
    public IUAVariable Operation_TargetVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Operation_Target");
        }
    }
    public double Operation_Fitplus
    {
        get
        {
            return (double)Refs.GetVariable("Operation_Fitplus").Value.Value;
        }
        set
        {
            Refs.GetVariable("Operation_Fitplus").SetValue(value);
        }
    }
    public IUAVariable Operation_FitplusVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Operation_Fitplus");
        }
    }
    public double Operation_Fitsubtract
    {
        get
        {
            return (double)Refs.GetVariable("Operation_Fitsubtract").Value.Value;
        }
        set
        {
            Refs.GetVariable("Operation_Fitsubtract").SetValue(value);
        }
    }
    public IUAVariable Operation_FitsubtractVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Operation_Fitsubtract");
        }
    }
    public double ShutdownMode_Target
    {
        get
        {
            return (double)Refs.GetVariable("ShutdownMode_Target").Value.Value;
        }
        set
        {
            Refs.GetVariable("ShutdownMode_Target").SetValue(value);
        }
    }
    public IUAVariable ShutdownMode_TargetVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ShutdownMode_Target");
        }
    }
    public double ShutdownMode_Fitplus
    {
        get
        {
            return (double)Refs.GetVariable("ShutdownMode_Fitplus").Value.Value;
        }
        set
        {
            Refs.GetVariable("ShutdownMode_Fitplus").SetValue(value);
        }
    }
    public IUAVariable ShutdownMode_FitplusVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ShutdownMode_Fitplus");
        }
    }
    public double ShutdownMode_Fitsubtract
    {
        get
        {
            return (double)Refs.GetVariable("ShutdownMode_Fitsubtract").Value.Value;
        }
        set
        {
            Refs.GetVariable("ShutdownMode_Fitsubtract").SetValue(value);
        }
    }
    public IUAVariable ShutdownMode_FitsubtractVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ShutdownMode_Fitsubtract");
        }
    }
#endregion
}
