using System.Collections;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;
using Core.Api.Application;
using Core.Api.Service;
using Core.Api.Tools;
using Core.Api.Utilities;
using Core.Engine.Application;
using Neo.ApplicationFramework.Attributes;
using Neo.ApplicationFramework.Common;
using Neo.ApplicationFramework.Common.Runtime;
using Neo.ApplicationFramework.Common.TypeConverters;
using Neo.ApplicationFramework.Common.Utilities;
using Neo.ApplicationFramework.Interfaces;
using Neo.ApplicationFramework.Measurement;
using Neo.ApplicationFramework.Storage.Settings;
using Neo.ApplicationFramework.Tools.Runtime;
using Neo.ApplicationFramework.Tools.Storage;

[assembly: AssemblyVersion("2.20.2296.0")]
[assembly: NeoDesignerVersion("2.20.2296.0")]

namespace Neo.ApplicationFramework.Generated
{
    public class Globals : GlobalsBase
    {
        private static readonly log4net.ILog m_Log = log4net.LogManager.GetLogger(typeof(Globals));

        static Globals()
        {
            
        }

        public Globals() 
            : base(CreateToolManager())
        {
            m_ProjectSettings.MainScreenTitle = "Seat_15_805B";
            m_ProjectSettings.Topmost = false;
            m_ProjectSettings.StartupLocation = new Point(0, 0);
            m_ProjectSettings.MaximizeOnStartup = false;
            m_ProjectSettings.MainScreenSize = new Size(800,480);
            m_ProjectSettings.BorderStyle = ScreenBorderStyle.SingleBorder;
            m_ProjectSettings.InputDelay = 2000;
            m_ProjectSettings.IsOnScreenKeyboardEnabled = true;
            m_ProjectSettings.KeyboardLayoutName = "US";
            m_ProjectSettings.TerminalGroup = TerminalGroup.Default;
            List<IStorageProviderSetting> storageProviderSettingsList = new List<IStorageProviderSetting>() {
                new ProjectStorageProviderSetting("BackupAtStartup", false), new ProjectStorageProviderSetting("MaxSize", 0), 
            };
            m_ProjectSettings.StorageProviderSettings = new LocallyHostedProjectStorageProviderSettings("SQLite Database", storageProviderSettingsList, "");
            m_SystemSettings.AutomaticallyTurnOfBacklight = true;
            m_SystemSettings.BacklightTimeout = 300;    
            m_SystemSettings.KeepBacklightOnIfNotifierWindowIsVisible = true;
            Dictionary<ComPort, PortMode> comPortModes = new Dictionary<ComPort, PortMode>();
            comPortModes.Add(ComPort.COM1, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM2, PortMode.rs422); comPortModes.Add(ComPort.COM3, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM4, PortMode.rs485);                            
            m_SystemSettings.ComPortModes = comPortModes;                            
            m_SystemSettings.KeyBeep = true;
            m_SystemSettings.TimeZoneDisplayName = "";
            m_SystemSettings.RegionLCID = 0;
            m_SystemSettings.AdjustForDaylightSaving = true;
            m_SystemSettings.FtpServerEnabled = false;
            m_SystemSettings.FtpServerAllowAnonymous = false;
            m_SystemSettings.FtpServerSdCardAccess = false;
            m_SystemSettings.FtpServerUsbAccess = false;
            m_SystemSettings.FtpServerDefaultDir = @"";
            m_SystemSettings.NTLMUser = @"";
            m_SystemSettings.NTLMPassword = @"";
            m_SystemSettings.VncServerEnabled = false;
            m_SystemSettings.VncTcpPort = 5900;
            m_SystemSettings.VncHttpTcpPort = 5800;
            m_SystemSettings.VncViewOnlyPassword = @"";
            m_SystemSettings.VncFullAccessPassword = @"";
            m_SystemSettings.IsKeyPanel = false;
            m_SystemSettings.AlarmButtonShowScreenTarget = @"";
            m_SystemSettings.ScreenRotationAngle = 0;
            m_SystemSettings.BeShellMenuPassword = @"";
            m_SystemSettings.ProjectGuid = new Guid("1aa92fd4-e58b-4687-9e13-5bc2b744b4be");
        }
        
        
        private static IToolManager CreateToolManager()
        {
            // take simulation into account
            var coreApplication = Environment.OSVersion.Platform != PlatformID.WinCE ? (ICoreApplication)new CoreApplication(true) : (ICoreApplication)new CoreApplicationCe();
            IToolManager toolManager = new ApplicationEngineCe().CreateToolManager(true, coreApplication, Path.Combine(coreApplication.StartupPath, "Modules.cfgtool"));
            return toolManager;
        }
            

        
       

