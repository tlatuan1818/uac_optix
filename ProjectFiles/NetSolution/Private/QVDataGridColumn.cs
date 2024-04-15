using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "UAC", Guid = "1117a9f6dea8ce6022a29cb3f1413b01")]
public class QVDataGridColumn : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public string Title
    {
        get
        {
            return (string)Refs.GetVariable("Title").Value.Value;
        }
        set
        {
            Refs.GetVariable("Title").SetValue(value);
        }
    }
    public IUAVariable TitleVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Title");
        }
    }
    public string Property
    {
        get
        {
            return (string)Refs.GetVariable("Property").Value.Value;
        }
        set
        {
            Refs.GetVariable("Property").SetValue(value);
        }
    }
    public IUAVariable PropertyVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Property");
        }
    }
    public int Width
    {
        get
        {
            return (int)Refs.GetVariable("Width").Value.Value;
        }
        set
        {
            Refs.GetVariable("Width").SetValue(value);
        }
    }
    public IUAVariable WidthVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Width");
        }
    }
    public UAManagedCore.NodeId TItem
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("TItem").Value.Value;
        }
        set
        {
            Refs.GetVariable("TItem").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer TItemVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("TItem");
        }
    }
    public UAManagedCore.NodeId CellType
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("CellType").Value.Value;
        }
        set
        {
            Refs.GetVariable("CellType").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer CellTypeVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("CellType");
        }
    }
#endregion
}
