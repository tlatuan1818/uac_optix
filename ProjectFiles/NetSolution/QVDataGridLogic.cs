#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using System.Reflection.PortableExecutable;
#endregion

public class QVDataGridLogic : BaseNetLogic
{
    private IUANode _header;
    private IUANode _body;
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        _header = Owner.Get("ScrollView/VerticalLayout/Header");
        _body = Owner.Get("ScrollView/VerticalLayout/Body");

        var dataItems = Project.Current.Get("Model/Stations").GetOwnedNodes();


        if (_header.Children.Count > 0)
        {
            _header.Children.Clear();
        }

        if (_body.Children.Count > 0)
        {
            _body.Children.Clear();
        }

        var uaObjectType = InformationModel.Get(Owner.GetVariable("TItem").Value);

        // get type of uaObjectType
        if (uaObjectType.GetType() == typeof(UAObjectType))
        {

        }


        // Render Header Row
        var columns = Owner.Get<UAObject>("Columns").Children;

        for (var i = 0; i < columns.Count; i++)
        {
            var column = columns[i];

            var checkExistedColumnFieldWithItemType = uaObjectType.GetVariable(column.GetVariable("Property").Value) != null;

            if (!checkExistedColumnFieldWithItemType) continue;

            var hCell = InformationModel.Make<TbCellHeader>($"header-{column.BrowseName}");

            var labelHeaderText = (Label)hCell.GetObject("Text");
            labelHeaderText.Text = column.GetVariable("Title").Value;
            if (i > 0)
            {
                hCell.LeftMargin = -2;
            }
            _header.Children.Add(hCell);
        }



        for (var i = 0; i < dataItems.Count; i++)
        {
            // Render Body Rows
            var dr = InformationModel.Make<RowLayout>($"row-{i}");
            for (var j = 0; j < columns.Count; j++)
            {
                var column = columns[j];
                var prop = column.GetVariable("Property").Value;
                var checkExistedColumnFieldWithItemType = uaObjectType.GetVariable(prop) != null;

                if (!checkExistedColumnFieldWithItemType) continue;

                var cellType = InformationModel.Get(column.GetVariable("CellType").Value);

                if (cellType.BrowseName == "TbCellItemText")
                {
                    var hCell = InformationModel.Make<TbCellItemText>($"item-{column.BrowseName}");
                    var dtValue = hCell.GetObject("Text").GetOrCreateVariable("Text");
                    dtValue.SetDynamicLink(dataItems[i].GetVariable(prop), DynamicLinkMode.ReadWrite);
                    if (j > 0)
                    {
                        hCell.LeftMargin = -2;
                    }
                    dr.Children.Add(hCell);
                }
                else if (cellType.BrowseName == "TbCellItemEditText")
                {
                    var hCell = InformationModel.Make<TbCellItemEditText>($"item-{column.BrowseName}");
                    var dtValue = hCell.GetObject("TextBox").GetOrCreateVariable("Text");
                    dtValue.SetDynamicLink(dataItems[i].GetVariable(prop), DynamicLinkMode.ReadWrite);
                    if (j > 0)
                    {
                        hCell.LeftMargin = -2;
                    }
                    dr.Children.Add(hCell);
                }
                else if (cellType.BrowseName == "TbCellItemCheckBox")
                {
                    var hCell = InformationModel.Make<TbCellItemCheckBox>($"item-{column.BrowseName}");
                    var dtValue = hCell.GetObject("Checkbox").GetOrCreateVariable("Checked");
                    dtValue.SetDynamicLink(dataItems[i].GetVariable(prop), DynamicLinkMode.ReadWrite);
                    if (j > 0)
                    {
                        hCell.LeftMargin = -2;
                    }

                    dr.Children.Add(hCell);
                }
                //}else if (cellType.BrowseName == "TbCellItemButton")
                //{
                //    var hCell = InformationModel.Make<TbCellItemCheckBox>($"item-{column.BrowseName}");
                //    var dtValue = hCell.GetObject("Button").GetOrCreateVariable("Checked");
                //    dtValue.SetDynamicLink(dataItems[i].GetVariable(prop), DynamicLinkMode.ReadWrite);
                //    if (j > 0)
                //    {
                //        hCell.LeftMargin = -2;
                //    }
                //    dr.Children.Add(hCell);
                //}


                //var hCell = InformationModel.Make<TbCell>($"item-{column.BrowseName}");
                //var dtValue = hCell.GetObject("HeaderText").GetOrCreateVariable("Text");
                //dtValue.SetDynamicLink(dataItems[i].GetVariable(prop), DynamicLinkMode.ReadWrite);


                //if (j > 0)
                //{
                //    hCell.LeftMargin = -2;

                //}

                //dr.Children.Add(hCell);
            }
            _body.Children.Add(dr);
        }
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