        /// <summary>
        /// Neo generated code - do not modify
        /// the contents of this method(s) with the code editor.
        /// </summary>        
                    public static IPrinterDevice Printer1
                    {
                        get
                        {
                            IDeviceManagerServiceCF deviceManagerService = ServiceContainerCF.GetService<IDeviceManagerServiceCF>();
                            return deviceManagerService.GetOutputDevice<IPrinterDevice>();
                        }
                    }           
                    public static IScreenAdapter Z軸位置移動確認頁
                    {
                        get
                        {
                            return GetObject<Z軸位置移動確認頁>().Adapter;
                        }
                    }           
                    public static IScreenAdapter 警報顯示
                    {
                        get
                        {
                            return GetObject<警報顯示>().Adapter;
                        }
                    }           
                    public static IScreenAdapter 手動_取放盤
                    {
                        get
                        {
                            return GetObject<手動_取放盤>().Adapter;
                        }
                    }           
                    public static IScreenAdapter 手動_取放料
                    {
                        get
                        {
                            return GetObject<手動_取放料>().Adapter;
                        }
                    }           
                    public static ScriptModule1 ScriptModule1
                    {
                        get
                        {
                            return GetObject<ScriptModule1>();
                        }
                    }           
                    public static SntpClientRootComponent SntpClientRootComponent
                    {
                        get
                        {
                            return GetObject<SntpClientRootComponent>();
                        }
                    }           
                    public static Security Security
                    {
                        get
                        {
                            return GetObject<Security>();
                        }
                    }           
                    public static ProjectConfiguration ProjectConfiguration
                    {
                        get
                        {
                            return GetObject<ProjectConfiguration>();
                        }
                    }           
                    public static Tags Tags
                    {
                        get
                        {
                            return GetObject<Tags>();
                        }
                    }           
                    public static MultipleLanguages MultipleLanguages
                    {
                        get
                        {
                            return GetObject<MultipleLanguages>();
                        }
                    }           
                    public static LicenseRootComponent LicenseRootComponent
                    {
                        get
                        {
                            return GetObject<LicenseRootComponent>();
                        }
                    }           
                    public static Expressions Expressions
                    {
                        get
                        {
                            return GetObject<Expressions>();
                        }
                    }           
                    public static AlarmServer AlarmServer
                    {
                        get
                        {
                            return GetObject<AlarmServer>();
                        }
                    }           
                    public static IScreenAdapter 主頁
                    {
                        get
                        {
                            return GetObject<主頁>().Adapter;
                        }
                    }   
        [MTAThread]
        static void Main(string[] args)
        {

            Thread.CurrentThread.Name = "NeoMainThread";
            
            InitializeBeHwApiLog();
            
            
            
            UserStartupMessage.SendUserStartupMessageToBeijerShell("Loading Files");
            if (!StopWatchCF.Silent)
                StopWatchCF.Send("Starting Project");
            StopWatchCF.SetTimestamp("***** Project Startup Time *****");
            while (ProcessExplorer.WaitForAttachDebugger)
            {
                Thread.Sleep(1000);
            }
            IsCompiledForCE = true;   

            Instance = new Globals();
        	if (!Instance.CheckIfApplicationCanRun())
				return;

            string executingAssemblyName = Assembly.GetExecutingAssembly().FullName;
            string executablePath = typeof(Globals).Module.FullyQualifiedName;

            Instance.Go(executingAssemblyName, executablePath, args, new string[]{"Tags","AlarmServer","Expressions","LicenseRootComponent","MultipleLanguages","ProjectConfiguration","Security","SntpClientRootComponent","ScriptModule1","ProjectImages"}, new string[]{}, () => 主頁);
        }

    }
}