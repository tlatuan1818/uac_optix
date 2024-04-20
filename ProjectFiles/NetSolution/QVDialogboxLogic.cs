#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using FTOptix.Core;
using FTOptix.WebUI;
#endregion

public class QVDialogboxLogic : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started


    }
    [ExportMethod]
    public void DialogStation(int id, NodeId nodeId)
    {
      

       
    } 
   
    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
