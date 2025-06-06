﻿using Avalonia;
using System;
using NLog;

namespace MusicLyricApp;

sealed class Program
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        try
        {
            LogManager.LoadConfiguration("NLog.config");
            Logger.Info("Application starting...");
            
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }
        catch (Exception ex)
        {
            Logger.Error(ex, "App will be crash, message: {ErrorMsg}", ex.Message);
        }
        finally
        {
            LogManager.Shutdown(); // flush and close
        }
    }
    
    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}