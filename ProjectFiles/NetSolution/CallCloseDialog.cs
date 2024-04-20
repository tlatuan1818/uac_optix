#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.WebUI;
#endregion

public class CallCloseDialog : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
    [ExportMethod]
    public void CloseDialog() {

        DialogSession dialogSession = DialogSession.GetInstance();
        if (dialogSession.IsOpen)
        {

            var dialog = (Dialog)Owner;

            dialog.Close();
            dialogSession.IsOpen = false;
        }

    }
}
