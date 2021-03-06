﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WaywardGamers.KParser.Plugin
{
    // For use when needing to invoke into the main messagepump thread.
    public delegate void DatasetInvoker(KPDatabaseDataSet dataset);

    public interface IPlugin
    {
        string TabName { get; }
        UserControl Control { get; }
        string TextContents { get; }
        string TextContentsAsRTF { get; }
        DataTable GeneratedDataTableForExcel { get; }

        bool IsActive { get; set; }

        void WatchDatabaseChanging(object sender, DatabaseWatchEventArgs e);
        void WatchDatabaseChanged(object sender, DatabaseWatchEventArgs e);

        void NotifyOfCultureChange();
        void NotifyOfUpdate();
        void Reset();

        void CustomMobFilterChanged(object sender, EventArgs e);

        bool IsDebug { get; }
    }
}
